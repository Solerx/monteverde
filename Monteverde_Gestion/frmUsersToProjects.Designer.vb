<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserToProjects
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
        Me.lblProjectAssignedUsers = New System.Windows.Forms.Label()
        Me.dgvAssignedUsers = New System.Windows.Forms.DataGridView()
        Me.lblProjects = New System.Windows.Forms.Label()
        Me.dgvProjects = New System.Windows.Forms.DataGridView()
        Me.dgvUsers = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAddUserToProject = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnRemoveProject = New System.Windows.Forms.Button()
        Me.lblProjectToAdd = New System.Windows.Forms.Label()
        CType(Me.dgvAssignedUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProjectAssignedUsers
        '
        Me.lblProjectAssignedUsers.AutoSize = True
        Me.lblProjectAssignedUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectAssignedUsers.ForeColor = System.Drawing.Color.Maroon
        Me.lblProjectAssignedUsers.Location = New System.Drawing.Point(444, 97)
        Me.lblProjectAssignedUsers.Name = "lblProjectAssignedUsers"
        Me.lblProjectAssignedUsers.Size = New System.Drawing.Size(226, 18)
        Me.lblProjectAssignedUsers.TabIndex = 44
        Me.lblProjectAssignedUsers.Text = "Project Currently Assigned Users"
        Me.lblProjectAssignedUsers.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgvAssignedUsers
        '
        Me.dgvAssignedUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssignedUsers.Location = New System.Drawing.Point(439, 124)
        Me.dgvAssignedUsers.Name = "dgvAssignedUsers"
        Me.dgvAssignedUsers.Size = New System.Drawing.Size(232, 181)
        Me.dgvAssignedUsers.TabIndex = 43
        '
        'lblProjects
        '
        Me.lblProjects.AutoSize = True
        Me.lblProjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjects.ForeColor = System.Drawing.Color.Maroon
        Me.lblProjects.Location = New System.Drawing.Point(12, 90)
        Me.lblProjects.Name = "lblProjects"
        Me.lblProjects.Size = New System.Drawing.Size(121, 31)
        Me.lblProjects.TabIndex = 41
        Me.lblProjects.Text = "Projects"
        Me.lblProjects.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgvProjects
        '
        Me.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjects.Location = New System.Drawing.Point(12, 124)
        Me.dgvProjects.Name = "dgvProjects"
        Me.dgvProjects.Size = New System.Drawing.Size(356, 181)
        Me.dgvProjects.TabIndex = 40
        '
        'dgvUsers
        '
        Me.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsers.Location = New System.Drawing.Point(12, 368)
        Me.dgvUsers.Name = "dgvUsers"
        Me.dgvUsers.Size = New System.Drawing.Size(356, 181)
        Me.dgvUsers.TabIndex = 45
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
        Me.btnBack.TabIndex = 46
        Me.btnBack.Text = "Back to Main Menu"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnAddUserToProject
        '
        Me.btnAddUserToProject.BackColor = System.Drawing.Color.White
        Me.btnAddUserToProject.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnAddUserToProject.FlatAppearance.BorderSize = 2
        Me.btnAddUserToProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUserToProject.ForeColor = System.Drawing.Color.Maroon
        Me.btnAddUserToProject.Location = New System.Drawing.Point(462, 407)
        Me.btnAddUserToProject.Name = "btnAddUserToProject"
        Me.btnAddUserToProject.Size = New System.Drawing.Size(232, 89)
        Me.btnAddUserToProject.TabIndex = 49
        Me.btnAddUserToProject.Text = "Add User to Selected Project"
        Me.btnAddUserToProject.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Maroon
        Me.Button2.Location = New System.Drawing.Point(677, 124)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 45)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "Edit User Work Time"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnRemoveProject
        '
        Me.btnRemoveProject.BackColor = System.Drawing.Color.White
        Me.btnRemoveProject.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnRemoveProject.FlatAppearance.BorderSize = 2
        Me.btnRemoveProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveProject.ForeColor = System.Drawing.Color.Maroon
        Me.btnRemoveProject.Location = New System.Drawing.Point(677, 260)
        Me.btnRemoveProject.Name = "btnRemoveProject"
        Me.btnRemoveProject.Size = New System.Drawing.Size(97, 45)
        Me.btnRemoveProject.TabIndex = 47
        Me.btnRemoveProject.Text = "Remove User From Project"
        Me.btnRemoveProject.UseVisualStyleBackColor = False
        '
        'lblProjectToAdd
        '
        Me.lblProjectToAdd.AutoSize = True
        Me.lblProjectToAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectToAdd.ForeColor = System.Drawing.Color.Maroon
        Me.lblProjectToAdd.Location = New System.Drawing.Point(12, 334)
        Me.lblProjectToAdd.Name = "lblProjectToAdd"
        Me.lblProjectToAdd.Size = New System.Drawing.Size(185, 31)
        Me.lblProjectToAdd.TabIndex = 50
        Me.lblProjectToAdd.Text = "User to Add: "
        Me.lblProjectToAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmUserToProjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lblProjectToAdd)
        Me.Controls.Add(Me.btnAddUserToProject)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnRemoveProject)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvUsers)
        Me.Controls.Add(Me.lblProjectAssignedUsers)
        Me.Controls.Add(Me.dgvAssignedUsers)
        Me.Controls.Add(Me.lblProjects)
        Me.Controls.Add(Me.dgvProjects)
        Me.Name = "frmUserToProjects"
        Me.Text = "Assign Users to Projects"
        CType(Me.dgvAssignedUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProjectAssignedUsers As System.Windows.Forms.Label
    Friend WithEvents dgvAssignedUsers As System.Windows.Forms.DataGridView
    Friend WithEvents lblProjects As System.Windows.Forms.Label
    Friend WithEvents dgvProjects As System.Windows.Forms.DataGridView
    Friend WithEvents dgvUsers As System.Windows.Forms.DataGridView
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnAddUserToProject As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnRemoveProject As System.Windows.Forms.Button
    Friend WithEvents lblProjectToAdd As System.Windows.Forms.Label
End Class
