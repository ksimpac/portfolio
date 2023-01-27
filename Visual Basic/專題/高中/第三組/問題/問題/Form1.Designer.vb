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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.option1 = New System.Windows.Forms.RadioButton()
        Me.option2 = New System.Windows.Forms.RadioButton()
        Me.option3 = New System.Windows.Forms.RadioButton()
        Me.option4 = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.reply = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'option1
        '
        Me.option1.AutoSize = True
        Me.option1.Location = New System.Drawing.Point(186, 154)
        Me.option1.Name = "option1"
        Me.option1.Size = New System.Drawing.Size(89, 16)
        Me.option1.TabIndex = 1
        Me.option1.TabStop = True
        Me.option1.Text = "RadioButton1"
        Me.option1.UseVisualStyleBackColor = True
        '
        'option2
        '
        Me.option2.AutoSize = True
        Me.option2.Location = New System.Drawing.Point(186, 176)
        Me.option2.Name = "option2"
        Me.option2.Size = New System.Drawing.Size(89, 16)
        Me.option2.TabIndex = 1
        Me.option2.TabStop = True
        Me.option2.Text = "RadioButton1"
        Me.option2.UseVisualStyleBackColor = True
        '
        'option3
        '
        Me.option3.AutoSize = True
        Me.option3.Location = New System.Drawing.Point(186, 199)
        Me.option3.Name = "option3"
        Me.option3.Size = New System.Drawing.Size(89, 16)
        Me.option3.TabIndex = 1
        Me.option3.Text = "RadioButton1"
        Me.option3.UseVisualStyleBackColor = True
        '
        'option4
        '
        Me.option4.AutoSize = True
        Me.option4.Location = New System.Drawing.Point(186, 221)
        Me.option4.Name = "option4"
        Me.option4.Size = New System.Drawing.Size(89, 16)
        Me.option4.TabIndex = 1
        Me.option4.Text = "RadioButton1"
        Me.option4.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 297)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "剩餘時間："
        '
        'reply
        '
        Me.reply.Location = New System.Drawing.Point(200, 337)
        Me.reply.Name = "reply"
        Me.reply.Size = New System.Drawing.Size(75, 23)
        Me.reply.TabIndex = 10
        Me.reply.Text = "送出答案"
        Me.reply.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 372)
        Me.Controls.Add(Me.reply)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.option4)
        Me.Controls.Add(Me.option3)
        Me.Controls.Add(Me.option2)
        Me.Controls.Add(Me.option1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents option1 As System.Windows.Forms.RadioButton
    Friend WithEvents option2 As System.Windows.Forms.RadioButton
    Friend WithEvents option3 As System.Windows.Forms.RadioButton
    Friend WithEvents option4 As System.Windows.Forms.RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents reply As System.Windows.Forms.Button

End Class
