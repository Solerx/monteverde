Public Class frmProjectManagement

    Dim projectdataInstance As Projectdata = New Projectdata

    Dim row As Integer

    Private Sub frmProjectManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        hideAll()
        updateTable()
        Fill_Combobox()

    End Sub

    Public Sub Fill_Combobox()

        Dim role = New Dictionary(Of String, String)()

        role("1") = "New"
        role("2") = "On Progress"
        role("3") = "Finished"

        cbxProjectsStatus.DataSource = New BindingSource(role, Nothing)
        cbxProjectsStatus.DisplayMember = "Value"
        cbxProjectsStatus.ValueMember = "Key"
        cbxProjectsStatus.ForeColor = Color.White

    End Sub

    Public Sub resetInputs()

        txtProjectContactInfo.ResetText()
        txtProjectEnterprise.ResetText()
        txtProjectHours.ResetText()
        txtProjectName.ResetText()

    End Sub

    Public Sub showAll()

        txtProjectContactInfo.Show()
        txtProjectEnterprise.Show()
        txtProjectHours.Show()
        txtProjectName.Show()

        lblEditingUser.Show()
        lblProjectEnterprise.Show()
        lblProjectHours.Show()
        lblProjectInfo.Show()
        lblProjectName.Show()
        lblProjectStatus.Show()
        lblProjectId.Show()

        cbxProjectsStatus.Show()

    End Sub

    Public Sub hideAll()

        txtProjectContactInfo.Hide()
        txtProjectEnterprise.Hide()
        txtProjectHours.Hide()
        txtProjectName.Hide()

        lblEditingUser.Hide()
        lblProjectEnterprise.Hide()
        lblProjectHours.Hide()
        lblProjectInfo.Hide()
        lblProjectName.Hide()
        lblProjectStatus.Hide()
        lblProjectId.Hide()

        btnSave.Hide()
        btnAdd.Hide()

        cbxProjectsStatus.Hide()

    End Sub

    Public Function Project_Inputs() As Project

        Dim projectName As String = " "
        Dim projectEnterprise As String = " "
        Dim projectHours As Integer
        Dim projectStatus As String = " "
        Dim projectInfo As String = " "

        Dim newProject As New Project

        projectName = txtProjectName.Text
        projectEnterprise = txtProjectEnterprise.Text
        projectHours = CInt(txtProjectHours.Text)
        projectInfo = txtProjectContactInfo.Text
        projectStatus = cbxProjectsStatus.Text

        newProject.Project_Name = projectName
        newProject.Project_Enterprise = projectEnterprise
        newProject.Project_Hours = projectHours
        newProject.Project_Status = projectStatus
        newProject.Project_ContactInfo = projectInfo

        Project_Inputs = newProject

    End Function

    Public Sub Fill_Inputs(ByVal project As Project)

        txtProjectName.Text = project.Project_Name
        txtProjectEnterprise.Text = project.Project_Enterprise
        txtProjectHours.Text = project.Project_Hours
        txtProjectContactInfo.Text = project.Project_ContactInfo
        cbxProjectsStatus.Text = project.Project_Status

    End Sub


    Public Sub updateTable()

        Me.dgvProjects.DataSource = projectdataInstance.Fill_Data_Grid_View()

    End Sub

    Private Sub dgvProjects_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProjects.CellClick

        row = dgvProjects.CurrentRow.Index

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()
        frmHome.Show()

    End Sub

    Private Sub btnAddProject_Click(sender As Object, e As EventArgs) Handles btnAddProject.Click

        resetInputs()
        showAll()
        btnAdd.Show()
        cbxProjectsStatus.Enabled = False

    End Sub

    Private Sub btnEditProject_Click(sender As Object, e As EventArgs) Handles btnEditProject.Click

        showAll()
        btnSave.Show()
        Fill_Inputs(projectdataInstance.getProyectById(dgvProjects.Item(0, row).Value))
        cbxProjectsStatus.Enabled = True

    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtProjectContactInfo.Text = vbNullString Or txtProjectEnterprise.Text = vbNullString Or txtProjectHours.Text = vbNullString Or txtProjectName.Text = vbNullString Then

            MsgBox("You can't leave any space blank.")

        Else

            Dim alert = MsgBox("Are you sure you want to add this Project?", MsgBoxStyle.YesNo, "Adding new Project!")

            If alert = MsgBoxResult.Yes Then

                projectdataInstance.insertProject(Project_Inputs)
                updateTable()
                resetInputs()

            Else

                resetInputs()

            End If

        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtProjectContactInfo.Text = vbNullString Or txtProjectEnterprise.Text = vbNullString Or txtProjectHours.Text = vbNullString Or txtProjectName.Text = vbNullString Then

            MsgBox("You can't leave any space blank.")

        Else

            Dim alert = MsgBox("Are you sure you want to add this User?", MsgBoxStyle.YesNo, "Editing Project!")

            If alert = MsgBoxResult.Yes Then

                projectdataInstance.editProject(Project_Inputs, dgvProjects.Item(0, row).Value())
                updateTable()
                resetInputs()

            Else

                resetInputs()

            End If

        End If

    End Sub

    Private Sub btnRemoveProject_Click(sender As Object, e As EventArgs) Handles btnRemoveProject.Click

        hideAll()

        Dim alert = MsgBox("Are you sure you want remove Project ID: " & dgvProjects.Item(0, row).Value() & ", " & dgvProjects.Item(1, row).Value() & "?", MsgBoxStyle.YesNo, "Removing!")

        If alert = MsgBoxResult.Yes Then

            projectdataInstance.deleteProject(row, dgvProjects.Item(0, row).Value())
            updateTable()

        End If

    End Sub
End Class