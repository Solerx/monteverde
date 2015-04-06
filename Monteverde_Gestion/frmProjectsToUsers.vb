Public Class frmProjectsToUsers

    Dim assignedProjectInstance As AssignedProjectData = New AssignedProjectData

    Dim userdataInstance As Userdata = New Userdata

    Dim projectInstance As Projectdata = New Projectdata

    Dim row As Integer

    Dim row2 As Integer

    Dim row3 As Integer

    Private Sub frmUserProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        updateUserTable()
        updateProjectTable()

    End Sub

    Public Function SelectedItmes() As AssignedProject

        Dim firstId As Integer
        Dim secondId As Integer
        Dim hours As Integer

        Dim newEntry As New AssignedProject

        firstId = dgvProjects.Item(0, row2).Value()
        secondId = dgvUsers.Item(0, row).Value()
        hours = CInt(InputBox("Type the amount of hours to assign to this User."))

        newEntry.apProject = projectInstance.getProyectById(firstId)
        newEntry.apUser = userdataInstance.GetUserFromTable(secondId)
        newEntry.apWorkTime = hours

        SelectedItmes = newEntry

    End Function

    Private Sub dgvUsers_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUsers.CellClick

        row = dgvUsers.CurrentRow.Index
        updateAssignedProjectsTable()


    End Sub

    Private Sub dgvProjects_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProjects.CellClick

        row2 = dgvProjects.CurrentRow.Index

    End Sub

    Private Sub dgvAssignedProjects_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAssignedProjects.CellClick

        row3 = dgvAssignedProjects.CurrentRow.Index

    End Sub

    Public Sub updateUserTable()

        Me.dgvUsers.DataSource = assignedProjectInstance.FillDataGridViewUser()

    End Sub

    Public Sub updateProjectTable()

        Me.dgvProjects.DataSource = assignedProjectInstance.FillDataGridViewProject()

    End Sub

    Public Sub updateAssignedProjectsTable()

        Me.dgvAssignedProjects.DataSource = assignedProjectInstance.FillDataGridViewAssignedProject(dgvUsers.Item(0, row).Value())

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()
        frmHome.Show()

    End Sub

    Private Sub btnAddProjectToUser_Click(sender As Object, e As EventArgs) Handles btnAddProjectToUser.Click

        assignedProjectInstance.Insert(SelectedItmes)
        MsgBox("Project added to user successfully!")
        updateAssignedProjectsTable()

    End Sub

    Private Sub btnRemoveProject_Click(sender As Object, e As EventArgs) Handles btnRemoveProject.Click

        assignedProjectInstance.Delete(dgvUsers.Item(0, row).Value(), dgvAssignedProjects.Item(0, row3).Value())
        MsgBox("Project removed from User successfully!")
        updateAssignedProjectsTable()

    End Sub
End Class