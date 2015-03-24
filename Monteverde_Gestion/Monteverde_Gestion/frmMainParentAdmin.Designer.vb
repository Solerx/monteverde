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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MANAGEMENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProyectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditCategoriesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTimeRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewUserRegistrationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HolidaysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HolidaysResquestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersHolidaysToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblWelcomeTittle = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSignOut
        '
        Me.btnSignOut.Location = New System.Drawing.Point(683, 54)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(89, 38)
        Me.btnSignOut.TabIndex = 19
        Me.btnSignOut.Text = "Cerrar Sesión"
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'lblUserEmail
        '
        Me.lblUserEmail.AutoSize = True
        Me.lblUserEmail.Location = New System.Drawing.Point(279, 207)
        Me.lblUserEmail.Name = "lblUserEmail"
        Me.lblUserEmail.Size = New System.Drawing.Size(57, 13)
        Me.lblUserEmail.TabIndex = 20
        Me.lblUserEmail.Text = "UserName"
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(280, 231)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(56, 13)
        Me.lblRole.TabIndex = 22
        Me.lblRole.Text = "role_name"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MANAGEMENTToolStripMenuItem, Me.ProjectToolStripMenuItem, Me.HolidaysToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(624, 24)
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
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.UserToolStripMenuItem.Text = "Users"
        '
        'ProyectsToolStripMenuItem
        '
        Me.ProyectsToolStripMenuItem.Name = "ProyectsToolStripMenuItem"
        Me.ProyectsToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ProyectsToolStripMenuItem.Text = "Projects"
        '
        'EditCategoriesToolStripMenuItem1
        '
        Me.EditCategoriesToolStripMenuItem1.Name = "EditCategoriesToolStripMenuItem1"
        Me.EditCategoriesToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.EditCategoriesToolStripMenuItem1.Text = "Categories"
        '
        'ProjectToolStripMenuItem
        '
        Me.ProjectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTimeRegistrationToolStripMenuItem, Me.ViewUserRegistrationsToolStripMenuItem})
        Me.ProjectToolStripMenuItem.Name = "ProjectToolStripMenuItem"
        Me.ProjectToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.ProjectToolStripMenuItem.Text = "Time registration"
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
        'lblWelcomeTittle
        '
        Me.lblWelcomeTittle.AutoSize = True
        Me.lblWelcomeTittle.Location = New System.Drawing.Point(279, 181)
        Me.lblWelcomeTittle.Name = "lblWelcomeTittle"
        Me.lblWelcomeTittle.Size = New System.Drawing.Size(65, 13)
        Me.lblWelcomeTittle.TabIndex = 37
        Me.lblWelcomeTittle.Text = "WELCOME!"
        '
        'frmMainParentAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.lblWelcomeTittle)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.btnSignOut)
        Me.Controls.Add(Me.lblUserEmail)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMainParentAdmin"
        Me.Text = "Proyect Management"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSignOut As System.Windows.Forms.Button
    Friend WithEvents lblUserEmail As System.Windows.Forms.Label
    Friend WithEvents lblRole As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MANAGEMENTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HolidaysToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HolidaysResquestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersHolidaysToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProyectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditCategoriesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTimeRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewUserRegistrationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblWelcomeTittle As System.Windows.Forms.Label
End Class
