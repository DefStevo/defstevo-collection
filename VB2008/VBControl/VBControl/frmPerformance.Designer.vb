<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerformance
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
        Me.cbCPU = New System.Windows.Forms.CheckBox
        Me.cbRAM = New System.Windows.Forms.CheckBox
        Me.grpCPU = New System.Windows.Forms.GroupBox
        Me.gCPU = New System.Windows.Forms.Panel
        Me.lblCPU = New System.Windows.Forms.Label
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.CPU9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.CPU10 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.CPU7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.CPU8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.CPU4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.CPU3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.CPU6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.CPU5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.CPU1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.CPU2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.grpRAM = New System.Windows.Forms.GroupBox
        Me.gRAM = New System.Windows.Forms.Panel
        Me.lblRAM = New System.Windows.Forms.Label
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.RAM9 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RAM10 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RAM7 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RAM8 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RAM4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RAM3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RAM6 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RAM5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RAM1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RAM2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.ShapeContainer5 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.grpCPU.SuspendLayout()
        Me.grpRAM.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbCPU
        '
        Me.cbCPU.AutoSize = True
        Me.cbCPU.Location = New System.Drawing.Point(0, 8)
        Me.cbCPU.Name = "cbCPU"
        Me.cbCPU.Size = New System.Drawing.Size(48, 17)
        Me.cbCPU.TabIndex = 0
        Me.cbCPU.Text = "CPU"
        Me.cbCPU.UseVisualStyleBackColor = True
        '
        'cbRAM
        '
        Me.cbRAM.AutoSize = True
        Me.cbRAM.Location = New System.Drawing.Point(127, 8)
        Me.cbRAM.Name = "cbRAM"
        Me.cbRAM.Size = New System.Drawing.Size(50, 17)
        Me.cbRAM.TabIndex = 1
        Me.cbRAM.Text = "RAM"
        Me.cbRAM.UseVisualStyleBackColor = True
        '
        'grpCPU
        '
        Me.grpCPU.Controls.Add(Me.gCPU)
        Me.grpCPU.Controls.Add(Me.lblCPU)
        Me.grpCPU.Controls.Add(Me.ShapeContainer1)
        Me.grpCPU.Location = New System.Drawing.Point(0, 30)
        Me.grpCPU.Name = "grpCPU"
        Me.grpCPU.Size = New System.Drawing.Size(341, 82)
        Me.grpCPU.TabIndex = 4
        Me.grpCPU.TabStop = False
        Me.grpCPU.Text = "CPU"
        '
        'gCPU
        '
        Me.gCPU.BackColor = System.Drawing.Color.Black
        Me.gCPU.Location = New System.Drawing.Point(81, 16)
        Me.gCPU.Name = "gCPU"
        Me.gCPU.Size = New System.Drawing.Size(250, 60)
        Me.gCPU.TabIndex = 5
        '
        'lblCPU
        '
        Me.lblCPU.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCPU.Location = New System.Drawing.Point(40, 16)
        Me.lblCPU.Name = "lblCPU"
        Me.lblCPU.Size = New System.Drawing.Size(34, 60)
        Me.lblCPU.TabIndex = 4
        Me.lblCPU.Text = "100%"
        Me.lblCPU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.CPU9, Me.CPU10, Me.CPU7, Me.CPU8, Me.CPU4, Me.CPU3, Me.CPU6, Me.CPU5, Me.CPU1, Me.CPU2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(335, 63)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'CPU9
        '
        Me.CPU9.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CPU9.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.CPU9.FillColor = System.Drawing.Color.Red
        Me.CPU9.FillGradientColor = System.Drawing.Color.Red
        Me.CPU9.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.CPU9.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.CPU9.Location = New System.Drawing.Point(5, 6)
        Me.CPU9.Name = "CPU9"
        Me.CPU9.Size = New System.Drawing.Size(30, 5)
        '
        'CPU10
        '
        Me.CPU10.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CPU10.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.CPU10.FillColor = System.Drawing.Color.Red
        Me.CPU10.FillGradientColor = System.Drawing.Color.Red
        Me.CPU10.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.CPU10.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.CPU10.Location = New System.Drawing.Point(5, 0)
        Me.CPU10.Name = "CPU10"
        Me.CPU10.Size = New System.Drawing.Size(30, 5)
        '
        'CPU7
        '
        Me.CPU7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CPU7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.CPU7.FillColor = System.Drawing.Color.Yellow
        Me.CPU7.FillGradientColor = System.Drawing.Color.Yellow
        Me.CPU7.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.CPU7.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.CPU7.Location = New System.Drawing.Point(5, 18)
        Me.CPU7.Name = "CPU7"
        Me.CPU7.Size = New System.Drawing.Size(30, 5)
        '
        'CPU8
        '
        Me.CPU8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CPU8.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.CPU8.FillColor = System.Drawing.Color.Red
        Me.CPU8.FillGradientColor = System.Drawing.Color.Yellow
        Me.CPU8.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.CPU8.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.CPU8.Location = New System.Drawing.Point(5, 12)
        Me.CPU8.Name = "qdCPU8"
        Me.CPU8.Size = New System.Drawing.Size(30, 5)
        '
        'CPU4
        '
        Me.CPU4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CPU4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.CPU4.FillColor = System.Drawing.Color.Lime
        Me.CPU4.FillGradientColor = System.Drawing.Color.Lime
        Me.CPU4.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.CPU4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.CPU4.Location = New System.Drawing.Point(5, 36)
        Me.CPU4.Name = "CPU4"
        Me.CPU4.Size = New System.Drawing.Size(30, 5)
        '
        'CPU3
        '
        Me.CPU3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CPU3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.CPU3.FillColor = System.Drawing.Color.Lime
        Me.CPU3.FillGradientColor = System.Drawing.Color.Lime
        Me.CPU3.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.CPU3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.CPU3.Location = New System.Drawing.Point(5, 42)
        Me.CPU3.Name = "qdCPU3"
        Me.CPU3.Size = New System.Drawing.Size(30, 5)
        '
        'CPU6
        '
        Me.CPU6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CPU6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.CPU6.FillColor = System.Drawing.Color.Yellow
        Me.CPU6.FillGradientColor = System.Drawing.Color.Yellow
        Me.CPU6.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.CPU6.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.CPU6.Location = New System.Drawing.Point(5, 24)
        Me.CPU6.Name = "CPU6"
        Me.CPU6.Size = New System.Drawing.Size(30, 5)
        '
        'CPU5
        '
        Me.CPU5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CPU5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.CPU5.FillColor = System.Drawing.Color.Yellow
        Me.CPU5.FillGradientColor = System.Drawing.Color.Lime
        Me.CPU5.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.CPU5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.CPU5.Location = New System.Drawing.Point(5, 30)
        Me.CPU5.Name = "CPU5"
        Me.CPU5.Size = New System.Drawing.Size(30, 5)
        '
        'CPU1
        '
        Me.CPU1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CPU1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.CPU1.FillColor = System.Drawing.Color.Lime
        Me.CPU1.FillGradientColor = System.Drawing.Color.Lime
        Me.CPU1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.CPU1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.CPU1.Location = New System.Drawing.Point(5, 54)
        Me.CPU1.Name = "CPU1"
        Me.CPU1.Size = New System.Drawing.Size(30, 5)
        '
        'CPU2
        '
        Me.CPU2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.CPU2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.CPU2.FillColor = System.Drawing.Color.Lime
        Me.CPU2.FillGradientColor = System.Drawing.Color.Lime
        Me.CPU2.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.CPU2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.CPU2.Location = New System.Drawing.Point(5, 48)
        Me.CPU2.Name = "CPU2"
        Me.CPU2.Size = New System.Drawing.Size(30, 5)
        '
        'grpRAM
        '
        Me.grpRAM.Controls.Add(Me.gRAM)
        Me.grpRAM.Controls.Add(Me.lblRAM)
        Me.grpRAM.Controls.Add(Me.ShapeContainer2)
        Me.grpRAM.Location = New System.Drawing.Point(0, 113)
        Me.grpRAM.Name = "grpRAM"
        Me.grpRAM.Size = New System.Drawing.Size(340, 82)
        Me.grpRAM.TabIndex = 5
        Me.grpRAM.TabStop = False
        Me.grpRAM.Text = "RAM"
        '
        'gRAM
        '
        Me.gRAM.BackColor = System.Drawing.Color.Black
        Me.gRAM.Location = New System.Drawing.Point(80, 16)
        Me.gRAM.Name = "gRAM"
        Me.gRAM.Size = New System.Drawing.Size(250, 60)
        Me.gRAM.TabIndex = 6
        '
        'lblRAM
        '
        Me.lblRAM.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRAM.Location = New System.Drawing.Point(39, 16)
        Me.lblRAM.Name = "lblRAM"
        Me.lblRAM.Size = New System.Drawing.Size(34, 60)
        Me.lblRAM.TabIndex = 5
        Me.lblRAM.Text = "1024 MB"
        Me.lblRAM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RAM9, Me.RAM10, Me.RAM7, Me.RAM8, Me.RAM4, Me.RAM3, Me.RAM6, Me.RAM5, Me.RAM1, Me.RAM2})
        Me.ShapeContainer2.Size = New System.Drawing.Size(334, 63)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'RAM9
        '
        Me.RAM9.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.RAM9.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RAM9.FillColor = System.Drawing.Color.Red
        Me.RAM9.FillGradientColor = System.Drawing.Color.Red
        Me.RAM9.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.RAM9.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RAM9.Location = New System.Drawing.Point(5, 6)
        Me.RAM9.Name = "RAM9"
        Me.RAM9.Size = New System.Drawing.Size(30, 5)
        '
        'RAM10
        '
        Me.RAM10.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.RAM10.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RAM10.FillColor = System.Drawing.Color.Red
        Me.RAM10.FillGradientColor = System.Drawing.Color.Red
        Me.RAM10.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.RAM10.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RAM10.Location = New System.Drawing.Point(5, 0)
        Me.RAM10.Name = "RAM10"
        Me.RAM10.Size = New System.Drawing.Size(30, 5)
        '
        'RAM7
        '
        Me.RAM7.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.RAM7.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RAM7.FillColor = System.Drawing.Color.Yellow
        Me.RAM7.FillGradientColor = System.Drawing.Color.Yellow
        Me.RAM7.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.RAM7.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RAM7.Location = New System.Drawing.Point(5, 18)
        Me.RAM7.Name = "RAM7"
        Me.RAM7.Size = New System.Drawing.Size(30, 5)
        '
        'RAM8
        '
        Me.RAM8.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.RAM8.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RAM8.FillColor = System.Drawing.Color.Red
        Me.RAM8.FillGradientColor = System.Drawing.Color.Yellow
        Me.RAM8.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.RAM8.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RAM8.Location = New System.Drawing.Point(5, 12)
        Me.RAM8.Name = "RAM8"
        Me.RAM8.Size = New System.Drawing.Size(30, 5)
        '
        'RAM4
        '
        Me.RAM4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.RAM4.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RAM4.FillColor = System.Drawing.Color.Lime
        Me.RAM4.FillGradientColor = System.Drawing.Color.Lime
        Me.RAM4.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.RAM4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RAM4.Location = New System.Drawing.Point(5, 36)
        Me.RAM4.Name = "RAM4"
        Me.RAM4.Size = New System.Drawing.Size(30, 5)
        '
        'RAM3
        '
        Me.RAM3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.RAM3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RAM3.FillColor = System.Drawing.Color.Lime
        Me.RAM3.FillGradientColor = System.Drawing.Color.Lime
        Me.RAM3.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.RAM3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RAM3.Location = New System.Drawing.Point(5, 42)
        Me.RAM3.Name = "RAM3"
        Me.RAM3.Size = New System.Drawing.Size(30, 5)
        '
        'RAM6
        '
        Me.RAM6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.RAM6.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RAM6.FillColor = System.Drawing.Color.Yellow
        Me.RAM6.FillGradientColor = System.Drawing.Color.Yellow
        Me.RAM6.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.RAM6.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RAM6.Location = New System.Drawing.Point(5, 24)
        Me.RAM6.Name = "RAM6"
        Me.RAM6.Size = New System.Drawing.Size(30, 5)
        '
        'RAM5
        '
        Me.RAM5.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.RAM5.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RAM5.FillColor = System.Drawing.Color.Yellow
        Me.RAM5.FillGradientColor = System.Drawing.Color.Lime
        Me.RAM5.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.RAM5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RAM5.Location = New System.Drawing.Point(5, 30)
        Me.RAM5.Name = "RAM5"
        Me.RAM5.Size = New System.Drawing.Size(30, 5)
        '
        'RAM1
        '
        Me.RAM1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.RAM1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RAM1.FillColor = System.Drawing.Color.Lime
        Me.RAM1.FillGradientColor = System.Drawing.Color.Lime
        Me.RAM1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.RAM1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RAM1.Location = New System.Drawing.Point(5, 54)
        Me.RAM1.Name = "RAM1"
        Me.RAM1.Size = New System.Drawing.Size(30, 5)
        '
        'RAM2
        '
        Me.RAM2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.RAM2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RAM2.FillColor = System.Drawing.Color.Lime
        Me.RAM2.FillGradientColor = System.Drawing.Color.Lime
        Me.RAM2.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Vertical
        Me.RAM2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.RAM2.Location = New System.Drawing.Point(5, 48)
        Me.RAM2.Name = "RAM2"
        Me.RAM2.Size = New System.Drawing.Size(30, 5)
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ShapeContainer5)
        Me.Panel1.Location = New System.Drawing.Point(46, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(68, 33)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(15, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 10)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Total"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ShapeContainer5
        '
        Me.ShapeContainer5.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer5.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer5.Name = "ShapeContainer5"
        Me.ShapeContainer5.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape3, Me.LineShape1})
        Me.ShapeContainer5.Size = New System.Drawing.Size(68, 33)
        Me.ShapeContainer5.TabIndex = 14
        Me.ShapeContainer5.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.Yellow
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 0
        Me.LineShape3.X2 = 15
        Me.LineShape3.Y1 = 15
        Me.LineShape3.Y2 = 15
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.Lime
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 15
        Me.LineShape1.Y1 = 5
        Me.LineShape1.Y2 = 5
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.Red
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 1
        Me.LineShape2.X2 = 15
        Me.LineShape2.Y1 = 25
        Me.LineShape2.Y2 = 25
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(15, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 10)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "User"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(15, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 10)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Kernel"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmPerformance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 196)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.grpRAM)
        Me.Controls.Add(Me.grpCPU)
        Me.Controls.Add(Me.cbRAM)
        Me.Controls.Add(Me.cbCPU)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPerformance"
        Me.Text = "Performance Monitor"
        Me.grpCPU.ResumeLayout(False)
        Me.grpRAM.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbCPU As System.Windows.Forms.CheckBox
    Friend WithEvents cbRAM As System.Windows.Forms.CheckBox
    Friend WithEvents grpCPU As System.Windows.Forms.GroupBox
    Friend WithEvents lblCPU As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents CPU9 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents CPU10 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents CPU7 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents CPU8 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents CPU4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents CPU3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents CPU6 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents CPU5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents CPU1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents CPU2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents grpRAM As System.Windows.Forms.GroupBox
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RAM9 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RAM10 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RAM7 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RAM8 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RAM4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RAM3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RAM6 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RAM5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RAM1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RAM2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblRAM As System.Windows.Forms.Label
    Friend WithEvents gCPU As System.Windows.Forms.Panel
    Friend WithEvents gRAM As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer4 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RAMLine1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RAMLine2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RAMLine3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RAMLine4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RAMLine5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RAMLine6 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RAMLine7 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RAMLine8 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RAMLine9 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RAMLine10 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer5 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
