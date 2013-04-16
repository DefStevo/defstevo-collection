<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRDP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRDP))
        Me.myRDP = New AxMSTSCLib.AxMsRdpClient2
        CType(Me.myRDP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'myRDP
        '
        Me.myRDP.Enabled = True
        Me.myRDP.Location = New System.Drawing.Point(0, 0)
        Me.myRDP.Name = "myRDP"
        Me.myRDP.OcxState = CType(resources.GetObject("myRDP.OcxState"), System.Windows.Forms.AxHost.State)
        Me.myRDP.Size = New System.Drawing.Size(300, 300)
        Me.myRDP.TabIndex = 4
        '
        'frmRDP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 299)
        Me.Controls.Add(Me.myRDP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmRDP"
        Me.Text = "frmRDP"
        CType(Me.myRDP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents myRDP As AxMSTSCLib.AxMsRdpClient2
End Class
