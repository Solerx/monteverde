Imports System.Data.SqlClient

Public Class frmUserManagement

    Dim dataTableProyects As New DataTable

    Dim row As Integer

    Dim userdataInstance As Userdata = New Userdata

    Private Sub frmUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.dgvUsers.DataSource = userdataInstance.Fill_Data_Grid_View()
        Hide_All()

    End Sub

    Public Sub Update_Table()

        Me.dgvUsers.DataSource = userdataInstance.Fill_Data_Grid_View()

    End Sub

    Public Sub Hide_All()

        lblUserName.Hide()
        lblUserEmail.Hide()
        lblUserPassword.Hide()
        lblUserWorkedHours.Hide()
        lblUserHolidays.Hide()
        lblRegisteredDate.Hide()
        lblUserRole.Hide()
        lblUserStatus.Hide()

        txtUserName.Hide()
        txtUserEmail.Hide()
        txtUserPassword.Hide()
        txtUserWorkedHours.Hide()
        txtUserHolidays.Hide()
        txtUserRegisteredDate.Hide()
        txtUserRole.Hide()
        txtUserStatus.Hide()

        btnSave.Hide()

    End Sub

    Public Sub Show_All()

        lblUserName.Show()
        lblUserEmail.Show()
        lblUserPassword.Show()
        lblUserWorkedHours.Show()
        lblUserHolidays.Show()
        lblRegisteredDate.Show()
        lblUserRole.Show()
        lblUserStatus.Show()

        txtUserName.Show()
        txtUserEmail.Show()
        txtUserPassword.Show()
        txtUserWorkedHours.Show()
        txtUserHolidays.Show()
        txtUserRegisteredDate.Show()
        txtUserRole.Show()
        txtUserStatus.Show()

        btnSave.Show()


    End Sub

    Public Function User_Inputs() As User

        Dim userName As String = " "
        Dim userEmail As String = " "
        Dim password As String = " "
        Dim workedHours As Integer
        Dim holidays As Integer
        Dim registeredDate As Date
        Dim userRole As Integer
        Dim isActive As Boolean

        Dim newUser As New User


        'If txtUserName.Text = vbNullString Or txtUserEmail.Text = vbNullString Or txtUserPassword.Text = vbNullString Or txtUserWorkedHours.Text = vbNullString Or txtUserHolidays.Text = vbNullString Or txtUserRegisteredDate.Text = vbNullString Or txtUserRole.Text = vbNullString Or txtUserStatus.Text = vbNullString Then

        'MsgBox("You can't leave any space blank.")
        'Dim reset = New frmUserManagement
        'reset.Show()
        'Me.Close()

        ' Else

        userName = txtUserName.Text
        userEmail = txtUserEmail.Text
        password = txtUserPassword.Text
        workedHours = CInt(txtUserWorkedHours.Text)
        holidays = CInt(txtUserHolidays.Text)
        registeredDate = CDate(txtUserRegisteredDate.Text)
        userRole = CInt(txtUserRole.Text)
        isActive = CInt(txtUserStatus.Text)


        'Here we create the object
        newUser.user_name = userName
        newUser.user_email = userEmail
        newUser.user_password = password
        newUser.user_worked_hours = workedHours
        newUser.user_holidays = holidays
        newUser.user_registered_date = registeredDate
        newUser.user_user_role = userRole
        newUser.user_is_active = isActive

        User_Inputs = newUser

        'End If



        'return the user


    End Function

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click

        Show_All()

    End Sub

    Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click

    End Sub

    Private Sub btnRemoveUser_Click(sender As Object, e As EventArgs) Handles btnRemoveUser.Click

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        userdataInstance.Insert(User_Inputs)
        Update_Table()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        frmHome.Show()
    End Sub
End Class