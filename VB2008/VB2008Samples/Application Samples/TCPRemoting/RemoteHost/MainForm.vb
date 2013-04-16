Imports System.IO
Imports System.Runtime.Remoting

Public Class MainForm
    ' This function iterates through all the ClientActivatedService types
    ' that were loaded via the RemotingConfiguration.Configure(Remoting.config)
    ' file.
    Private Sub ListClientActivatedServiceTypes()
        Dim entry As ActivatedServiceTypeEntry
        For Each entry In RemotingConfiguration.GetRegisteredActivatedServiceTypes()
            Me.lstOutput.Items.Add("Registered ActivatedServiceType: " & entry.TypeName)
        Next
    End Sub

    ' This function iterates through all the WellKnownService types
    ' that were loaded via the RemotingConfiguration.Configure(Remoting.config)
    ' file.
    Private Sub ListWellKnownServiceTypes()
        Dim entry As WellKnownServiceTypeEntry
        For Each entry In RemotingConfiguration.GetRegisteredWellKnownServiceTypes()
            Me.lstOutput.Items.Add(entry.TypeName & " is available at " & entry.ObjectUri)
        Next
    End Sub

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Read in Host.exe.config file
            'The call to RemotingConfiguration.Configure loads in the xml configuration file
            'and lets the remoting architecture know what types to make available via remoting
            Me.lstOutput.Items.Add("Loading Activated Configuration File")

            RemotingConfiguration.Configure("Host.exe.config", False)

            'After loading the remoting.config file enumerate the list of ClientActivated
            'types and WellKnown types and list them in the list box on the form.
            Me.ListClientActivatedServiceTypes()
            Me.ListWellKnownServiceTypes()

        Catch exp As Exception
            ' Will catch any generic exception
            Dim txt As String
            txt = "I was unable to load the file remoting.config or it is not in the correct format." & vbCrLf & _
             "Please make sure it is located in the same directory as this exe " & _
             " and that it is in the correct format." & vbCrLf & _
             "Please see the Help, About box for the location of this exe." & vbCrLf & vbCrLf & _
             "Detailed Error Information below:" & vbCrLf & vbCrLf & _
             "  Message: " & exp.Message & vbCrLf & _
             "  Source: " & exp.Source & vbCrLf & vbCrLf & _
             "  Stack Trace:" & vbCrLf & _
             exp.StackTrace

            MessageBox.Show(txt, "Generic Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            Me.lstOutput.Items.Add("Unabled to load objects.")
        End Try

    End Sub


End Class
