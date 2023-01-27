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
        Me.Show1 = New System.Windows.Forms.TextBox()
        Me.Show2 = New System.Windows.Forms.TextBox()
        Me.Show3 = New System.Windows.Forms.TextBox()
        Me.Show4 = New System.Windows.Forms.TextBox()
        Me.Show5 = New System.Windows.Forms.TextBox()
        Me.Show6 = New System.Windows.Forms.TextBox()
        Me.Show7 = New System.Windows.Forms.TextBox()
        Me.Show8 = New System.Windows.Forms.TextBox()
        Me.ShowLCM = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Show1
        '
        Me.Show1.Location = New System.Drawing.Point(23, 22)
        Me.Show1.Name = "Show1"
        Me.Show1.Size = New System.Drawing.Size(100, 22)
        Me.Show1.TabIndex = 0
        '
        'Show2
        '
        Me.Show2.Location = New System.Drawing.Point(23, 51)
        Me.Show2.Name = "Show2"
        Me.Show2.Size = New System.Drawing.Size(100, 22)
        Me.Show2.TabIndex = 1
        '
        'Show3
        '
        Me.Show3.Location = New System.Drawing.Point(23, 80)
        Me.Show3.Name = "Show3"
        Me.Show3.Size = New System.Drawing.Size(100, 22)
        Me.Show3.TabIndex = 2
        '
        'Show4
        '
        Me.Show4.Location = New System.Drawing.Point(23, 109)
        Me.Show4.Name = "Show4"
        Me.Show4.Size = New System.Drawing.Size(100, 22)
        Me.Show4.TabIndex = 3
        '
        'Show5
        '
        Me.Show5.Location = New System.Drawing.Point(23, 138)
        Me.Show5.Name = "Show5"
        Me.Show5.Size = New System.Drawing.Size(100, 22)
        Me.Show5.TabIndex = 4
        '
        'Show6
        '
        Me.Show6.Location = New System.Drawing.Point(23, 167)
        Me.Show6.Name = "Show6"
        Me.Show6.Size = New System.Drawing.Size(100, 22)
        Me.Show6.TabIndex = 5
        '
        'Show7
        '
        Me.Show7.Location = New System.Drawing.Point(23, 196)
        Me.Show7.Name = "Show7"
        Me.Show7.Size = New System.Drawing.Size(100, 22)
        Me.Show7.TabIndex = 6
        '
        'Show8
        '
        Me.Show8.Location = New System.Drawing.Point(23, 225)
        Me.Show8.Name = "Show8"
        Me.Show8.Size = New System.Drawing.Size(100, 22)
        Me.Show8.TabIndex = 7
        '
        'ShowLCM
        '
        Me.ShowLCM.Location = New System.Drawing.Point(170, 80)
        Me.ShowLCM.Name = "ShowLCM"
        Me.ShowLCM.ReadOnly = True
        Me.ShowLCM.Size = New System.Drawing.Size(100, 22)
        Me.ShowLCM.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(185, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShowLCM)
        Me.Controls.Add(Me.Show8)
        Me.Controls.Add(Me.Show7)
        Me.Controls.Add(Me.Show6)
        Me.Controls.Add(Me.Show5)
        Me.Controls.Add(Me.Show4)
        Me.Controls.Add(Me.Show3)
        Me.Controls.Add(Me.Show2)
        Me.Controls.Add(Me.Show1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Show1 As System.Windows.Forms.TextBox
    Friend WithEvents Show2 As System.Windows.Forms.TextBox
    Friend WithEvents Show3 As System.Windows.Forms.TextBox
    Friend WithEvents Show4 As System.Windows.Forms.TextBox
    Friend WithEvents Show5 As System.Windows.Forms.TextBox
    Friend WithEvents Show6 As System.Windows.Forms.TextBox
    Friend WithEvents Show7 As System.Windows.Forms.TextBox
    Friend WithEvents Show8 As System.Windows.Forms.TextBox
    Friend WithEvents ShowLCM As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
