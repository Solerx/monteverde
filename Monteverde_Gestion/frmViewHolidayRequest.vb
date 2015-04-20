Public Class frmViewHolidayRequest

    Dim userDataInstance As Userdata = New Userdata

    Dim holidaysDataInstance As HolidaysData = New HolidaysData

    Dim user As User

    Dim row As Integer

    Private Sub frmRequestHolidays_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UpdateTable()

    End Sub

    Public Sub UpdateTable()

        Me.dgvHolidaysRequest.DataSource = holidaysDataInstance.FillDataGridView()

    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()
        frmHome.Show()

    End Sub

    Private Sub dgvHolidaysRequest_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvHolidaysRequest.CellClick

        row = dgvHolidaysRequest.CurrentRow.Index

    End Sub

    Private Sub btnRejectRequest_Click(sender As Object, e As EventArgs) Handles btnRejectRequest.Click

        Dim alert = MsgBox("Are you sure you want to reject this request?", MsgBoxStyle.YesNo, "Pending Request!")

        If alert = MsgBoxResult.Yes Then

            holidaysDataInstance.Edit("Rejected", user.user_user_id, dgvHolidaysRequest.Item(6, row).Value())
            UpdateTable()

        Else

            UpdateTable()

        End If

    End Sub

    Private Sub btnAcceptRequest_Click(sender As Object, e As EventArgs) Handles btnAcceptRequest.Click

        Dim alert = MsgBox("Are you sure you want to accept this request?", MsgBoxStyle.YesNo, "Pending Request!")

        If alert = MsgBoxResult.Yes Then

            user = userDataInstance.GetUserFromTable(userDataInstance.GetIdUserFromName(dgvHolidaysRequest.Item(0, row).Value()))
            holidaysDataInstance.Edit("Accepted", user.user_user_id, dgvHolidaysRequest.Item(6, row).Value())
            user.user_holidays = user.user_holidays - dgvHolidaysRequest.Item(2, row).Value()
            user.user_user_role = userDataInstance.GetRoleClass(user.user_user_id)
            userDataInstance.Edit(user, user.user_user_id)
            UpdateTable()

        Else

            UpdateTable()

        End If

    End Sub

End Class