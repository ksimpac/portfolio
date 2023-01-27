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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.num1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.num2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.num3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.num4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.num5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("PMingLiU", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(569, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "按GO鈕會顯示5個數字，並在5秒後消失"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.num1)
        Me.Panel1.Location = New System.Drawing.Point(23, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(83, 83)
        Me.Panel1.TabIndex = 1
        '
        'num1
        '
        Me.num1.AutoSize = True
        Me.num1.Font = New System.Drawing.Font("PMingLiU", 12.0!)
        Me.num1.Location = New System.Drawing.Point(19, 36)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(51, 16)
        Me.num1.TabIndex = 0
        Me.num1.Text = "Label2"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.num2)
        Me.Panel2.Location = New System.Drawing.Point(156, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(90, 83)
        Me.Panel2.TabIndex = 2
        '
        'num2
        '
        Me.num2.AutoSize = True
        Me.num2.Font = New System.Drawing.Font("PMingLiU", 12.0!)
        Me.num2.Location = New System.Drawing.Point(26, 36)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(51, 16)
        Me.num2.TabIndex = 0
        Me.num2.Text = "Label3"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Controls.Add(Me.num3)
        Me.Panel3.Location = New System.Drawing.Point(303, 92)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(90, 83)
        Me.Panel3.TabIndex = 3
        '
        'num3
        '
        Me.num3.AutoSize = True
        Me.num3.Font = New System.Drawing.Font("PMingLiU", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.num3.Location = New System.Drawing.Point(27, 36)
        Me.num3.Name = "num3"
        Me.num3.Size = New System.Drawing.Size(51, 16)
        Me.num3.TabIndex = 0
        Me.num3.Text = "Label4"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Controls.Add(Me.num4)
        Me.Panel4.Location = New System.Drawing.Point(443, 92)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(90, 83)
        Me.Panel4.TabIndex = 4
        '
        'num4
        '
        Me.num4.AutoSize = True
        Me.num4.Font = New System.Drawing.Font("PMingLiU", 12.0!)
        Me.num4.Location = New System.Drawing.Point(27, 36)
        Me.num4.Name = "num4"
        Me.num4.Size = New System.Drawing.Size(51, 16)
        Me.num4.TabIndex = 0
        Me.num4.Text = "Label5"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel5.Controls.Add(Me.num5)
        Me.Panel5.Location = New System.Drawing.Point(577, 92)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(93, 83)
        Me.Panel5.TabIndex = 5
        '
        'num5
        '
        Me.num5.AutoSize = True
        Me.num5.Font = New System.Drawing.Font("PMingLiU", 12.0!)
        Me.num5.Location = New System.Drawing.Point(39, 36)
        Me.num5.Name = "num5"
        Me.num5.Size = New System.Drawing.Size(51, 16)
        Me.num5.TabIndex = 0
        Me.num5.Text = "Label6"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(577, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "GO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 262)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "記憶力大考驗"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents num1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents num2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents num3 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents num4 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents num5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
