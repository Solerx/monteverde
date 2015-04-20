Imports System.Data.SqlClient

Public Class frmUserManagement

    Dim dataTableProyects As New DataTable

    Dim row As Integer

    Dim userdataInstance As Userdata = New Userdata

    Private Sub frmUserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        updateUserTable()
        Hide_All()
        Fill_Combobox()
        Fill_ComboboxStatus()

    End Sub

    Public Sub updateUserTable()

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
        lblEditingUser.Hide()
        lblUserId.Hide()
        cbxUserRole.Hide()
        cbxUserStatus.Hide()

        txtUserName.Hide()
        txtUserEmail.Hide()
        txtUserPassword.Hide()
        txtUserWorkedHours.Hide()
        txtUserHolidays.Hide()
        txtUserRegisteredDate.Hide()

        btnSave.Hide()
        btnAdd.Hide()

    End Sub

    Public Sub Reset_Spaces()

        txtUserName.ResetText()
        txtUserEmail.ResetText()
        txtUserPassword.ResetText()
        txtUserRegisteredDate.ResetText()
        'cbxUserStatus.Refresh()
        'cbxUserRole.Refresh()
        txtUserHolidays.BackColor = Color.Maroon
        txtUserWorkedHours.BackColor = Color.Maroon
        txtUserHolidays.ForeColor = Color.White
        txtUserWorkedHours.ForeColor = Color.White

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
        cbxUserRole.Show()
        cbxUserStatus.Show()

        txtUserName.Show()
        txtUserEmail.Show()
        txtUserPassword.Show()
        txtUserWorkedHours.Show()
        txtUserHolidays.Show()
        txtUserRegisteredDate.Show()

    End Sub

    Public Function User_Inputs() As User

        Dim userName As String = " "
        Dim userEmail As String = " "
        Dim password As String = " "
        Dim workedHours As Double
        Dim holidays As Integer
        Dim userRole As String
        Dim userSince As DateTime
        Dim isActive As Boolean
        Dim newUser As New User


        userName = txtUserName.Text
        userEmail = txtUserEmail.Text
        password = txtUserPassword.Text
        workedHours = CInt(txtUserWorkedHours.Text)
        holidays = CInt(txtUserHolidays.Text)
        userSince = DateTime.Now
        userRole = cbxUserRole.Text

        If cbxUserStatus.SelectedIndex = 0 Then

            isActive = True

        Else

            isActive = False

        End If

        newUser.user_name = userName
        newUser.user_email = userEmail
        newUser.user_password = password
        newUser.user_worked_hours = workedHours
        newUser.user_holidays = holidays
        newUser.user_user_role = userdataInstance.GetRoleId(userRole)
        newUser.user_registered_date = userSince
        newUser.user_is_active = isActive

        User_Inputs = newUser

    End Function

    Public Sub Fill_Combobox()

        Dim role = New Dictionary(Of String, String)()

        role("1") = "Parent-Administrator"
        role("2") = "Administrator"
        role("3") = "User"

        cbxUserRole.DataSource = New BindingSource(role, Nothing)
        cbxUserRole.DisplayMember = "Value"
        cbxUserRole.ValueMember = "Key"
        cbxUserRole.ForeColor = Color.White

    End Sub

    Public Sub Fill_ComboboxStatus()

        Dim status = New Dictionary(Of String, String)()

        status("1") = "Active"
        status("2") = "Inactive"

        cbxUserStatus.DataSource = New BindingSource(status, Nothing)
        cbxUserStatus.DisplayMember = "Value"
        cbxUserStatus.ValueMember = "Key"
        cbxUserStatus.ForeColor = Color.White

    End Sub

    Public Sub Fill_Inputs(ByVal user As User)

        lblUserId.Text = user.user_user_id
        txtUserName.Text = user.user_name
        txtUserEmail.Text = user.user_email
        txtUserPassword.Text = user.user_password
        txtUserWorkedHours.Text = user.user_worked_hours
        txtUserHolidays.Text = user.user_holidays
        txtUserRegisteredDate.Text = user.user_registered_date

        Select Case user.user_user_role.role_role_name

            Case "Parent-Administrator"
                cbxUserRole.SelectedIndex = 0
            Case "Administrator"
                cbxUserRole.SelectedIndex = 1
            Case "User"
                cbxUserRole.SelectedIndex = 2
        End Select

        'cbxUserRole.SelectedValue = user.user_user_role.role_id_role

        If user.user_is_active = True Then

            cbxUserStatus.SelectedIndex = 0
        Else

            cbxUserStatus.SelectedIndex = 1

        End If


    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click

        Hide_All()
        Reset_Spaces()
        btnAdd.Show()
        Show_All()
        txtUserRegisteredDate.Enabled = True
        txtUserWorkedHours.Enabled = False
        txtUserHolidays.Enabled = False
        txtUserRegisteredDate.Text = DateTime.Now
        lblRegisteredDate.Hide()
        txtUserRegisteredDate.Hide()

    End Sub

    Private Sub dgvUsers_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUsers.CellClick

        row = dgvUsers.CurrentRow.Index

    End Sub

    Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click

        Show_All()
        btnAdd.Hide()
        txtUserRegisteredDate.Enabled = False
        Fill_Inputs(userdataInstance.GetUserFromTable(dgvUsers.Item(0, row).Value))
        lblEditingUser.Show()
        lblUserId.Show()
        txtUserWorkedHours.Enabled = True
        txtUserHolidays.Enabled = True
        btnSave.Show()


    End Sub

    Private Sub btnRemoveUser_Click(sender As Object, e As EventArgs) Handles btnRemoveUser.Click

        Hide_All()

        Dim alert = MsgBox("Are you sure you want remove user ID: " & dgvUsers.Item(0, row).Value() & ", " & dgvUsers.Item(1, row).Value() & "?", MsgBoxStyle.YesNo, "Removing!")

        If alert = MsgBoxResult.Yes Then

            userdataInstance.delete(row, dgvUsers.Item(0, row).Value())
            updateUserTable()

        End If
        

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        If txtUserName.Text = vbNullString Or txtUserEmail.Text = vbNullString Or txtUserPassword.Text = vbNullString Or txtUserWorkedHours.Text = vbNullString Or txtUserHolidays.Text = vbNullString Or txtUserRegisteredDate.Text = vbNullString Or cbxUserStatus.Text = vbNullString Or cbxUserRole.Text = vbNullString Then

            MsgBox("You can't leave any space blank.")

        Else

            Dim alert = MsgBox("Are you sure you want to save changes?", MsgBoxStyle.YesNo, "Saving!")

            If alert = MsgBoxResult.Yes Then

                userdataInstance.Edit(User_Inputs, dgvUsers.Item(0, row).Value())
                updateUserTable()
                Reset_Spaces()
                MsgBox("User edited successfully!")
            Else

                Reset_Spaces()

            End If

        End If

        Hide_All()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()
        frmHome.Show()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtUserName.Text = vbNullString Or txtUserEmail.Text = vbNullString Or txtUserPassword.Text = vbNullString Or txtUserWorkedHours.Text = vbNullString Or txtUserHolidays.Text = vbNullString Or txtUserRegisteredDate.Text = vbNullString Or cbxUserRole.Text = vbNullString Or cbxUserStatus.Text = vbNullString Then

            MsgBox("You can't leave any space blank.")

        Else

            Dim alert = MsgBox("Are you sure you want to add this User?", MsgBoxStyle.YesNo, "Adding new User!")

            If alert = MsgBoxResult.Yes Then

                userdataInstance.Insert(User_Inputs)
                updateUserTable()
                Reset_Spaces()
                Hide_All()

            Else

                Reset_Spaces()

            End If

        End If



    End Sub

    Private Sub OnlyNumbersHolidays_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserHolidays.KeyPress

        If (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
                  Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            MessageBox.Show("Only numbers on this input.", "Holidays")
            e.Handled = True
            txtUserHolidays.BackColor = Color.Yellow
            txtUserHolidays.ForeColor = Color.Black

        End If
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then

            e.Handled = False
        End If
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