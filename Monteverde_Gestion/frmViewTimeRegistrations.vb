Public Class frmViewTimeRegistrations

    Dim userTimeRegistrationInstance As UserTimeRegistrationData = New UserTimeRegistrationData

    Dim workCategoryDataInstance As WorkCategoryData = New WorkCategoryData

    Dim userDataInstance As Userdata = New Userdata

    Dim assignedProjectDataInstance As AssignedProjectData = New AssignedProjectData

    Dim projectDataInstace As Projectdata = New Projectdata

    Dim userRegistrationDataInstance As UserTimeRegistrationData = New UserTimeRegistrationData

    Dim row As Integer

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

            cbxProject.Items.Add(project.Project_Name)

        Next

    End Sub

    Public Sub FillComboBoxUsers()

        Dim listOfUsers As List(Of User) = userDataInstance.List_Of_Users()

        For Each user In listOfUsers

            cbxUsers.Items.Add(user.user_name)

        Next

    End Sub

    Public Sub UpdateTable()

        Me.dgvWorkedTime.DataSource = userTimeRegistrationInstance.FillDataGridView()
        txtUserWorkedHours.Hide()
        lblUserWorkedHours.Hide()
        btnSave.Hide()

    End Sub

    Private Sub dgvUsers_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvWorkedTime.CellClick

        row = dgvWorkedTime.CurrentRow.Index

    End Sub

    Public Sub FilterTableByName()

            Me.dgvWorkedTime.DataSource = userTimeRegistrationInstance.GridViewFilteredByUser(cbxUsers.Text)

    End Sub

    Public Sub FilterTableByProject()

            Me.dgvWorkedTime.DataSource = userTimeRegistrationInstance.GridViewFilteredByProject(cbxProject.Text)

    End Sub

    Public Sub FilterTableByWorkCategory()

        Me.dgvWorkedTime.DataSource = userTimeRegistrationInstance.GridViewFilteredByWorkCategory(cbxWorkCategories.Text)

    End Sub

    Public Sub FilterTableByUserProject()

        Me.dgvWorkedTime.DataSource = userTimeRegistrationInstance.GridViewFilteredByUserProject(cbxUsers.Text, cbxProject.Text)

    End Sub

    Public Sub FilterTableByUserWorkCategory()

        Me.dgvWorkedTime.DataSource = userTimeRegistrationInstance.GridViewFilteredByUserCategory(cbxUsers.Text, cbxWorkCategories.Text)

    End Sub

    Public Sub FilterTableByProjectWorkCategory()

        Me.dgvWorkedTime.DataSource = userTimeRegistrationInstance.GridViewFilteredByProjectCategory(cbxProject.Text, cbxWorkCategories.Text)

    End Sub

    Public Sub FilterTableByUserProjectWorkCategory()

        Me.dgvWorkedTime.DataSource = userTimeRegistrationInstance.GridViewFilteredByUserProjectCategory(cbxUsers.Text, cbxProject.Text, cbxWorkCategories.Text)

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

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click


        If cbxUsers.Text <> " All" And cbxProject.Text = " All" And cbxWorkCategories.Text = " All" Then

            FilterTableByName()

        ElseIf cbxUsers.Text = " All" And cbxProject.Text <> " All" And cbxWorkCategories.Text = " All" Then

            FilterTableByProject()

        ElseIf cbxUsers.Text = " All" And cbxProject.Text = " All" And cbxWorkCategories.Text <> " All" Then

            FilterTableByWorkCategory()

        ElseIf cbxUsers.Text <> " All" And cbxProject.Text <> " All" And cbxWorkCategories.Text = " All" Then

            FilterTableByUserProject()

        ElseIf cbxUsers.Text <> " All" And cbxProject.Text = " All" And cbxWorkCategories.Text <> " All" Then

            FilterTableByUserWorkCategory()

        ElseIf cbxUsers.Text = " All" And cbxProject.Text <> " All" And cbxWorkCategories.Text <> " All" Then

            FilterTableByProjectWorkCategory()

        ElseIf cbxUsers.Text <> " All" And cbxProject.Text <> " All" And cbxWorkCategories.Text <> " All" Then

            FilterTableByUserProjectWorkCategory()

        End If


    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        lblUserWorkedHours.Show()
        txtUserWorkedHours.Show()
        txtUserWorkedHours.Text = dgvWorkedTime.Item(2, row).Value()
        btnSave.Show()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim workTime As Integer
        Dim userName As Integer
        Dim projectName As Integer
        Dim notes As String

        userName = userDataInstance.GetIdUserFromName(dgvWorkedTime.Item(0, row).Value())
        workTime = txtUserWorkedHours.Text
        projectName = projectDataInstace.GetProyectByName(dgvWorkedTime.Item(1, row).Value())
        notes = dgvWorkedTime.Item(4, row).Value()

        userRegistrationDataInstance.EditWorkTimeFromUser(workTime, userName, projectName, notes)

        txtUserWorkedHours.BackColor = Color.Maroon
        txtUserWorkedHours.ForeColor = Color.White

        UpdateTable()

    End Sub

    Private Sub OnlyNumbersWorkedHours_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserWorkedHours.KeyPress

        If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
                  Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            MessageBox.Show("Only numbers on this input.", "Worked Hours")
            e.Handled = True
            txtUserWorkedHours.BackColor = Color.Yellow
            txtUserWorkedHours.ForeColor = Color.Black

        End If

        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False

        End If
    End Sub
End Class