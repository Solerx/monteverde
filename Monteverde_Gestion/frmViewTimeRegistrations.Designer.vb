﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.cbxWorkCategories = New System.Windows.Forms.ComboBox()
        Me.lblWorkCategory = New System.Windows.Forms.Label()
        Me.lblFilters = New System.Windows.Forms.Label()
        Me.lblUserWorkedHours = New System.Windows.Forms.Label()
        Me.txtUserWorkedHours = New System.Windows.Forms.MaskedTextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnResetFilter = New System.Windows.Forms.Button()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvWorkedTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvWorkedTime
        '
        Me.dgvWorkedTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvWorkedTime.Location = New System.Drawing.Point(12, 249)
        Me.dgvWorkedTime.Name = "dgvWorkedTime"
        Me.dgvWorkedTime.Size = New System.Drawing.Size(760, 249)
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
        'lblUserWorkedHours
        '
        Me.lblUserWorkedHours.AutoSize = True
        Me.lblUserWorkedHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserWorkedHours.ForeColor = System.Drawing.Color.Maroon
        Me.lblUserWorkedHours.Location = New System.Drawing.Point(177, 510)
        Me.lblUserWorkedHours.Name = "lblUserWorkedHours"
        Me.lblUserWorkedHours.Size = New System.Drawing.Size(101, 16)
        Me.lblUserWorkedHours.TabIndex = 89
        Me.lblUserWorkedHours.Text = "Worked Hours: "
        '
        'txtUserWorkedHours
        '
        Me.txtUserWorkedHours.BackColor = System.Drawing.Color.Maroon
        Me.txtUserWorkedHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserWorkedHours.ForeColor = System.Drawing.Color.White
        Me.txtUserWorkedHours.Location = New System.Drawing.Point(180, 529)
        Me.txtUserWorkedHours.Name = "txtUserWorkedHours"
        Me.txtUserWorkedHours.Size = New System.Drawing.Size(239, 20)
        Me.txtUserWorkedHours.TabIndex = 88
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.White
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnEdit.FlatAppearance.BorderSize = 2
        Me.btnEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.ForeColor = System.Drawing.Color.Maroon
        Me.btnEdit.Location = New System.Drawing.Point(12, 510)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(149, 45)
        Me.btnEdit.TabIndex = 90
        Me.btnEdit.Text = "Edit Time Registration"
        Me.btnEdit.UseVisualStyleBackColor = False
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
        Me.btnSave.Location = New System.Drawing.Point(445, 510)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(149, 45)
        Me.btnSave.TabIndex = 91
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
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
        Me.btnResetFilter.Image = Global.Monteverde_Administrator.My.Resources.Resources.Imagen30
        Me.btnResetFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnResetFilter.Location = New System.Drawing.Point(167, 198)
        Me.btnResetFilter.Name = "btnResetFilter"
        Me.btnResetFilter.Size = New System.Drawing.Size(149, 45)
        Me.btnResetFilter.TabIndex = 86
        Me.btnResetFilter.Text = "Reset Filter"
        Me.btnResetFilter.UseVisualStyleBackColor = False
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
        Me.btnFilter.Image = Global.Monteverde_Administrator.My.Resources.Resources.Imagen6
        Me.btnFilter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFilter.Location = New System.Drawing.Point(12, 198)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(149, 45)
        Me.btnFilter.TabIndex = 85
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.White
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnBack.FlatAppearance.BorderSize = 2
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.ForeColor = System.Drawing.Color.Maroon
        Me.btnBack.Image = Global.Monteverde_Administrator.My.Resources.Resources.Sin_título
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(266, 45)
        Me.btnBack.TabIndex = 82
        Me.btnBack.Text = "Back to Main Menu"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmViewTimeRegistrations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.lblUserWorkedHours)
        Me.Controls.Add(Me.txtUserWorkedHours)
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
    Friend WithEvents lblUserWorkedHours As System.Windows.Forms.Label
    Friend WithEvents txtUserWorkedHours As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
