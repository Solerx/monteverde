Public Class frmUserToProjects

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

        firstId = dgvUsers.Item(0, row).Value()
        secondId = dgvProjects.Item(0, row2).Value()
        hours = CInt(InputBox("Type the amount of hours to assign to this User."))

        newEntry.apUser = userdataInstance.GetUserFromTable(firstId)
        newEntry.apProject = projectInstance.getProyectById(secondId)
        newEntry.apWorkTime = hours

        SelectedItmes = newEntry

    End Function


    Private Sub dgvUsers_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUsers.CellClick

        row = dgvUsers.CurrentRow.Index

    End Sub

    Private Sub dgvProjects_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProjects.CellClick

        row2 = dgvProjects.CurrentRow.Index
        updateAssignedUsersTable()

    End Sub

    Private Sub dgvAssignedUsers_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAssignedUsers.CellClick

        row3 = dgvAssignedUsers.CurrentRow.Index

    End Sub

    Public Sub updateUserTable()

        Me.dgvUsers.DataSource = assignedProjectInstance.FillDataGridViewUser()

    End Sub

    Public Sub updateProjectTable()

        Me.dgvProjects.DataSource = assignedProjectInstance.FillDataGridViewProject()

    End Sub

    Public Sub updateAssignedUsersTable()

        Me.dgvAssignedUsers.DataSource = assignedProjectInstance.FillDataGridViewAssignedUser(dgvProjects.Item(0, row2).Value())

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()
        frmHome.Show()

    End Sub

    Private Sub btnAddUserToProject_Click(sender As Object, e As EventArgs) Handles btnAddUserToProject.Click

        assignedProjectInstance.Insert(SelectedItmes)
        MsgBox("User added to project successfully!")
        updateAssignedUsersTable()

    End Sub


    Private Sub btnRemoveProject_Click(sender As Object, e As EventArgs) Handles btnRemoveProject.Click

        assignedProjectInstance.Delete(dgvAssignedUsers.Item(0, row2).Value(), dgvProjects.Item(0, row2).Value())
        MsgBox("User removed from User successfully!")
        updateAssignedUsersTable()

    End Sub
End Class