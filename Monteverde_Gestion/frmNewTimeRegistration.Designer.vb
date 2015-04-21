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
        Me.components = New System.ComponentModel.Container()
        Me.dgvAssignedProjects = New System.Windows.Forms.DataGridView()
        Me.cbxWorkCategories = New System.Windows.Forms.ComboBox()
        Me.lblProjectToAdd = New System.Windows.Forms.Label()
        Me.lblWorkCategories = New System.Windows.Forms.Label()
        Me.rtbNotes = New System.Windows.Forms.RichTextBox()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.lvlWorkedTimeInfo = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnStartToWork = New System.Windows.Forms.Button()
        Me.dgvUserWorkedTime = New System.Windows.Forms.DataGridView()
        Me.lblChrono = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnFinishWork = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvAssignedProjects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUserWorkedTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAssignedProjects
        '
        Me.dgvAssignedProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAssignedProjects.Location = New System.Drawing.Point(12, 118)
        Me.dgvAssignedProjects.Name = "dgvAssignedProjects"
        Me.dgvAssignedProjects.Size = New System.Drawing.Size(328, 203)
        Me.dgvAssignedProjects.TabIndex = 32
        '
        'cbxWorkCategories
        '
        Me.cbxWorkCategories.BackColor = System.Drawing.Color.Maroon
        Me.cbxWorkCategories.ForeColor = System.Drawing.Color.White
        Me.cbxWorkCategories.FormattingEnabled = True
        Me.cbxWorkCategories.Location = New System.Drawing.Point(434, 324)
        Me.cbxWorkCategories.Name = "cbxWorkCategories"
        Me.cbxWorkCategories.Size = New System.Drawing.Size(239, 21)
        Me.cbxWorkCategories.TabIndex = 54
        '
        'lblProjectToAdd
        '
        Me.lblProjectToAdd.AutoSize = True
        Me.lblProjectToAdd.BackColor = System.Drawing.SystemColors.Window
        Me.lblProjectToAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectToAdd.ForeColor = System.Drawing.Color.Maroon
        Me.lblProjectToAdd.Location = New System.Drawing.Point(6, 84)
        Me.lblProjectToAdd.Name = "lblProjectToAdd"
        Me.lblProjectToAdd.Size = New System.Drawing.Size(266, 31)
        Me.lblProjectToAdd.TabIndex = 55
        Me.lblProjectToAdd.Text = "Projects Assigned: "
        Me.lblProjectToAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblWorkCategories
        '
        Me.lblWorkCategories.AutoSize = True
        Me.lblWorkCategories.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkCategories.ForeColor = System.Drawing.Color.Maroon
        Me.lblWorkCategories.Location = New System.Drawing.Point(431, 305)
        Me.lblWorkCategories.Name = "lblWorkCategories"
        Me.lblWorkCategories.Size = New System.Drawing.Size(107, 16)
        Me.lblWorkCategories.TabIndex = 59
        Me.lblWorkCategories.Text = "Work Category:  "
        '
        'rtbNotes
        '
        Me.rtbNotes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rtbNotes.Location = New System.Drawing.Point(434, 375)
        Me.rtbNotes.Name = "rtbNotes"
        Me.rtbNotes.Size = New System.Drawing.Size(338, 95)
        Me.rtbNotes.TabIndex = 60
        Me.rtbNotes.Text = ""
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.ForeColor = System.Drawing.Color.Maroon
        Me.lblNotes.Location = New System.Drawing.Point(431, 354)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(50, 16)
        Me.lblNotes.TabIndex = 61
        Me.lblNotes.Text = "Notes: "
        '
        'lvlWorkedTimeInfo
        '
        Me.lvlWorkedTimeInfo.AutoSize = True
        Me.lvlWorkedTimeInfo.BackColor = System.Drawing.SystemColors.Window
        Me.lvlWorkedTimeInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlWorkedTimeInfo.ForeColor = System.Drawing.Color.Maroon
        Me.lvlWorkedTimeInfo.Location = New System.Drawing.Point(6, 341)
        Me.lvlWorkedTimeInfo.Name = "lvlWorkedTimeInfo"
        Me.lvlWorkedTimeInfo.Size = New System.Drawing.Size(349, 31)
        Me.lvlWorkedTimeInfo.TabIndex = 63
        Me.lvlWorkedTimeInfo.Text = "Worked Time Information:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lvlWorkedTimeInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        '
        'btnStartToWork
        '
        Me.btnStartToWork.BackColor = System.Drawing.Color.White
        Me.btnStartToWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnStartToWork.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnStartToWork.FlatAppearance.BorderSize = 2
        Me.btnStartToWork.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnStartToWork.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnStartToWork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnStartToWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartToWork.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartToWork.ForeColor = System.Drawing.Color.Maroon
        Me.btnStartToWork.Location = New System.Drawing.Point(444, 118)
        Me.btnStartToWork.Name = "btnStartToWork"
        Me.btnStartToWork.Size = New System.Drawing.Size(328, 65)
        Me.btnStartToWork.TabIndex = 65
        Me.btnStartToWork.Text = "Start Working"
        Me.btnStartToWork.UseVisualStyleBackColor = False
        '
        'dgvUserWorkedTime
        '
        Me.dgvUserWorkedTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserWorkedTime.Location = New System.Drawing.Point(12, 375)
        Me.dgvUserWorkedTime.Name = "dgvUserWorkedTime"
        Me.dgvUserWorkedTime.Size = New System.Drawing.Size(328, 174)
        Me.dgvUserWorkedTime.TabIndex = 66
        '
        'lblChrono
        '
        Me.lblChrono.AutoSize = True
        Me.lblChrono.BackColor = System.Drawing.SystemColors.Window
        Me.lblChrono.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChrono.ForeColor = System.Drawing.Color.Maroon
        Me.lblChrono.Location = New System.Drawing.Point(537, 186)
        Me.lblChrono.Name = "lblChrono"
        Me.lblChrono.Size = New System.Drawing.Size(136, 55)
        Me.lblChrono.TabIndex = 67
        Me.lblChrono.Text = "0:0:0"
        Me.lblChrono.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnCancel.FlatAppearance.BorderSize = 2
        Me.btnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.Maroon
        Me.btnCancel.Image = Global.Monteverde_Administrator.My.Resources.Resources.Imagen22
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(444, 244)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(159, 45)
        Me.btnCancel.TabIndex = 68
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnFinishWork
        '
        Me.btnFinishWork.BackColor = System.Drawing.Color.White
        Me.btnFinishWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFinishWork.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnFinishWork.FlatAppearance.BorderSize = 2
        Me.btnFinishWork.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnFinishWork.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnFinishWork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnFinishWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinishWork.ForeColor = System.Drawing.Color.Maroon
        Me.btnFinishWork.Image = Global.Monteverde_Administrator.My.Resources.Resources.Imagen31
        Me.btnFinishWork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFinishWork.Location = New System.Drawing.Point(613, 244)
        Me.btnFinishWork.Name = "btnFinishWork"
        Me.btnFinishWork.Size = New System.Drawing.Size(159, 45)
        Me.btnFinishWork.TabIndex = 64
        Me.btnFinishWork.Text = "Finish Work"
        Me.btnFinishWork.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.White
        Me.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnRegister.FlatAppearance.BorderSize = 2
        Me.btnRegister.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.ForeColor = System.Drawing.Color.Maroon
        Me.btnRegister.Image = Global.Monteverde_Administrator.My.Resources.Resources.Imagen23
        Me.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegister.Location = New System.Drawing.Point(601, 504)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(171, 45)
        Me.btnRegister.TabIndex = 62
        Me.btnRegister.Text = "Register New Work Time"
        Me.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegister.UseVisualStyleBackColor = False
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
        Me.btnBack.TabIndex = 56
        Me.btnBack.Text = "Back to Main Menu"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmNewTimeRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblChrono)
        Me.Controls.Add(Me.dgvUserWorkedTime)
        Me.Controls.Add(Me.btnStartToWork)
        Me.Controls.Add(Me.btnFinishWork)
        Me.Controls.Add(Me.lvlWorkedTimeInfo)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.rtbNotes)
        Me.Controls.Add(Me.lblWorkCategories)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblProjectToAdd)
        Me.Controls.Add(Me.cbxWorkCategories)
        Me.Controls.Add(Me.dgvAssignedProjects)
        Me.Name = "frmNewTimeRegistration"
        Me.Text = "New Time Registration"
        CType(Me.dgvAssignedProjects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUserWorkedTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvAssignedProjects As System.Windows.Forms.DataGridView
    Friend WithEvents cbxWorkCategories As System.Windows.Forms.ComboBox
    Friend WithEvents lblProjectToAdd As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblWorkCategories As System.Windows.Forms.Label
    Friend WithEvents rtbNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents lvlWorkedTimeInfo As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnFinishWork As System.Windows.Forms.Button
    Friend WithEvents btnStartToWork As System.Windows.Forms.Button
    Friend WithEvents dgvUserWorkedTime As System.Windows.Forms.DataGridView
    Friend WithEvents lblChrono As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
