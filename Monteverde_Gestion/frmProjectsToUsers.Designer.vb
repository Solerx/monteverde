<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProjectsToUsers
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
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvAssignedProjects = New System.Windows.Forms.DataGridView()
        Me.lblUsers = New System.Windows.Forms.Label()
        Me.lblAssignedProjects = New System.Windows.Forms.Label()
        Me.btnRemoveProject = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblProjectToAdd = New System.Windows.Forms.Label()
        Me.dgvProjects = New System.Windows.Forms.DataGridView()
        Me.btnAddProjectToUser = New System.Windows.Forms.Button()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAssignedProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUsers
        '
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(12, 120)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.Size = New System.Drawing.Size(356, 181)
        Me.dgvUsers.TabIndex = 0
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
        Me.btnBack.TabIndex = 30
        Me.btnBack.Text = "Back to Main Menu"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'dgvAssignedProjects
        '
        Me.dgvAssignedProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssignedProjects.Location = New System.Drawing.Point(386, 120)
        Me.dgvAssignedProjects.Name = "dgvAssignedProjects"
        Me.dgvAssignedProjects.Size = New System.Drawing.Size(286, 181)
        Me.dgvAssignedProjects.TabIndex = 31
        '
        'lblUsers
        '
        Me.lblUsers.AutoSize = True
        Me.lblUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsers.ForeColor = System.Drawing.Color.Maroon
        Me.lblUsers.Location = New System.Drawing.Point(12, 86)
        Me.lblUsers.Name = "lblUsers"
        Me.lblUsers.Size = New System.Drawing.Size(91, 31)
        Me.lblUsers.TabIndex = 32
        Me.lblUsers.Text = "Users"
        Me.lblUsers.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAssignedProjects
        '
        Me.lblAssignedProjects.AutoSize = True
        Me.lblAssignedProjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssignedProjects.ForeColor = System.Drawing.Color.Maroon
        Me.lblAssignedProjects.Location = New System.Drawing.Point(383, 97)
        Me.lblAssignedProjects.Name = "lblAssignedProjects"
        Me.lblAssignedProjects.Size = New System.Drawing.Size(226, 18)
        Me.lblAssignedProjects.TabIndex = 34
        Me.lblAssignedProjects.Text = "User Currently Assigned Projects"
        Me.lblAssignedProjects.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnRemoveProject
        '
        Me.btnRemoveProject.BackColor = System.Drawing.Color.White
        Me.btnRemoveProject.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnRemoveProject.FlatAppearance.BorderSize = 2
        Me.btnRemoveProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveProject.ForeColor = System.Drawing.Color.Maroon
        Me.btnRemoveProject.Location = New System.Drawing.Point(678, 256)
        Me.btnRemoveProject.Name = "btnRemoveProject"
        Me.btnRemoveProject.Size = New System.Drawing.Size(97, 45)
        Me.btnRemoveProject.TabIndex = 37
        Me.btnRemoveProject.Text = "Remove Project From User"
        Me.btnRemoveProject.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.Location = New System.Drawing.Point(678, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 45)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Edit Project Work Time"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblProjectToAdd
        '
        Me.lblProjectToAdd.AutoSize = True
        Me.lblProjectToAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectToAdd.ForeColor = System.Drawing.Color.Maroon
        Me.lblProjectToAdd.Location = New System.Drawing.Point(12, 334)
        Me.lblProjectToAdd.Name = "lblProjectToAdd"
        Me.lblProjectToAdd.Size = New System.Drawing.Size(215, 31)
        Me.lblProjectToAdd.TabIndex = 41
        Me.lblProjectToAdd.Text = "Project to Add: "
        Me.lblProjectToAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgvProjects
        '
        Me.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjects.Location = New System.Drawing.Point(12, 368)
        Me.dgvProjects.Name = "dgvProjects"
        Me.dgvProjects.Size = New System.Drawing.Size(356, 181)
        Me.dgvProjects.TabIndex = 42
        '
        'btnAddProjectToUser
        '
        Me.btnAddProjectToUser.BackColor = System.Drawing.Color.White
        Me.btnAddProjectToUser.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnAddProjectToUser.FlatAppearance.BorderSize = 2
        Me.btnAddProjectToUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProjectToUser.ForeColor = System.Drawing.Color.Maroon
        Me.btnAddProjectToUser.Location = New System.Drawing.Point(460, 411)
        Me.btnAddProjectToUser.Name = "btnAddProjectToUser"
        Me.btnAddProjectToUser.Size = New System.Drawing.Size(232, 89)
        Me.btnAddProjectToUser.TabIndex = 43
        Me.btnAddProjectToUser.Text = "Add Project to Selected User"
        Me.btnAddProjectToUser.UseVisualStyleBackColor = False
        '
        'frmProjectsToUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btnAddProjectToUser)
        Me.Controls.Add(Me.dgvProjects)
        Me.Controls.Add(Me.lblProjectToAdd)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRemoveProject)
        Me.Controls.Add(Me.lblAssignedProjects)
        Me.Controls.Add(Me.lblUsers)
        Me.Controls.Add(Me.dgvAssignedProjects)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvUsers)
        Me.Name = "frmProjectsToUsers"
        Me.Text = "Assign Projects to Users"
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAssignedProjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvUsers As System.Windows.Forms.DataGridView
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents dgvAssignedProjects As System.Windows.Forms.DataGridView
    Friend WithEvents lblUsers As System.Windows.Forms.Label
    Friend WithEvents lblAssignedProjects As System.Windows.Forms.Label
    Friend WithEvents btnRemoveProject As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblProjectToAdd As System.Windows.Forms.Label
    Friend WithEvents dgvProjects As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddProjectToUser As System.Windows.Forms.Button
End Class
