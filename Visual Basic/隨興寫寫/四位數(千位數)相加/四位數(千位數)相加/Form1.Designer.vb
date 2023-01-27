<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.Lb_plus = New System.Windows.Forms.Label()
        Me.lb2 = New System.Windows.Forms.Label()
        Me.Lb_equal = New System.Windows.Forms.Label()
        Me.ans = New System.Windows.Forms.TextBox()
        Me.countdown = New System.Windows.Forms.Timer(Me.components)
        Me.tip = New System.Windows.Forms.Label()
        Me.showtime = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Font = New System.Drawing.Font("新細明體", 14.0!)
        Me.lb1.Location = New System.Drawing.Point(23, 11)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(50, 19)
        Me.lb1.TabIndex = 1
        Me.lb1.Text = "num1"
        '
        'Lb_plus
        '
        Me.Lb_plus.AutoSize = True
        Me.Lb_plus.Font = New System.Drawing.Font("新細明體", 14.0!)
        Me.Lb_plus.Location = New System.Drawing.Point(35, 61)
        Me.Lb_plus.Name = "Lb_plus"
        Me.Lb_plus.Size = New System.Drawing.Size(38, 19)
        Me.Lb_plus.TabIndex = 1
        Me.Lb_plus.Text = "Lb1"
        '
        'lb2
        '
        Me.lb2.AutoSize = True
        Me.lb2.Font = New System.Drawing.Font("新細明體", 14.0!)
        Me.lb2.Location = New System.Drawing.Point(23, 108)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(50, 19)
        Me.lb2.TabIndex = 1
        Me.lb2.Text = "num2"
        '
        'Lb_equal
        '
        Me.Lb_equal.AutoSize = True
        Me.Lb_equal.Font = New System.Drawing.Font("新細明體", 14.0!)
        Me.Lb_equal.Location = New System.Drawing.Point(35, 165)
        Me.Lb_equal.Name = "Lb_equal"
        Me.Lb_equal.Size = New System.Drawing.Size(50, 19)
        Me.Lb_equal.TabIndex = 1
        Me.Lb_equal.Text = "num2"
        '
        'ans
        '
        Me.ans.Location = New System.Drawing.Point(120, 167)
        Me.ans.Name = "ans"
        Me.ans.Size = New System.Drawing.Size(94, 22)
        Me.ans.TabIndex = 2
        Me.ans.Text = " "
        '
        'countdown
        '
        Me.countdown.Interval = 10000
        '
        'tip
        '
        Me.tip.AutoSize = True
        Me.tip.Font = New System.Drawing.Font("新細明體", 14.0!)
        Me.tip.Location = New System.Drawing.Point(116, 82)
        Me.tip.Name = "tip"
        Me.tip.Size = New System.Drawing.Size(59, 19)
        Me.tip.TabIndex = 3
        Me.tip.Text = "Label1"
        '
        'showtime
        '
        Me.showtime.Interval = 2000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 210)
        Me.Controls.Add(Me.tip)
        Me.Controls.Add(Me.ans)
        Me.Controls.Add(Me.Lb_equal)
        Me.Controls.Add(Me.lb2)
        Me.Controls.Add(Me.Lb_plus)
        Me.Controls.Add(Me.lb1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lb1 As Label
    Friend WithEvents Lb_plus As Label
    Friend WithEvents lb2 As Label
    Friend WithEvents Lb_equal As Label
    Friend WithEvents ans As TextBox
    Friend WithEvents countdown As Timer
    Friend WithEvents tip As Label
    Friend WithEvents showtime As Timer
End Class
