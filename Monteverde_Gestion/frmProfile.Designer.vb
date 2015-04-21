<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfile
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblRegisteredDate = New System.Windows.Forms.Label()
        Me.txtUserRegisteredDate = New System.Windows.Forms.MaskedTextBox()
        Me.lblUserPassword = New System.Windows.Forms.Label()
        Me.txtUserPassword = New System.Windows.Forms.MaskedTextBox()
        Me.lblUserEmail = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtUserEmail = New System.Windows.Forms.MaskedTextBox()
        Me.txtUserName = New System.Windows.Forms.MaskedTextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnBack.FlatAppearance.BorderSize = 2
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.ForeColor = System.Drawing.Color.Maroon
        Me.btnBack.Image = Global.Monteverde_Administrator.My.Resources.Resources.Sin_título
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(266, 45)
        Me.btnBack.TabIndex = 30
        Me.btnBack.Text = "Back to Main Menu"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblRegisteredDate
        '
        Me.lblRegisteredDate.AutoSize = True
        Me.lblRegisteredDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisteredDate.ForeColor = System.Drawing.Color.Maroon
        Me.lblRegisteredDate.Location = New System.Drawing.Point(46, 403)
        Me.lblRegisteredDate.Name = "lblRegisteredDate"
        Me.lblRegisteredDate.Size = New System.Drawing.Size(78, 16)
        Me.lblRegisteredDate.TabIndex = 67
        Me.lblRegisteredDate.Text = "User since: "
        '
        'txtUserRegisteredDate
        '
        Me.txtUserRegisteredDate.BackColor = System.Drawing.Color.Maroon
        Me.txtUserRegisteredDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserRegisteredDate.ForeColor = System.Drawing.Color.White
        Me.txtUserRegisteredDate.Location = New System.Drawing.Point(49, 422)
        Me.txtUserRegisteredDate.Name = "txtUserRegisteredDate"
        Me.txtUserRegisteredDate.Size = New System.Drawing.Size(163, 20)
        Me.txtUserRegisteredDate.TabIndex = 66
        '
        'lblUserPassword
        '
        Me.lblUserPassword.AutoSize = True
        Me.lblUserPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserPassword.ForeColor = System.Drawing.Color.Maroon
        Me.lblUserPassword.Location = New System.Drawing.Point(267, 325)
        Me.lblUserPassword.Name = "lblUserPassword"
        Me.lblUserPassword.Size = New System.Drawing.Size(74, 16)
        Me.lblUserPassword.TabIndex = 59
        Me.lblUserPassword.Text = "Password: "
        '
        'txtUserPassword
        '
        Me.txtUserPassword.BackColor = System.Drawing.Color.Maroon
        Me.txtUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserPassword.ForeColor = System.Drawing.Color.White
        Me.txtUserPassword.Location = New System.Drawing.Point(269, 344)
        Me.txtUserPassword.Name = "txtUserPassword"
        Me.txtUserPassword.Size = New System.Drawing.Size(265, 20)
        Me.txtUserPassword.TabIndex = 58
        '
        'lblUserEmail
        '
        Me.lblUserEmail.AutoSize = True
        Me.lblUserEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserEmail.ForeColor = System.Drawing.Color.Maroon
        Me.lblUserEmail.Location = New System.Drawing.Point(267, 247)
        Me.lblUserEmail.Name = "lblUserEmail"
        Me.lblUserEmail.Size = New System.Drawing.Size(48, 16)
        Me.lblUserEmail.TabIndex = 57
        Me.lblUserEmail.Text = "Email: "
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.Maroon
        Me.lblUserName.Location = New System.Drawing.Point(267, 171)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(75, 16)
        Me.lblUserName.TabIndex = 56
        Me.lblUserName.Text = "Full Name: "
        '
        'txtUserEmail
        '
        Me.txtUserEmail.BackColor = System.Drawing.Color.Maroon
        Me.txtUserEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserEmail.ForeColor = System.Drawing.Color.White
        Me.txtUserEmail.Location = New System.Drawing.Point(270, 266)
        Me.txtUserEmail.Name = "txtUserEmail"
        Me.txtUserEmail.Size = New System.Drawing.Size(265, 20)
        Me.txtUserEmail.TabIndex = 55
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.Maroon
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.ForeColor = System.Drawing.Color.White
        Me.txtUserName.Location = New System.Drawing.Point(270, 190)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(265, 20)
        Me.txtUserName.TabIndex = 54
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.Maroon
        Me.btnSave.Image = Global.Monteverde_Administrator.My.Resources.Resources.Imagen23
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(651, 504)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(121, 45)
        Me.btnSave.TabIndex = 71
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblRegisteredDate)
        Me.Controls.Add(Me.txtUserRegisteredDate)
        Me.Controls.Add(Me.lblUserPassword)
        Me.Controls.Add(Me.txtUserPassword)
        Me.Controls.Add(Me.lblUserEmail)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtUserEmail)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "frmProfile"
        Me.Text = "Profile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblRegisteredDate As System.Windows.Forms.Label
    Friend WithEvents txtUserRegisteredDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblUserPassword As System.Windows.Forms.Label
    Friend WithEvents txtUserPassword As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblUserEmail As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txtUserEmail As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtUserName As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
