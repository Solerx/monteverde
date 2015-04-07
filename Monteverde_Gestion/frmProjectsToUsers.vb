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

    Public Function SelectedItmes(ByVal workTime As Integer) As AssignedProject

        Dim firstId As Integer
        Dim secondId As Integer
        Dim hours As Integer

        Dim newEntry As New AssignedProject

        firstId = dgvProjects.Item(0, row2).Value()
        secondId = dgvUsers.Item(0, row).Value()
        hours = workTime

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
                MsgBox("Project added to user successfully!")
            Else

                MsgBox("The amount of worktime assined is longer than the project's assigned hours!")

            End If

        Else

            MsgBox("The user has this project assigned.")

        End If

    End Sub

    Private Sub btnAddProjectToUser_Click(sender As Object, e As EventArgs) Handles btnAddProjectToUser.Click

        ValidationOfWorkTimeAdd()
        updateAssignedProjectsTable()
        updateProjectTable()

    End Sub

    Public Sub WorkTimeRemove()

        Dim workTimeFromProject As New Project

        Dim alreadyAssignedTime As Integer

        Dim newWorkTime As Integer

        alreadyAssignedTime = assignedProjectInstance.GetHoursAssigned(dgvUsers.Item(0, row).Value(), dgvAssignedProjects.Item(0, row3).Value())
        workTimeFromProject = projectInstance.getProyectById(dgvAssignedProjects.Item(0, row3).Value())
        newWorkTime = workTimeFromProject.Project_Hours + alreadyAssignedTime
        assignedProjectInstance.EditProjectHours(newWorkTime, dgvProjects.Item(0, row2).Value())
        assignedProjectInstance.Delete(dgvUsers.Item(0, row).Value(), dgvAssignedProjects.Item(0, row3).Value())
        MsgBox("Project Removed from user successfully!")

    End Sub

    Private Sub btnRemoveProject_Click(sender As Object, e As EventArgs) Handles btnRemoveProject.Click

        Dim alert = MsgBox("Are you sure you want remove this project from the user?", MsgBoxStyle.YesNo, "Removing!")

        If alert = MsgBoxResult.Yes Then
            WorkTimeRemove()
            updateAssignedProjectsTable()
            updateProjectTable()

        End If

    End Sub

    Public Sub ValidationOfWorkTimeEdit(ByVal workTime As Integer)

        Dim workTimeFromProject As New Project

        Dim alreadyAssignedTime As Integer

        Dim newWorkTime As Integer

        alreadyAssignedTime = assignedProjectInstance.GetHoursAssigned(dgvUsers.Item(0, row).Value(), dgvAssignedProjects.Item(0, row3).Value())
        workTimeFromProject = projectInstance.getProyectById(dgvAssignedProjects.Item(0, row3).Value())

        Dim totalHours = workTimeFromProject.Project_Hours + alreadyAssignedTime

        If totalHours >= workTime Then

            If alreadyAssignedTime > workTime Then

                newWorkTime = alreadyAssignedTime - workTime
                newWorkTime = newWorkTime + workTimeFromProject.Project_Hours
                assignedProjectInstance.EditProjectHours(newWorkTime, dgvAssignedProjects.Item(0, row3).Value())
                assignedProjectInstance.Edit(workTime, dgvUsers.Item(0, row).Value(), dgvAssignedProjects.Item(0, row3).Value())
                MsgBox("Project time edited successfully!")
                updateAssignedProjectsTable()
                updateProjectTable()


            Else

                newWorkTime = workTime - alreadyAssignedTime
                newWorkTime = workTimeFromProject.Project_Hours - newWorkTime
                assignedProjectInstance.EditProjectHours(newWorkTime, dgvAssignedProjects.Item(0, row3).Value())
                assignedProjectInstance.Edit(workTime, dgvUsers.Item(0, row).Value(), dgvAssignedProjects.Item(0, row3).Value())
                MsgBox("Project time edited successfully!")
                updateAssignedProjectsTable()
                updateProjectTable()

            End If

        Else

            MsgBox("The amount of worktime assined is longer than the project's assigned hours!")

        End If

    End Sub
   
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Dim workTime As Integer = CInt(InputBox("Enter the new amount of hours.", "Editing Work Time", 1))

        ValidationOfWorkTimeEdit(workTime)

    End Sub
End Class