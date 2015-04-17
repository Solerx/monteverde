Public Class frmViewHolidayRquest

    Dim userDataInstance As Userdata = New Userdata

    Dim holidaysDataInstance As HolidaysData = New HolidaysData

    Dim user As User

    Private Sub frmRequestHolidays_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UpdateTable()

    End Sub

    Public Sub UpdateTable()

        Me.dgvHolidaysRequest.DataSource = holidaysDataInstance.FillDataGridView(1)


    End Sub

    Private Sub frmViewHolidayRquest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()
        frmHome.Show()

    End Sub
End Class