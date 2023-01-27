<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Chinese = New System.Windows.Forms.Label()
        Me.English = New System.Windows.Forms.Label()
        Me.Math = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.Average = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Average)
        Me.GroupBox1.Controls.Add(Me.Total)
        Me.GroupBox1.Controls.Add(Me.Math)
        Me.GroupBox1.Controls.Add(Me.English)
        Me.GroupBox1.Controls.Add(Me.Chinese)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 174)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "結果"
        '
        'Chinese
        '
        Me.Chinese.AutoSize = True
        Me.Chinese.Location = New System.Drawing.Point(28, 30)
        Me.Chinese.Name = "Chinese"
        Me.Chinese.Size = New System.Drawing.Size(41, 12)
        Me.Chinese.TabIndex = 0
        Me.Chinese.Text = "國文："
        '
        'English
        '
        Me.English.AutoSize = True
        Me.English.Location = New System.Drawing.Point(28, 55)
        Me.English.Name = "English"
        Me.English.Size = New System.Drawing.Size(41, 12)
        Me.English.TabIndex = 1
        Me.English.Text = "英文："
        '
        'Math
        '
        Me.Math.AutoSize = True
        Me.Math.Location = New System.Drawing.Point(28, 81)
        Me.Math.Name = "Math"
        Me.Math.Size = New System.Drawing.Size(41, 12)
        Me.Math.TabIndex = 2
        Me.Math.Text = "數學："
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Location = New System.Drawing.Point(28, 107)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(41, 12)
        Me.Total.TabIndex = 3
        Me.Total.Text = "總分："
        '
        'Average
        '
        Me.Average.AutoSize = True
        Me.Average.Location = New System.Drawing.Point(28, 134)
        Me.Average.Name = "Average"
        Me.Average.Size = New System.Drawing.Size(41, 12)
        Me.Average.TabIndex = 4
        Me.Average.Text = "平均："
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 12)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "座號（1 ~ 5）"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(245, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "查詢"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(117, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 284)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "成績查詢"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Average As System.Windows.Forms.Label
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents Math As System.Windows.Forms.Label
    Friend WithEvents English As System.Windows.Forms.Label
    Friend WithEvents Chinese As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
