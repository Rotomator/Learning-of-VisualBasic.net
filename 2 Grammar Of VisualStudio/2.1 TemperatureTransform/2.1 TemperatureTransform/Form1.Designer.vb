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
        Me.txtTemperature = New System.Windows.Forms.TextBox()
        Me.labF = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTemperature
        '
        Me.txtTemperature.Location = New System.Drawing.Point(82, 112)
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.Size = New System.Drawing.Size(102, 21)
        Me.txtTemperature.TabIndex = 0
        '
        'labF
        '
        Me.labF.AutoSize = True
        Me.labF.Font = New System.Drawing.Font("楷体", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.labF.Location = New System.Drawing.Point(61, 55)
        Me.labF.Name = "labF"
        Me.labF.Size = New System.Drawing.Size(154, 24)
        Me.labF.TabIndex = 1
        Me.labF.Text = "华氏温度为："
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(82, 174)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(102, 28)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "计算"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.labF)
        Me.Controls.Add(Me.txtTemperature)
        Me.Name = "Form1"
        Me.Text = "计算温度"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTemperature As TextBox
    Friend WithEvents labF As Label
    Friend WithEvents btnStart As Button
End Class
