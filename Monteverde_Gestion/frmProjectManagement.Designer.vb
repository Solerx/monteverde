<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectManagement
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
        Me.cbxProjectsStatus = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblProjectId = New System.Windows.Forms.Label()
        Me.lblEditingUser = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblProjectStatus = New System.Windows.Forms.Label()
        Me.lblProjectHours = New System.Windows.Forms.Label()
        Me.txtProjectHours = New System.Windows.Forms.MaskedTextBox()
        Me.lblProjectEnterprise = New System.Windows.Forms.Label()
        Me.lblProjectName = New System.Windows.Forms.Label()
        Me.txtProjectEnterprise = New System.Windows.Forms.MaskedTextBox()
        Me.txtProjectName = New System.Windows.Forms.MaskedTextBox()
        Me.btnEditProject = New System.Windows.Forms.Button()
        Me.btnRemoveProject = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAddProject = New System.Windows.Forms.Button()
        Me.dgvProjects = New System.Windows.Forms.DataGridView()
        Me.txtProjectContactInfo = New System.Windows.Forms.MaskedTextBox()
        Me.lblProjectInfo = New System.Windows.Forms.Label()
        CType(Me.dgvProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxProjectsStatus
        '
        Me.cbxProjectsStatus.BackColor = System.Drawing.Color.Maroon
        Me.cbxProjectsStatus.FormattingEnabled = True
        Me.cbxProjectsStatus.Location = New System.Drawing.Point(594, 397)
        Me.cbxProjectsStatus.Name = "cbxProjectsStatus"
        Me.cbxProjectsStatus.Size = New System.Drawing.Size(178, 21)
        Me.cbxProjectsStatus.TabIndex = 77
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnAdd.FlatAppearance.BorderSize = 2
        Me.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.Maroon
        Me.btnAdd.Location = New System.Drawing.Point(315, 504)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(149, 45)
        Me.btnAdd.TabIndex = 76
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblProjectId
        '
        Me.lblProjectId.AutoSize = True
        Me.lblProjectId.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectId.ForeColor = System.Drawing.Color.Maroon
        Me.lblProjectId.Location = New System.Drawing.Point(297, 306)
        Me.lblProjectId.Name = "lblProjectId"
        Me.lblProjectId.Size = New System.Drawing.Size(130, 29)
        Me.lblProjectId.TabIndex = 75
        Me.lblProjectId.Text = "id_project"
        '
        'lblEditingUser
        '
        Me.lblEditingUser.AutoSize = True
        Me.lblEditingUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditingUser.ForeColor = System.Drawing.Color.Maroon
        Me.lblEditingUser.Location = New System.Drawing.Point(299, 290)
        Me.lblEditingUser.Name = "lblEditingUser"
        Me.lblEditingUser.Size = New System.Drawing.Size(104, 15)
        Me.lblEditingUser.TabIndex = 74
        Me.lblEditingUser.Text = "Editing Project ID:"
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
        Me.btnSave.Location = New System.Drawing.Point(315, 504)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(149, 45)
        Me.btnSave.TabIndex = 73
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblProjectStatus
        '
        Me.lblProjectStatus.AutoSize = True
        Me.lblProjectStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectStatus.ForeColor = System.Drawing.Color.Maroon
        Me.lblProjectStatus.Location = New System.Drawing.Point(591, 378)
        Me.lblProjectStatus.Name = "lblProjectStatus"
        Me.lblProjectStatus.Size = New System.Drawing.Size(51, 16)
        Me.lblProjectStatus.TabIndex = 66
        Me.lblProjectStatus.Text = "Status: "
        '
        'lblProjectHours
        '
        Me.lblProjectHours.AutoSize = True
        Me.lblProjectHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectHours.ForeColor = System.Drawing.Color.Maroon
        Me.lblProjectHours.Location = New System.Drawing.Point(299, 379)
        Me.lblProjectHours.Name = "lblProjectHours"
        Me.lblProjectHours.Size = New System.Drawing.Size(108, 16)
        Me.lblProjectHours.TabIndex = 64
        Me.lblProjectHours.Text = "Hours to Assign: "
        '
        'txtProjectHours
        '
        Me.txtProjectHours.BackColor = System.Drawing.Color.Maroon
        Me.txtProjectHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProjectHours.ForeColor = System.Drawing.Color.White
        Me.txtProjectHours.Location = New System.Drawing.Point(302, 398)
        Me.txtProjectHours.Name = "txtProjectHours"
        Me.txtProjectHours.Size = New System.Drawing.Size(265, 20)
        Me.txtProjectHours.TabIndex = 63
        '
        'lblProjectEnterprise
        '
        Me.lblProjectEnterprise.AutoSize = True
        Me.lblProjectEnterprise.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectEnterprise.ForeColor = System.Drawing.Color.Maroon
        Me.lblProjectEnterprise.Location = New System.Drawing.Point(10, 432)
        Me.lblProjectEnterprise.Name = "lblProjectEnterprise"
        Me.lblProjectEnterprise.Size = New System.Drawing.Size(121, 16)
        Me.lblProjectEnterprise.TabIndex = 62
        Me.lblProjectEnterprise.Text = "Enterprise: (Owner)"
        '
        'lblProjectName
        '
        Me.lblProjectName.AutoSize = True
        Me.lblProjectName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectName.ForeColor = System.Drawing.Color.Maroon
        Me.lblProjectName.Location = New System.Drawing.Point(10, 379)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(96, 16)
        Me.lblProjectName.TabIndex = 61
        Me.lblProjectName.Text = "Project Name: "
        '
        'txtProjectEnterprise
        '
        Me.txtProjectEnterprise.BackColor = System.Drawing.Color.Maroon
        Me.txtProjectEnterprise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProjectEnterprise.ForeColor = System.Drawing.Color.White
        Me.txtProjectEnterprise.Location = New System.Drawing.Point(13, 451)
        Me.txtProjectEnterprise.Name = "txtProjectEnterprise"
        Me.txtProjectEnterprise.Size = New System.Drawing.Size(265, 20)
        Me.txtProjectEnterprise.TabIndex = 60
        '
        'txtProjectName
        '
        Me.txtProjectName.BackColor = System.Drawing.Color.Maroon
        Me.txtProjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProjectName.ForeColor = System.Drawing.Color.White
        Me.txtProjectName.Location = New System.Drawing.Point(13, 398)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(265, 20)
        Me.txtProjectName.TabIndex = 59
        '
        'btnEditProject
        '
        Me.btnEditProject.BackColor = System.Drawing.Color.White
        Me.btnEditProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEditProject.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnEditProject.FlatAppearance.BorderSize = 2
        Me.btnEditProject.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnEditProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnEditProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnEditProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditProject.ForeColor = System.Drawing.Color.Maroon
        Me.btnEditProject.Location = New System.Drawing.Point(157, 290)
        Me.btnEditProject.Name = "btnEditProject"
        Me.btnEditProject.Size = New System.Drawing.Size(121, 45)
        Me.btnEditProject.TabIndex = 56
        Me.btnEditProject.Text = "Edit Selected Project"
        Me.btnEditProject.UseVisualStyleBackColor = False
        '
        'btnRemoveProject
        '
        Me.btnRemoveProject.BackColor = System.Drawing.Color.White
        Me.btnRemoveProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRemoveProject.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnRemoveProject.FlatAppearance.BorderSize = 2
        Me.btnRemoveProject.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnRemoveProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnRemoveProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnRemoveProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveProject.ForeColor = System.Drawing.Color.Maroon
        Me.btnRemoveProject.Location = New System.Drawing.Point(594, 290)
        Me.btnRemoveProject.Name = "btnRemoveProject"
        Me.btnRemoveProject.Size = New System.Drawing.Size(178, 45)
        Me.btnRemoveProject.TabIndex = 57
        Me.btnRemoveProject.Text = "Remove Selected Project"
        Me.btnRemoveProject.UseVisualStyleBackColor = False
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
        Me.btnBack.TabIndex = 58
        Me.btnBack.Text = "Back to Main Menu"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnAddProject
        '
        Me.btnAddProject.BackColor = System.Drawing.Color.White
        Me.btnAddProject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddProject.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnAddProject.FlatAppearance.BorderSize = 2
        Me.btnAddProject.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnAddProject.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnAddProject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnAddProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProject.ForeColor = System.Drawing.Color.Maroon
        Me.btnAddProject.Location = New System.Drawing.Point(12, 290)
        Me.btnAddProject.Name = "btnAddProject"
        Me.btnAddProject.Size = New System.Drawing.Size(121, 45)
        Me.btnAddProject.TabIndex = 55
        Me.btnAddProject.Text = "Add New Project"
        Me.btnAddProject.UseVisualStyleBackColor = False
        '
        'dgvProjects
        '
        Me.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjects.Location = New System.Drawing.Point(12, 63)
        Me.dgvProjects.Name = "dgvProjects"
        Me.dgvProjects.Size = New System.Drawing.Size(760, 221)
        Me.dgvProjects.TabIndex = 54
        '
        'txtProjectContactInfo
        '
        Me.txtProjectContactInfo.BackColor = System.Drawing.Color.Maroon
        Me.txtProjectContactInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProjectContactInfo.ForeColor = System.Drawing.Color.White
        Me.txtProjectContactInfo.Location = New System.Drawing.Point(302, 451)
        Me.txtProjectContactInfo.Name = "txtProjectContactInfo"
        Me.txtProjectContactInfo.Size = New System.Drawing.Size(265, 20)
        Me.txtProjectContactInfo.TabIndex = 63
        '
        'lblProjectInfo
        '
        Me.lblProjectInfo.AutoSize = True
        Me.lblProjectInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectInfo.ForeColor = System.Drawing.Color.Maroon
        Me.lblProjectInfo.Location = New System.Drawing.Point(299, 432)
        Me.lblProjectInfo.Name = "lblProjectInfo"
        Me.lblProjectInfo.Size = New System.Drawing.Size(124, 16)
        Me.lblProjectInfo.TabIndex = 64
        Me.lblProjectInfo.Text = "Contact Information:"
        '
        'frmProjectManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.cbxProjectsStatus)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblProjectId)
        Me.Controls.Add(Me.lblEditingUser)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblProjectStatus)
        Me.Controls.Add(Me.lblProjectInfo)
        Me.Controls.Add(Me.lblProjectHours)
        Me.Controls.Add(Me.txtProjectContactInfo)
        Me.Controls.Add(Me.txtProjectHours)
        Me.Controls.Add(Me.lblProjectEnterprise)
        Me.Controls.Add(Me.lblProjectName)
        Me.Controls.Add(Me.txtProjectEnterprise)
        Me.Controls.Add(Me.txtProjectName)
        Me.Controls.Add(Me.btnEditProject)
        Me.Controls.Add(Me.btnRemoveProject)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAddProject)
        Me.Controls.Add(Me.dgvProjects)
        Me.Name = "frmProjectManagement"
        Me.Text = "Projects Management"
        CType(Me.dgvProjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxProjectsStatus As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblProjectId As System.Windows.Forms.Label
    Friend WithEvents lblEditingUser As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblProjectStatus As System.Windows.Forms.Label
    Friend WithEvents lblProjectHours As System.Windows.Forms.Label
    Friend WithEvents txtProjectHours As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblProjectEnterprise As System.Windows.Forms.Label
    Friend WithEvents lblProjectName As System.Windows.Forms.Label
    Friend WithEvents txtProjectEnterprise As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtProjectName As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnEditProject As System.Windows.Forms.Button
    Friend WithEvents btnRemoveProject As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnAddProject As System.Windows.Forms.Button
    Friend WithEvents dgvProjects As System.Windows.Forms.DataGridView
    Friend WithEvents txtProjectContactInfo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblProjectInfo As System.Windows.Forms.Label
End Class
