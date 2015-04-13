Imports System.Data.SqlClient

Public Class frmNewTimeRegistration

    Dim strConexion As String = "Data Source=SOLERPC\MONTEVERDE;Initial Catalog=Monteverdedb;Integrated Security=True"

    Dim connection As New SqlConnection(strConexion)

    Dim userDataInstace As Userdata = New Userdata

    Dim projectDataInstace As Projectdata = New Projectdata

    Dim assignedProjectInstance As AssignedProjectData = New AssignedProjectData

    Dim workCategoryDataInstance As WorkCategoryData = New WorkCategoryData

    Dim userTimeRegistrationDataInstance As UserTimeRegistrationData = New UserTimeRegistrationData

    Dim chronometer As New DateTime

    Dim userWorkedHours As Integer

    Dim row2 As Integer

    Private Sub frmNewTimeRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UpdateTable()
        HideAll()
        FillCombobox()

    End Sub

    Public Sub UpdateTable()

        Me.dgvAssignedProjects.DataSource = assignedProjectInstance.FillDataGridViewAssignedProject(frmLogin.globalUserId)
        Me.dgvUserWorkedTime.DataSource = userTimeRegistrationDataInstance.FillDataGridViewWithUserTime(userTimeRegistrationDataInstance.ListOfWorkedTimeByUserId(frmLogin.globalUserId))

    End Sub

    Public Sub ResetAll()

        cbxWorkCategories.ResetText()
        txtUserWorkedHours.ResetText()
        rtbNotes.ResetText()
        btnFinishWork.Enabled = True
        btnStartToWork.Enabled = True
        HideAll()

    End Sub

    Public Sub FillComboBox()

        Dim listOfCategories As List(Of WorkCategory) = workCategoryDataInstance.ListOfCategories()

        For Each category In listOfCategories

            cbxWorkCategories.Items.Add(category.Name)

        Next

        'Another way out

        '  For i = 0 To listOfCategories.Count - 1

        ' cbxWorkCategories.Items.Add(listOfCategories.Item(i))

        ' Next i

    End Sub

    Public Function Inputs() As UserTimeRegistration

        Dim timeStamp As DateTime
        Dim workCategory As String
        Dim notes As String
        Dim newRegister As New UserTimeRegistration

        workCategory = cbxWorkCategories.Text
        notes = rtbNotes.Text
        timeStamp = DateTime.Now

        newRegister.UtUser = userDataInstace.GetUserFromTable(frmLogin.globalUserId)
        newRegister.UtWorkTimeCategory = workCategoryDataInstance.GetCategoryByName(workCategory)
        newRegister.UtProject = projectDataInstace.GetProyectById(dgvAssignedProjects.Item(0, row2).Value())
        newRegister.UtWorkTime = userWorkedHours
        newRegister.UtUserNotes = notes
        newRegister.UtTimeStampDate = timeStamp

        Inputs = newRegister

    End Function

    Public Function ValidationOfWorkTimeEdit(ByVal workTime As Integer) As Boolean

        Dim workTimeFromProject As New Project

        Dim alreadyAssignedTime As Integer

        Dim newWorkTime As Integer

        alreadyAssignedTime = assignedProjectInstance.GetHoursAssigned(frmLogin.globalUserId, dgvAssignedProjects.Item(0, row2).Value())

        If alreadyAssignedTime >= workTime Then

            newWorkTime = alreadyAssignedTime - workTime
            assignedProjectInstance.Edit(newWorkTime, frmLogin.globalUserId, dgvAssignedProjects.Item(0, row2).Value())
            ValidationOfWorkTimeEdit = True
            UpdateTable()

        Else

            ValidationOfWorkTimeEdit = False
            UpdateTable()

        End If


    End Function

    Public Sub HideAll()

        lblWorkCategories.Hide()
        cbxWorkCategories.Hide()
        lblUserWorkedHours.Hide()
        txtUserWorkedHours.Hide()
        lblChrono.Hide()
        lblNotes.Hide()
        rtbNotes.Hide()
        btnRegister.Hide()
        btnFinishWork.Hide()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()
        frmHome.Show()

    End Sub

    Private Sub dgvAssignedProjects_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAssignedProjects.CellClick

        row2 = dgvAssignedProjects.CurrentRow.Index

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        If ValidationOfWorkTimeEdit(Inputs.UtWorkTime) = False Then

            UpdateTable()
            MsgBox("You can't work more hours on this project as the ones already assigned." & vbCrLf & "Contact an administrator.")

        Else

            userTimeRegistrationDataInstance.Insert(Inputs())
            Dim timeStamp As DateTime = DateTime.Now
            UpdateTable()
            ResetAll()

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim Difference As TimeSpan = DateTime.Now.Subtract(chronometer)

        Dim alreadyAssignedTime As Integer

        alreadyAssignedTime = assignedProjectInstance.GetHoursAssigned(frmLogin.globalUserId, dgvAssignedProjects.Item(0, row2).Value())

        lblChrono.Text = Difference.Hours.ToString & ":" & Difference.Minutes.ToString & ":" & Difference.Seconds.ToString

        If Difference.Hours = alreadyAssignedTime Then

            Timer1.Stop()
            MsgBox("You already complete your hours assigned to this proyect." & vbCrLf & "Contact an administrator.")
            lblWorkCategories.Show()
            cbxWorkCategories.Show()
            lblUserWorkedHours.Hide()
            txtUserWorkedHours.Hide()
            lblNotes.Show()
            rtbNotes.Show()
            btnRegister.Show()
            btnFinishWork.Enabled = False
            userWorkedHours = Difference.Hours

        End If

        userWorkedHours = Difference.Hours

    End Sub


    Private Sub btnFinishWork_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinishWork.Click

        Timer1.Stop()
        lblWorkCategories.Show()
        cbxWorkCategories.Show()
        lblUserWorkedHours.Hide()
        txtUserWorkedHours.Hide()
        lblNotes.Show()
        rtbNotes.Show()
        btnRegister.Show()
        btnFinishWork.Enabled = False

    End Sub

    Private Sub btnStartToWork_Click(sender As Object, e As EventArgs) Handles btnStartToWork.Click

        lblChrono.Show()
        chronometer = DateTime.Now 'This will change 'Time' to the current time
        Timer1.Start() 'Starts the Timer.
        btnStartToWork.Enabled = False
        btnFinishWork.Show()

    End Sub
End Class