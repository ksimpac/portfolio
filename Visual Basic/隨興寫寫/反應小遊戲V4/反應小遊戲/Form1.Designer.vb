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
        Me.components = New System.ComponentModel.Container()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_click = New System.Windows.Forms.Button()
        Me.switch_time = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(100, 236)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(75, 23)
        Me.btn_start.TabIndex = 0
        Me.btn_start.Text = "開始"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 20.29091!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "反應小遊戲"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(471, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "遊戲規則：等到本視窗的背景顏色從紅色變成綠色時，請按右下角的Click。"
        '
        'btn_click
        '
        Me.btn_click.Location = New System.Drawing.Point(386, 236)
        Me.btn_click.Name = "btn_click"
        Me.btn_click.Size = New System.Drawing.Size(75, 23)
        Me.btn_click.TabIndex = 4
        Me.btn_click.Text = "Click"
        Me.btn_click.UseVisualStyleBackColor = True
        '
        'switch_time
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(575, 304)
        Me.Controls.Add(Me.btn_click)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_start)
        Me.Name = "Form1"
        Me.Text = "小遊戲"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_start As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_click As System.Windows.Forms.Button
    Friend WithEvents switch_time As System.Windows.Forms.Timer

End Class
