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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.num_box = New System.Windows.Forms.TextBox()
        Me.ansbox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(60, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "請輸入數字"
        '
        'num_box
        '
        Me.num_box.Location = New System.Drawing.Point(168, 82)
        Me.num_box.Name = "num_box"
        Me.num_box.Size = New System.Drawing.Size(100, 24)
        Me.num_box.TabIndex = 1
        '
        'ansbox
        '
        Me.ansbox.Location = New System.Drawing.Point(168, 127)
        Me.ansbox.Name = "ansbox"
        Me.ansbox.ReadOnly = True
        Me.ansbox.Size = New System.Drawing.Size(100, 24)
        Me.ansbox.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(110, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "是否為質數"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 270)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ansbox)
        Me.Controls.Add(Me.num_box)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents num_box As System.Windows.Forms.TextBox
    Friend WithEvents ansbox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
