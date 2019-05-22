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
        Me.out_text = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.clr_btn = New System.Windows.Forms.Button()
        Me.sign_text = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'out_text
        '
        Me.out_text.AutoSize = True
        Me.out_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.out_text.Location = New System.Drawing.Point(175, 9)
        Me.out_text.Name = "out_text"
        Me.out_text.Size = New System.Drawing.Size(146, 55)
        Me.out_text.TabIndex = 0
        Me.out_text.Text = "TEXT"
        Me.out_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(317, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "To:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(71, 89)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(346, 89)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(144, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(215, 115)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "GO!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'clr_btn
        '
        Me.clr_btn.Location = New System.Drawing.Point(436, 246)
        Me.clr_btn.Name = "clr_btn"
        Me.clr_btn.Size = New System.Drawing.Size(75, 23)
        Me.clr_btn.TabIndex = 6
        Me.clr_btn.Text = "Clear"
        Me.clr_btn.UseVisualStyleBackColor = True
        '
        'sign_text
        '
        Me.sign_text.AutoSize = True
        Me.sign_text.Location = New System.Drawing.Point(12, 30)
        Me.sign_text.Name = "sign_text"
        Me.sign_text.Size = New System.Drawing.Size(176, 13)
        Me.sign_text.TabIndex = 7
        Me.sign_text.Text = "Input Number From Anything u want"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 281)
        Me.Controls.Add(Me.sign_text)
        Me.Controls.Add(Me.clr_btn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.out_text)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Random Number Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents out_text As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents clr_btn As Button
    Friend WithEvents sign_text As Label
End Class
