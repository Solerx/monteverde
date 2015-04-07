<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.lblMainTittle = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.MaskedTextBox()
        Me.txtPassword = New System.Windows.Forms.MaskedTextBox()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.cbxRecordLog = New System.Windows.Forms.CheckBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMainTittle
        '
        Me.lblMainTittle.AutoSize = True
        Me.lblMainTittle.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainTittle.ForeColor = System.Drawing.Color.Maroon
        Me.lblMainTittle.Location = New System.Drawing.Point(148, 68)
        Me.lblMainTittle.Name = "lblMainTittle"
        Me.lblMainTittle.Size = New System.Drawing.Size(518, 39)
        Me.lblMainTittle.TabIndex = 0
        Me.lblMainTittle.Text = "Proyect Management, Monterverde"
        '
        'txtEmail
        '
        Me.txtEmail.AsciiOnly = True
        Me.txtEmail.BackColor = System.Drawing.Color.Maroon
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.ForeColor = System.Drawing.Color.White
        Me.txtEmail.Location = New System.Drawing.Point(275, 199)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(265, 20)
        Me.txtEmail.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Maroon
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.ForeColor = System.Drawing.Color.White
        Me.txtPassword.Location = New System.Drawing.Point(275, 298)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(265, 20)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnLogIn
        '
        Me.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnLogIn.FlatAppearance.BorderSize = 2
        Me.btnLogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.btnLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogIn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.ForeColor = System.Drawing.Color.Maroon
        Me.btnLogIn.Location = New System.Drawing.Point(536, 413)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(114, 38)
        Me.btnLogIn.TabIndex = 3
        Me.btnLogIn.Text = "Ingresar"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'cbxRecordLog
        '
        Me.cbxRecordLog.AutoSize = True
        Me.cbxRecordLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxRecordLog.ForeColor = System.Drawing.Color.Maroon
        Me.cbxRecordLog.Location = New System.Drawing.Point(275, 355)
        Me.cbxRecordLog.Name = "cbxRecordLog"
        Me.cbxRecordLog.Size = New System.Drawing.Size(164, 17)
        Me.cbxRecordLog.TabIndex = 6
        Me.cbxRecordLog.Text = "Recordar correo y contraseña"
        Me.cbxRecordLog.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Maroon
        Me.lblEmail.Location = New System.Drawing.Point(272, 170)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(48, 16)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Email: "
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Maroon
        Me.lblPassword.Location = New System.Drawing.Point(272, 269)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(74, 16)
        Me.lblPassword.TabIndex = 9
        Me.lblPassword.Text = "Password: "
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogIn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.cbxRecordLog)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblMainTittle)
        Me.ForeColor = System.Drawing.Color.Maroon
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.Text = "Monteverde: Log In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMainTittle As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPassword As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnLogIn As System.Windows.Forms.Button
    Friend WithEvents cbxRecordLog As System.Windows.Forms.CheckBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label

End Class
