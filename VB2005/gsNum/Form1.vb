Public Class Form1
    Inherits System.Windows.Forms.Form

    Private NumInput As gsNumInput

#Region " Vom Windows Form Designer generierter Code "

    Public Sub New()
        MyBase.New()

        ' Dieser Aufruf ist für den Windows Form-Designer erforderlich.
        InitializeComponent()

        ' Initialisierungen nach dem Aufruf InitializeComponent() hinzufügen

    End Sub

    ' Die Form überschreibt den Löschvorgang der Basisklasse, um Komponenten zu bereinigen.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' Für Windows Form-Designer erforderlich
    Private components As System.ComponentModel.IContainer

    'HINWEIS: Die folgende Prozedur ist für den Windows Form-Designer erforderlich
    'Sie kann mit dem Windows Form-Designer modifiziert werden.
    'Verwenden Sie nicht den Code-Editor zur Bearbeitung.
    Public WithEvents cmdEnd As System.Windows.Forms.Button
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents optDecimales4 As System.Windows.Forms.RadioButton
    Public WithEvents optDecimales3 As System.Windows.Forms.RadioButton
    Public WithEvents optDecimales2 As System.Windows.Forms.RadioButton
    Public WithEvents optDecimales1 As System.Windows.Forms.RadioButton
    Public WithEvents optDecimales0 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.cmdEnd = New System.Windows.Forms.Button
    Me.Frame1 = New System.Windows.Forms.GroupBox
    Me.optDecimales0 = New System.Windows.Forms.RadioButton
    Me.optDecimales4 = New System.Windows.Forms.RadioButton
    Me.optDecimales3 = New System.Windows.Forms.RadioButton
    Me.optDecimales2 = New System.Windows.Forms.RadioButton
    Me.optDecimales1 = New System.Windows.Forms.RadioButton
    Me.TextBox1 = New System.Windows.Forms.TextBox
    Me.Frame1.SuspendLayout()
    Me.SuspendLayout()
    '
    'cmdEnd
    '
    Me.cmdEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.cmdEnd.BackColor = System.Drawing.SystemColors.Control
    Me.cmdEnd.Cursor = System.Windows.Forms.Cursors.Default
    Me.cmdEnd.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.cmdEnd.ForeColor = System.Drawing.SystemColors.ControlText
    Me.cmdEnd.Location = New System.Drawing.Point(210, 96)
    Me.cmdEnd.Name = "cmdEnd"
    Me.cmdEnd.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.cmdEnd.Size = New System.Drawing.Size(90, 33)
    Me.cmdEnd.TabIndex = 7
    Me.cmdEnd.Text = "Be&enden"
    Me.cmdEnd.UseVisualStyleBackColor = False
    '
    'Frame1
    '
    Me.Frame1.BackColor = System.Drawing.SystemColors.Control
    Me.Frame1.Controls.Add(Me.optDecimales0)
    Me.Frame1.Controls.Add(Me.optDecimales4)
    Me.Frame1.Controls.Add(Me.optDecimales3)
    Me.Frame1.Controls.Add(Me.optDecimales2)
    Me.Frame1.Controls.Add(Me.optDecimales1)
    Me.Frame1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
    Me.Frame1.Location = New System.Drawing.Point(16, 74)
    Me.Frame1.Name = "Frame1"
    Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.Frame1.Size = New System.Drawing.Size(172, 56)
    Me.Frame1.TabIndex = 1
    Me.Frame1.TabStop = False
    Me.Frame1.Text = "Dezimalstellen"
    '
    'optDecimales0
    '
    Me.optDecimales0.BackColor = System.Drawing.SystemColors.Control
    Me.optDecimales0.CheckAlign = System.Drawing.ContentAlignment.TopCenter
    Me.optDecimales0.Cursor = System.Windows.Forms.Cursors.Default
    Me.optDecimales0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.optDecimales0.ForeColor = System.Drawing.SystemColors.ControlText
    Me.optDecimales0.Location = New System.Drawing.Point(8, 16)
    Me.optDecimales0.Name = "optDecimales0"
    Me.optDecimales0.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.optDecimales0.Size = New System.Drawing.Size(16, 34)
    Me.optDecimales0.TabIndex = 2
    Me.optDecimales0.TabStop = True
    Me.optDecimales0.Text = "0"
    Me.optDecimales0.TextAlign = System.Drawing.ContentAlignment.BottomCenter
    Me.optDecimales0.UseVisualStyleBackColor = False
    '
    'optDecimales4
    '
    Me.optDecimales4.BackColor = System.Drawing.SystemColors.Control
    Me.optDecimales4.CheckAlign = System.Drawing.ContentAlignment.TopCenter
    Me.optDecimales4.Cursor = System.Windows.Forms.Cursors.Default
    Me.optDecimales4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.optDecimales4.ForeColor = System.Drawing.SystemColors.ControlText
    Me.optDecimales4.Location = New System.Drawing.Point(144, 16)
    Me.optDecimales4.Name = "optDecimales4"
    Me.optDecimales4.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.optDecimales4.Size = New System.Drawing.Size(16, 34)
    Me.optDecimales4.TabIndex = 6
    Me.optDecimales4.TabStop = True
    Me.optDecimales4.Text = "4"
    Me.optDecimales4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
    Me.optDecimales4.UseVisualStyleBackColor = False
    '
    'optDecimales3
    '
    Me.optDecimales3.BackColor = System.Drawing.SystemColors.Control
    Me.optDecimales3.CheckAlign = System.Drawing.ContentAlignment.TopCenter
    Me.optDecimales3.Cursor = System.Windows.Forms.Cursors.Default
    Me.optDecimales3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.optDecimales3.ForeColor = System.Drawing.SystemColors.ControlText
    Me.optDecimales3.Location = New System.Drawing.Point(110, 16)
    Me.optDecimales3.Name = "optDecimales3"
    Me.optDecimales3.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.optDecimales3.Size = New System.Drawing.Size(16, 34)
    Me.optDecimales3.TabIndex = 5
    Me.optDecimales3.TabStop = True
    Me.optDecimales3.Text = "3"
    Me.optDecimales3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
    Me.optDecimales3.UseVisualStyleBackColor = False
    '
    'optDecimales2
    '
    Me.optDecimales2.BackColor = System.Drawing.SystemColors.Control
    Me.optDecimales2.CheckAlign = System.Drawing.ContentAlignment.TopCenter
    Me.optDecimales2.Cursor = System.Windows.Forms.Cursors.Default
    Me.optDecimales2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.optDecimales2.ForeColor = System.Drawing.SystemColors.ControlText
    Me.optDecimales2.Location = New System.Drawing.Point(76, 16)
    Me.optDecimales2.Name = "optDecimales2"
    Me.optDecimales2.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.optDecimales2.Size = New System.Drawing.Size(16, 34)
    Me.optDecimales2.TabIndex = 4
    Me.optDecimales2.TabStop = True
    Me.optDecimales2.Text = "2"
    Me.optDecimales2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
    Me.optDecimales2.UseVisualStyleBackColor = False
    '
    'optDecimales1
    '
    Me.optDecimales1.BackColor = System.Drawing.SystemColors.Control
    Me.optDecimales1.CheckAlign = System.Drawing.ContentAlignment.TopCenter
    Me.optDecimales1.Cursor = System.Windows.Forms.Cursors.Default
    Me.optDecimales1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.optDecimales1.ForeColor = System.Drawing.SystemColors.ControlText
    Me.optDecimales1.Location = New System.Drawing.Point(42, 16)
    Me.optDecimales1.Name = "optDecimales1"
    Me.optDecimales1.RightToLeft = System.Windows.Forms.RightToLeft.No
    Me.optDecimales1.Size = New System.Drawing.Size(16, 34)
    Me.optDecimales1.TabIndex = 3
    Me.optDecimales1.TabStop = True
    Me.optDecimales1.Text = "1"
    Me.optDecimales1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
    Me.optDecimales1.UseVisualStyleBackColor = False
    '
    'TextBox1
    '
    Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TextBox1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBox1.Location = New System.Drawing.Point(16, 20)
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.Size = New System.Drawing.Size(284, 32)
    Me.TextBox1.TabIndex = 0
    Me.TextBox1.Text = "TextBox1"
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(322, 145)
    Me.Controls.Add(Me.TextBox1)
    Me.Controls.Add(Me.cmdEnd)
    Me.Controls.Add(Me.Frame1)
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.Frame1.ResumeLayout(False)
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

#End Region


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim RB As RadioButton

        ' Tag-Eigenschaft der RadioButtons in Frame1 auf die Werte 0...4 setzen und für 
        ' alle RadioButtons gemeinsame Ereignisprozedur optDecimales_CheckedChanged
        ' zuweisen.
        For Each RB In Frame1.Controls
            RB.Tag = CType(RB.Name.Substring(Len(RB.Name) - 1), Integer)
            AddHandler RB.CheckedChanged, AddressOf optDecimales_CheckedChanged
        Next

        Me.MinimumSize = New Size(Me.Width, Me.Height)
        Me.MaximumSize = New Size(Screen.PrimaryScreen.WorkingArea.Width, Me.Height)

        cmdEnd.TabStop = False
        TextBox1.TextAlign = HorizontalAlignment.Right

        ' Instanz der Klasse gsNumInput mit Verweis auf die Textbox Textbox1 erstellen 
        NumInput = New gsNumInput(TextBox1)
        ' ab hier lässt TextBox1 nur noch numerische Eingaben zu


        ' RadioButton optDecimales2 auswählen und damit in 
        ' Sub optDecimales_CheckedChanged den Wert für 
        ' NumInput.NumDecimales auf 2 setzen.
        optDecimales2.Checked = True

    End Sub

    Private Sub optDecimales_CheckedChanged(ByVal Sender As System.Object, ByVal eventArgs As System.EventArgs)
        ' gemeinsame Ereignisprozedur für die RadioButtons optDecimales0 ... optDecimales4
        Dim RB As RadioButton = DirectCast(Sender, RadioButton)
        Dim intND As Integer

        If RB.Checked Then
            intND = CType(RB.Tag, Integer)
            ' Anzahl der erlaubten Dezimalstellen einstellen
            NumInput.NumDecimales = intND

            TextBox1.Text = ""
            TextBox1.Focus()

            ' Titelleiste der Form beschriften
            Select Case intND
                Case 0
                    Me.Text = "keine Dezimalstellen"
                Case 1
                    Me.Text = "1 Dezimalstelle"
                Case Else
                    Me.Text = "max. " & intND & " Dezimalstellen"
            End Select
        End If
    End Sub

    Private Sub cmdEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnd.Click
        Me.Close()
    End Sub

  Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

  End Sub
End Class
