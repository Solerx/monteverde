<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewTimeRegistration
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
        Me.dgvAssignedProjects = New System.Windows.Forms.DataGridView()
        Me.cbxWorkCategories = New System.Windows.Forms.ComboBox()
        Me.lblProjectToAdd = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtUserWorkedHours = New System.Windows.Forms.MaskedTextBox()
        Me.lblUserWorkedHours = New System.Windows.Forms.Label()
        Me.lblWorkCategories = New System.Windows.Forms.Label()
        Me.rtbNotes = New System.Windows.Forms.RichTextBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lvlWorkedTimeInfo = New System.Windows.Forms.Label()
        CType(Me.dgvAssignedProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAssignedProjects
        '
        Me.dgvAssignedProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssignedProjects.Location = New System.Drawing.Point(12, 118)
        Me.dgvAssignedProjects.Name = "dgvAssignedProjects"
        Me.dgvAssignedProjects.Size = New System.Drawing.Size(328, 431)
        Me.dgvAssignedProjects.TabIndex = 32
        '
        'cbxWorkCategories
        '
        Me.cbxWorkCategories.BackColor = System.Drawing.Color.Maroon
        Me.cbxWorkCategories.ForeColor = System.Drawing.Color.White
        Me.cbxWorkCategories.FormattingEnabled = True
        Me.cbxWorkCategories.Location = New System.Drawing.Point(434, 178)
        Me.cbxWorkCategories.Name = "cbxWorkCategories"
        Me.cbxWorkCategories.Size = New System.Drawing.Size(178, 21)
        Me.cbxWorkCategories.TabIndex = 54
        '
        'lblProjectToAdd
        '
        Me.lblProjectToAdd.AutoSize = True
        Me.lblProjectToAdd.BackColor = System.Drawing.SystemColors.Window
        Me.lblProjectToAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectToAdd.ForeColor = System.Drawing.Color.Maroon
        Me.lblProjectToAdd.Location = New System.Drawing.Point(12, 84)
        Me.lblProjectToAdd.Name = "lblProjectToAdd"
        Me.lblProjectToAdd.Size = New System.Drawing.Size(266, 31)
        Me.lblProjectToAdd.TabIndex = 55
        Me.lblProjectToAdd.Text = "Projects Assigned: "
        Me.lblProjectToAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.btnBack.TabIndex = 56
        Me.btnBack.Text = "Back to Main Menu"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'txtUserWorkedHours
        '
        Me.txtUserWorkedHours.BackColor = System.Drawing.Color.Maroon
        Me.txtUserWorkedHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserWorkedHours.ForeColor = System.Drawing.Color.White
        Me.txtUserWorkedHours.Location = New System.Drawing.Point(434, 242)
        Me.txtUserWorkedHours.Name = "txtUserWorkedHours"
        Me.txtUserWorkedHours.Size = New System.Drawing.Size(239, 20)
        Me.txtUserWorkedHours.TabIndex = 57
        '
        'lblUserWorkedHours
        '
        Me.lblUserWorkedHours.AutoSize = True
        Me.lblUserWorkedHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserWorkedHours.ForeColor = System.Drawing.Color.Maroon
        Me.lblUserWorkedHours.Location = New System.Drawing.Point(431, 223)
        Me.lblUserWorkedHours.Name = "lblUserWorkedHours"
        Me.lblUserWorkedHours.Size = New System.Drawing.Size(101, 16)
        Me.lblUserWorkedHours.TabIndex = 58
        Me.lblUserWorkedHours.Text = "Worked Hours: "
        '
        'lblWorkCategories
        '
        Me.lblWorkCategories.AutoSize = True
        Me.lblWorkCategories.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkCategories.ForeColor = System.Drawing.Color.Maroon
        Me.lblWorkCategories.Location = New System.Drawing.Point(431, 159)
        Me.lblWorkCategories.Name = "lblWorkCategories"
        Me.lblWorkCategories.Size = New System.Drawing.Size(107, 16)
        Me.lblWorkCategories.TabIndex = 59
        Me.lblWorkCategories.Text = "Work Category:  "
        '
        'rtbNotes
        '
        Me.rtbNotes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rtbNotes.Location = New System.Drawing.Point(434, 305)
        Me.rtbNotes.Name = "rtbNotes"
        Me.rtbNotes.Size = New System.Drawing.Size(239, 147)
        Me.rtbNotes.TabIndex = 60
        Me.rtbNotes.Text = ""
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.ForeColor = System.Drawing.Color.Maroon
        Me.lblNotes.Location = New System.Drawing.Point(431, 286)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(50, 16)
        Me.lblNotes.TabIndex = 61
        Me.lblNotes.Text = "Notes: "
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
        Me.btnSave.Location = New System.Drawing.Point(545, 504)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(149, 45)
        Me.btnSave.TabIndex = 62
        Me.btnSave.Text = "Register New Work Time"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lvlWorkedTimeInfo
        '
        Me.lvlWorkedTimeInfo.AutoSize = True
        Me.lvlWorkedTimeInfo.BackColor = System.Drawing.SystemColors.Window
        Me.lvlWorkedTimeInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlWorkedTimeInfo.ForeColor = System.Drawing.Color.Maroon
        Me.lvlWorkedTimeInfo.Location = New System.Drawing.Point(401, 95)
        Me.lvlWorkedTimeInfo.Name = "lvlWorkedTimeInfo"
        Me.lvlWorkedTimeInfo.Size = New System.Drawing.Size(349, 31)
        Me.lvlWorkedTimeInfo.TabIndex = 63
        Me.lvlWorkedTimeInfo.Text = "Worked Time Information:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lvlWorkedTimeInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmNewTimeRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lvlWorkedTimeInfo)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.rtbNotes)
        Me.Controls.Add(Me.lblWorkCategories)
        Me.Controls.Add(Me.lblUserWorkedHours)
        Me.Controls.Add(Me.txtUserWorkedHours)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblProjectToAdd)
        Me.Controls.Add(Me.cbxWorkCategories)
        Me.Controls.Add(Me.dgvAssignedProjects)
        Me.Name = "frmNewTimeRegistration"
        Me.Text = "New Time Registration"
        CType(Me.dgvAssignedProjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvAssignedProjects As System.Windows.Forms.DataGridView
    Friend WithEvents cbxWorkCategories As System.Windows.Forms.ComboBox
    Friend WithEvents lblProjectToAdd As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtUserWorkedHours As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblUserWorkedHours As System.Windows.Forms.Label
    Friend WithEvents lblWorkCategories As System.Windows.Forms.Label
    Friend WithEvents rtbNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lvlWorkedTimeInfo As System.Windows.Forms.Label
End Class
