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
        Me.original_tem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.burn_second = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ansbox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'original_tem
        '
        Me.original_tem.Location = New System.Drawing.Point(143, 68)
        Me.original_tem.Name = "original_tem"
        Me.original_tem.Size = New System.Drawing.Size(100, 24)
        Me.original_tem.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "礦石初始溫度"
        '
        'burn_second
        '
        Me.burn_second.Location = New System.Drawing.Point(143, 105)
        Me.burn_second.Name = "burn_second"
        Me.burn_second.Size = New System.Drawing.Size(100, 24)
        Me.burn_second.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "加熱秒數"
        '
        'ansbox
        '
        Me.ansbox.Location = New System.Drawing.Point(143, 160)
        Me.ansbox.Name = "ansbox"
        Me.ansbox.ReadOnly = True
        Me.ansbox.Size = New System.Drawing.Size(100, 24)
        Me.ansbox.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(59, 230)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "計算礦石最終溫度"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 274)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ansbox)
        Me.Controls.Add(Me.burn_second)
        Me.Controls.Add(Me.original_tem)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents original_tem As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents burn_second As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ansbox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
