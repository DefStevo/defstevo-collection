<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHaupt
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHaupt))
        Me.dgErgebnis = New System.Windows.Forms.DataGridView()
        Me.colExport = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.colFirma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPosition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAnzeige_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colVorname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colName_Zusatz = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNachname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNickname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colGruppe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMail_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTelefon_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTelefon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKurzwahl_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colKurzwahl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMobil_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMobil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabExport = New System.Windows.Forms.TabControl()
        Me.TabMitarbeiter = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnMitarbeiter_Auswahl_Umkehren = New System.Windows.Forms.Button()
        Me.btnMitarbeiter_Auswahl_Keine = New System.Windows.Forms.Button()
        Me.btnMitarbeiter_Auswahl_Alle = New System.Windows.Forms.Button()
        Me.txtMitarbeiter_Gruppe = New System.Windows.Forms.TextBox()
        Me.btnMitarbeiter_Datei_Auswählen = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMitarbeiter_Datei = New System.Windows.Forms.TextBox()
        Me.btnMitarbeiter_Export = New System.Windows.Forms.Button()
        Me.btnMitarbeiter_Laden = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtMitarbeiter_Info = New System.Windows.Forms.TextBox()
        Me.TabKunden = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtKunden_Info = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtKunden_PL = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnKunden_Auswahl_Umkehren = New System.Windows.Forms.Button()
        Me.btnKunden_Auswahl_Keine = New System.Windows.Forms.Button()
        Me.btnKunden_Auswahl_Alle = New System.Windows.Forms.Button()
        Me.txtKunden_Gruppe = New System.Windows.Forms.TextBox()
        Me.btnKunden_Datei_Auswählen = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKunden_Datei = New System.Windows.Forms.TextBox()
        Me.btnKunden_Export = New System.Windows.Forms.Button()
        Me.btnKunden_Laden = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnEinstellungen = New System.Windows.Forms.Button()
        Me.grpEinstellungen = New System.Windows.Forms.GroupBox()
        Me.btnVerbinden = New System.Windows.Forms.Button()
        Me.txtKennwort = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBenutzer = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgErgebnis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabExport.SuspendLayout()
        Me.TabMitarbeiter.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabKunden.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpEinstellungen.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgErgebnis
        '
        Me.dgErgebnis.AllowUserToAddRows = False
        Me.dgErgebnis.AllowUserToDeleteRows = False
        Me.dgErgebnis.AllowUserToResizeRows = False
        Me.dgErgebnis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgErgebnis.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colExport, Me.colFirma, Me.colPosition, Me.colAnzeige_Name, Me.colVorname, Me.colName_Zusatz, Me.colNachname, Me.colNickname, Me.colGruppe, Me.colMail_Type, Me.colMail, Me.colTelefon_Type, Me.colTelefon, Me.colKurzwahl_Type, Me.colKurzwahl, Me.colMobil_Type, Me.colMobil})
        Me.dgErgebnis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgErgebnis.Location = New System.Drawing.Point(0, 179)
        Me.dgErgebnis.Name = "dgErgebnis"
        Me.dgErgebnis.RowHeadersWidth = 20
        Me.dgErgebnis.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgErgebnis.Size = New System.Drawing.Size(1008, 555)
        Me.dgErgebnis.TabIndex = 4
        '
        'colExport
        '
        Me.colExport.HeaderText = "Export"
        Me.colExport.Name = "colExport"
        Me.colExport.Width = 50
        '
        'colFirma
        '
        Me.colFirma.HeaderText = "Firma"
        Me.colFirma.Name = "colFirma"
        Me.colFirma.ReadOnly = True
        '
        'colPosition
        '
        Me.colPosition.HeaderText = "Position"
        Me.colPosition.Name = "colPosition"
        Me.colPosition.ReadOnly = True
        '
        'colAnzeige_Name
        '
        Me.colAnzeige_Name.HeaderText = "Anzeige Name"
        Me.colAnzeige_Name.Name = "colAnzeige_Name"
        Me.colAnzeige_Name.ReadOnly = True
        '
        'colVorname
        '
        Me.colVorname.HeaderText = "Vorname"
        Me.colVorname.Name = "colVorname"
        Me.colVorname.ReadOnly = True
        '
        'colName_Zusatz
        '
        Me.colName_Zusatz.HeaderText = "Name Zusatz"
        Me.colName_Zusatz.Name = "colName_Zusatz"
        Me.colName_Zusatz.ReadOnly = True
        '
        'colNachname
        '
        Me.colNachname.HeaderText = "Nachname"
        Me.colNachname.Name = "colNachname"
        Me.colNachname.ReadOnly = True
        '
        'colNickname
        '
        Me.colNickname.HeaderText = "Kürzel"
        Me.colNickname.Name = "colNickname"
        Me.colNickname.ReadOnly = True
        '
        'colGruppe
        '
        Me.colGruppe.HeaderText = "Gruppe"
        Me.colGruppe.Name = "colGruppe"
        Me.colGruppe.ReadOnly = True
        '
        'colMail_Type
        '
        Me.colMail_Type.HeaderText = "E-Mail Type"
        Me.colMail_Type.Name = "colMail_Type"
        '
        'colMail
        '
        Me.colMail.HeaderText = "E-Mail"
        Me.colMail.Name = "colMail"
        Me.colMail.ReadOnly = True
        '
        'colTelefon_Type
        '
        Me.colTelefon_Type.HeaderText = "Telefon Type"
        Me.colTelefon_Type.Name = "colTelefon_Type"
        '
        'colTelefon
        '
        Me.colTelefon.HeaderText = "Telefon"
        Me.colTelefon.Name = "colTelefon"
        Me.colTelefon.ReadOnly = True
        '
        'colKurzwahl_Type
        '
        Me.colKurzwahl_Type.HeaderText = "Kurzwahl Type"
        Me.colKurzwahl_Type.Name = "colKurzwahl_Type"
        '
        'colKurzwahl
        '
        Me.colKurzwahl.HeaderText = "Kurzwahl"
        Me.colKurzwahl.Name = "colKurzwahl"
        Me.colKurzwahl.ReadOnly = True
        '
        'colMobil_Type
        '
        Me.colMobil_Type.HeaderText = "Mobil - Type"
        Me.colMobil_Type.Name = "colMobil_Type"
        '
        'colMobil
        '
        Me.colMobil.HeaderText = "Mobil"
        Me.colMobil.Name = "colMobil"
        Me.colMobil.ReadOnly = True
        '
        'TabExport
        '
        Me.TabExport.Controls.Add(Me.TabMitarbeiter)
        Me.TabExport.Controls.Add(Me.TabKunden)
        Me.TabExport.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabExport.Location = New System.Drawing.Point(0, 0)
        Me.TabExport.Name = "TabExport"
        Me.TabExport.SelectedIndex = 0
        Me.TabExport.Size = New System.Drawing.Size(1008, 179)
        Me.TabExport.TabIndex = 3
        '
        'TabMitarbeiter
        '
        Me.TabMitarbeiter.Controls.Add(Me.Panel2)
        Me.TabMitarbeiter.Controls.Add(Me.Panel1)
        Me.TabMitarbeiter.Location = New System.Drawing.Point(4, 22)
        Me.TabMitarbeiter.Name = "TabMitarbeiter"
        Me.TabMitarbeiter.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMitarbeiter.Size = New System.Drawing.Size(1000, 153)
        Me.TabMitarbeiter.TabIndex = 0
        Me.TabMitarbeiter.Text = "Mitarbeiter"
        Me.TabMitarbeiter.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnMitarbeiter_Auswahl_Umkehren)
        Me.Panel2.Controls.Add(Me.btnMitarbeiter_Auswahl_Keine)
        Me.Panel2.Controls.Add(Me.btnMitarbeiter_Auswahl_Alle)
        Me.Panel2.Controls.Add(Me.txtMitarbeiter_Gruppe)
        Me.Panel2.Controls.Add(Me.btnMitarbeiter_Datei_Auswählen)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtMitarbeiter_Datei)
        Me.Panel2.Controls.Add(Me.btnMitarbeiter_Export)
        Me.Panel2.Controls.Add(Me.btnMitarbeiter_Laden)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(332, 147)
        Me.Panel2.TabIndex = 9
        '
        'btnMitarbeiter_Auswahl_Umkehren
        '
        Me.btnMitarbeiter_Auswahl_Umkehren.Location = New System.Drawing.Point(217, 116)
        Me.btnMitarbeiter_Auswahl_Umkehren.Name = "btnMitarbeiter_Auswahl_Umkehren"
        Me.btnMitarbeiter_Auswahl_Umkehren.Size = New System.Drawing.Size(107, 23)
        Me.btnMitarbeiter_Auswahl_Umkehren.TabIndex = 16
        Me.btnMitarbeiter_Auswahl_Umkehren.Text = "&Auswahl umkehren"
        Me.btnMitarbeiter_Auswahl_Umkehren.UseVisualStyleBackColor = True
        '
        'btnMitarbeiter_Auswahl_Keine
        '
        Me.btnMitarbeiter_Auswahl_Keine.Location = New System.Drawing.Point(111, 116)
        Me.btnMitarbeiter_Auswahl_Keine.Name = "btnMitarbeiter_Auswahl_Keine"
        Me.btnMitarbeiter_Auswahl_Keine.Size = New System.Drawing.Size(100, 23)
        Me.btnMitarbeiter_Auswahl_Keine.TabIndex = 15
        Me.btnMitarbeiter_Auswahl_Keine.Text = "&Keine Auswählen"
        Me.btnMitarbeiter_Auswahl_Keine.UseVisualStyleBackColor = True
        '
        'btnMitarbeiter_Auswahl_Alle
        '
        Me.btnMitarbeiter_Auswahl_Alle.Location = New System.Drawing.Point(5, 116)
        Me.btnMitarbeiter_Auswahl_Alle.Name = "btnMitarbeiter_Auswahl_Alle"
        Me.btnMitarbeiter_Auswahl_Alle.Size = New System.Drawing.Size(100, 23)
        Me.btnMitarbeiter_Auswahl_Alle.TabIndex = 14
        Me.btnMitarbeiter_Auswahl_Alle.Text = "All&e Auswählen"
        Me.btnMitarbeiter_Auswahl_Alle.UseVisualStyleBackColor = True
        '
        'txtMitarbeiter_Gruppe
        '
        Me.txtMitarbeiter_Gruppe.Location = New System.Drawing.Point(55, 6)
        Me.txtMitarbeiter_Gruppe.Name = "txtMitarbeiter_Gruppe"
        Me.txtMitarbeiter_Gruppe.Size = New System.Drawing.Size(100, 20)
        Me.txtMitarbeiter_Gruppe.TabIndex = 7
        '
        'btnMitarbeiter_Datei_Auswählen
        '
        Me.btnMitarbeiter_Datei_Auswählen.Location = New System.Drawing.Point(296, 61)
        Me.btnMitarbeiter_Datei_Auswählen.Name = "btnMitarbeiter_Datei_Auswählen"
        Me.btnMitarbeiter_Datei_Auswählen.Size = New System.Drawing.Size(24, 23)
        Me.btnMitarbeiter_Datei_Auswählen.TabIndex = 13
        Me.btnMitarbeiter_Datei_Auswählen.Text = "..."
        Me.btnMitarbeiter_Datei_Auswählen.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Datei"
        '
        'txtMitarbeiter_Datei
        '
        Me.txtMitarbeiter_Datei.Location = New System.Drawing.Point(55, 61)
        Me.txtMitarbeiter_Datei.Name = "txtMitarbeiter_Datei"
        Me.txtMitarbeiter_Datei.Size = New System.Drawing.Size(244, 20)
        Me.txtMitarbeiter_Datei.TabIndex = 11
        '
        'btnMitarbeiter_Export
        '
        Me.btnMitarbeiter_Export.Location = New System.Drawing.Point(55, 87)
        Me.btnMitarbeiter_Export.Name = "btnMitarbeiter_Export"
        Me.btnMitarbeiter_Export.Size = New System.Drawing.Size(100, 23)
        Me.btnMitarbeiter_Export.TabIndex = 10
        Me.btnMitarbeiter_Export.Text = "&Export"
        Me.btnMitarbeiter_Export.UseVisualStyleBackColor = True
        '
        'btnMitarbeiter_Laden
        '
        Me.btnMitarbeiter_Laden.Location = New System.Drawing.Point(55, 32)
        Me.btnMitarbeiter_Laden.Name = "btnMitarbeiter_Laden"
        Me.btnMitarbeiter_Laden.Size = New System.Drawing.Size(100, 23)
        Me.btnMitarbeiter_Laden.TabIndex = 9
        Me.btnMitarbeiter_Laden.Text = "&Laden"
        Me.btnMitarbeiter_Laden.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Gruppe"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtMitarbeiter_Info)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(589, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(408, 147)
        Me.Panel1.TabIndex = 8
        '
        'txtMitarbeiter_Info
        '
        Me.txtMitarbeiter_Info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMitarbeiter_Info.Location = New System.Drawing.Point(0, 0)
        Me.txtMitarbeiter_Info.Multiline = True
        Me.txtMitarbeiter_Info.Name = "txtMitarbeiter_Info"
        Me.txtMitarbeiter_Info.ReadOnly = True
        Me.txtMitarbeiter_Info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMitarbeiter_Info.Size = New System.Drawing.Size(408, 147)
        Me.txtMitarbeiter_Info.TabIndex = 8
        '
        'TabKunden
        '
        Me.TabKunden.Controls.Add(Me.Panel4)
        Me.TabKunden.Controls.Add(Me.Panel3)
        Me.TabKunden.Location = New System.Drawing.Point(4, 22)
        Me.TabKunden.Name = "TabKunden"
        Me.TabKunden.Padding = New System.Windows.Forms.Padding(3)
        Me.TabKunden.Size = New System.Drawing.Size(1000, 153)
        Me.TabKunden.TabIndex = 1
        Me.TabKunden.Text = "Kunden"
        Me.TabKunden.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtKunden_Info)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(589, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(408, 147)
        Me.Panel4.TabIndex = 12
        '
        'txtKunden_Info
        '
        Me.txtKunden_Info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtKunden_Info.Location = New System.Drawing.Point(0, 0)
        Me.txtKunden_Info.Multiline = True
        Me.txtKunden_Info.Name = "txtKunden_Info"
        Me.txtKunden_Info.ReadOnly = True
        Me.txtKunden_Info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtKunden_Info.Size = New System.Drawing.Size(408, 147)
        Me.txtKunden_Info.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtKunden_PL)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.btnKunden_Auswahl_Umkehren)
        Me.Panel3.Controls.Add(Me.btnKunden_Auswahl_Keine)
        Me.Panel3.Controls.Add(Me.btnKunden_Auswahl_Alle)
        Me.Panel3.Controls.Add(Me.txtKunden_Gruppe)
        Me.Panel3.Controls.Add(Me.btnKunden_Datei_Auswählen)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtKunden_Datei)
        Me.Panel3.Controls.Add(Me.btnKunden_Export)
        Me.Panel3.Controls.Add(Me.btnKunden_Laden)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(332, 147)
        Me.Panel3.TabIndex = 11
        '
        'txtKunden_PL
        '
        Me.txtKunden_PL.Location = New System.Drawing.Point(220, 6)
        Me.txtKunden_PL.Name = "txtKunden_PL"
        Me.txtKunden_PL.Size = New System.Drawing.Size(100, 20)
        Me.txtKunden_PL.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(191, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "PL"
        '
        'btnKunden_Auswahl_Umkehren
        '
        Me.btnKunden_Auswahl_Umkehren.Location = New System.Drawing.Point(217, 116)
        Me.btnKunden_Auswahl_Umkehren.Name = "btnKunden_Auswahl_Umkehren"
        Me.btnKunden_Auswahl_Umkehren.Size = New System.Drawing.Size(107, 23)
        Me.btnKunden_Auswahl_Umkehren.TabIndex = 16
        Me.btnKunden_Auswahl_Umkehren.Text = "&Auswahl umkehren"
        Me.btnKunden_Auswahl_Umkehren.UseVisualStyleBackColor = True
        '
        'btnKunden_Auswahl_Keine
        '
        Me.btnKunden_Auswahl_Keine.Location = New System.Drawing.Point(111, 116)
        Me.btnKunden_Auswahl_Keine.Name = "btnKunden_Auswahl_Keine"
        Me.btnKunden_Auswahl_Keine.Size = New System.Drawing.Size(100, 23)
        Me.btnKunden_Auswahl_Keine.TabIndex = 15
        Me.btnKunden_Auswahl_Keine.Text = "&Keine Auswählen"
        Me.btnKunden_Auswahl_Keine.UseVisualStyleBackColor = True
        '
        'btnKunden_Auswahl_Alle
        '
        Me.btnKunden_Auswahl_Alle.Location = New System.Drawing.Point(5, 116)
        Me.btnKunden_Auswahl_Alle.Name = "btnKunden_Auswahl_Alle"
        Me.btnKunden_Auswahl_Alle.Size = New System.Drawing.Size(100, 23)
        Me.btnKunden_Auswahl_Alle.TabIndex = 14
        Me.btnKunden_Auswahl_Alle.Text = "All&e Auswählen"
        Me.btnKunden_Auswahl_Alle.UseVisualStyleBackColor = True
        '
        'txtKunden_Gruppe
        '
        Me.txtKunden_Gruppe.Location = New System.Drawing.Point(55, 6)
        Me.txtKunden_Gruppe.Name = "txtKunden_Gruppe"
        Me.txtKunden_Gruppe.Size = New System.Drawing.Size(100, 20)
        Me.txtKunden_Gruppe.TabIndex = 7
        '
        'btnKunden_Datei_Auswählen
        '
        Me.btnKunden_Datei_Auswählen.Location = New System.Drawing.Point(296, 61)
        Me.btnKunden_Datei_Auswählen.Name = "btnKunden_Datei_Auswählen"
        Me.btnKunden_Datei_Auswählen.Size = New System.Drawing.Size(24, 23)
        Me.btnKunden_Datei_Auswählen.TabIndex = 13
        Me.btnKunden_Datei_Auswählen.Text = "..."
        Me.btnKunden_Datei_Auswählen.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Datei"
        '
        'txtKunden_Datei
        '
        Me.txtKunden_Datei.Location = New System.Drawing.Point(55, 61)
        Me.txtKunden_Datei.Name = "txtKunden_Datei"
        Me.txtKunden_Datei.Size = New System.Drawing.Size(244, 20)
        Me.txtKunden_Datei.TabIndex = 11
        '
        'btnKunden_Export
        '
        Me.btnKunden_Export.Location = New System.Drawing.Point(55, 87)
        Me.btnKunden_Export.Name = "btnKunden_Export"
        Me.btnKunden_Export.Size = New System.Drawing.Size(100, 23)
        Me.btnKunden_Export.TabIndex = 10
        Me.btnKunden_Export.Text = "&Export"
        Me.btnKunden_Export.UseVisualStyleBackColor = True
        '
        'btnKunden_Laden
        '
        Me.btnKunden_Laden.Location = New System.Drawing.Point(55, 32)
        Me.btnKunden_Laden.Name = "btnKunden_Laden"
        Me.btnKunden_Laden.Size = New System.Drawing.Size(100, 23)
        Me.btnKunden_Laden.TabIndex = 9
        Me.btnKunden_Laden.Text = "&Laden"
        Me.btnKunden_Laden.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Gruppe"
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.FileName = "Google_Export.csv"
        Me.SaveFileDialog.Filter = "CSV-Datei|*.csv"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'btnEinstellungen
        '
        Me.btnEinstellungen.Image = Global.RS_Adress_Export.My.Resources.Resources.Settings
        Me.btnEinstellungen.Location = New System.Drawing.Point(987, 0)
        Me.btnEinstellungen.Name = "btnEinstellungen"
        Me.btnEinstellungen.Size = New System.Drawing.Size(20, 20)
        Me.btnEinstellungen.TabIndex = 5
        Me.btnEinstellungen.UseVisualStyleBackColor = True
        '
        'grpEinstellungen
        '
        Me.grpEinstellungen.Controls.Add(Me.btnVerbinden)
        Me.grpEinstellungen.Controls.Add(Me.txtKennwort)
        Me.grpEinstellungen.Controls.Add(Me.Label8)
        Me.grpEinstellungen.Controls.Add(Me.txtBenutzer)
        Me.grpEinstellungen.Controls.Add(Me.Label7)
        Me.grpEinstellungen.Controls.Add(Me.txtServer)
        Me.grpEinstellungen.Controls.Add(Me.Label6)
        Me.grpEinstellungen.Location = New System.Drawing.Point(787, 0)
        Me.grpEinstellungen.Name = "grpEinstellungen"
        Me.grpEinstellungen.Size = New System.Drawing.Size(200, 124)
        Me.grpEinstellungen.TabIndex = 8
        Me.grpEinstellungen.TabStop = False
        Me.grpEinstellungen.Text = "Einstellungen"
        Me.grpEinstellungen.Visible = False
        '
        'btnVerbinden
        '
        Me.btnVerbinden.Location = New System.Drawing.Point(66, 97)
        Me.btnVerbinden.Name = "btnVerbinden"
        Me.btnVerbinden.Size = New System.Drawing.Size(100, 23)
        Me.btnVerbinden.TabIndex = 17
        Me.btnVerbinden.Text = "&Verbinden"
        Me.btnVerbinden.UseVisualStyleBackColor = True
        '
        'txtKennwort
        '
        Me.txtKennwort.Location = New System.Drawing.Point(66, 71)
        Me.txtKennwort.Name = "txtKennwort"
        Me.txtKennwort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtKennwort.Size = New System.Drawing.Size(100, 20)
        Me.txtKennwort.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Kennwort"
        '
        'txtBenutzer
        '
        Me.txtBenutzer.Location = New System.Drawing.Point(66, 45)
        Me.txtBenutzer.Name = "txtBenutzer"
        Me.txtBenutzer.Size = New System.Drawing.Size(100, 20)
        Me.txtBenutzer.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Benutzer"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(66, 19)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(100, 20)
        Me.txtServer.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Server"
        '
        'frmHaupt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 734)
        Me.Controls.Add(Me.grpEinstellungen)
        Me.Controls.Add(Me.btnEinstellungen)
        Me.Controls.Add(Me.dgErgebnis)
        Me.Controls.Add(Me.TabExport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmHaupt"
        Me.Text = "Adressexport"
        CType(Me.dgErgebnis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabExport.ResumeLayout(False)
        Me.TabMitarbeiter.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabKunden.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpEinstellungen.ResumeLayout(False)
        Me.grpEinstellungen.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgErgebnis As System.Windows.Forms.DataGridView
    Friend WithEvents TabExport As System.Windows.Forms.TabControl
    Friend WithEvents TabMitarbeiter As System.Windows.Forms.TabPage
    Friend WithEvents TabKunden As System.Windows.Forms.TabPage
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents colExport As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents colFirma As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPosition As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAnzeige_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colVorname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colName_Zusatz As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNachname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNickname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colGruppe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMail_Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTelefon_Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTelefon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colKurzwahl_Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colKurzwahl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMobil_Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMobil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtMitarbeiter_Gruppe As System.Windows.Forms.TextBox
    Friend WithEvents btnMitarbeiter_Datei_Auswählen As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMitarbeiter_Datei As System.Windows.Forms.TextBox
    Friend WithEvents btnMitarbeiter_Export As System.Windows.Forms.Button
    Friend WithEvents btnMitarbeiter_Laden As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtMitarbeiter_Info As System.Windows.Forms.TextBox
    Friend WithEvents btnMitarbeiter_Auswahl_Umkehren As System.Windows.Forms.Button
    Friend WithEvents btnMitarbeiter_Auswahl_Keine As System.Windows.Forms.Button
    Friend WithEvents btnMitarbeiter_Auswahl_Alle As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtKunden_PL As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnKunden_Auswahl_Umkehren As System.Windows.Forms.Button
    Friend WithEvents btnKunden_Auswahl_Keine As System.Windows.Forms.Button
    Friend WithEvents btnKunden_Auswahl_Alle As System.Windows.Forms.Button
    Friend WithEvents txtKunden_Gruppe As System.Windows.Forms.TextBox
    Friend WithEvents btnKunden_Datei_Auswählen As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKunden_Datei As System.Windows.Forms.TextBox
    Friend WithEvents btnKunden_Export As System.Windows.Forms.Button
    Friend WithEvents btnKunden_Laden As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtKunden_Info As System.Windows.Forms.TextBox
    Friend WithEvents btnEinstellungen As System.Windows.Forms.Button
    Friend WithEvents grpEinstellungen As System.Windows.Forms.GroupBox
    Friend WithEvents btnVerbinden As System.Windows.Forms.Button
    Friend WithEvents txtKennwort As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBenutzer As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
