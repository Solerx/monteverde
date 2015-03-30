Public Class frmProjectManagement

    Dim projectdataInstance As Projectdata = New Projectdata

    Dim row As Integer

    Private Sub frmProjectManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Hide_All()
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

    Public Sub Reset_Inputs()

        txtProjectContactInfo.ResetText()
        txtProjectEnterprise.ResetText()
        txtProjectHours.ResetText()
        txtProjectName.ResetText()

    End Sub

    Public Sub Show_All()

        txtProjectContactInfo.Show()
        txtProjectEnterprise.Show()
        txtProjectHours.Show()
        txtProjectName.Show()

        lblEditingUser.Show()
        lblProyectEnterprise.Show()
        lblProyectHours.Show()
        lblProyectInfo.Show()
        lblProyectName.Show()
        lblProyectStatus.Show()
        lblProjectId.Show()

        btnSave.Show()
        btnAdd.Show()

        cbxProjectsStatus.Show()

    End Sub

    Public Sub Hide_All()

        txtProjectContactInfo.Hide()
        txtProjectEnterprise.Hide()
        txtProjectHours.Hide()
        txtProjectName.Hide()

        lblEditingUser.Hide()
        lblProyectEnterprise.Hide()
        lblProyectHours.Hide()
        lblProyectInfo.Hide()
        lblProyectName.Hide()
        lblProyectStatus.Hide()
        lblProjectId.Hide()

        btnSave.Hide()
        btnAdd.Hide()

        cbxProjectsStatus.Hide()

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

        Show_All()
        cbxProjectsStatus.Enabled = False


    End Sub

    Private Sub btnEditProject_Click(sender As Object, e As EventArgs) Handles btnEditProject.Click

        Show_All()
        cbxProjectsStatus.Enabled = True
    End Sub
End Class