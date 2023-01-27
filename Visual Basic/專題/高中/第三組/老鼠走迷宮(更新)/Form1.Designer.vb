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
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.hard = New System.Windows.Forms.Button()
        Me.easy = New System.Windows.Forms.Button()
        Me.middle = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(240, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "請選擇難度"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 30.0!)
        Me.Label1.Location = New System.Drawing.Point(204, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 40)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "老鼠走迷宮"
        '
        'hard
        '
        Me.hard.Location = New System.Drawing.Point(442, 325)
        Me.hard.Name = "hard"
        Me.hard.Size = New System.Drawing.Size(136, 49)
        Me.hard.TabIndex = 9
        Me.hard.Text = "Button1"
        Me.hard.UseVisualStyleBackColor = True
        '
        'easy
        '
        Me.easy.Location = New System.Drawing.Point(36, 325)
        Me.easy.Name = "easy"
        Me.easy.Size = New System.Drawing.Size(136, 49)
        Me.easy.TabIndex = 7
        Me.easy.Text = "Button1"
        Me.easy.UseVisualStyleBackColor = True
        '
        'middle
        '
        Me.middle.Location = New System.Drawing.Point(232, 325)
        Me.middle.Name = "middle"
        Me.middle.Size = New System.Drawing.Size(136, 49)
        Me.middle.TabIndex = 8
        Me.middle.Text = "Button1"
        Me.middle.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 417)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hard)
        Me.Controls.Add(Me.easy)
        Me.Controls.Add(Me.middle)
        Me.Name = "Form1"
        Me.Text = "老鼠走迷宮"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents hard As System.Windows.Forms.Button
    Friend WithEvents easy As System.Windows.Forms.Button
    Friend WithEvents middle As System.Windows.Forms.Button

End Class
