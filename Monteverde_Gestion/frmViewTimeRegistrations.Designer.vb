<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewTimeRegistrations
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
        Me.dgvWorkedTime = New System.Windows.Forms.DataGridView()
        Me.cbxUsers = New System.Windows.Forms.ComboBox()
        Me.lblUsers = New System.Windows.Forms.Label()
        Me.cbxProject = New System.Windows.Forms.ComboBox()
        Me.lblProjects = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cbxWorkCategories = New System.Windows.Forms.ComboBox()
        Me.lblWorkCategory = New System.Windows.Forms.Label()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnResetFilter = New System.Windows.Forms.Button()
        Me.lblFilters = New System.Windows.Forms.Label()
        CType(Me.dgvWorkedTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvWorkedTime
        '
        Me.dgvWorkedTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWorkedTime.Location = New System.Drawing.Point(12, 249)
        Me.dgvWorkedTime.Name = "dgvWorkedTime"
        Me.dgvWorkedTime.Size = New System.Drawing.Size(760, 300)
        Me.dgvWorkedTime.TabIndex = 55
        '
        'cbxUsers
        '
        Me.cbxUsers.BackColor = System.Drawing.Color.Maroon
        Me.cbxUsers.ForeColor = System.Drawing.Color.White
        Me.cbxUsers.FormattingEnabled = True
        Me.cbxUsers.Location = New System.Drawing.Point(12, 151)
        Me.cbxUsers.Name = "cbxUsers"
        Me.cbxUsers.Size = New System.Drawing.Size(178, 21)
        Me.cbxUsers.TabIndex = 79
        Me.cbxUsers.Text = " All"
        '
        'lblUsers
        '
        Me.lblUsers.AutoSize = True
        Me.lblUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsers.ForeColor = System.Drawing.Color.Maroon
        Me.lblUsers.Location = New System.Drawing.Point(9, 132)
        Me.lblUsers.Name = "lblUsers"
        Me.lblUsers.Size = New System.Drawing.Size(40, 16)
        Me.lblUsers.TabIndex = 78
        Me.lblUsers.Text = "User:"
        '
        'cbxProject
        '
        Me.cbxProject.BackColor = System.Drawing.Color.Maroon
        Me.cbxProject.ForeColor = System.Drawing.Color.White
        Me.cbxProject.FormattingEnabled = True
        Me.cbxProject.Location = New System.Drawing.Point(302, 151)
        Me.cbxProject.Name = "cbxProject"
        Me.cbxProject.Size = New System.Drawing.Size(178, 21)
        Me.cbxProject.TabIndex = 81
        Me.cbxProject.Text = " All"
        '
        'lblProjects
        '
        Me.lblProjects.AutoSize = True
        Me.lblProjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjects.ForeColor = System.Drawing.Color.Maroon
        Me.lblProjects.Location = New System.Drawing.Point(299, 132)
        Me.lblProjects.Name = "lblProjects"
        Me.lblProjects.Size = New System.Drawing.Size(56, 16)
        Me.lblProjects.TabIndex = 80
        Me.lblProjects.Text = "Project: "
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
        Me.btnBack.TabIndex = 82
        Me.btnBack.Text = "Back to Main Menu"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'cbxWorkCategories
        '
        Me.cbxWorkCategories.BackColor = System.Drawing.Color.Maroon
        Me.cbxWorkCategories.ForeColor = System.Drawing.Color.White
        Me.cbxWorkCategories.FormattingEnabled = True
        Me.cbxWorkCategories.Location = New System.Drawing.Point(594, 151)
        Me.cbxWorkCategories.Name = "cbxWorkCategories"
        Me.cbxWorkCategories.Size = New System.Drawing.Size(178, 21)
        Me.cbxWorkCategories.TabIndex = 84
        Me.cbxWorkCategories.Text = " All"
        '
        'lblWorkCategory
        '
        Me.lblWorkCategory.AutoSize = True
        Me.lblWorkCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkCategory.ForeColor = System.Drawing.Color.Maroon
        Me.lblWorkCategory.Location = New System.Drawing.Point(591, 132)
        Me.lblWorkCategory.Name = "lblWorkCategory"
        Me.lblWorkCategory.Size = New System.Drawing.Size(104, 16)
        Me.lblWorkCategory.TabIndex = 83
        Me.lblWorkCategory.Text = "Work Category: "
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.White
        Me.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnFilter.FlatAppearance.BorderSize = 2
        Me.btnFilter.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFilter.ForeColor = System.Drawing.Color.Maroon
        Me.btnFilter.Location = New System.Drawing.Point(12, 198)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(149, 45)
        Me.btnFilter.TabIndex = 85
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'btnResetFilter
        '
        Me.btnResetFilter.BackColor = System.Drawing.Color.White
        Me.btnResetFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnResetFilter.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnResetFilter.FlatAppearance.BorderSize = 2
        Me.btnResetFilter.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnResetFilter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnResetFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnResetFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResetFilter.ForeColor = System.Drawing.Color.Maroon
        Me.btnResetFilter.Location = New System.Drawing.Point(623, 198)
        Me.btnResetFilter.Name = "btnResetFilter"
        Me.btnResetFilter.Size = New System.Drawing.Size(149, 45)
        Me.btnResetFilter.TabIndex = 86
        Me.btnResetFilter.Text = "Reset Filter"
        Me.btnResetFilter.UseVisualStyleBackColor = False
        '
        'lblFilters
        '
        Me.lblFilters.AutoSize = True
        Me.lblFilters.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilters.ForeColor = System.Drawing.Color.Maroon
        Me.lblFilters.Location = New System.Drawing.Point(316, 79)
        Me.lblFilters.Name = "lblFilters"
        Me.lblFilters.Size = New System.Drawing.Size(129, 31)
        Me.lblFilters.TabIndex = 87
        Me.lblFilters.Text = "Filter by:"
        Me.lblFilters.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmViewTimeRegistrations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lblFilters)
        Me.Controls.Add(Me.btnResetFilter)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.cbxWorkCategories)
        Me.Controls.Add(Me.lblWorkCategory)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.cbxProject)
        Me.Controls.Add(Me.lblProjects)
        Me.Controls.Add(Me.cbxUsers)
        Me.Controls.Add(Me.lblUsers)
        Me.Controls.Add(Me.dgvWorkedTime)
        Me.Name = "frmViewTimeRegistrations"
        Me.Text = "View Users Time Registrations"
        CType(Me.dgvWorkedTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvWorkedTime As System.Windows.Forms.DataGridView
    Friend WithEvents cbxUsers As System.Windows.Forms.ComboBox
    Friend WithEvents lblUsers As System.Windows.Forms.Label
    Friend WithEvents cbxProject As System.Windows.Forms.ComboBox
    Friend WithEvents lblProjects As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents cbxWorkCategories As System.Windows.Forms.ComboBox
    Friend WithEvents lblWorkCategory As System.Windows.Forms.Label
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents btnResetFilter As System.Windows.Forms.Button
    Friend WithEvents lblFilters As System.Windows.Forms.Label
End Class
