<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 密碼轉換
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.question = New System.Windows.Forms.TextBox()
        Me.answer = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(23, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(79, 22)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "輸入字串"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(23, 60)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(79, 22)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = "輸出字串"
        '
        'question
        '
        Me.question.Location = New System.Drawing.Point(158, 22)
        Me.question.Name = "question"
        Me.question.Size = New System.Drawing.Size(402, 22)
        Me.question.TabIndex = 2
        '
        'answer
        '
        Me.answer.Enabled = False
        Me.answer.Location = New System.Drawing.Point(158, 60)
        Me.answer.Name = "answer"
        Me.answer.Size = New System.Drawing.Size(402, 22)
        Me.answer.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(585, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "轉換"
        Me.Button1.UseVisualStyleBackColor = True
        '
        '密碼轉換
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 121)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.answer)
        Me.Controls.Add(Me.question)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "密碼轉換"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents question As System.Windows.Forms.TextBox
    Friend WithEvents answer As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
