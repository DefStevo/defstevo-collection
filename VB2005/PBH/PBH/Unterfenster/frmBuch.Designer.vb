<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuch
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuch))
    Me.grpEinstellungen = New System.Windows.Forms.GroupBox
    Me.btnOK = New System.Windows.Forms.Button
    Me.txtArt = New System.Windows.Forms.ComboBox
    Me.txtDatum = New System.Windows.Forms.MaskedTextBox
    Me.txtBuchNr = New System.Windows.Forms.TextBox
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label1 = New System.Windows.Forms.Label
    Me.grpBestand = New System.Windows.Forms.GroupBox
    Me.txtBestandSaldo = New System.Windows.Forms.TextBox
    Me.txtBestandName = New System.Windows.Forms.TextBox
    Me.txtBestand = New System.Windows.Forms.TextBox
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.Label6 = New System.Windows.Forms.Label
    Me.grpKonto = New System.Windows.Forms.GroupBox
    Me.txtKtoSaldo = New System.Windows.Forms.TextBox
    Me.txtKtoName = New System.Windows.Forms.TextBox
    Me.txtKto = New System.Windows.Forms.TextBox
    Me.Label7 = New System.Windows.Forms.Label
    Me.Label8 = New System.Windows.Forms.Label
    Me.Label9 = New System.Windows.Forms.Label
    Me.grpSonstiges = New System.Windows.Forms.GroupBox
    Me.txtBuchBetrag = New System.Windows.Forms.TextBox
    Me.Label18 = New System.Windows.Forms.Label
    Me.Label17 = New System.Windows.Forms.Label
    Me.txtBuchMemo = New System.Windows.Forms.TextBox
    Me.Label16 = New System.Windows.Forms.Label
    Me.txtBuchText = New System.Windows.Forms.TextBox
    Me.txtAdrSaldo = New System.Windows.Forms.TextBox
    Me.txtAdrName = New System.Windows.Forms.TextBox
    Me.txtAdr = New System.Windows.Forms.TextBox
    Me.Label10 = New System.Windows.Forms.Label
    Me.Label11 = New System.Windows.Forms.Label
    Me.Label12 = New System.Windows.Forms.Label
    Me.btnFertig = New System.Windows.Forms.Button
    Me.grpEinstellungen.SuspendLayout()
    Me.grpBestand.SuspendLayout()
    Me.grpKonto.SuspendLayout()
    Me.grpSonstiges.SuspendLayout()
    Me.SuspendLayout()
    '
    'grpEinstellungen
    '
    Me.grpEinstellungen.Controls.Add(Me.btnOK)
    Me.grpEinstellungen.Controls.Add(Me.txtArt)
    Me.grpEinstellungen.Controls.Add(Me.txtDatum)
    Me.grpEinstellungen.Controls.Add(Me.txtBuchNr)
    Me.grpEinstellungen.Controls.Add(Me.Label3)
    Me.grpEinstellungen.Controls.Add(Me.Label2)
    Me.grpEinstellungen.Controls.Add(Me.Label1)
    Me.grpEinstellungen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpEinstellungen.Location = New System.Drawing.Point(12, 12)
    Me.grpEinstellungen.Name = "grpEinstellungen"
    Me.grpEinstellungen.Size = New System.Drawing.Size(360, 60)
    Me.grpEinstellungen.TabIndex = 0
    Me.grpEinstellungen.TabStop = False
    Me.grpEinstellungen.Text = "Einstellungen"
    '
    'btnOK
    '
    Me.btnOK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnOK.Location = New System.Drawing.Point(239, 31)
    Me.btnOK.Name = "btnOK"
    Me.btnOK.Size = New System.Drawing.Size(113, 23)
    Me.btnOK.TabIndex = 2
    Me.btnOK.Text = "Einstellungen OK"
    Me.btnOK.UseVisualStyleBackColor = True
    '
    'txtArt
    '
    Me.txtArt.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtArt.FormattingEnabled = True
    Me.txtArt.Items.AddRange(New Object() {"Ausgabe", "Einnahme", "Umbuchung"})
    Me.txtArt.Location = New System.Drawing.Point(149, 33)
    Me.txtArt.Name = "txtArt"
    Me.txtArt.Size = New System.Drawing.Size(84, 21)
    Me.txtArt.TabIndex = 1
    '
    'txtDatum
    '
    Me.txtDatum.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtDatum.Location = New System.Drawing.Point(78, 33)
    Me.txtDatum.Mask = "00/00/0000"
    Me.txtDatum.Name = "txtDatum"
    Me.txtDatum.Size = New System.Drawing.Size(65, 21)
    Me.txtDatum.TabIndex = 0
    Me.txtDatum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    Me.txtDatum.ValidatingType = GetType(Date)
    '
    'txtBuchNr
    '
    Me.txtBuchNr.Enabled = False
    Me.txtBuchNr.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtBuchNr.Location = New System.Drawing.Point(6, 33)
    Me.txtBuchNr.MaxLength = 4
    Me.txtBuchNr.Name = "txtBuchNr"
    Me.txtBuchNr.Size = New System.Drawing.Size(66, 21)
    Me.txtBuchNr.TabIndex = 3
    Me.txtBuchNr.Text = "0000"
    Me.txtBuchNr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'Label3
    '
    Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(146, 17)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(83, 13)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "Art"
    Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'Label2
    '
    Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(78, 17)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(65, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Datum"
    Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'Label1
    '
    Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(6, 17)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(66, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "BuchungsID"
    Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'grpBestand
    '
    Me.grpBestand.Controls.Add(Me.txtBestandSaldo)
    Me.grpBestand.Controls.Add(Me.txtBestandName)
    Me.grpBestand.Controls.Add(Me.txtBestand)
    Me.grpBestand.Controls.Add(Me.Label4)
    Me.grpBestand.Controls.Add(Me.Label5)
    Me.grpBestand.Controls.Add(Me.Label6)
    Me.grpBestand.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpBestand.Location = New System.Drawing.Point(12, 78)
    Me.grpBestand.Name = "grpBestand"
    Me.grpBestand.Size = New System.Drawing.Size(360, 60)
    Me.grpBestand.TabIndex = 1
    Me.grpBestand.TabStop = False
    Me.grpBestand.Text = "Bestandskonto"
    '
    'txtBestandSaldo
    '
    Me.txtBestandSaldo.Enabled = False
    Me.txtBestandSaldo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtBestandSaldo.Location = New System.Drawing.Point(279, 33)
    Me.txtBestandSaldo.MaxLength = 12
    Me.txtBestandSaldo.Name = "txtBestandSaldo"
    Me.txtBestandSaldo.Size = New System.Drawing.Size(73, 21)
    Me.txtBestandSaldo.TabIndex = 5
    Me.txtBestandSaldo.Text = "00.000,00 €"
    Me.txtBestandSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtBestandName
    '
    Me.txtBestandName.Enabled = False
    Me.txtBestandName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtBestandName.Location = New System.Drawing.Point(40, 33)
    Me.txtBestandName.MaxLength = 38
    Me.txtBestandName.Name = "txtBestandName"
    Me.txtBestandName.Size = New System.Drawing.Size(239, 21)
    Me.txtBestandName.TabIndex = 4
    Me.txtBestandName.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
    '
    'txtBestand
    '
    Me.txtBestand.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtBestand.Location = New System.Drawing.Point(6, 33)
    Me.txtBestand.MaxLength = 4
    Me.txtBestand.Name = "txtBestand"
    Me.txtBestand.Size = New System.Drawing.Size(34, 21)
    Me.txtBestand.TabIndex = 3
    Me.txtBestand.Text = "0000"
    Me.txtBestand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'Label4
    '
    Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(279, 17)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(73, 13)
    Me.Label4.TabIndex = 2
    Me.Label4.Text = "Saldo"
    Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'Label5
    '
    Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(37, 17)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(242, 13)
    Me.Label5.TabIndex = 1
    Me.Label5.Text = "Name"
    Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'Label6
    '
    Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(6, 17)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(34, 13)
    Me.Label6.TabIndex = 0
    Me.Label6.Text = "Kto"
    Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'grpKonto
    '
    Me.grpKonto.Controls.Add(Me.txtKtoSaldo)
    Me.grpKonto.Controls.Add(Me.txtKtoName)
    Me.grpKonto.Controls.Add(Me.txtKto)
    Me.grpKonto.Controls.Add(Me.Label7)
    Me.grpKonto.Controls.Add(Me.Label8)
    Me.grpKonto.Controls.Add(Me.Label9)
    Me.grpKonto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpKonto.Location = New System.Drawing.Point(12, 144)
    Me.grpKonto.Name = "grpKonto"
    Me.grpKonto.Size = New System.Drawing.Size(360, 60)
    Me.grpKonto.TabIndex = 2
    Me.grpKonto.TabStop = False
    Me.grpKonto.Text = "Gegenkonto"
    '
    'txtKtoSaldo
    '
    Me.txtKtoSaldo.Enabled = False
    Me.txtKtoSaldo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtKtoSaldo.Location = New System.Drawing.Point(279, 33)
    Me.txtKtoSaldo.MaxLength = 12
    Me.txtKtoSaldo.Name = "txtKtoSaldo"
    Me.txtKtoSaldo.Size = New System.Drawing.Size(73, 21)
    Me.txtKtoSaldo.TabIndex = 5
    Me.txtKtoSaldo.Text = "00.000,00 €"
    Me.txtKtoSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtKtoName
    '
    Me.txtKtoName.Enabled = False
    Me.txtKtoName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtKtoName.Location = New System.Drawing.Point(40, 33)
    Me.txtKtoName.MaxLength = 38
    Me.txtKtoName.Name = "txtKtoName"
    Me.txtKtoName.Size = New System.Drawing.Size(239, 21)
    Me.txtKtoName.TabIndex = 4
    Me.txtKtoName.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
    '
    'txtKto
    '
    Me.txtKto.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtKto.Location = New System.Drawing.Point(6, 33)
    Me.txtKto.MaxLength = 4
    Me.txtKto.Name = "txtKto"
    Me.txtKto.Size = New System.Drawing.Size(34, 21)
    Me.txtKto.TabIndex = 4
    Me.txtKto.Text = "0000"
    Me.txtKto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'Label7
    '
    Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label7.Location = New System.Drawing.Point(279, 17)
    Me.Label7.Name = "Label7"
    Me.Label7.Size = New System.Drawing.Size(73, 13)
    Me.Label7.TabIndex = 2
    Me.Label7.Text = "Saldo"
    Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'Label8
    '
    Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label8.Location = New System.Drawing.Point(37, 17)
    Me.Label8.Name = "Label8"
    Me.Label8.Size = New System.Drawing.Size(242, 13)
    Me.Label8.TabIndex = 1
    Me.Label8.Text = "Name"
    Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'Label9
    '
    Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label9.Location = New System.Drawing.Point(6, 17)
    Me.Label9.Name = "Label9"
    Me.Label9.Size = New System.Drawing.Size(34, 13)
    Me.Label9.TabIndex = 0
    Me.Label9.Text = "Kto"
    Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'grpSonstiges
    '
    Me.grpSonstiges.Controls.Add(Me.txtBuchBetrag)
    Me.grpSonstiges.Controls.Add(Me.Label18)
    Me.grpSonstiges.Controls.Add(Me.Label17)
    Me.grpSonstiges.Controls.Add(Me.txtBuchMemo)
    Me.grpSonstiges.Controls.Add(Me.Label16)
    Me.grpSonstiges.Controls.Add(Me.txtBuchText)
    Me.grpSonstiges.Controls.Add(Me.txtAdrSaldo)
    Me.grpSonstiges.Controls.Add(Me.txtAdrName)
    Me.grpSonstiges.Controls.Add(Me.txtAdr)
    Me.grpSonstiges.Controls.Add(Me.Label10)
    Me.grpSonstiges.Controls.Add(Me.Label11)
    Me.grpSonstiges.Controls.Add(Me.Label12)
    Me.grpSonstiges.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.grpSonstiges.Location = New System.Drawing.Point(12, 210)
    Me.grpSonstiges.Name = "grpSonstiges"
    Me.grpSonstiges.Size = New System.Drawing.Size(360, 234)
    Me.grpSonstiges.TabIndex = 3
    Me.grpSonstiges.TabStop = False
    Me.grpSonstiges.Text = "Sonstiges"
    '
    'txtBuchBetrag
    '
    Me.txtBuchBetrag.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtBuchBetrag.Location = New System.Drawing.Point(6, 113)
    Me.txtBuchBetrag.MaxLength = 12
    Me.txtBuchBetrag.Name = "txtBuchBetrag"
    Me.txtBuchBetrag.Size = New System.Drawing.Size(101, 21)
    Me.txtBuchBetrag.TabIndex = 7
    Me.txtBuchBetrag.Text = "00.000,00 €"
    Me.txtBuchBetrag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'Label18
    '
    Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label18.Location = New System.Drawing.Point(6, 97)
    Me.Label18.Name = "Label18"
    Me.Label18.Size = New System.Drawing.Size(101, 13)
    Me.Label18.TabIndex = 14
    Me.Label18.Text = "Betrag"
    Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'Label17
    '
    Me.Label17.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label17.Location = New System.Drawing.Point(113, 97)
    Me.Label17.Name = "Label17"
    Me.Label17.Size = New System.Drawing.Size(239, 13)
    Me.Label17.TabIndex = 13
    Me.Label17.Text = "Anmerkung"
    Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'txtBuchMemo
    '
    Me.txtBuchMemo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtBuchMemo.Location = New System.Drawing.Point(113, 113)
    Me.txtBuchMemo.MaxLength = 296
    Me.txtBuchMemo.Multiline = True
    Me.txtBuchMemo.Name = "txtBuchMemo"
    Me.txtBuchMemo.Size = New System.Drawing.Size(239, 112)
    Me.txtBuchMemo.TabIndex = 8
    Me.txtBuchMemo.Text = resources.GetString("txtBuchMemo.Text")
    '
    'Label16
    '
    Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label16.Location = New System.Drawing.Point(6, 57)
    Me.Label16.Name = "Label16"
    Me.Label16.Size = New System.Drawing.Size(346, 13)
    Me.Label16.TabIndex = 7
    Me.Label16.Text = "Name"
    Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'txtBuchText
    '
    Me.txtBuchText.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtBuchText.Location = New System.Drawing.Point(9, 73)
    Me.txtBuchText.MaxLength = 56
    Me.txtBuchText.Name = "txtBuchText"
    Me.txtBuchText.Size = New System.Drawing.Size(343, 21)
    Me.txtBuchText.TabIndex = 6
    Me.txtBuchText.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
    '
    'txtAdrSaldo
    '
    Me.txtAdrSaldo.Enabled = False
    Me.txtAdrSaldo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAdrSaldo.Location = New System.Drawing.Point(279, 33)
    Me.txtAdrSaldo.MaxLength = 12
    Me.txtAdrSaldo.Name = "txtAdrSaldo"
    Me.txtAdrSaldo.Size = New System.Drawing.Size(73, 21)
    Me.txtAdrSaldo.TabIndex = 5
    Me.txtAdrSaldo.Text = "00.000,00 €"
    Me.txtAdrSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'txtAdrName
    '
    Me.txtAdrName.Enabled = False
    Me.txtAdrName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAdrName.Location = New System.Drawing.Point(40, 33)
    Me.txtAdrName.MaxLength = 38
    Me.txtAdrName.Name = "txtAdrName"
    Me.txtAdrName.Size = New System.Drawing.Size(239, 21)
    Me.txtAdrName.TabIndex = 4
    Me.txtAdrName.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
    '
    'txtAdr
    '
    Me.txtAdr.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.txtAdr.Location = New System.Drawing.Point(6, 33)
    Me.txtAdr.MaxLength = 4
    Me.txtAdr.Name = "txtAdr"
    Me.txtAdr.Size = New System.Drawing.Size(34, 21)
    Me.txtAdr.TabIndex = 5
    Me.txtAdr.Text = "0000"
    Me.txtAdr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
    '
    'Label10
    '
    Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label10.Location = New System.Drawing.Point(279, 17)
    Me.Label10.Name = "Label10"
    Me.Label10.Size = New System.Drawing.Size(73, 13)
    Me.Label10.TabIndex = 2
    Me.Label10.Text = "Saldo"
    Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'Label11
    '
    Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label11.Location = New System.Drawing.Point(37, 17)
    Me.Label11.Name = "Label11"
    Me.Label11.Size = New System.Drawing.Size(242, 13)
    Me.Label11.TabIndex = 1
    Me.Label11.Text = "Name"
    Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'Label12
    '
    Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label12.Location = New System.Drawing.Point(6, 17)
    Me.Label12.Name = "Label12"
    Me.Label12.Size = New System.Drawing.Size(34, 13)
    Me.Label12.TabIndex = 0
    Me.Label12.Text = "Adr"
    Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
    '
    'btnFertig
    '
    Me.btnFertig.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnFertig.Location = New System.Drawing.Point(12, 450)
    Me.btnFertig.Name = "btnFertig"
    Me.btnFertig.Size = New System.Drawing.Size(360, 23)
    Me.btnFertig.TabIndex = 9
    Me.btnFertig.Text = "Fertig"
    Me.btnFertig.UseVisualStyleBackColor = True
    '
    'frmBuch
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(738, 505)
    Me.Controls.Add(Me.btnFertig)
    Me.Controls.Add(Me.grpSonstiges)
    Me.Controls.Add(Me.grpKonto)
    Me.Controls.Add(Me.grpBestand)
    Me.Controls.Add(Me.grpEinstellungen)
    Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Name = "frmBuch"
    Me.Text = "Buchung erfassen"
    Me.grpEinstellungen.ResumeLayout(False)
    Me.grpEinstellungen.PerformLayout()
    Me.grpBestand.ResumeLayout(False)
    Me.grpBestand.PerformLayout()
    Me.grpKonto.ResumeLayout(False)
    Me.grpKonto.PerformLayout()
    Me.grpSonstiges.ResumeLayout(False)
    Me.grpSonstiges.PerformLayout()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents grpEinstellungen As System.Windows.Forms.GroupBox
  Friend WithEvents txtBuchNr As System.Windows.Forms.TextBox
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents txtArt As System.Windows.Forms.ComboBox
  Friend WithEvents txtDatum As System.Windows.Forms.MaskedTextBox
  Friend WithEvents btnOK As System.Windows.Forms.Button
  Friend WithEvents grpBestand As System.Windows.Forms.GroupBox
  Friend WithEvents txtBestandSaldo As System.Windows.Forms.TextBox
  Friend WithEvents txtBestandName As System.Windows.Forms.TextBox
  Friend WithEvents txtBestand As System.Windows.Forms.TextBox
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents grpKonto As System.Windows.Forms.GroupBox
  Friend WithEvents txtKtoSaldo As System.Windows.Forms.TextBox
  Friend WithEvents txtKtoName As System.Windows.Forms.TextBox
  Friend WithEvents txtKto As System.Windows.Forms.TextBox
  Friend WithEvents Label7 As System.Windows.Forms.Label
  Friend WithEvents Label8 As System.Windows.Forms.Label
  Friend WithEvents Label9 As System.Windows.Forms.Label
  Friend WithEvents grpSonstiges As System.Windows.Forms.GroupBox
  Friend WithEvents txtAdrSaldo As System.Windows.Forms.TextBox
  Friend WithEvents txtAdrName As System.Windows.Forms.TextBox
  Friend WithEvents txtAdr As System.Windows.Forms.TextBox
  Friend WithEvents Label10 As System.Windows.Forms.Label
  Friend WithEvents Label11 As System.Windows.Forms.Label
  Friend WithEvents Label12 As System.Windows.Forms.Label
  Friend WithEvents Label16 As System.Windows.Forms.Label
  Friend WithEvents txtBuchText As System.Windows.Forms.TextBox
  Friend WithEvents txtBuchBetrag As System.Windows.Forms.TextBox
  Friend WithEvents Label18 As System.Windows.Forms.Label
  Friend WithEvents Label17 As System.Windows.Forms.Label
  Friend WithEvents txtBuchMemo As System.Windows.Forms.TextBox
  Friend WithEvents btnFertig As System.Windows.Forms.Button
End Class
