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
        Me.title = New System.Windows.Forms.Label()
        Me.ans = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tips = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Location = New System.Drawing.Point(59, 72)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(37, 12)
        Me.title.TabIndex = 0
        Me.title.Text = "Label1"
        '
        'ans
        '
        Me.ans.Location = New System.Drawing.Point(89, 106)
        Me.ans.Name = "ans"
        Me.ans.Size = New System.Drawing.Size(100, 22)
        Me.ans.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(36, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "確定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(175, 208)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "清除"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tips
        '
        Me.tips.AutoSize = True
        Me.tips.Location = New System.Drawing.Point(49, 160)
        Me.tips.Name = "tips"
        Me.tips.Size = New System.Drawing.Size(37, 12)
        Me.tips.TabIndex = 4
        Me.tips.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.tips)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ans)
        Me.Controls.Add(Me.title)
        Me.Name = "Form1"
        Me.Text = "水母寫程式"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents title As System.Windows.Forms.Label
    Friend WithEvents ans As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tips As System.Windows.Forms.Label

End Class
