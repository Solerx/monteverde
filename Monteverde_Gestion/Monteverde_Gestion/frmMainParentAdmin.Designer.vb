<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainParentAdmin
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
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.lblUserEmail = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.btnUpdateUserGriedView = New System.Windows.Forms.Button()
        Me.btnRemoveUserFromDataBase = New System.Windows.Forms.Button()
        Me.btnEditUser = New System.Windows.Forms.Button()
        Me.lblUserGridViewTittle = New System.Windows.Forms.Label()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MANAGEMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProyectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditCategoriesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HolidaysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HolidaysResquestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersHolidaysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NewTimeRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewUserRegistrationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSignOut
        '
        Me.btnSignOut.Location = New System.Drawing.Point(683, 27)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(89, 38)
        Me.btnSignOut.TabIndex = 19
        Me.btnSignOut.Text = "Cerrar Sesión"
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'lblUserEmail
        '
        Me.lblUserEmail.AutoSize = True
        Me.lblUserEmail.Location = New System.Drawing.Point(9, 40)
        Me.lblUserEmail.Name = "lblUserEmail"
        Me.lblUserEmail.Size = New System.Drawing.Size(57, 13)
        Me.lblUserEmail.TabIndex = 20
        Me.lblUserEmail.Text = "UserName"
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(9, 62)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(70, 13)
        Me.lblRole.TabIndex = 22
        Me.lblRole.Text = "Administrador"
        '
        'btnUpdateUserGriedView
        '
        Me.btnUpdateUserGriedView.Location = New System.Drawing.Point(330, 19)
        Me.btnUpdateUserGriedView.Name = "btnUpdateUserGriedView"
        Me.btnUpdateUserGriedView.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateUserGriedView.TabIndex = 35
        Me.btnUpdateUserGriedView.Text = "Refrescar lista!"
        Me.btnUpdateUserGriedView.UseVisualStyleBackColor = True
        '
        'btnRemoveUserFromDataBase
        '
        Me.btnRemoveUserFromDataBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRemoveUserFromDataBase.Location = New System.Drawing.Point(221, 87)
        Me.btnRemoveUserFromDataBase.Name = "btnRemoveUserFromDataBase"
        Me.btnRemoveUserFromDataBase.Size = New System.Drawing.Size(56, 49)
        Me.btnRemoveUserFromDataBase.TabIndex = 34
        Me.btnRemoveUserFromDataBase.Text = "Eliminar usuario"
        Me.btnRemoveUserFromDataBase.UseVisualStyleBackColor = True
        '
        'btnEditUser
        '
        Me.btnEditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEditUser.Location = New System.Drawing.Point(230, 152)
        Me.btnEditUser.Name = "btnEditUser"
        Me.btnEditUser.Size = New System.Drawing.Size(56, 47)
        Me.btnEditUser.TabIndex = 33
        Me.btnEditUser.Text = "Editar"
        Me.btnEditUser.UseVisualStyleBackColor = True
        '
        'lblUserGridViewTittle
        '
        Me.lblUserGridViewTittle.AutoSize = True
        Me.lblUserGridViewTittle.Location = New System.Drawing.Point(3, 19)
        Me.lblUserGridViewTittle.Name = "lblUserGridViewTittle"
        Me.lblUserGridViewTittle.Size = New System.Drawing.Size(34, 13)
        Me.lblUserGridViewTittle.TabIndex = 24
        Me.lblUserGridViewTittle.Text = "Users"
        '
        'dgvUsers
        '
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(29, 22)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.Size = New System.Drawing.Size(129, 76)
        Me.dgvUsers.TabIndex = 23
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MANAGEMENTToolStripMenuItem, Me.ProjectToolStripMenuItem, Me.HolidaysToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 36
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MANAGEMENTToolStripMenuItem
        '
        Me.MANAGEMENTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.ProyectsToolStripMenuItem, Me.EditCategoriesToolStripMenuItem1})
        Me.MANAGEMENTToolStripMenuItem.Name = "MANAGEMENTToolStripMenuItem"
        Me.MANAGEMENTToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.MANAGEMENTToolStripMenuItem.Text = "Management"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UserToolStripMenuItem.Text = "Users"
        '
        'ProyectsToolStripMenuItem
        '
        Me.ProyectsToolStripMenuItem.Name = "ProyectsToolStripMenuItem"
        Me.ProyectsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ProyectsToolStripMenuItem.Text = "Projects"
        '
        'EditCategoriesToolStripMenuItem1
        '
        Me.EditCategoriesToolStripMenuItem1.Name = "EditCategoriesToolStripMenuItem1"
        Me.EditCategoriesToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.EditCategoriesToolStripMenuItem1.Text = "Categories"
        '
        'ProjectToolStripMenuItem
        '
        Me.ProjectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTimeRegistrationToolStripMenuItem, Me.ViewUserRegistrationsToolStripMenuItem})
        Me.ProjectToolStripMenuItem.Name = "ProjectToolStripMenuItem"
        Me.ProjectToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.ProjectToolStripMenuItem.Text = "Time registration"
        '
        'HolidaysToolStripMenuItem
        '
        Me.HolidaysToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HolidaysResquestToolStripMenuItem, Me.UsersHolidaysToolStripMenuItem})
        Me.HolidaysToolStripMenuItem.Name = "HolidaysToolStripMenuItem"
        Me.HolidaysToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.HolidaysToolStripMenuItem.Text = "Holidays"
        '
        'HolidaysResquestToolStripMenuItem
        '
        Me.HolidaysResquestToolStripMenuItem.Name = "HolidaysResquestToolStripMenuItem"
        Me.HolidaysResquestToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.HolidaysResquestToolStripMenuItem.Text = "Holidays Resquest"
        '
        'UsersHolidaysToolStripMenuItem
        '
        Me.UsersHolidaysToolStripMenuItem.Name = "UsersHolidaysToolStripMenuItem"
        Me.UsersHolidaysToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.UsersHolidaysToolStripMenuItem.Text = "Users Holidays"
        '
        'btnAddUser
        '
        Me.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddUser.Location = New System.Drawing.Point(221, 22)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(56, 49)
        Me.btnAddUser.TabIndex = 37
        Me.btnAddUser.Text = "Add"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblUserGridViewTittle)
        Me.Panel1.Controls.Add(Me.btnUpdateUserGriedView)
        Me.Panel1.Controls.Add(Me.btnAddUser)
        Me.Panel1.Controls.Add(Me.btnEditUser)
        Me.Panel1.Controls.Add(Me.btnRemoveUserFromDataBase)
        Me.Panel1.Controls.Add(Me.dgvUsers)
        Me.Panel1.Location = New System.Drawing.Point(12, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(408, 295)
        Me.Panel1.TabIndex = 38
        '
        'NewTimeRegistrationToolStripMenuItem
        '
        Me.NewTimeRegistrationToolStripMenuItem.Name = "NewTimeRegistrationToolStripMenuItem"
        Me.NewTimeRegistrationToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.NewTimeRegistrationToolStripMenuItem.Text = "New Time Registration"
        '
        'ViewUserRegistrationsToolStripMenuItem
        '
        Me.ViewUserRegistrationsToolStripMenuItem.Name = "ViewUserRegistrationsToolStripMenuItem"
        Me.ViewUserRegistrationsToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ViewUserRegistrationsToolStripMenuItem.Text = "View User Registrations"
        '
        'frmMainParentAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.btnSignOut)
        Me.Controls.Add(Me.lblUserEmail)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMainParentAdmin"
        Me.Text = "frmMainParentAdmin"
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSignOut As System.Windows.Forms.Button
    Friend WithEvents lblUserEmail As System.Windows.Forms.Label
    Friend WithEvents lblRole As System.Windows.Forms.Label
    Friend WithEvents btnUpdateUserGriedView As System.Windows.Forms.Button
    Friend WithEvents btnRemoveUserFromDataBase As System.Windows.Forms.Button
    Friend WithEvents btnEditUser As System.Windows.Forms.Button
    Friend WithEvents lblUserGridViewTittle As System.Windows.Forms.Label
    Friend WithEvents dgvUsers As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MANAGEMENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HolidaysToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HolidaysResquestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersHolidaysToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAddUser As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ProyectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditCategoriesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTimeRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewUserRegistrationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
