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
        Me.TxtHeight = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtWeight = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabShowBMI = New System.Windows.Forms.Label()
        Me.btnCount = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtHeight
        '
        Me.TxtHeight.Location = New System.Drawing.Point(93, 12)
        Me.TxtHeight.MaxLength = 3
        Me.TxtHeight.Name = "TxtHeight"
        Me.TxtHeight.Size = New System.Drawing.Size(100, 22)
        Me.TxtHeight.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "身高"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "體重"
        '
        'TxtWeight
        '
        Me.TxtWeight.Location = New System.Drawing.Point(93, 63)
        Me.TxtWeight.MaxLength = 2
        Me.TxtWeight.Name = "TxtWeight"
        Me.TxtWeight.Size = New System.Drawing.Size(100, 22)
        Me.TxtWeight.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "BMI:"
        '
        'LabShowBMI
        '
        Me.LabShowBMI.AutoSize = True
        Me.LabShowBMI.Location = New System.Drawing.Point(93, 125)
        Me.LabShowBMI.Name = "LabShowBMI"
        Me.LabShowBMI.Size = New System.Drawing.Size(0, 12)
        Me.LabShowBMI.TabIndex = 5
        '
        'btnCount
        '
        Me.btnCount.Location = New System.Drawing.Point(38, 173)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(75, 23)
        Me.btnCount.TabIndex = 6
        Me.btnCount.Text = "計算"
        Me.btnCount.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(166, 173)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "清除"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCount)
        Me.Controls.Add(Me.LabShowBMI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtWeight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtHeight)
        Me.Name = "Form1"
        Me.Text = "BMI計算"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtHeight As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtWeight As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabShowBMI As System.Windows.Forms.Label
    Friend WithEvents btnCount As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
