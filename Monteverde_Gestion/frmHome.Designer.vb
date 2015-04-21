<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Me.lblUserRole = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblUserEmail = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.msiManagement = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiManageUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiManageProjects = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiManageWorkCategories = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiManageUserProjects = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiProjectToUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiUserToProject = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiManageProfile = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTimeRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiViewUserRegs = New System.Windows.Forms.ToolStripMenuItem()
        Me.HolidaysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HolidaysRequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msiUserHolidays = New System.Windows.Forms.ToolStripMenuItem()
        Me.msHome = New System.Windows.Forms.MenuStrip()
        Me.lblHolidayRequest = New System.Windows.Forms.Label()
        Me.lblRequests = New System.Windows.Forms.Label()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.msHome.SuspendLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUserRole
        '
        Me.lblUserRole.AutoSize = True
        Me.lblUserRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserRole.ForeColor = System.Drawing.Color.Maroon
        Me.lblUserRole.Location = New System.Drawing.Point(13, 256)
        Me.lblUserRole.Name = "lblUserRole"
        Me.lblUserRole.Size = New System.Drawing.Size(102, 25)
        Me.lblUserRole.TabIndex = 22
        Me.lblUserRole.Text = "user_role"
        Me.lblUserRole.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.ForeColor = System.Drawing.Color.Maroon
        Me.lblUserName.Location = New System.Drawing.Point(12, 141)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(158, 31)
        Me.lblUserName.TabIndex = 8
        Me.lblUserName.Text = "user_name"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblUserEmail
        '
        Me.lblUserEmail.AutoSize = True
        Me.lblUserEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserEmail.ForeColor = System.Drawing.Color.Maroon
        Me.lblUserEmail.Location = New System.Drawing.Point(13, 204)
        Me.lblUserEmail.Name = "lblUserEmail"
        Me.lblUserEmail.Size = New System.Drawing.Size(117, 25)
        Me.lblUserEmail.TabIndex = 24
        Me.lblUserEmail.Text = "user_email"
        Me.lblUserEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.White
        Me.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnLogOut.FlatAppearance.BorderSize = 2
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.ForeColor = System.Drawing.Color.Maroon
        Me.btnLogOut.Location = New System.Drawing.Point(683, 0)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(89, 24)
        Me.btnLogOut.TabIndex = 36
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'msiManagement
        '
        Me.msiManagement.BackColor = System.Drawing.Color.Maroon
        Me.msiManagement.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msiManageUsers, Me.msiManageProjects, Me.msiManageWorkCategories, Me.msiManageUserProjects, Me.msiManageProfile})
        Me.msiManagement.ForeColor = System.Drawing.SystemColors.Control
        Me.msiManagement.Name = "msiManagement"
        Me.msiManagement.Size = New System.Drawing.Size(90, 20)
        Me.msiManagement.Text = "Management"
        '
        'msiManageUsers
        '
        Me.msiManageUsers.BackColor = System.Drawing.Color.Maroon
        Me.msiManageUsers.ForeColor = System.Drawing.SystemColors.Control
        Me.msiManageUsers.Name = "msiManageUsers"
        Me.msiManageUsers.Size = New System.Drawing.Size(194, 22)
        Me.msiManageUsers.Text = "Users"
        '
        'msiManageProjects
        '
        Me.msiManageProjects.BackColor = System.Drawing.Color.Maroon
        Me.msiManageProjects.ForeColor = System.Drawing.SystemColors.Control
        Me.msiManageProjects.Name = "msiManageProjects"
        Me.msiManageProjects.Size = New System.Drawing.Size(194, 22)
        Me.msiManageProjects.Text = "Projects"
        '
        'msiManageWorkCategories
        '
        Me.msiManageWorkCategories.BackColor = System.Drawing.Color.Maroon
        Me.msiManageWorkCategories.ForeColor = System.Drawing.SystemColors.Control
        Me.msiManageWorkCategories.Name = "msiManageWorkCategories"
        Me.msiManageWorkCategories.Size = New System.Drawing.Size(194, 22)
        Me.msiManageWorkCategories.Text = "Work Categories"
        '
        'msiManageUserProjects
        '
        Me.msiManageUserProjects.BackColor = System.Drawing.Color.Maroon
        Me.msiManageUserProjects.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msiProjectToUser, Me.msiUserToProject})
        Me.msiManageUserProjects.ForeColor = System.Drawing.SystemColors.Control
        Me.msiManageUserProjects.Name = "msiManageUserProjects"
        Me.msiManageUserProjects.Size = New System.Drawing.Size(194, 22)
        Me.msiManageUserProjects.Text = "Assing User to Projects"
        '
        'msiProjectToUser
        '
        Me.msiProjectToUser.BackColor = System.Drawing.Color.Maroon
        Me.msiProjectToUser.ForeColor = System.Drawing.Color.White
        Me.msiProjectToUser.Name = "msiProjectToUser"
        Me.msiProjectToUser.Size = New System.Drawing.Size(151, 22)
        Me.msiProjectToUser.Text = "Project to User"
        '
        'msiUserToProject
        '
        Me.msiUserToProject.BackColor = System.Drawing.Color.Maroon
        Me.msiUserToProject.ForeColor = System.Drawing.Color.White
        Me.msiUserToProject.Name = "msiUserToProject"
        Me.msiUserToProject.Size = New System.Drawing.Size(151, 22)
        Me.msiUserToProject.Text = "User to Project"
        '
        'msiManageProfile
        '
        Me.msiManageProfile.BackColor = System.Drawing.Color.Maroon
        Me.msiManageProfile.ForeColor = System.Drawing.Color.White
        Me.msiManageProfile.Name = "msiManageProfile"
        Me.msiManageProfile.Size = New System.Drawing.Size(194, 22)
        Me.msiManageProfile.Text = "Profile"
        '
        'TimeRegistrationToolStripMenuItem
        '
        Me.TimeRegistrationToolStripMenuItem.BackColor = System.Drawing.Color.Maroon
        Me.TimeRegistrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTimeRegistrationToolStripMenuItem, Me.msiViewUserRegs})
        Me.TimeRegistrationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.TimeRegistrationToolStripMenuItem.Name = "TimeRegistrationToolStripMenuItem"
        Me.TimeRegistrationToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.TimeRegistrationToolStripMenuItem.Text = "Time Registration"
        '
        'NewTimeRegistrationToolStripMenuItem
        '
        Me.NewTimeRegistrationToolStripMenuItem.BackColor = System.Drawing.Color.Maroon
        Me.NewTimeRegistrationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.NewTimeRegistrationToolStripMenuItem.Name = "NewTimeRegistrationToolStripMenuItem"
        Me.NewTimeRegistrationToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.NewTimeRegistrationToolStripMenuItem.Text = "New Time Registration"
        '
        'msiViewUserRegs
        '
        Me.msiViewUserRegs.BackColor = System.Drawing.Color.Maroon
        Me.msiViewUserRegs.ForeColor = System.Drawing.SystemColors.Control
        Me.msiViewUserRegs.Name = "msiViewUserRegs"
        Me.msiViewUserRegs.Size = New System.Drawing.Size(201, 22)
        Me.msiViewUserRegs.Text = "View Users Registrations"
        '
        'HolidaysToolStripMenuItem
        '
        Me.HolidaysToolStripMenuItem.BackColor = System.Drawing.Color.Maroon
        Me.HolidaysToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HolidaysRequestToolStripMenuItem, Me.msiUserHolidays})
        Me.HolidaysToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.HolidaysToolStripMenuItem.Name = "HolidaysToolStripMenuItem"
        Me.HolidaysToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.HolidaysToolStripMenuItem.Text = "Holidays"
        '
        'HolidaysRequestToolStripMenuItem
        '
        Me.HolidaysRequestToolStripMenuItem.BackColor = System.Drawing.Color.Maroon
        Me.HolidaysRequestToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.HolidaysRequestToolStripMenuItem.Name = "HolidaysRequestToolStripMenuItem"
        Me.HolidaysRequestToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.HolidaysRequestToolStripMenuItem.Text = "Holidays Request"
        '
        'msiUserHolidays
        '
        Me.msiUserHolidays.BackColor = System.Drawing.Color.Maroon
        Me.msiUserHolidays.ForeColor = System.Drawing.SystemColors.Control
        Me.msiUserHolidays.Name = "msiUserHolidays"
        Me.msiUserHolidays.Size = New System.Drawing.Size(165, 22)
        Me.msiUserHolidays.Text = "Users Holidays"
        '
        'msHome
        '
        Me.msHome.BackColor = System.Drawing.Color.Maroon
        Me.msHome.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.msiManagement, Me.TimeRegistrationToolStripMenuItem, Me.HolidaysToolStripMenuItem, Me.ReportsToolStripMenuItem})
        Me.msHome.Location = New System.Drawing.Point(0, 0)
        Me.msHome.Name = "msHome"
        Me.msHome.Size = New System.Drawing.Size(784, 24)
        Me.msHome.TabIndex = 23
        Me.msHome.Text = "MenuStrip1"
        '
        'lblHolidayRequest
        '
        Me.lblHolidayRequest.AutoSize = True
        Me.lblHolidayRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHolidayRequest.ForeColor = System.Drawing.Color.Maroon
        Me.lblHolidayRequest.Location = New System.Drawing.Point(482, 477)
        Me.lblHolidayRequest.Name = "lblHolidayRequest"
        Me.lblHolidayRequest.Size = New System.Drawing.Size(290, 25)
        Me.lblHolidayRequest.TabIndex = 37
        Me.lblHolidayRequest.Text = "Pending Holiday Requests"
        Me.lblHolidayRequest.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRequests
        '
        Me.lblRequests.AutoSize = True
        Me.lblRequests.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRequests.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRequests.ForeColor = System.Drawing.Color.Maroon
        Me.lblRequests.Location = New System.Drawing.Point(613, 502)
        Me.lblRequests.Name = "lblRequests"
        Me.lblRequests.Size = New System.Drawing.Size(36, 37)
        Me.lblRequests.TabIndex = 38
        Me.lblRequests.Text = "0"
        Me.lblRequests.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'pbLogo
        '
        Me.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(660, 40)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(112, 94)
        Me.pbLogo.TabIndex = 17
        Me.pbLogo.TabStop = False
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lblRequests)
        Me.Controls.Add(Me.lblHolidayRequest)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.lblUserEmail)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.lblUserRole)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.msHome)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MainMenuStrip = Me.msHome
        Me.Name = "frmHome"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Welcome!"
        Me.msHome.ResumeLayout(False)
        Me.msHome.PerformLayout()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblUserRole As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents lblUserEmail As System.Windows.Forms.Label
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents msiManagement As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msiManageUsers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msiManageProjects As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msiManageWorkCategories As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msiManageUserProjects As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msiProjectToUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msiUserToProject As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msiManageProfile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTimeRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msiViewUserRegs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HolidaysToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HolidaysRequestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msiUserHolidays As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents msHome As System.Windows.Forms.MenuStrip
    Friend WithEvents lblHolidayRequest As System.Windows.Forms.Label
    Friend WithEvents lblRequests As System.Windows.Forms.Label
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
