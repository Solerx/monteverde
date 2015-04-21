<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkCategoryManagement
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
        Me.dgvCategories = New System.Windows.Forms.DataGridView()
        Me.txtWCName = New System.Windows.Forms.MaskedTextBox()
        Me.txtWCDescription = New System.Windows.Forms.MaskedTextBox()
        Me.btnAddCategory = New System.Windows.Forms.Button()
        Me.btnRemoveCategory = New System.Windows.Forms.Button()
        Me.btnEditCategory = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblWorkCategories = New System.Windows.Forms.Label()
        Me.lblwcName = New System.Windows.Forms.Label()
        Me.lblWCDescription = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCategories
        '
        Me.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategories.Location = New System.Drawing.Point(12, 123)
        Me.dgvCategories.Name = "dgvCategories"
        Me.dgvCategories.Size = New System.Drawing.Size(370, 336)
        Me.dgvCategories.TabIndex = 0
        '
        'txtWCName
        '
        Me.txtWCName.BackColor = System.Drawing.Color.Maroon
        Me.txtWCName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWCName.ForeColor = System.Drawing.Color.White
        Me.txtWCName.Location = New System.Drawing.Point(492, 227)
        Me.txtWCName.Name = "txtWCName"
        Me.txtWCName.Size = New System.Drawing.Size(198, 20)
        Me.txtWCName.TabIndex = 31
        '
        'txtWCDescription
        '
        Me.txtWCDescription.BackColor = System.Drawing.Color.Maroon
        Me.txtWCDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWCDescription.ForeColor = System.Drawing.Color.White
        Me.txtWCDescription.Location = New System.Drawing.Point(492, 305)
        Me.txtWCDescription.Name = "txtWCDescription"
        Me.txtWCDescription.Size = New System.Drawing.Size(198, 20)
        Me.txtWCDescription.TabIndex = 33
        '
        'btnAddCategory
        '
        Me.btnAddCategory.BackColor = System.Drawing.Color.White
        Me.btnAddCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddCategory.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnAddCategory.FlatAppearance.BorderSize = 2
        Me.btnAddCategory.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnAddCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnAddCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCategory.ForeColor = System.Drawing.Color.Maroon
        Me.btnAddCategory.Image = Global.Monteverde_Administrator.My.Resources.Resources.Imagen14
        Me.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddCategory.Location = New System.Drawing.Point(12, 465)
        Me.btnAddCategory.Name = "btnAddCategory"
        Me.btnAddCategory.Size = New System.Drawing.Size(106, 45)
        Me.btnAddCategory.TabIndex = 34
        Me.btnAddCategory.Text = "    Add New" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Category"
        Me.btnAddCategory.UseVisualStyleBackColor = False
        '
        'btnRemoveCategory
        '
        Me.btnRemoveCategory.BackColor = System.Drawing.Color.White
        Me.btnRemoveCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRemoveCategory.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnRemoveCategory.FlatAppearance.BorderSize = 2
        Me.btnRemoveCategory.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnRemoveCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnRemoveCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnRemoveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveCategory.ForeColor = System.Drawing.Color.Maroon
        Me.btnRemoveCategory.Image = Global.Monteverde_Administrator.My.Resources.Resources.Imagen1
        Me.btnRemoveCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemoveCategory.Location = New System.Drawing.Point(276, 465)
        Me.btnRemoveCategory.Name = "btnRemoveCategory"
        Me.btnRemoveCategory.Size = New System.Drawing.Size(106, 45)
        Me.btnRemoveCategory.TabIndex = 36
        Me.btnRemoveCategory.Text = "    Remove " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    Category"
        Me.btnRemoveCategory.UseVisualStyleBackColor = False
        '
        'btnEditCategory
        '
        Me.btnEditCategory.BackColor = System.Drawing.Color.White
        Me.btnEditCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEditCategory.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnEditCategory.FlatAppearance.BorderSize = 2
        Me.btnEditCategory.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnEditCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnEditCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditCategory.ForeColor = System.Drawing.Color.Maroon
        Me.btnEditCategory.Image = Global.Monteverde_Administrator.My.Resources.Resources.Imagen16
        Me.btnEditCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditCategory.Location = New System.Drawing.Point(124, 465)
        Me.btnEditCategory.Name = "btnEditCategory"
        Me.btnEditCategory.Size = New System.Drawing.Size(106, 45)
        Me.btnEditCategory.TabIndex = 37
        Me.btnEditCategory.Text = "Edit Category"
        Me.btnEditCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEditCategory.UseVisualStyleBackColor = False
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
        Me.btnSave.Location = New System.Drawing.Point(683, 465)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(89, 45)
        Me.btnSave.TabIndex = 38
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.btnAdd.FlatAppearance.BorderSize = 2
        Me.btnAdd.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.ForeColor = System.Drawing.Color.Maroon
        Me.btnAdd.Image = Global.Monteverde_Administrator.My.Resources.Resources.Imagen2
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(678, 465)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(94, 45)
        Me.btnAdd.TabIndex = 39
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'lblWorkCategories
        '
        Me.lblWorkCategories.AutoSize = True
        Me.lblWorkCategories.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWorkCategories.ForeColor = System.Drawing.Color.Maroon
        Me.lblWorkCategories.Location = New System.Drawing.Point(6, 87)
        Me.lblWorkCategories.Name = "lblWorkCategories"
        Me.lblWorkCategories.Size = New System.Drawing.Size(265, 33)
        Me.lblWorkCategories.TabIndex = 49
        Me.lblWorkCategories.Text = "Work Categories: "
        '
        'lblwcName
        '
        Me.lblwcName.AutoSize = True
        Me.lblwcName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwcName.ForeColor = System.Drawing.Color.Maroon
        Me.lblwcName.Location = New System.Drawing.Point(489, 208)
        Me.lblwcName.Name = "lblwcName"
        Me.lblwcName.Size = New System.Drawing.Size(106, 16)
        Me.lblwcName.TabIndex = 50
        Me.lblwcName.Text = "Category Name:"
        '
        'lblWCDescription
        '
        Me.lblWCDescription.AutoSize = True
        Me.lblWCDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWCDescription.ForeColor = System.Drawing.Color.Maroon
        Me.lblWCDescription.Location = New System.Drawing.Point(489, 286)
        Me.lblWCDescription.Name = "lblWCDescription"
        Me.lblWCDescription.Size = New System.Drawing.Size(76, 16)
        Me.lblWCDescription.TabIndex = 51
        Me.lblWCDescription.Text = "Description"
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
        Me.btnBack.Location = New System.Drawing.Point(12, 11)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(266, 45)
        Me.btnBack.TabIndex = 52
        Me.btnBack.Text = "Back to Main Menu"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmWorkCategoryManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblWCDescription)
        Me.Controls.Add(Me.lblwcName)
        Me.Controls.Add(Me.lblWorkCategories)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEditCategory)
        Me.Controls.Add(Me.btnRemoveCategory)
        Me.Controls.Add(Me.btnAddCategory)
        Me.Controls.Add(Me.txtWCDescription)
        Me.Controls.Add(Me.txtWCName)
        Me.Controls.Add(Me.dgvCategories)
        Me.Name = "frmWorkCategoryManagement"
        Me.Text = "Work Catergories Management"
        CType(Me.dgvCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCategories As System.Windows.Forms.DataGridView
    Friend WithEvents txtWCName As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtWCDescription As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnAddCategory As System.Windows.Forms.Button
    Friend WithEvents btnRemoveCategory As System.Windows.Forms.Button
    Friend WithEvents btnEditCategory As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblWorkCategories As System.Windows.Forms.Label
    Friend WithEvents lblwcName As System.Windows.Forms.Label
    Friend WithEvents lblWCDescription As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
