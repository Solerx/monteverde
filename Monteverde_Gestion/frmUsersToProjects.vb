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

    Public Function SelectedItmes(ByVal workTime As Integer) As AssignedProject

        Dim firstId As Integer
        Dim secondId As Integer
        Dim hours As Integer

        Dim newEntry As New AssignedProject

        firstId = dgvUsers.Item(0, row).Value()
        secondId = dgvProjects.Item(0, row2).Value()
        hours = workTime

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

    Public Sub ValidationOfWorkTimeAdd()

        Dim workTimeFromProject As New Project

        Dim userAssigned As Boolean

        Dim newWorkTime As Integer

        workTimeFromProject = projectInstance.getProyectById(dgvProjects.Item(0, row2).Value())
        userAssigned = userdataInstance.GetUserIfAssigned(dgvUsers.Item(0, row).Value(), dgvProjects.Item(0, row2).Value())

        If userAssigned = False Then

            Dim workTime As Integer = CInt(InputBox("Enter the amount of hours for this User.", "Adding Project's Work Time to User."))

            If workTimeFromProject.Project_Hours >= workTime Then

                newWorkTime = workTimeFromProject.Project_Hours - workTime
                assignedProjectInstance.Insert(SelectedItmes(workTime))
                assignedProjectInstance.EditProjectHours(newWorkTime, dgvProjects.Item(0, row2).Value())
                MsgBox("User added to project successfully!")
            Else

                MsgBox("The amount of worktime assined is longer than the project's assigned hours!")

            End If

        Else

            MsgBox("The user has this project assigned.")

        End If

    End Sub

    Private Sub btnAddUserToProject_Click(sender As Object, e As EventArgs) Handles btnAddUserToProject.Click

        ValidationOfWorkTimeAdd()

        updateAssignedUsersTable()
        updateProjectTable()

    End Sub

    Public Sub WorkTimeRemove()

        Dim workTimeFromProject As New Project

        Dim alreadyAssignedTime As Integer

        Dim newWorkTime As Integer

        alreadyAssignedTime = assignedProjectInstance.GetHoursAssigned(dgvAssignedUsers.Item(0, row3).Value(), dgvProjects.Item(0, row2).Value())
        workTimeFromProject = projectInstance.getProyectById(dgvProjects.Item(0, row2).Value())
        newWorkTime = workTimeFromProject.Project_Hours + alreadyAssignedTime
        assignedProjectInstance.EditProjectHours(newWorkTime, dgvProjects.Item(0, row2).Value())
        assignedProjectInstance.Delete(dgvAssignedUsers.Item(0, row3).Value(), dgvProjects.Item(0, row2).Value())
        MsgBox("Project Removed from user successfully!")

    End Sub

    Private Sub btnRemoveProject_Click(sender As Object, e As EventArgs) Handles btnRemoveProject.Click

        Dim alert = MsgBox("Are you sure you want remove this project from the user?", MsgBoxStyle.YesNo, "Removing!")

        If alert = MsgBoxResult.Yes Then

            WorkTimeRemove()
            updateAssignedUsersTable()
            updateProjectTable()

        End If

    End Sub

    Public Sub ValidationOfWorkTime()

        Dim workTime = InputBox("Enter the new amount of hours.", "Editing Work Time", 1)

        If workTime <> "" Then



            Dim workTimeFromProject As New Project

            Dim alreadyAssignedTime As Integer

            Dim newWorkTime As Integer


            alreadyAssignedTime = assignedProjectInstance.GetHoursAssigned(dgvAssignedUsers.Item(0, row3).Value(), dgvProjects.Item(0, row2).Value())
            workTimeFromProject = projectInstance.GetProyectById(dgvProjects.Item(0, row2).Value())

            Dim totalHours = workTimeFromProject.Project_Hours + alreadyAssignedTime

            If totalHours >= workTime Then

                If alreadyAssignedTime > workTime Then

                    newWorkTime = alreadyAssignedTime - workTime
                    newWorkTime = newWorkTime + workTimeFromProject.Project_Hours
                    assignedProjectInstance.EditProjectHours(newWorkTime, dgvProjects.Item(0, row2).Value())
                    assignedProjectInstance.Edit(workTime, dgvAssignedUsers.Item(0, row3).Value(), dgvProjects.Item(0, row2).Value())
                    MsgBox("User time edited successfully!")
                    updateAssignedUsersTable()
                    updateProjectTable()


                Else

                    newWorkTime = workTime - alreadyAssignedTime
                    newWorkTime = workTimeFromProject.Project_Hours - newWorkTime
                    assignedProjectInstance.EditProjectHours(newWorkTime, dgvProjects.Item(0, row2).Value())
                    assignedProjectInstance.Edit(workTime, dgvAssignedUsers.Item(0, row3).Value(), dgvProjects.Item(0, row2).Value())
                    MsgBox("User time edited successfully!")
                    updateAssignedUsersTable()
                    updateProjectTable()

                End If

            Else

                MsgBox("The amount of worktime assined is longer than the project's assigned hours!")

            End If


        Else

            Exit Sub

        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        ValidationOfWorkTime()
        updateAssignedUsersTable()
        updateProjectTable()

    End Sub
End Class