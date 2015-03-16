<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblMainTittle = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.MaskedTextBox()
        Me.txtPassword = New System.Windows.Forms.MaskedTextBox()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.lnkSignIn = New System.Windows.Forms.LinkLabel()
        Me.cbxRecordLog = New System.Windows.Forms.CheckBox()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMainTittle
        '
        Me.lblMainTittle.AutoSize = True
        Me.lblMainTittle.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainTittle.ForeColor = System.Drawing.Color.Gray
        Me.lblMainTittle.Location = New System.Drawing.Point(35, 19)
        Me.lblMainTittle.Name = "lblMainTittle"
        Me.lblMainTittle.Size = New System.Drawing.Size(502, 39)
        Me.lblMainTittle.TabIndex = 0
        Me.lblMainTittle.Text = "Gestión de Proyectos, Monteverde"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(256, 182)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(265, 20)
        Me.txtEmail.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(256, 248)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(265, 20)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnLogIn
        '
        Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogIn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.ForeColor = System.Drawing.Color.White
        Me.btnLogIn.Location = New System.Drawing.Point(420, 357)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(101, 24)
        Me.btnLogIn.TabIndex = 3
        Me.btnLogIn.Text = "Ingresar"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'lnkSignIn
        '
        Me.lnkSignIn.AutoSize = True
        Me.lnkSignIn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkSignIn.LinkColor = System.Drawing.Color.CornflowerBlue
        Me.lnkSignIn.Location = New System.Drawing.Point(23, 528)
        Me.lnkSignIn.Name = "lnkSignIn"
        Me.lnkSignIn.Size = New System.Drawing.Size(70, 13)
        Me.lnkSignIn.TabIndex = 4
        Me.lnkSignIn.TabStop = True
        Me.lnkSignIn.Text = "Crear cuenta"
        '
        'cbxRecordLog
        '
        Me.cbxRecordLog.AutoSize = True
        Me.cbxRecordLog.ForeColor = System.Drawing.Color.White
        Me.cbxRecordLog.Location = New System.Drawing.Point(256, 295)
        Me.cbxRecordLog.Name = "cbxRecordLog"
        Me.cbxRecordLog.Size = New System.Drawing.Size(167, 17)
        Me.cbxRecordLog.TabIndex = 6
        Me.cbxRecordLog.Text = "Recordar correo y contraseña"
        Me.cbxRecordLog.UseVisualStyleBackColor = True
        '
        'pbLogo
        '
        Me.pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), System.Drawing.Image)
        Me.pbLogo.Location = New System.Drawing.Point(657, 9)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(115, 86)
        Me.pbLogo.TabIndex = 7
        Me.pbLogo.TabStop = False
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(253, 163)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(128, 16)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Correo Electrónico:  "
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(253, 229)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(83, 16)
        Me.lblPassword.TabIndex = 9
        Me.lblPassword.Text = "Contraseña: "
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogIn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.cbxRecordLog)
        Me.Controls.Add(Me.lnkSignIn)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblMainTittle)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.Text = "Monteverde: Log In"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMainTittle As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPassword As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnLogIn As System.Windows.Forms.Button
    Friend WithEvents lnkSignIn As System.Windows.Forms.LinkLabel
    Friend WithEvents cbxRecordLog As System.Windows.Forms.CheckBox
    Friend WithEvents pbLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label

End Class
