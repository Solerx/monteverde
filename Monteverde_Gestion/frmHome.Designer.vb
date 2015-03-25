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
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.lblUserRole = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTimeRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewUsersRegistrationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HolidaysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HolidaysRequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersHolidaysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblUserEmail = New System.Windows.Forms.Label()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbLogo
        '
        Me.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(326, 97)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(112, 94)
        Me.pbLogo.TabIndex = 17
        Me.pbLogo.TabStop = False
        '
        'lblUserRole
        '
        Me.lblUserRole.AutoSize = True
        Me.lblUserRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserRole.ForeColor = System.Drawing.Color.Maroon
        Me.lblUserRole.Location = New System.Drawing.Point(321, 346)
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
        Me.lblUserName.Location = New System.Drawing.Point(303, 233)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(156, 31)
        Me.lblUserName.TabIndex = 8
        Me.lblUserName.Text = "user_email"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Maroon
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManagementToolStripMenuItem, Me.TimeRegistrationToolStripMenuItem, Me.HolidaysToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ManagementToolStripMenuItem
        '
        Me.ManagementToolStripMenuItem.BackColor = System.Drawing.Color.Maroon
        Me.ManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsersToolStripMenuItem, Me.ProjectsToolStripMenuItem, Me.CategoriesToolStripMenuItem, Me.ProfileToolStripMenuItem})
        Me.ManagementToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ManagementToolStripMenuItem.Name = "ManagementToolStripMenuItem"
        Me.ManagementToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.ManagementToolStripMenuItem.Text = "Management"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.BackColor = System.Drawing.Color.Maroon
        Me.UsersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'ProjectsToolStripMenuItem
        '
        Me.ProjectsToolStripMenuItem.BackColor = System.Drawing.Color.Maroon
        Me.ProjectsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ProjectsToolStripMenuItem.Name = "ProjectsToolStripMenuItem"
        Me.ProjectsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProjectsToolStripMenuItem.Text = "Projects"
        '
        'CategoriesToolStripMenuItem
        '
        Me.CategoriesToolStripMenuItem.BackColor = System.Drawing.Color.Maroon
        Me.CategoriesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.CategoriesToolStripMenuItem.Name = "CategoriesToolStripMenuItem"
        Me.CategoriesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CategoriesToolStripMenuItem.Text = "Categories"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.BackColor = System.Drawing.Color.Maroon
        Me.ProfileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'TimeRegistrationToolStripMenuItem
        '
        Me.TimeRegistrationToolStripMenuItem.BackColor = System.Drawing.Color.Maroon
        Me.TimeRegistrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTimeRegistrationToolStripMenuItem, Me.ViewUsersRegistrationsToolStripMenuItem})
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
        'ViewUsersRegistrationsToolStripMenuItem
        '
        Me.ViewUsersRegistrationsToolStripMenuItem.BackColor = System.Drawing.Color.Maroon
        Me.ViewUsersRegistrationsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ViewUsersRegistrationsToolStripMenuItem.Name = "ViewUsersRegistrationsToolStripMenuItem"
        Me.ViewUsersRegistrationsToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ViewUsersRegistrationsToolStripMenuItem.Text = "View Users Registrations"
        '
        'HolidaysToolStripMenuItem
        '
        Me.HolidaysToolStripMenuItem.BackColor = System.Drawing.Color.Maroon
        Me.HolidaysToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HolidaysRequestToolStripMenuItem, Me.UsersHolidaysToolStripMenuItem})
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
        'UsersHolidaysToolStripMenuItem
        '
        Me.UsersHolidaysToolStripMenuItem.BackColor = System.Drawing.Color.Maroon
        Me.UsersHolidaysToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.UsersHolidaysToolStripMenuItem.Name = "UsersHolidaysToolStripMenuItem"
        Me.UsersHolidaysToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.UsersHolidaysToolStripMenuItem.Text = "Users Holidays"
        '
        'lblUserEmail
        '
        Me.lblUserEmail.AutoSize = True
        Me.lblUserEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserEmail.ForeColor = System.Drawing.Color.Maroon
        Me.lblUserEmail.Location = New System.Drawing.Point(321, 296)
        Me.lblUserEmail.Name = "lblUserEmail"
        Me.lblUserEmail.Size = New System.Drawing.Size(117, 25)
        Me.lblUserEmail.TabIndex = 24
        Me.lblUserEmail.Text = "user_email"
        Me.lblUserEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lblUserEmail)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.lblUserRole)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmHome"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Welcome!"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblUserRole As System.Windows.Forms.Label
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTimeRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewUsersRegistrationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HolidaysToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HolidaysRequestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersHolidaysToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblUserEmail As System.Windows.Forms.Label
End Class
