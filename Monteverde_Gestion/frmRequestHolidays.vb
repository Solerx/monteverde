Public Class frmRequestHolidays

    Dim userDataInstance As Userdata = New Userdata

    Dim holidaysDataInstance As HolidaysData = New HolidaysData

    Dim user As User

    Private Sub frmRequestHolidays_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetUserHolidays()

        UpdateTable()

    End Sub

    Public Sub UpdateTable()

        Me.dgvHolidaysRequest.DataSource = holidaysDataInstance.FillDataGridView(1)


    End Sub

    Public Sub GetUserHolidays()

        user = userDataInstance.GetUserFromTable(frmLogin.globalUserId)
        lblHolidays.Text = user.user_holidays

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()
        frmHome.Show()

    End Sub

    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click

        Dim requestedHolidays As Integer

        requestedHolidays = txtUserHolidays.Text

        If requestedHolidays > user.user_holidays Then

            MsgBox("You requested more days than the ones you have available.")

        Else





        End If

    End Sub
End Class