<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequestHolidays
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
        Me.btnRequest = New System.Windows.Forms.Button()
        Me.lblUserHolidays = New System.Windows.Forms.Label()
        Me.txtUserHolidays = New System.Windows.Forms.MaskedTextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblHolidays = New System.Windows.Forms.Label()
        Me.lblAvailableHolidays = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNotes = New System.Windows.Forms.Label()
        Me.rtbNotes = New System.Windows.Forms.RichTextBox()
        Me.dgvHolidaysRequest = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        CType(Me.dgvHolidaysRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRequest
        '
        Me.btnRequest.BackColor = System.Drawing.Color.White
        Me.btnRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRequest.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnRequest.FlatAppearance.BorderSize = 2
        Me.btnRequest.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRequest.ForeColor = System.Drawing.Color.Maroon
        Me.btnRequest.Location = New System.Drawing.Point(137, 474)
        Me.btnRequest.Name = "btnRequest"
        Me.btnRequest.Size = New System.Drawing.Size(149, 45)
        Me.btnRequest.TabIndex = 53
        Me.btnRequest.Text = "Request"
        Me.btnRequest.UseVisualStyleBackColor = False
        '
        'lblUserHolidays
        '
        Me.lblUserHolidays.AutoSize = True
        Me.lblUserHolidays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserHolidays.ForeColor = System.Drawing.Color.Maroon
        Me.lblUserHolidays.Location = New System.Drawing.Point(35, 198)
        Me.lblUserHolidays.Name = "lblUserHolidays"
        Me.lblUserHolidays.Size = New System.Drawing.Size(268, 16)
        Me.lblUserHolidays.TabIndex = 52
        Me.lblUserHolidays.Text = "How many holidays do you want to request?"
        '
        'txtUserHolidays
        '
        Me.txtUserHolidays.BackColor = System.Drawing.Color.Maroon
        Me.txtUserHolidays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserHolidays.ForeColor = System.Drawing.Color.White
        Me.txtUserHolidays.Location = New System.Drawing.Point(38, 230)
        Me.txtUserHolidays.Name = "txtUserHolidays"
        Me.txtUserHolidays.Size = New System.Drawing.Size(239, 20)
        Me.txtUserHolidays.TabIndex = 51
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
        Me.btnBack.TabIndex = 50
        Me.btnBack.Text = "Back to Main Menu"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblHolidays
        '
        Me.lblHolidays.AutoSize = True
        Me.lblHolidays.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHolidays.ForeColor = System.Drawing.Color.Maroon
        Me.lblHolidays.Location = New System.Drawing.Point(146, 133)
        Me.lblHolidays.Name = "lblHolidays"
        Me.lblHolidays.Size = New System.Drawing.Size(52, 55)
        Me.lblHolidays.TabIndex = 55
        Me.lblHolidays.Text = "0"
        '
        'lblAvailableHolidays
        '
        Me.lblAvailableHolidays.AutoSize = True
        Me.lblAvailableHolidays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailableHolidays.ForeColor = System.Drawing.Color.Maroon
        Me.lblAvailableHolidays.Location = New System.Drawing.Point(112, 117)
        Me.lblAvailableHolidays.Name = "lblAvailableHolidays"
        Me.lblAvailableHolidays.Size = New System.Drawing.Size(125, 16)
        Me.lblAvailableHolidays.TabIndex = 54
        Me.lblAvailableHolidays.Text = "Available holidays: "
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.BackColor = System.Drawing.Color.Maroon
        Me.MaskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MaskedTextBox1.ForeColor = System.Drawing.Color.White
        Me.MaskedTextBox1.Location = New System.Drawing.Point(38, 287)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(239, 20)
        Me.MaskedTextBox1.TabIndex = 56
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(35, 268)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 16)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Date to use them: "
        '
        'lblNotes
        '
        Me.lblNotes.AutoSize = True
        Me.lblNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotes.ForeColor = System.Drawing.Color.Maroon
        Me.lblNotes.Location = New System.Drawing.Point(35, 326)
        Me.lblNotes.Name = "lblNotes"
        Me.lblNotes.Size = New System.Drawing.Size(50, 16)
        Me.lblNotes.TabIndex = 63
        Me.lblNotes.Text = "Notes: "
        '
        'rtbNotes
        '
        Me.rtbNotes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.rtbNotes.Location = New System.Drawing.Point(38, 345)
        Me.rtbNotes.Name = "rtbNotes"
        Me.rtbNotes.Size = New System.Drawing.Size(322, 95)
        Me.rtbNotes.TabIndex = 62
        Me.rtbNotes.Text = ""
        '
        'dgvHolidaysRequest
        '
        Me.dgvHolidaysRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHolidaysRequest.Location = New System.Drawing.Point(437, 136)
        Me.dgvHolidaysRequest.Name = "dgvHolidaysRequest"
        Me.dgvHolidaysRequest.Size = New System.Drawing.Size(308, 306)
        Me.dgvHolidaysRequest.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(434, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "Request Status:"
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
        Me.btnCancel.Location = New System.Drawing.Point(527, 474)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(149, 45)
        Me.btnCancel.TabIndex = 66
        Me.btnCancel.Text = "Cancel Rquest"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmRequestHolidays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvHolidaysRequest)
        Me.Controls.Add(Me.lblNotes)
        Me.Controls.Add(Me.rtbNotes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.lblHolidays)
        Me.Controls.Add(Me.lblAvailableHolidays)
        Me.Controls.Add(Me.btnRequest)
        Me.Controls.Add(Me.lblUserHolidays)
        Me.Controls.Add(Me.txtUserHolidays)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "frmRequestHolidays"
        Me.Text = "Request Holidays"
        CType(Me.dgvHolidaysRequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRequest As System.Windows.Forms.Button
    Friend WithEvents lblUserHolidays As System.Windows.Forms.Label
    Friend WithEvents txtUserHolidays As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblHolidays As System.Windows.Forms.Label
    Friend WithEvents lblAvailableHolidays As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNotes As System.Windows.Forms.Label
    Friend WithEvents rtbNotes As System.Windows.Forms.RichTextBox
    Friend WithEvents dgvHolidaysRequest As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
