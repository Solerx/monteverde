Public Class frmViewTimeRegistrations

    Dim userTimeRegistrationInstance As UserTimeRegistrationData = New UserTimeRegistrationData

    Dim workCategoryDataInstance As WorkCategoryData = New WorkCategoryData

    Dim userDataInstance As Userdata = New Userdata

    Dim projectDataInstace As Projectdata = New Projectdata

    Private Sub frmViewTimeRegistrations_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UpdateTable()
        FillComboBoxCategories()
        FillComboBoxProjects()
        FillComboBoxUsers()

    End Sub

    Public Sub FillComboBoxCategories()

        Dim listOfCategories As List(Of WorkCategory) = workCategoryDataInstance.ListOfCategories()

        For Each category In listOfCategories

            cbxWorkCategories.Items.Add(category.Name)

        Next

        'Another way out

        '  For i = 0 To listOfCategories.Count - 1

        ' cbxWorkCategories.Items.Add(listOfCategories.Item(i))

        ' Next i

    End Sub

    Public Sub FillComboBoxProjects()

        Dim listOfProjects As List(Of Project) = projectDataInstace.ListOfProjects()

        For Each project In ListOfProjects

            cbxProject.Items.Add(project.Project_Id & " - " & project.Project_Name)

        Next

    End Sub

    Public Sub FillComboBoxUsers()

        Dim listOfUsers As List(Of User) = userDataInstance.List_Of_Users()

        For Each user In listOfUsers

            cbxUsers.Items.Add(user.user_user_id & " - " & user.user_name)

        Next

    End Sub

    Public Sub UpdateTable()

        Me.dgvWorkedTime.DataSource = userTimeRegistrationInstance.FillDataGridView()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()
        frmHome.Show()

    End Sub

    Private Sub btnResetFilter_Click(sender As Object, e As EventArgs) Handles btnResetFilter.Click

        cbxProject.Text = " All"
        cbxUsers.Text = " All"
        cbxWorkCategories.Text = " All"
        UpdateTable()

    End Sub
End Class