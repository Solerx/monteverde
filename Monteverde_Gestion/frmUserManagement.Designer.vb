<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserManagement
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
        Me.btnEditUser = New System.Windows.Forms.Button()
        Me.btnRemoveUser = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.txtUserEmail = New System.Windows.Forms.MaskedTextBox()
        Me.txtUserName = New System.Windows.Forms.MaskedTextBox()
        Me.lblUserEmail = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblUserPassword = New System.Windows.Forms.Label()
        Me.txtUserPassword = New System.Windows.Forms.MaskedTextBox()
        Me.lblUserRole = New System.Windows.Forms.Label()
        Me.txtUserRole = New System.Windows.Forms.MaskedTextBox()
        Me.lblUserStatus = New System.Windows.Forms.Label()
        Me.txtUserStatus = New System.Windows.Forms.MaskedTextBox()
        Me.lblUserWorkedHours = New System.Windows.Forms.Label()
        Me.txtUserWorkedHours = New System.Windows.Forms.MaskedTextBox()
        Me.lblUserHolidays = New System.Windows.Forms.Label()
        Me.txtUserHolidays = New System.Windows.Forms.MaskedTextBox()
        Me.lblRegisteredDate = New System.Windows.Forms.Label()
        Me.txtUserRegisteredDate = New System.Windows.Forms.MaskedTextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditUser
        '
        Me.btnEditUser.BackColor = System.Drawing.Color.White
        Me.btnEditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEditUser.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnEditUser.FlatAppearance.BorderSize = 2
        Me.btnEditUser.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnEditUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnEditUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditUser.ForeColor = System.Drawing.Color.Maroon
        Me.btnEditUser.Location = New System.Drawing.Point(157, 290)
        Me.btnEditUser.Name = "btnEditUser"
        Me.btnEditUser.Size = New System.Drawing.Size(121, 45)
        Me.btnEditUser.TabIndex = 26
        Me.btnEditUser.Text = "Edit User"
        Me.btnEditUser.UseVisualStyleBackColor = False
        '
        'btnRemoveUser
        '
        Me.btnRemoveUser.BackColor = System.Drawing.Color.White
        Me.btnRemoveUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRemoveUser.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnRemoveUser.FlatAppearance.BorderSize = 2
        Me.btnRemoveUser.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnRemoveUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnRemoveUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnRemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveUser.ForeColor = System.Drawing.Color.Maroon
        Me.btnRemoveUser.Location = New System.Drawing.Point(624, 290)
        Me.btnRemoveUser.Name = "btnRemoveUser"
        Me.btnRemoveUser.Size = New System.Drawing.Size(148, 45)
        Me.btnRemoveUser.TabIndex = 27
        Me.btnRemoveUser.Text = "Remove User"
        Me.btnRemoveUser.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnBack.FlatAppearance.BorderSize = 2
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.ForeColor = System.Drawing.Color.Maroon
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(266, 45)
        Me.btnBack.TabIndex = 29
        Me.btnBack.Text = "Back to Main Menu"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnAddUser
        '
        Me.btnAddUser.BackColor = System.Drawing.Color.White
        Me.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnAddUser.FlatAppearance.BorderSize = 2
        Me.btnAddUser.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUser.ForeColor = System.Drawing.Color.Maroon
        Me.btnAddUser.Location = New System.Drawing.Point(12, 290)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(121, 45)
        Me.btnAddUser.TabIndex = 25
        Me.btnAddUser.Text = "Add New User"
        Me.btnAddUser.UseVisualStyleBackColor = False
        '
        'dgvUsers
        '
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(12, 63)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.Size = New System.Drawing.Size(760, 221)
        Me.dgvUsers.TabIndex = 20
        '
        'txtUserEmail
        '
        Me.txtUserEmail.BackColor = System.Drawing.Color.Maroon
        Me.txtUserEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserEmail.ForeColor = System.Drawing.Color.White
        Me.txtUserEmail.Location = New System.Drawing.Point(16, 417)
        Me.txtUserEmail.Name = "txtUserEmail"
        Me.txtUserEmail.Size = New System.Drawing.Size(265, 20)
        Me.txtUserEmail.TabIndex = 31
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.Maroon
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.ForeColor = System.Drawing.Color.White
        Me.txtUserName.Location = New System.Drawing.Point(13, 366)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(265, 20)
        Me.txtUserName.TabIndex = 30
        '
        'lblUserEmail
        '
        Me.lblUserEmail.AutoSize = True
        Me.lblUserEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserEmail.ForeColor = System.Drawing.Color.Maroon
        Me.lblUserEmail.Location = New System.Drawing.Point(13, 398)
        Me.lblUserEmail.Name = "lblUserEmail"
        Me.lblUserEmail.Size = New System.Drawing.Size(48, 16)
        Me.lblUserEmail.TabIndex = 33
        Me.lblUserEmail.Text = "Email: "
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.Maroon
        Me.lblUserName.Location = New System.Drawing.Point(13, 347)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(75, 16)
        Me.lblUserName.TabIndex = 32
        Me.lblUserName.Text = "Full Name: "
        '
        'lblUserPassword
        '
        Me.lblUserPassword.AutoSize = True
        Me.lblUserPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserPassword.ForeColor = System.Drawing.Color.Maroon
        Me.lblUserPassword.Location = New System.Drawing.Point(13, 452)
        Me.lblUserPassword.Name = "lblUserPassword"
        Me.lblUserPassword.Size = New System.Drawing.Size(74, 16)
        Me.lblUserPassword.TabIndex = 35
        Me.lblUserPassword.Text = "Password: "
        '
        'txtUserPassword
        '
        Me.txtUserPassword.BackColor = System.Drawing.Color.Maroon
        Me.txtUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserPassword.ForeColor = System.Drawing.Color.White
        Me.txtUserPassword.Location = New System.Drawing.Point(16, 471)
        Me.txtUserPassword.Name = "txtUserPassword"
        Me.txtUserPassword.Size = New System.Drawing.Size(265, 20)
        Me.txtUserPassword.TabIndex = 34
        '
        'lblUserRole
        '
        Me.lblUserRole.AutoSize = True
        Me.lblUserRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserRole.ForeColor = System.Drawing.Color.Maroon
        Me.lblUserRole.Location = New System.Drawing.Point(318, 398)
        Me.lblUserRole.Name = "lblUserRole"
        Me.lblUserRole.Size = New System.Drawing.Size(43, 16)
        Me.lblUserRole.TabIndex = 37
        Me.lblUserRole.Text = "Role: "
        '
        'txtUserRole
        '
        Me.txtUserRole.BackColor = System.Drawing.Color.Maroon
        Me.txtUserRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserRole.ForeColor = System.Drawing.Color.White
        Me.txtUserRole.Location = New System.Drawing.Point(321, 417)
        Me.txtUserRole.Name = "txtUserRole"
        Me.txtUserRole.Size = New System.Drawing.Size(265, 20)
        Me.txtUserRole.TabIndex = 36
        '
        'lblUserStatus
        '
        Me.lblUserStatus.AutoSize = True
        Me.lblUserStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserStatus.ForeColor = System.Drawing.Color.Maroon
        Me.lblUserStatus.Location = New System.Drawing.Point(318, 452)
        Me.lblUserStatus.Name = "lblUserStatus"
        Me.lblUserStatus.Size = New System.Drawing.Size(51, 16)
        Me.lblUserStatus.TabIndex = 39
        Me.lblUserStatus.Text = "Status: "
        '
        'txtUserStatus
        '
        Me.txtUserStatus.BackColor = System.Drawing.Color.Maroon
        Me.txtUserStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserStatus.ForeColor = System.Drawing.Color.White
        Me.txtUserStatus.Location = New System.Drawing.Point(321, 471)
        Me.txtUserStatus.Name = "txtUserStatus"
        Me.txtUserStatus.Size = New System.Drawing.Size(265, 20)
        Me.txtUserStatus.TabIndex = 38
        '
        'lblUserWorkedHours
        '
        Me.lblUserWorkedHours.AutoSize = True
        Me.lblUserWorkedHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserWorkedHours.ForeColor = System.Drawing.Color.Maroon
        Me.lblUserWorkedHours.Location = New System.Drawing.Point(621, 347)
        Me.lblUserWorkedHours.Name = "lblUserWorkedHours"
        Me.lblUserWorkedHours.Size = New System.Drawing.Size(95, 16)
        Me.lblUserWorkedHours.TabIndex = 41
        Me.lblUserWorkedHours.Text = "Worked Hours"
        '
        'txtUserWorkedHours
        '
        Me.txtUserWorkedHours.BackColor = System.Drawing.Color.Maroon
        Me.txtUserWorkedHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserWorkedHours.ForeColor = System.Drawing.Color.White
        Me.txtUserWorkedHours.Location = New System.Drawing.Point(624, 366)
        Me.txtUserWorkedHours.Name = "txtUserWorkedHours"
        Me.txtUserWorkedHours.Size = New System.Drawing.Size(148, 20)
        Me.txtUserWorkedHours.TabIndex = 40
        '
        'lblUserHolidays
        '
        Me.lblUserHolidays.AutoSize = True
        Me.lblUserHolidays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserHolidays.ForeColor = System.Drawing.Color.Maroon
        Me.lblUserHolidays.Location = New System.Drawing.Point(621, 398)
        Me.lblUserHolidays.Name = "lblUserHolidays"
        Me.lblUserHolidays.Size = New System.Drawing.Size(71, 16)
        Me.lblUserHolidays.TabIndex = 43
        Me.lblUserHolidays.Text = "Holidays:  "
        '
        'txtUserHolidays
        '
        Me.txtUserHolidays.BackColor = System.Drawing.Color.Maroon
        Me.txtUserHolidays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserHolidays.ForeColor = System.Drawing.Color.White
        Me.txtUserHolidays.Location = New System.Drawing.Point(624, 417)
        Me.txtUserHolidays.Name = "txtUserHolidays"
        Me.txtUserHolidays.Size = New System.Drawing.Size(148, 20)
        Me.txtUserHolidays.TabIndex = 42
        '
        'lblRegisteredDate
        '
        Me.lblRegisteredDate.AutoSize = True
        Me.lblRegisteredDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegisteredDate.ForeColor = System.Drawing.Color.Maroon
        Me.lblRegisteredDate.Location = New System.Drawing.Point(621, 452)
        Me.lblRegisteredDate.Name = "lblRegisteredDate"
        Me.lblRegisteredDate.Size = New System.Drawing.Size(78, 16)
        Me.lblRegisteredDate.TabIndex = 45
        Me.lblRegisteredDate.Text = "User since: "
        '
        'txtUserRegisteredDate
        '
        Me.txtUserRegisteredDate.BackColor = System.Drawing.Color.Maroon
        Me.txtUserRegisteredDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserRegisteredDate.ForeColor = System.Drawing.Color.White
        Me.txtUserRegisteredDate.Location = New System.Drawing.Point(624, 471)
        Me.txtUserRegisteredDate.Mask = "00/00/0000"
        Me.txtUserRegisteredDate.Name = "txtUserRegisteredDate"
        Me.txtUserRegisteredDate.Size = New System.Drawing.Size(148, 20)
        Me.txtUserRegisteredDate.TabIndex = 44
        Me.txtUserRegisteredDate.ValidatingType = GetType(Date)
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.White
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnSave.FlatAppearance.BorderSize = 2
        Me.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.Maroon
        Me.btnSave.Location = New System.Drawing.Point(340, 504)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(149, 45)
        Me.btnSave.TabIndex = 46
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmUserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblRegisteredDate)
        Me.Controls.Add(Me.txtUserRegisteredDate)
        Me.Controls.Add(Me.lblUserHolidays)
        Me.Controls.Add(Me.txtUserHolidays)
        Me.Controls.Add(Me.lblUserWorkedHours)
        Me.Controls.Add(Me.txtUserWorkedHours)
        Me.Controls.Add(Me.lblUserStatus)
        Me.Controls.Add(Me.txtUserStatus)
        Me.Controls.Add(Me.lblUserRole)
        Me.Controls.Add(Me.txtUserRole)
        Me.Controls.Add(Me.lblUserPassword)
        Me.Controls.Add(Me.txtUserPassword)
        Me.Controls.Add(Me.lblUserEmail)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.txtUserEmail)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.btnEditUser)
        Me.Controls.Add(Me.btnRemoveUser)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.dgvUsers)
        Me.Name = "frmUserManagement"
        Me.Text = "frmUserManagement"
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEditUser As System.Windows.Forms.Button
    Friend WithEvents btnRemoveUser As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnAddUser As System.Windows.Forms.Button
    Friend WithEvents dgvUsers As System.Windows.Forms.DataGridView
    Friend WithEvents txtUserEmail As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtUserName As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblUserEmail As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblUserPassword As System.Windows.Forms.Label
    Friend WithEvents txtUserPassword As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblUserRole As System.Windows.Forms.Label
    Friend WithEvents txtUserRole As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblUserStatus As System.Windows.Forms.Label
    Friend WithEvents txtUserStatus As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblUserWorkedHours As System.Windows.Forms.Label
    Friend WithEvents txtUserWorkedHours As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblUserHolidays As System.Windows.Forms.Label
    Friend WithEvents txtUserHolidays As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblRegisteredDate As System.Windows.Forms.Label
    Friend WithEvents txtUserRegisteredDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
