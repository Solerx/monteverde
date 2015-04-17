<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewHolidayRquest
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
        Me.dgvHolidaysRequest = New System.Windows.Forms.DataGridView()
        Me.btnAcceptRequest = New System.Windows.Forms.Button()
        Me.btnRejectRequest = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvHolidaysRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHolidaysRequest
        '
        Me.dgvHolidaysRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHolidaysRequest.Location = New System.Drawing.Point(51, 110)
        Me.dgvHolidaysRequest.Name = "dgvHolidaysRequest"
        Me.dgvHolidaysRequest.Size = New System.Drawing.Size(677, 306)
        Me.dgvHolidaysRequest.TabIndex = 65
        '
        'btnAcceptRequest
        '
        Me.btnAcceptRequest.BackColor = System.Drawing.Color.White
        Me.btnAcceptRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAcceptRequest.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnAcceptRequest.FlatAppearance.BorderSize = 2
        Me.btnAcceptRequest.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnAcceptRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnAcceptRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnAcceptRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcceptRequest.ForeColor = System.Drawing.Color.Maroon
        Me.btnAcceptRequest.Location = New System.Drawing.Point(579, 456)
        Me.btnAcceptRequest.Name = "btnAcceptRequest"
        Me.btnAcceptRequest.Size = New System.Drawing.Size(149, 45)
        Me.btnAcceptRequest.TabIndex = 66
        Me.btnAcceptRequest.Text = "Accept Request"
        Me.btnAcceptRequest.UseVisualStyleBackColor = False
        '
        'btnRejectRequest
        '
        Me.btnRejectRequest.BackColor = System.Drawing.Color.White
        Me.btnRejectRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRejectRequest.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnRejectRequest.FlatAppearance.BorderSize = 2
        Me.btnRejectRequest.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnRejectRequest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnRejectRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnRejectRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRejectRequest.ForeColor = System.Drawing.Color.Maroon
        Me.btnRejectRequest.Location = New System.Drawing.Point(388, 456)
        Me.btnRejectRequest.Name = "btnRejectRequest"
        Me.btnRejectRequest.Size = New System.Drawing.Size(149, 45)
        Me.btnRejectRequest.TabIndex = 67
        Me.btnRejectRequest.Text = "Reject Request"
        Me.btnRejectRequest.UseVisualStyleBackColor = False
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
        Me.btnBack.TabIndex = 68
        Me.btnBack.Text = "Back to Main Menu"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmViewHolidayRquest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRejectRequest)
        Me.Controls.Add(Me.btnAcceptRequest)
        Me.Controls.Add(Me.dgvHolidaysRequest)
        Me.Name = "frmViewHolidayRquest"
        Me.Text = "frmViewHolidayRquest"
        CType(Me.dgvHolidaysRequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvHolidaysRequest As System.Windows.Forms.DataGridView
    Friend WithEvents btnAcceptRequest As System.Windows.Forms.Button
    Friend WithEvents btnRejectRequest As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
