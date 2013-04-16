<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListe
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
    Me.lstListe = New System.Windows.Forms.ListView
    Me.colID = New System.Windows.Forms.ColumnHeader
    Me.colName = New System.Windows.Forms.ColumnHeader
    Me.colSaldo = New System.Windows.Forms.ColumnHeader
    Me.btnAuswählen = New System.Windows.Forms.Button
    Me.btnSchließen = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'lstListe
    '
    Me.lstListe.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colName, Me.colSaldo})
    Me.lstListe.FullRowSelect = True
    Me.lstListe.GridLines = True
    Me.lstListe.Location = New System.Drawing.Point(4, 4)
    Me.lstListe.Name = "lstListe"
    Me.lstListe.Size = New System.Drawing.Size(336, 215)
    Me.lstListe.TabIndex = 0
    Me.lstListe.UseCompatibleStateImageBehavior = False
    Me.lstListe.View = System.Windows.Forms.View.Details
    '
    'colID
    '
    Me.colID.Text = "Nummer"
    '
    'colName
    '
    Me.colName.Text = "Name"
    Me.colName.Width = 180
    '
    'colSaldo
    '
    Me.colSaldo.Text = "Saldo"
    Me.colSaldo.Width = 90
    '
    'btnAuswählen
    '
    Me.btnAuswählen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnAuswählen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
    Me.btnAuswählen.Location = New System.Drawing.Point(4, 225)
    Me.btnAuswählen.Name = "btnAuswählen"
    Me.btnAuswählen.Size = New System.Drawing.Size(163, 33)
    Me.btnAuswählen.TabIndex = 1
    Me.btnAuswählen.Text = "Auswählen"
    Me.btnAuswählen.UseVisualStyleBackColor = True
    '
    'btnSchließen
    '
    Me.btnSchließen.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btnSchließen.Location = New System.Drawing.Point(177, 225)
    Me.btnSchließen.Name = "btnSchließen"
    Me.btnSchließen.Size = New System.Drawing.Size(163, 33)
    Me.btnSchließen.TabIndex = 2
    Me.btnSchließen.Text = "Schließen"
    Me.btnSchließen.UseVisualStyleBackColor = True
    '
    'frmListe
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(345, 264)
    Me.Controls.Add(Me.btnSchließen)
    Me.Controls.Add(Me.btnAuswählen)
    Me.Controls.Add(Me.lstListe)
    Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
    Me.Name = "frmListe"
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Liste"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents lstListe As System.Windows.Forms.ListView
  Friend WithEvents btnAuswählen As System.Windows.Forms.Button
  Friend WithEvents btnSchließen As System.Windows.Forms.Button
  Friend WithEvents colID As System.Windows.Forms.ColumnHeader
  Friend WithEvents colName As System.Windows.Forms.ColumnHeader
  Friend WithEvents colSaldo As System.Windows.Forms.ColumnHeader
End Class
