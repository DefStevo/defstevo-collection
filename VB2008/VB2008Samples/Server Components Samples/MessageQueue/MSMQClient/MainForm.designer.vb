' Copyright (c) Microsoft Corporation. All rights reserved.
Partial Public Class MainForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OrderButton = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Fries = New System.Windows.Forms.RadioButton
        Me.Drink = New System.Windows.Forms.RadioButton
        Me.Hotdog = New System.Windows.Forms.RadioButton
        Me.Hamburger = New System.Windows.Forms.RadioButton
        Me.qOrders = New System.Messaging.MessageQueue
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OrderButton
        '
        Me.OrderButton.Location = New System.Drawing.Point(99, 106)
        Me.OrderButton.Name = "OrderButton"
        Me.OrderButton.Size = New System.Drawing.Size(160, 25)
        Me.OrderButton.TabIndex = 0
        Me.OrderButton.Text = "Place Order"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Fries)
        Me.GroupBox1.Controls.Add(Me.Drink)
        Me.GroupBox1.Controls.Add(Me.Hotdog)
        Me.GroupBox1.Controls.Add(Me.Hamburger)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 73)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu Items"
        '
        'Fries
        '
        Me.Fries.AutoSize = True
        Me.Fries.Location = New System.Drawing.Point(89, 42)
        Me.Fries.Name = "Fries"
        Me.Fries.Size = New System.Drawing.Size(47, 17)
        Me.Fries.TabIndex = 3
        Me.Fries.Text = "Fries"
        '
        'Drink
        '
        Me.Drink.AutoSize = True
        Me.Drink.Location = New System.Drawing.Point(10, 42)
        Me.Drink.Name = "Drink"
        Me.Drink.Size = New System.Drawing.Size(50, 17)
        Me.Drink.TabIndex = 2
        Me.Drink.Text = "Drink"
        '
        'Hotdog
        '
        Me.Hotdog.AutoSize = True
        Me.Hotdog.Location = New System.Drawing.Point(89, 19)
        Me.Hotdog.Name = "Hotdog"
        Me.Hotdog.Size = New System.Drawing.Size(60, 17)
        Me.Hotdog.TabIndex = 1
        Me.Hotdog.Text = "Hotdog"
        '
        'Hamburger
        '
        Me.Hamburger.AutoSize = True
        Me.Hamburger.Checked = True
        Me.Hamburger.Location = New System.Drawing.Point(10, 19)
        Me.Hamburger.Name = "Hamburger"
        Me.Hamburger.Size = New System.Drawing.Size(77, 17)
        Me.Hamburger.TabIndex = 0
        Me.Hamburger.Text = "Hamburger"
        '
        'qOrders
        '
        Me.qOrders.Formatter = New System.Messaging.XmlMessageFormatter(New String() {"String"})
        Me.qOrders.MessageReadPropertyFilter.LookupId = True
        Me.qOrders.Path = ".\private$\orders"
        Me.qOrders.SynchronizingObject = Me
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(347, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'MainForm
        '
        Me.ClientSize = New System.Drawing.Size(347, 138)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.OrderButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "MSM Queue Client Sample"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OrderButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Hamburger As System.Windows.Forms.RadioButton
    Friend WithEvents Hotdog As System.Windows.Forms.RadioButton
    Friend WithEvents Drink As System.Windows.Forms.RadioButton
    Friend WithEvents Fries As System.Windows.Forms.RadioButton
    Friend WithEvents qOrders As System.Messaging.MessageQueue
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
