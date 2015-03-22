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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainParentAdmin))
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbpUserInfo = New System.Windows.Forms.TabPage()
        Me.tbpUsers = New System.Windows.Forms.TabPage()
        Me.btnUpdateUserGriedView = New System.Windows.Forms.Button()
        Me.btnRemoveUserFromDataBase = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.lblUserSelectedFromUserGridView = New System.Windows.Forms.Label()
        Me.btnRemoveProyectFromUser = New System.Windows.Forms.Button()
        Me.btnAssignProyectToUser = New System.Windows.Forms.Button()
        Me.lblProyectsGridViewTittle = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dgvUserProyects = New System.Windows.Forms.DataGridView()
        Me.lblUserProyectsGridViewTittle = New System.Windows.Forms.Label()
        Me.lblUserGridViewTittle = New System.Windows.Forms.Label()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.tbpProyects = New System.Windows.Forms.TabPage()
        Me.tbpCalendar = New System.Windows.Forms.TabPage()
        Me.tbpReports = New System.Windows.Forms.TabPage()
        Me.lblUserEmail = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tbpUsers.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUserProyects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSignOut
        '
        Me.btnSignOut.Location = New System.Drawing.Point(657, 104)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(115, 34)
        Me.btnSignOut.TabIndex = 19
        Me.btnSignOut.Text = "Cerrar Sesión"
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.tbpUserInfo)
        Me.TabControl1.Controls.Add(Me.tbpUsers)
        Me.TabControl1.Controls.Add(Me.tbpProyects)
        Me.TabControl1.Controls.Add(Me.tbpCalendar)
        Me.TabControl1.Controls.Add(Me.tbpReports)
        Me.TabControl1.Location = New System.Drawing.Point(1, 122)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(784, 435)
        Me.TabControl1.TabIndex = 21
        '
        'tbpUserInfo
        '
        Me.tbpUserInfo.Location = New System.Drawing.Point(4, 25)
        Me.tbpUserInfo.Name = "tbpUserInfo"
        Me.tbpUserInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpUserInfo.Size = New System.Drawing.Size(776, 406)
        Me.tbpUserInfo.TabIndex = 0
        Me.tbpUserInfo.Text = "Perfil de usuario"
        Me.tbpUserInfo.UseVisualStyleBackColor = True
        '
        'tbpUsers
        '
        Me.tbpUsers.Controls.Add(Me.btnUpdateUserGriedView)
        Me.tbpUsers.Controls.Add(Me.btnRemoveUserFromDataBase)
        Me.tbpUsers.Controls.Add(Me.Button2)
        Me.tbpUsers.Controls.Add(Me.btnAddUser)
        Me.tbpUsers.Controls.Add(Me.lblUserSelectedFromUserGridView)
        Me.tbpUsers.Controls.Add(Me.btnRemoveProyectFromUser)
        Me.tbpUsers.Controls.Add(Me.btnAssignProyectToUser)
        Me.tbpUsers.Controls.Add(Me.lblProyectsGridViewTittle)
        Me.tbpUsers.Controls.Add(Me.DataGridView1)
        Me.tbpUsers.Controls.Add(Me.dgvUserProyects)
        Me.tbpUsers.Controls.Add(Me.lblUserProyectsGridViewTittle)
        Me.tbpUsers.Controls.Add(Me.lblUserGridViewTittle)
        Me.tbpUsers.Controls.Add(Me.dgvUsers)
        Me.tbpUsers.Location = New System.Drawing.Point(4, 25)
        Me.tbpUsers.Name = "tbpUsers"
        Me.tbpUsers.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpUsers.Size = New System.Drawing.Size(776, 406)
        Me.tbpUsers.TabIndex = 1
        Me.tbpUsers.Text = "Usuario"
        Me.tbpUsers.UseVisualStyleBackColor = True
        '
        'btnUpdateUserGriedView
        '
        Me.btnUpdateUserGriedView.Location = New System.Drawing.Point(373, 205)
        Me.btnUpdateUserGriedView.Name = "btnUpdateUserGriedView"
        Me.btnUpdateUserGriedView.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateUserGriedView.TabIndex = 12
        Me.btnUpdateUserGriedView.Text = "Refrescar lista!"
        Me.btnUpdateUserGriedView.UseVisualStyleBackColor = True
        '
        'btnRemoveUserFromDataBase
        '
        Me.btnRemoveUserFromDataBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRemoveUserFromDataBase.Location = New System.Drawing.Point(454, 97)
        Me.btnRemoveUserFromDataBase.Name = "btnRemoveUserFromDataBase"
        Me.btnRemoveUserFromDataBase.Size = New System.Drawing.Size(56, 49)
        Me.btnRemoveUserFromDataBase.TabIndex = 11
        Me.btnRemoveUserFromDataBase.Text = "Eliminar usuario"
        Me.btnRemoveUserFromDataBase.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Location = New System.Drawing.Point(454, 152)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 47)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Editar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnAddUser
        '
        Me.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddUser.Location = New System.Drawing.Point(454, 41)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(56, 50)
        Me.btnAddUser.TabIndex = 9
        Me.btnAddUser.Text = "Agregar usuario"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'lblUserSelectedFromUserGridView
        '
        Me.lblUserSelectedFromUserGridView.AutoSize = True
        Me.lblUserSelectedFromUserGridView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserSelectedFromUserGridView.Location = New System.Drawing.Point(181, 216)
        Me.lblUserSelectedFromUserGridView.Name = "lblUserSelectedFromUserGridView"
        Me.lblUserSelectedFromUserGridView.Size = New System.Drawing.Size(62, 16)
        Me.lblUserSelectedFromUserGridView.TabIndex = 8
        Me.lblUserSelectedFromUserGridView.Text = "Usuario"
        '
        'btnRemoveProyectFromUser
        '
        Me.btnRemoveProyectFromUser.Location = New System.Drawing.Point(16, 380)
        Me.btnRemoveProyectFromUser.Name = "btnRemoveProyectFromUser"
        Me.btnRemoveProyectFromUser.Size = New System.Drawing.Size(167, 23)
        Me.btnRemoveProyectFromUser.TabIndex = 7
        Me.btnRemoveProyectFromUser.Text = "Remover proyecto del usuario"
        Me.btnRemoveProyectFromUser.UseVisualStyleBackColor = True
        '
        'btnAssignProyectToUser
        '
        Me.btnAssignProyectToUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAssignProyectToUser.Location = New System.Drawing.Point(454, 313)
        Me.btnAssignProyectToUser.Name = "btnAssignProyectToUser"
        Me.btnAssignProyectToUser.Size = New System.Drawing.Size(116, 60)
        Me.btnAssignProyectToUser.TabIndex = 6
        Me.btnAssignProyectToUser.Text = "<< Asignar <<"
        Me.btnAssignProyectToUser.UseVisualStyleBackColor = True
        '
        'lblProyectsGridViewTittle
        '
        Me.lblProyectsGridViewTittle.AutoSize = True
        Me.lblProyectsGridViewTittle.Location = New System.Drawing.Point(573, 19)
        Me.lblProyectsGridViewTittle.Name = "lblProyectsGridViewTittle"
        Me.lblProyectsGridViewTittle.Size = New System.Drawing.Size(119, 13)
        Me.lblProyectsGridViewTittle.TabIndex = 5
        Me.lblProyectsGridViewTittle.Text = "Proyectos Registrados: "
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(576, 35)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(191, 357)
        Me.DataGridView1.TabIndex = 4
        '
        'dgvUserProyects
        '
        Me.dgvUserProyects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserProyects.Location = New System.Drawing.Point(16, 235)
        Me.dgvUserProyects.Name = "dgvUserProyects"
        Me.dgvUserProyects.Size = New System.Drawing.Size(432, 138)
        Me.dgvUserProyects.TabIndex = 3
        '
        'lblUserProyectsGridViewTittle
        '
        Me.lblUserProyectsGridViewTittle.AutoSize = True
        Me.lblUserProyectsGridViewTittle.Location = New System.Drawing.Point(16, 219)
        Me.lblUserProyectsGridViewTittle.Name = "lblUserProyectsGridViewTittle"
        Me.lblUserProyectsGridViewTittle.Size = New System.Drawing.Size(159, 13)
        Me.lblUserProyectsGridViewTittle.TabIndex = 2
        Me.lblUserProyectsGridViewTittle.Text = "Proyectos asignados al usuario: "
        '
        'lblUserGridViewTittle
        '
        Me.lblUserGridViewTittle.AutoSize = True
        Me.lblUserGridViewTittle.Location = New System.Drawing.Point(16, 22)
        Me.lblUserGridViewTittle.Name = "lblUserGridViewTittle"
        Me.lblUserGridViewTittle.Size = New System.Drawing.Size(108, 13)
        Me.lblUserGridViewTittle.TabIndex = 1
        Me.lblUserGridViewTittle.Text = "Usuarios registrados: "
        '
        'dgvUsers
        '
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(16, 41)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.Size = New System.Drawing.Size(432, 158)
        Me.dgvUsers.TabIndex = 0
        '
        'tbpProyects
        '
        Me.tbpProyects.Location = New System.Drawing.Point(4, 25)
        Me.tbpProyects.Name = "tbpProyects"
        Me.tbpProyects.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpProyects.Size = New System.Drawing.Size(776, 406)
        Me.tbpProyects.TabIndex = 2
        Me.tbpProyects.Text = "Proyectos"
        Me.tbpProyects.UseVisualStyleBackColor = True
        '
        'tbpCalendar
        '
        Me.tbpCalendar.Location = New System.Drawing.Point(4, 25)
        Me.tbpCalendar.Name = "tbpCalendar"
        Me.tbpCalendar.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCalendar.Size = New System.Drawing.Size(776, 406)
        Me.tbpCalendar.TabIndex = 3
        Me.tbpCalendar.Text = "Calendario"
        Me.tbpCalendar.UseVisualStyleBackColor = True
        '
        'tbpReports
        '
        Me.tbpReports.Location = New System.Drawing.Point(4, 25)
        Me.tbpReports.Name = "tbpReports"
        Me.tbpReports.Size = New System.Drawing.Size(776, 406)
        Me.tbpReports.TabIndex = 4
        Me.tbpReports.Text = "Solicitud de Reportes"
        Me.tbpReports.UseVisualStyleBackColor = True
        '
        'lblUserEmail
        '
        Me.lblUserEmail.AutoSize = True
        Me.lblUserEmail.Location = New System.Drawing.Point(133, 64)
        Me.lblUserEmail.Name = "lblUserEmail"
        Me.lblUserEmail.Size = New System.Drawing.Size(57, 13)
        Me.lblUserEmail.TabIndex = 20
        Me.lblUserEmail.Text = "UserName"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 86)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'pbLogo
        '
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(657, 12)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(115, 86)
        Me.pbLogo.TabIndex = 17
        Me.pbLogo.TabStop = False
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Location = New System.Drawing.Point(133, 86)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(70, 13)
        Me.lblRole.TabIndex = 22
        Me.lblRole.Text = "Administrador"
        '
        'frmMainParentAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.btnSignOut)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblUserEmail)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbLogo)
        Me.Name = "frmMainParentAdmin"
        Me.Text = "frmMainParentAdmin1"
        Me.TabControl1.ResumeLayout(False)
        Me.tbpUsers.ResumeLayout(False)
        Me.tbpUsers.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUserProyects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSignOut As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbpUserInfo As System.Windows.Forms.TabPage
    Friend WithEvents tbpUsers As System.Windows.Forms.TabPage
    Friend WithEvents tbpProyects As System.Windows.Forms.TabPage
    Friend WithEvents tbpCalendar As System.Windows.Forms.TabPage
    Friend WithEvents tbpReports As System.Windows.Forms.TabPage
    Friend WithEvents lblUserEmail As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents dgvUsers As System.Windows.Forms.DataGridView
    Friend WithEvents btnAssignProyectToUser As System.Windows.Forms.Button
    Friend WithEvents lblProyectsGridViewTittle As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvUserProyects As System.Windows.Forms.DataGridView
    Friend WithEvents lblUserProyectsGridViewTittle As System.Windows.Forms.Label
    Friend WithEvents lblUserGridViewTittle As System.Windows.Forms.Label
    Friend WithEvents btnRemoveProyectFromUser As System.Windows.Forms.Button
    Friend WithEvents lblUserSelectedFromUserGridView As System.Windows.Forms.Label
    Friend WithEvents btnRemoveUserFromDataBase As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnAddUser As System.Windows.Forms.Button
    Friend WithEvents btnUpdateUserGriedView As System.Windows.Forms.Button
    Friend WithEvents lblRole As System.Windows.Forms.Label
End Class
