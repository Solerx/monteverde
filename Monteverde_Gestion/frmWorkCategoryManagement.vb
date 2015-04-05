Public Class frmWorkCategoryManagement

    Dim workcategoryInstance As New WorkCategoryData

    Dim row As Integer


    Private Sub frmWorkCategoryManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UpdateTable()
        HideAll()


    End Sub

    Public Sub HideAll()

        txtWCDescription.Hide()
        txtWCName.Hide()
        lblWCDescription.Hide()
        lblwcName.Hide()
        lblWorkCategories.Hide()
        btnAdd.Hide()
        btnSave.Hide()

    End Sub

    Public Sub ShowAll()

        txtWCDescription.Show()
        txtWCName.Show()
        lblWCDescription.Show()
        lblwcName.Show()
        lblWorkCategories.Show()

    End Sub

    Public Sub ResetInputs()

        txtWCDescription.ResetText()
        txtWCName.ResetText()
        lblWCDescription.Show()
        lblwcName.Show()
        lblWorkCategories.Show()

    End Sub

    Public Function CategoryInputs() As WorkCategory

        Dim categoryName As String = " "
        Dim categoryDescription As String = " "

        Dim newCategory As New WorkCategory

        categoryName = txtWCName.Text
        categoryDescription = txtWCDescription.Text


        newCategory.Name = categoryName
        newCategory.Description = categoryDescription

        CategoryInputs = newCategory

    End Function

    Public Sub UpdateTable()

        Me.dgvCategories.DataSource = workcategoryInstance.Fill_Data_Grid_View()

    End Sub

    Public Sub Fill_Inputs(ByVal category As WorkCategory)

        txtWCDescription.Text = category.Description
        txtWCName.Text = category.Name


    End Sub

    Private Sub dgvCategories_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCategories.CellClick

        row = dgvCategories.CurrentRow.Index

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()
        frmHome.Show()

    End Sub

    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click

        ShowAll()
        ResetInputs()
        btnAdd.Show()


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtWCName.Text = vbNullString Or txtWCDescription.Text = vbNullString Then

            MsgBox("You can't leave any space blank.")

        Else

            Dim alert = MsgBox("Are you sure you want to edit this Category?", MsgBoxStyle.YesNo, "Editing Project!")

            If alert = MsgBoxResult.Yes Then

                workcategoryInstance.Edit(CategoryInputs, dgvCategories.Item(0, row).Value())
                UpdateTable()
                ResetInputs()

            Else

                ResetInputs()

            End If

        End If

    End Sub

    Private Sub btnRemoveCategory_Click(sender As Object, e As EventArgs) Handles btnRemoveCategory.Click

        HideAll()

        Dim alert = MsgBox("Are you sure you want remove category: " & dgvCategories.Item(0, row).Value() & "?", MsgBoxStyle.YesNo, "Removing!")

        If alert = MsgBoxResult.Yes Then

            workcategoryInstance.Delete(row, dgvCategories.Item(0, row).Value(), dgvCategories.Item(1, row).Value())
            UpdateTable()

        End If


    End Sub

    Private Sub btnEditCategory_Click(sender As Object, e As EventArgs) Handles btnEditCategory.Click

        ShowAll()
        btnAdd.Hide()
        btnSave.Show()
        Fill_Inputs(workcategoryInstance.GetCategoryByName(dgvCategories.Item(0, row).Value()))

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtWCName.Text = vbNullString Or txtWCDescription.Text = vbNullString Then

            MsgBox("You can't leave any space blank.")

        Else

            Dim alert = MsgBox("Are you sure you want to save this Project?", MsgBoxStyle.YesNo, "Editing Project!")

            If alert = MsgBoxResult.Yes Then

                workcategoryInstance.Insert(CategoryInputs)
                UpdateTable()
                ResetInputs()

            Else

                ResetInputs()

            End If

        End If



    End Sub
End Class