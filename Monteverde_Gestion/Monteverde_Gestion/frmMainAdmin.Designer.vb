<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainAdmin))
        Me.lblUserEmail = New System.Windows.Forms.Label()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbpUserInfo = New System.Windows.Forms.TabPage()
        Me.tbpUsers = New System.Windows.Forms.TabPage()
        Me.tbpProyects = New System.Windows.Forms.TabPage()
        Me.tbpCalendar = New System.Windows.Forms.TabPage()
        Me.tbpReports = New System.Windows.Forms.TabPage()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUserEmail
        '
        Me.lblUserEmail.AutoSize = True
        Me.lblUserEmail.Location = New System.Drawing.Point(133, 85)
        Me.lblUserEmail.Name = "lblUserEmail"
        Me.lblUserEmail.Size = New System.Drawing.Size(57, 13)
        Me.lblUserEmail.TabIndex = 15
        Me.lblUserEmail.Text = "UserName"
        '
        'btnSignOut
        '
        Me.btnSignOut.Location = New System.Drawing.Point(657, 104)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(115, 34)
        Me.btnSignOut.TabIndex = 14
        Me.btnSignOut.Text = "Cerrar Sesión"
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 86)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'pbLogo
        '
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(657, 12)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(115, 86)
        Me.pbLogo.TabIndex = 12
        Me.pbLogo.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.TabControl1.Controls.Add(Me.tbpUserInfo)
        Me.TabControl1.Controls.Add(Me.tbpUsers)
        Me.TabControl1.Controls.Add(Me.tbpProyects)
        Me.TabControl1.Controls.Add(Me.tbpCalendar)
        Me.TabControl1.Controls.Add(Me.tbpReports)
        Me.TabControl1.Location = New System.Drawing.Point(12, 122)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(760, 427)
        Me.TabControl1.TabIndex = 16
        '
        'tbpUserInfo
        '
        Me.tbpUserInfo.Location = New System.Drawing.Point(4, 25)
        Me.tbpUserInfo.Name = "tbpUserInfo"
        Me.tbpUserInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpUserInfo.Size = New System.Drawing.Size(752, 398)
        Me.tbpUserInfo.TabIndex = 0
        Me.tbpUserInfo.Text = "Perfil de usuario"
        Me.tbpUserInfo.UseVisualStyleBackColor = True
        '
        'tbpUsers
        '
        Me.tbpUsers.Location = New System.Drawing.Point(4, 25)
        Me.tbpUsers.Name = "tbpUsers"
        Me.tbpUsers.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpUsers.Size = New System.Drawing.Size(752, 398)
        Me.tbpUsers.TabIndex = 1
        Me.tbpUsers.Text = "Usuario"
        Me.tbpUsers.UseVisualStyleBackColor = True
        '
        'tbpProyects
        '
        Me.tbpProyects.Location = New System.Drawing.Point(4, 25)
        Me.tbpProyects.Name = "tbpProyects"
        Me.tbpProyects.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpProyects.Size = New System.Drawing.Size(752, 398)
        Me.tbpProyects.TabIndex = 2
        Me.tbpProyects.Text = "Proyectos"
        Me.tbpProyects.UseVisualStyleBackColor = True
        '
        'tbpCalendar
        '
        Me.tbpCalendar.Location = New System.Drawing.Point(4, 25)
        Me.tbpCalendar.Name = "tbpCalendar"
        Me.tbpCalendar.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpCalendar.Size = New System.Drawing.Size(752, 398)
        Me.tbpCalendar.TabIndex = 3
        Me.tbpCalendar.Text = "Calendario"
        Me.tbpCalendar.UseVisualStyleBackColor = True
        '
        'tbpReports
        '
        Me.tbpReports.Location = New System.Drawing.Point(4, 25)
        Me.tbpReports.Name = "tbpReports"
        Me.tbpReports.Size = New System.Drawing.Size(752, 398)
        Me.tbpReports.TabIndex = 4
        Me.tbpReports.Text = "Solicitud de Reportes"
        Me.tbpReports.UseVisualStyleBackColor = True
        '
        'frmMainAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btnSignOut)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblUserEmail)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbLogo)
        Me.Name = "frmMainAdmin"
        Me.Text = "frmMainAdmin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUserEmail As System.Windows.Forms.Label
    Friend WithEvents btnSignOut As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbpUserInfo As System.Windows.Forms.TabPage
    Friend WithEvents tbpUsers As System.Windows.Forms.TabPage
    Friend WithEvents tbpProyects As System.Windows.Forms.TabPage
    Friend WithEvents tbpCalendar As System.Windows.Forms.TabPage
    Friend WithEvents tbpReports As System.Windows.Forms.TabPage
End Class
