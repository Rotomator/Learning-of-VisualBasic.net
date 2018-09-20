<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtX1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtX2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(68, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "a:"
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(124, 101)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(87, 21)
        Me.txtA.TabIndex = 2
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(124, 128)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(87, 21)
        Me.txtB.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "b:"
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(124, 155)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(87, 21)
        Me.txtC.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "c:"
        '
        'txtX1
        '
        Me.txtX1.Location = New System.Drawing.Point(39, 196)
        Me.txtX1.Name = "txtX1"
        Me.txtX1.Size = New System.Drawing.Size(87, 21)
        Me.txtX1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "x1:"
        '
        'txtX2
        '
        Me.txtX2.Location = New System.Drawing.Point(185, 196)
        Me.txtX2.Name = "txtX2"
        Me.txtX2.Size = New System.Drawing.Size(87, 21)
        Me.txtX2.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(155, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "x2:"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(89, 227)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(85, 22)
        Me.btnStart.TabIndex = 11
        Me.btnStart.Text = "计算"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtX2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtX1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "一元二次方程"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtX1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtX2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnStart As Button
End Class
