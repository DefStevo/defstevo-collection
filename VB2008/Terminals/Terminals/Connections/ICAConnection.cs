using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Terminals.Properties;
using System.Diagnostics;
using System.Runtime.InteropServices;
using TabControl;


namespace Terminals.Connections {
    public class ICAConnection : Connection {
        #region IConnection Members
        private bool connected = false;

        AxWFICALib.AxICAClient iIcaClient;

        public override void ChangeDesktopSize(Terminals.DesktopSize Size) {
        }

        public override bool Connected { get { return connected; } }
        

        public override bool Connect() {

            try
            {
                iIcaClient = new AxWFICALib.AxICAClient();
                ((Control)iIcaClient).DragEnter += new DragEventHandler(ICAConnection_DragEnter);
                ((Control)iIcaClient).DragDrop += new DragEventHandler(ICAConnection_DragDrop);
                iIcaClient.OnDisconnect += new EventHandler(iIcaClient_OnDisconnect);
                iIcaClient.Dock = DockStyle.Fill;


                Controls.Add(iIcaClient);


                string domainName = Favorite.DomainName;
                if(domainName == null || domainName == "") domainName = Settings.DefaultDomain;
                string pass = Favorite.Password;
                if(pass == null || pass == "") pass = Settings.DefaultPassword;
                string userName = Favorite.UserName;
                if(userName == null || userName == "") userName = Settings.DefaultUsername;

                icaPassword = pass;


                //rd.SendSpecialKeys(VncSharp.SpecialKeys);            
                iIcaClient.Parent = base.TerminalTabPage;
                this.Parent = TerminalTabPage;
                iIcaClient.Dock = DockStyle.Fill;

                iIcaClient.Address = Favorite.ServerName;
                switch(Favorite.Colors)
                {
                    case Colors.Bit16:
                        iIcaClient.SetProp("DesiredColor", "16");
                        break;
                    case Colors.Bits32:
                        iIcaClient.SetProp("DesiredColor", "32");
                        break;
                    case Colors.Bits8:
                        iIcaClient.SetProp("DesiredColor", "16");
                        break;
                    default:
                        iIcaClient.SetProp("DesiredColor", "24");
                        break;

                }
                iIcaClient.Application = "Terminals " + Program.TerminalsVersion.ToString();

                iIcaClient.AppsrvIni = Favorite.IcaServerINI;
                iIcaClient.WfclientIni = Favorite.IcaClientINI;
                iIcaClient.Encrypt = Favorite.IcaEnableEncryption;
                string encryptLevel = "Encrypt";
                string specifiedLevel = Favorite.IcaEncryptionLevel.Trim();
                if(specifiedLevel.Contains(" ")) {
                    encryptLevel = specifiedLevel.Substring(0, specifiedLevel.IndexOf(" ")).Trim();
                    if(encryptLevel != "") iIcaClient.EncryptionLevelSession = encryptLevel;
                }
                



                iIcaClient.Domain = domainName;
                iIcaClient.Address = Favorite.ServerName;
                iIcaClient.Username = userName;

                if(Favorite.ICAApplicationName != "")
                {
                    iIcaClient.ConnectionEntry = Favorite.ICAApplicationName;
                    //iIcaClient.Application = favorite.applicationName;
                    iIcaClient.InitialProgram = Favorite.ICAApplicationName;
                    iIcaClient.Application = Favorite.ICAApplicationPath;
                    iIcaClient.WorkDirectory = Favorite.ICAApplicationWorkingFolder;
                }


                Text = "Connecting to ICA Server...";

                iIcaClient.Visible = true;

                iIcaClient.SetProp("ScalingMode", "3");
                iIcaClient.Launch = false;
                iIcaClient.TransportDriver = "TCP/IP";
                iIcaClient.Connect();
                iIcaClient.Focus();


                return true;
            }
            catch(Exception exc)
            {
                Terminals.Logging.Log.Fatal("Connecting to ICA", exc);
                return false;
            }
        }


        void iIcaClient_OnDisconnect(object sender, EventArgs e) {
            Terminals.Logging.Log.Fatal("ICA Connection Lost" + this.Favorite.Name);
            this.connected = false;

            TabControlItem selectedTabPage = (TabControlItem)(this.Parent);
            bool wasSelected = selectedTabPage.Selected;
            ParentForm.tcTerminals.RemoveTab(selectedTabPage);
            ParentForm.tcTerminals_TabControlItemClosed(null, EventArgs.Empty);
            if(wasSelected)
                NativeApi.PostMessage(new HandleRef(this, this.Handle), MainForm.WM_LEAVING_FULLSCREEN, IntPtr.Zero, IntPtr.Zero);
            ParentForm.UpdateControls();
        }

        void ICAConnection_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string desktopShare = ParentForm.GetDesktopShare();
            if(String.IsNullOrEmpty(desktopShare))
            {
                MessageBox.Show(this, "A Desktop Share was not defined for this connection.\n" +
                    "Please define a share in the connection properties window (under the Local Resources tab)."
                    , "Terminals", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                SHCopyFiles(files, desktopShare);
        }

        void ICAConnection_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }
        private string icaPassword = "";
        string ICAPassword()
        {
            return icaPassword;
        }


        public override void Disconnect() {
            try {
                connected = false;
                iIcaClient.Disconnect();
            } catch (Exception e) {
                Terminals.Logging.Log.Info("", e);
            }
        }
        private void SHCopyFiles(string[] sourceFiles, string destinationFolder)
        {
            SHFileOperationWrapper fo = new SHFileOperationWrapper();
            List<string> destinationFiles = new List<string>();

            foreach(string sourceFile in sourceFiles)
            {
                destinationFiles.Add(Path.Combine(destinationFolder, Path.GetFileName(sourceFile)));
            }

            fo.Operation = SHFileOperationWrapper.FileOperations.FO_COPY;
            fo.OwnerWindow = this.Handle;
            fo.SourceFiles = sourceFiles;
            fo.DestFiles = destinationFiles.ToArray();

            fo.DoOperation();
        }
        #endregion
    }
}