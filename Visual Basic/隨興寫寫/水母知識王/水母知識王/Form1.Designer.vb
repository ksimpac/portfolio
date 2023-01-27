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
        Me.ans1 = New System.Windows.Forms.RadioButton()
        Me.ans2 = New System.Windows.Forms.RadioButton()
        Me.ans3 = New System.Windows.Forms.RadioButton()
        Me.ans4 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.title = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ans1
        '
        Me.ans1.AutoSize = True
        Me.ans1.Location = New System.Drawing.Point(37, 115)
        Me.ans1.Name = "ans1"
        Me.ans1.Size = New System.Drawing.Size(47, 16)
        Me.ans1.TabIndex = 0
        Me.ans1.TabStop = True
        Me.ans1.Text = "火車"
        Me.ans1.UseVisualStyleBackColor = True
        '
        'ans2
        '
        Me.ans2.AutoSize = True
        Me.ans2.Location = New System.Drawing.Point(136, 115)
        Me.ans2.Name = "ans2"
        Me.ans2.Size = New System.Drawing.Size(95, 16)
        Me.ans2.TabIndex = 1
        Me.ans2.TabStop = True
        Me.ans2.Text = "狗的肢體語言"
        Me.ans2.UseVisualStyleBackColor = True
        '
        'ans3
        '
        Me.ans3.AutoSize = True
        Me.ans3.Location = New System.Drawing.Point(37, 185)
        Me.ans3.Name = "ans3"
        Me.ans3.Size = New System.Drawing.Size(47, 16)
        Me.ans3.TabIndex = 2
        Me.ans3.TabStop = True
        Me.ans3.Text = "軍事"
        Me.ans3.UseVisualStyleBackColor = True
        '
        'ans4
        '
        Me.ans4.AutoSize = True
        Me.ans4.Location = New System.Drawing.Point(136, 185)
        Me.ans4.Name = "ans4"
        Me.ans4.Size = New System.Drawing.Size(119, 16)
        Me.ans4.TabIndex = 3
        Me.ans4.TabStop = True
        Me.ans4.Text = "大自然的各種生物"
        Me.ans4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(106, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "回答"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Location = New System.Drawing.Point(57, 49)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(37, 12)
        Me.title.TabIndex = 5
        Me.title.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ans4)
        Me.Controls.Add(Me.ans3)
        Me.Controls.Add(Me.ans2)
        Me.Controls.Add(Me.ans1)
        Me.Name = "Form1"
        Me.Text = "水母知識王"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ans1 As System.Windows.Forms.RadioButton
    Friend WithEvents ans2 As System.Windows.Forms.RadioButton
    Friend WithEvents ans3 As System.Windows.Forms.RadioButton
    Friend WithEvents ans4 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents title As System.Windows.Forms.Label

End Class
