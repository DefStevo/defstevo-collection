<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatistik
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
        Me.components = New System.ComponentModel.Container
        Me.TabStatistik = New System.Windows.Forms.TabControl
        Me.TabStatistikÜbersicht = New System.Windows.Forms.TabPage
        Me.nKapitalMax = New RouletteSystem.NumericTextBox
        Me.nKapitalMin = New RouletteSystem.NumericTextBox
        Me.nKapital = New RouletteSystem.NumericTextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.nRundenBisSiegMin = New RouletteSystem.NumericTextBox
        Me.nGewinnVerlustDurchschnitt = New RouletteSystem.NumericTextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.nSiegNachRunde9 = New RouletteSystem.NumericTextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.nSiegNachRunde6 = New RouletteSystem.NumericTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.nSiegNachRunde8 = New RouletteSystem.NumericTextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.nSiegNachRunde7 = New RouletteSystem.NumericTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.nSiegNachRunde5 = New RouletteSystem.NumericTextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.nSiegNachRunde4 = New RouletteSystem.NumericTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.nSiegNachRunde3 = New RouletteSystem.NumericTextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.nSiegNachRunde2 = New RouletteSystem.NumericTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.nSiegNachRunde1 = New RouletteSystem.NumericTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.nRundenBisSiegMax = New RouletteSystem.NumericTextBox
        Me.nRundenBisSiegDurchschnitt = New RouletteSystem.NumericTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.nRunden = New RouletteSystem.NumericTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.nGewinnVerlust = New RouletteSystem.NumericTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabStatistikDetail = New System.Windows.Forms.TabPage
        Me.dgStatistik = New System.Windows.Forms.DataGridView
        Me.colRunde = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colKapital = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEinsatz = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colZahlen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRoulette = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colBenötigteRunden = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TabStatistikGrafik = New System.Windows.Forms.TabPage
        Me.DiagStatistik = New ZedGraph.ZedGraphControl
        Me.TabStatistik.SuspendLayout()
        Me.TabStatistikÜbersicht.SuspendLayout()
        Me.TabStatistikDetail.SuspendLayout()
        CType(Me.dgStatistik, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabStatistikGrafik.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabStatistik
        '
        Me.TabStatistik.Controls.Add(Me.TabStatistikÜbersicht)
        Me.TabStatistik.Controls.Add(Me.TabStatistikDetail)
        Me.TabStatistik.Controls.Add(Me.TabStatistikGrafik)
        Me.TabStatistik.Location = New System.Drawing.Point(0, 0)
        Me.TabStatistik.Name = "TabStatistik"
        Me.TabStatistik.SelectedIndex = 0
        Me.TabStatistik.Size = New System.Drawing.Size(658, 363)
        Me.TabStatistik.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabStatistik.TabIndex = 1
        '
        'TabStatistikÜbersicht
        '
        Me.TabStatistikÜbersicht.Controls.Add(Me.nKapitalMax)
        Me.TabStatistikÜbersicht.Controls.Add(Me.nKapitalMin)
        Me.TabStatistikÜbersicht.Controls.Add(Me.nKapital)
        Me.TabStatistikÜbersicht.Controls.Add(Me.Label18)
        Me.TabStatistikÜbersicht.Controls.Add(Me.Label6)
        Me.TabStatistikÜbersicht.Controls.Add(Me.nRundenBisSiegMin)
        Me.TabStatistikÜbersicht.Controls.Add(Me.nGewinnVerlustDurchschnitt)
        Me.TabStatistikÜbersicht.Controls.Add(Me.Label17)
        Me.TabStatistikÜbersicht.Controls.Add(Me.Label4)
        Me.TabStatistikÜbersicht.Controls.Add(Me.Label16)
        Me.TabStatistikÜbersicht.Controls.Add(Me.nSiegNachRunde9)
        Me.TabStatistikÜbersicht.Controls.Add(Me.Label15)
        Me.TabStatistikÜbersicht.Controls.Add(Me.nSiegNachRunde6)
        Me.TabStatistikÜbersicht.Controls.Add(Me.Label14)
        Me.TabStatistikÜbersicht.Controls.Add(Me.nSiegNachRunde8)
        Me.TabStatistikÜbersicht.Controls.Add(Me.Label13)
        Me.TabStatistikÜbersicht.Controls.Add(Me.nSiegNachRunde7)
        Me.TabStatistikÜbersicht.Controls.Add(Me.Label12)
        Me.TabStatistikÜbersicht.Controls.Add(Me.nSiegNachRunde5)
        Me.TabStatistikÜbersicht.Controls.Add(Me.Label11)
        Me.TabStatistikÜbersicht.Controls.Add(Me.nSiegNachRunde4)
        Me.TabStatistikÜbersicht.Controls.Add(Me.Label10)
        Me.TabStatistikÜbersicht.Controls.Add(Me.nSiegNachRunde3)
        Me.TabStatistikÜbersicht.Controls.Add(Me.Label9)
        Me.TabStatistikÜbersicht.Controls.Add(Me.nSiegNachRunde2)
        Me.TabStatistikÜbersicht.Controls.Add(Me.Label8)
        Me.TabStatistikÜbersicht.Controls.Add(Me.Label3)
        Me.TabStatistikÜbersicht.Controls.Add(Me.nSiegNachRunde1)
        Me.TabStatistikÜbersicht.Controls.Add(Me.Label2)
        Me.TabStatistikÜbersicht.Controls.Add(Me.nRundenBisSiegMax)
        Me.TabStatistikÜbersicht.Controls.Add(Me.nRundenBisSiegDurchschnitt)
        Me.TabStatistikÜbersicht.Controls.Add(Me.Label7)
        Me.TabStatistikÜbersicht.Controls.Add(Me.nRunden)
        Me.TabStatistikÜbersicht.Controls.Add(Me.Label5)
        Me.TabStatistikÜbersicht.Controls.Add(Me.nGewinnVerlust)
        Me.TabStatistikÜbersicht.Controls.Add(Me.Label1)
        Me.TabStatistikÜbersicht.Location = New System.Drawing.Point(4, 22)
        Me.TabStatistikÜbersicht.Name = "TabStatistikÜbersicht"
        Me.TabStatistikÜbersicht.Padding = New System.Windows.Forms.Padding(3)
        Me.TabStatistikÜbersicht.Size = New System.Drawing.Size(650, 337)
        Me.TabStatistikÜbersicht.TabIndex = 0
        Me.TabStatistikÜbersicht.Text = "Übersicht"
        Me.TabStatistikÜbersicht.UseVisualStyleBackColor = True
        '
        'nKapitalMax
        '
        Me.nKapitalMax.IsInteger = True
        Me.nKapitalMax.Location = New System.Drawing.Point(320, 45)
        Me.nKapitalMax.Name = "nKapitalMax"
        Me.nKapitalMax.ReadOnly = True
        Me.nKapitalMax.Size = New System.Drawing.Size(62, 20)
        Me.nKapitalMax.StartsWithNull = False
        Me.nKapitalMax.TabIndex = 57
        Me.nKapitalMax.Text = "0"
        Me.nKapitalMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nKapitalMin
        '
        Me.nKapitalMin.IsInteger = True
        Me.nKapitalMin.Location = New System.Drawing.Point(252, 45)
        Me.nKapitalMin.Name = "nKapitalMin"
        Me.nKapitalMin.ReadOnly = True
        Me.nKapitalMin.Size = New System.Drawing.Size(62, 20)
        Me.nKapitalMin.StartsWithNull = False
        Me.nKapitalMin.TabIndex = 56
        Me.nKapitalMin.Text = "0"
        Me.nKapitalMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nKapital
        '
        Me.nKapital.IsInteger = True
        Me.nKapital.Location = New System.Drawing.Point(116, 45)
        Me.nKapital.Name = "nKapital"
        Me.nKapital.ReadOnly = True
        Me.nKapital.Size = New System.Drawing.Size(62, 20)
        Me.nKapital.StartsWithNull = False
        Me.nKapital.TabIndex = 54
        Me.nKapital.Text = "0"
        Me.nKapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 13)
        Me.Label18.TabIndex = 53
        Me.Label18.Text = "Kapital"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(252, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Min"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nRundenBisSiegMin
        '
        Me.nRundenBisSiegMin.IsInteger = True
        Me.nRundenBisSiegMin.Location = New System.Drawing.Point(252, 97)
        Me.nRundenBisSiegMin.Name = "nRundenBisSiegMin"
        Me.nRundenBisSiegMin.ReadOnly = True
        Me.nRundenBisSiegMin.Size = New System.Drawing.Size(62, 20)
        Me.nRundenBisSiegMin.StartsWithNull = False
        Me.nRundenBisSiegMin.TabIndex = 51
        Me.nRundenBisSiegMin.Text = "0"
        Me.nRundenBisSiegMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nGewinnVerlustDurchschnitt
        '
        Me.nGewinnVerlustDurchschnitt.IsInteger = False
        Me.nGewinnVerlustDurchschnitt.Location = New System.Drawing.Point(184, 71)
        Me.nGewinnVerlustDurchschnitt.Name = "nGewinnVerlustDurchschnitt"
        Me.nGewinnVerlustDurchschnitt.ReadOnly = True
        Me.nGewinnVerlustDurchschnitt.Size = New System.Drawing.Size(62, 20)
        Me.nGewinnVerlustDurchschnitt.StartsWithNull = False
        Me.nGewinnVerlustDurchschnitt.TabIndex = 50
        Me.nGewinnVerlustDurchschnitt.Text = "0"
        Me.nGewinnVerlustDurchschnitt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(320, 3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 13)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "Max"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(184, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Mittel"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(116, 3)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "Wert"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nSiegNachRunde9
        '
        Me.nSiegNachRunde9.IsInteger = True
        Me.nSiegNachRunde9.Location = New System.Drawing.Point(492, 196)
        Me.nSiegNachRunde9.Name = "nSiegNachRunde9"
        Me.nSiegNachRunde9.ReadOnly = True
        Me.nSiegNachRunde9.Size = New System.Drawing.Size(37, 20)
        Me.nSiegNachRunde9.StartsWithNull = False
        Me.nSiegNachRunde9.TabIndex = 46
        Me.nSiegNachRunde9.Text = "0"
        Me.nSiegNachRunde9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(426, 199)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 13)
        Me.Label15.TabIndex = 45
        Me.Label15.Text = "+8 Runden"
        '
        'nSiegNachRunde6
        '
        Me.nSiegNachRunde6.IsInteger = True
        Me.nSiegNachRunde6.Location = New System.Drawing.Point(492, 130)
        Me.nSiegNachRunde6.Name = "nSiegNachRunde6"
        Me.nSiegNachRunde6.ReadOnly = True
        Me.nSiegNachRunde6.Size = New System.Drawing.Size(37, 20)
        Me.nSiegNachRunde6.StartsWithNull = False
        Me.nSiegNachRunde6.TabIndex = 44
        Me.nSiegNachRunde6.Text = "0"
        Me.nSiegNachRunde6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(426, 133)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "6 Runden"
        '
        'nSiegNachRunde8
        '
        Me.nSiegNachRunde8.IsInteger = True
        Me.nSiegNachRunde8.Location = New System.Drawing.Point(492, 174)
        Me.nSiegNachRunde8.Name = "nSiegNachRunde8"
        Me.nSiegNachRunde8.ReadOnly = True
        Me.nSiegNachRunde8.Size = New System.Drawing.Size(37, 20)
        Me.nSiegNachRunde8.StartsWithNull = False
        Me.nSiegNachRunde8.TabIndex = 42
        Me.nSiegNachRunde8.Text = "0"
        Me.nSiegNachRunde8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(426, 177)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "8 Runden"
        '
        'nSiegNachRunde7
        '
        Me.nSiegNachRunde7.IsInteger = True
        Me.nSiegNachRunde7.Location = New System.Drawing.Point(492, 152)
        Me.nSiegNachRunde7.Name = "nSiegNachRunde7"
        Me.nSiegNachRunde7.ReadOnly = True
        Me.nSiegNachRunde7.Size = New System.Drawing.Size(37, 20)
        Me.nSiegNachRunde7.StartsWithNull = False
        Me.nSiegNachRunde7.TabIndex = 40
        Me.nSiegNachRunde7.Text = "0"
        Me.nSiegNachRunde7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(426, 155)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "7 Runden"
        '
        'nSiegNachRunde5
        '
        Me.nSiegNachRunde5.IsInteger = True
        Me.nSiegNachRunde5.Location = New System.Drawing.Point(492, 108)
        Me.nSiegNachRunde5.Name = "nSiegNachRunde5"
        Me.nSiegNachRunde5.ReadOnly = True
        Me.nSiegNachRunde5.Size = New System.Drawing.Size(37, 20)
        Me.nSiegNachRunde5.StartsWithNull = False
        Me.nSiegNachRunde5.TabIndex = 38
        Me.nSiegNachRunde5.Text = "0"
        Me.nSiegNachRunde5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(426, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "5 Runden"
        '
        'nSiegNachRunde4
        '
        Me.nSiegNachRunde4.IsInteger = True
        Me.nSiegNachRunde4.Location = New System.Drawing.Point(492, 86)
        Me.nSiegNachRunde4.Name = "nSiegNachRunde4"
        Me.nSiegNachRunde4.ReadOnly = True
        Me.nSiegNachRunde4.Size = New System.Drawing.Size(37, 20)
        Me.nSiegNachRunde4.StartsWithNull = False
        Me.nSiegNachRunde4.TabIndex = 36
        Me.nSiegNachRunde4.Text = "0"
        Me.nSiegNachRunde4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(426, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "4 Runden"
        '
        'nSiegNachRunde3
        '
        Me.nSiegNachRunde3.IsInteger = True
        Me.nSiegNachRunde3.Location = New System.Drawing.Point(492, 64)
        Me.nSiegNachRunde3.Name = "nSiegNachRunde3"
        Me.nSiegNachRunde3.ReadOnly = True
        Me.nSiegNachRunde3.Size = New System.Drawing.Size(37, 20)
        Me.nSiegNachRunde3.StartsWithNull = False
        Me.nSiegNachRunde3.TabIndex = 34
        Me.nSiegNachRunde3.Text = "0"
        Me.nSiegNachRunde3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(426, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "3 Runden"
        '
        'nSiegNachRunde2
        '
        Me.nSiegNachRunde2.IsInteger = True
        Me.nSiegNachRunde2.Location = New System.Drawing.Point(492, 42)
        Me.nSiegNachRunde2.Name = "nSiegNachRunde2"
        Me.nSiegNachRunde2.ReadOnly = True
        Me.nSiegNachRunde2.Size = New System.Drawing.Size(37, 20)
        Me.nSiegNachRunde2.StartsWithNull = False
        Me.nSiegNachRunde2.TabIndex = 32
        Me.nSiegNachRunde2.Text = "0"
        Me.nSiegNachRunde2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(426, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "2 Runden"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(426, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Sieg nach: (Anzahl)"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'nSiegNachRunde1
        '
        Me.nSiegNachRunde1.IsInteger = True
        Me.nSiegNachRunde1.Location = New System.Drawing.Point(492, 20)
        Me.nSiegNachRunde1.Name = "nSiegNachRunde1"
        Me.nSiegNachRunde1.ReadOnly = True
        Me.nSiegNachRunde1.Size = New System.Drawing.Size(37, 20)
        Me.nSiegNachRunde1.StartsWithNull = False
        Me.nSiegNachRunde1.TabIndex = 27
        Me.nSiegNachRunde1.Text = "0"
        Me.nSiegNachRunde1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(426, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "1 Runde"
        '
        'nRundenBisSiegMax
        '
        Me.nRundenBisSiegMax.IsInteger = True
        Me.nRundenBisSiegMax.Location = New System.Drawing.Point(320, 97)
        Me.nRundenBisSiegMax.Name = "nRundenBisSiegMax"
        Me.nRundenBisSiegMax.ReadOnly = True
        Me.nRundenBisSiegMax.Size = New System.Drawing.Size(62, 20)
        Me.nRundenBisSiegMax.StartsWithNull = False
        Me.nRundenBisSiegMax.TabIndex = 25
        Me.nRundenBisSiegMax.Text = "0"
        Me.nRundenBisSiegMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'nRundenBisSiegDurchschnitt
        '
        Me.nRundenBisSiegDurchschnitt.IsInteger = False
        Me.nRundenBisSiegDurchschnitt.Location = New System.Drawing.Point(184, 97)
        Me.nRundenBisSiegDurchschnitt.Name = "nRundenBisSiegDurchschnitt"
        Me.nRundenBisSiegDurchschnitt.ReadOnly = True
        Me.nRundenBisSiegDurchschnitt.Size = New System.Drawing.Size(62, 20)
        Me.nRundenBisSiegDurchschnitt.StartsWithNull = False
        Me.nRundenBisSiegDurchschnitt.TabIndex = 23
        Me.nRundenBisSiegDurchschnitt.Text = "0"
        Me.nRundenBisSiegDurchschnitt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Runden bis zum Sieg"
        '
        'nRunden
        '
        Me.nRunden.IsInteger = True
        Me.nRunden.Location = New System.Drawing.Point(116, 19)
        Me.nRunden.Name = "nRunden"
        Me.nRunden.ReadOnly = True
        Me.nRunden.Size = New System.Drawing.Size(62, 20)
        Me.nRunden.StartsWithNull = False
        Me.nRunden.TabIndex = 19
        Me.nRunden.Text = "0"
        Me.nRunden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Anzahl Runden"
        '
        'nGewinnVerlust
        '
        Me.nGewinnVerlust.IsInteger = True
        Me.nGewinnVerlust.Location = New System.Drawing.Point(116, 71)
        Me.nGewinnVerlust.Name = "nGewinnVerlust"
        Me.nGewinnVerlust.ReadOnly = True
        Me.nGewinnVerlust.Size = New System.Drawing.Size(62, 20)
        Me.nGewinnVerlust.StartsWithNull = False
        Me.nGewinnVerlust.TabIndex = 11
        Me.nGewinnVerlust.Text = "0"
        Me.nGewinnVerlust.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Gewinn/Verlust"
        '
        'TabStatistikDetail
        '
        Me.TabStatistikDetail.Controls.Add(Me.dgStatistik)
        Me.TabStatistikDetail.Location = New System.Drawing.Point(4, 22)
        Me.TabStatistikDetail.Name = "TabStatistikDetail"
        Me.TabStatistikDetail.Padding = New System.Windows.Forms.Padding(3)
        Me.TabStatistikDetail.Size = New System.Drawing.Size(650, 337)
        Me.TabStatistikDetail.TabIndex = 1
        Me.TabStatistikDetail.Text = "Details"
        Me.TabStatistikDetail.UseVisualStyleBackColor = True
        '
        'dgStatistik
        '
        Me.dgStatistik.AllowUserToAddRows = False
        Me.dgStatistik.AllowUserToDeleteRows = False
        Me.dgStatistik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStatistik.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colRunde, Me.colKapital, Me.colEinsatz, Me.colZahlen, Me.colRoulette, Me.colBenötigteRunden})
        Me.dgStatistik.Location = New System.Drawing.Point(0, 0)
        Me.dgStatistik.Name = "dgStatistik"
        Me.dgStatistik.ReadOnly = True
        Me.dgStatistik.Size = New System.Drawing.Size(650, 337)
        Me.dgStatistik.TabIndex = 1
        '
        'colRunde
        '
        Me.colRunde.HeaderText = "Runde"
        Me.colRunde.Name = "colRunde"
        Me.colRunde.ReadOnly = True
        '
        'colKapital
        '
        Me.colKapital.HeaderText = "Kapital"
        Me.colKapital.Name = "colKapital"
        Me.colKapital.ReadOnly = True
        '
        'colEinsatz
        '
        Me.colEinsatz.HeaderText = "Einsatz"
        Me.colEinsatz.Name = "colEinsatz"
        Me.colEinsatz.ReadOnly = True
        '
        'colZahlen
        '
        Me.colZahlen.HeaderText = "Zahlen"
        Me.colZahlen.Name = "colZahlen"
        Me.colZahlen.ReadOnly = True
        '
        'colRoulette
        '
        Me.colRoulette.HeaderText = "Roulette"
        Me.colRoulette.Name = "colRoulette"
        Me.colRoulette.ReadOnly = True
        '
        'colBenötigteRunden
        '
        Me.colBenötigteRunden.HeaderText = "Benötigte Runden"
        Me.colBenötigteRunden.Name = "colBenötigteRunden"
        Me.colBenötigteRunden.ReadOnly = True
        '
        'TabStatistikGrafik
        '
        Me.TabStatistikGrafik.Controls.Add(Me.DiagStatistik)
        Me.TabStatistikGrafik.Location = New System.Drawing.Point(4, 22)
        Me.TabStatistikGrafik.Name = "TabStatistikGrafik"
        Me.TabStatistikGrafik.Padding = New System.Windows.Forms.Padding(3)
        Me.TabStatistikGrafik.Size = New System.Drawing.Size(650, 337)
        Me.TabStatistikGrafik.TabIndex = 2
        Me.TabStatistikGrafik.Text = "Grafiken"
        Me.TabStatistikGrafik.UseVisualStyleBackColor = True
        '
        'DiagStatistik
        '
        Me.DiagStatistik.EditModifierKeys = System.Windows.Forms.Keys.None
        Me.DiagStatistik.IsAutoScrollRange = True
        Me.DiagStatistik.Location = New System.Drawing.Point(0, 0)
        Me.DiagStatistik.Name = "DiagStatistik"
        Me.DiagStatistik.ScrollGrace = 0
        Me.DiagStatistik.ScrollMaxX = 0
        Me.DiagStatistik.ScrollMaxY = 0
        Me.DiagStatistik.ScrollMaxY2 = 0
        Me.DiagStatistik.ScrollMinX = 0
        Me.DiagStatistik.ScrollMinY = 0
        Me.DiagStatistik.ScrollMinY2 = 0
        Me.DiagStatistik.Size = New System.Drawing.Size(650, 337)
        Me.DiagStatistik.TabIndex = 0
        '
        'frmStatistik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 380)
        Me.Controls.Add(Me.TabStatistik)
        Me.Name = "frmStatistik"
        Me.Text = "Roulette System Simulator - Statistik"
        Me.TabStatistik.ResumeLayout(False)
        Me.TabStatistikÜbersicht.ResumeLayout(False)
        Me.TabStatistikÜbersicht.PerformLayout()
        Me.TabStatistikDetail.ResumeLayout(False)
        CType(Me.dgStatistik, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabStatistikGrafik.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabStatistik As System.Windows.Forms.TabControl
    Friend WithEvents TabStatistikÜbersicht As System.Windows.Forms.TabPage
    Friend WithEvents TabStatistikDetail As System.Windows.Forms.TabPage
    Friend WithEvents dgStatistik As System.Windows.Forms.DataGridView
    Friend WithEvents colRunde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colKapital As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEinsatz As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colZahlen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRoulette As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBenötigteRunden As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabStatistikGrafik As System.Windows.Forms.TabPage
    Friend WithEvents nGewinnVerlust As RouletteSystem.NumericTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nRunden As RouletteSystem.NumericTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nSiegNachRunde1 As RouletteSystem.NumericTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nRundenBisSiegMax As RouletteSystem.NumericTextBox
    Friend WithEvents nRundenBisSiegDurchschnitt As RouletteSystem.NumericTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nSiegNachRunde6 As RouletteSystem.NumericTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents nSiegNachRunde8 As RouletteSystem.NumericTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents nSiegNachRunde7 As RouletteSystem.NumericTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents nSiegNachRunde5 As RouletteSystem.NumericTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents nSiegNachRunde4 As RouletteSystem.NumericTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents nSiegNachRunde3 As RouletteSystem.NumericTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents nSiegNachRunde2 As RouletteSystem.NumericTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nSiegNachRunde9 As RouletteSystem.NumericTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents nGewinnVerlustDurchschnitt As RouletteSystem.NumericTextBox
    Friend WithEvents DiagStatistik As ZedGraph.ZedGraphControl
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nRundenBisSiegMin As RouletteSystem.NumericTextBox
    Friend WithEvents nKapitalMax As RouletteSystem.NumericTextBox
    Friend WithEvents nKapitalMin As RouletteSystem.NumericTextBox
    Friend WithEvents nKapital As RouletteSystem.NumericTextBox
End Class
