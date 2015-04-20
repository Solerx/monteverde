Public Class frmRequestHolidays

    Dim userDataInstance As Userdata = New Userdata

    Dim holidaysDataInstance As HolidaysData = New HolidaysData

    Dim user As User = userDataInstance.GetUserFromTable(frmLogin.globalUserId)

    Dim row As Integer

    Private Sub frmRequestHolidays_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetUserHolidays()
        UpdateTable()

    End Sub

    Public Sub UpdateTable()

        Me.dgvHolidaysRequest.DataSource = holidaysDataInstance.FillDataGridViewUser(user.user_user_id)


    End Sub

    Public Sub GetUserHolidays()

        user = userDataInstance.GetUserFromTable(frmLogin.globalUserId)
        lblHolidays.Text = user.user_holidays

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()
        frmHome.Show()

    End Sub

    Public Function Inputs() As Holidays

        Dim holidaysToAsk As Integer
        Dim fromDate As DateTime
        Dim toDate As DateTime
        Dim status As String
        Dim notes As String
        Dim request As New Holidays


        holidaysToAsk = txtUserHolidays.Text
        fromDate = txtFromDate.Text
        toDate = txtToDate.Text
        status = "Pending"
        notes = rtbNotes.Text

        request.hRequested = holidaysToAsk
        request.hUser = user
        request.hFromDate = fromDate
        request.hToDate = toDate
        request.hStatus = status
        request.hNotes = notes

        Inputs = request

    End Function

    Public Sub ResetInputs()

        txtUserHolidays.BackColor = Color.Maroon
        txtUserHolidays.ForeColor = Color.White
        txtUserHolidays.ResetText()
        txtFromDate.BackColor = Color.Maroon
        txtFromDate.ForeColor = Color.White
        txtFromDate.ResetText()
        txtToDate.BackColor = Color.Maroon
        txtToDate.ForeColor = Color.White
        txtToDate.ResetText()

    End Sub



    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click

        Dim requestedHolidays As Integer

        requestedHolidays = txtUserHolidays.Text

        If requestedHolidays > user.user_holidays Then

            MsgBox("You requested more days than the ones you have available.")

        Else

            holidaysDataInstance.InsertRequest(Inputs)
            ResetInputs()
            UpdateTable()

        End If

    End Sub

    Private Sub OnlyNumbers_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserHolidays.KeyPress

        If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
                  Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            MessageBox.Show("Only numbers on this input.", "Worked Hours")
            e.Handled = True

            txtUserHolidays.BackColor = Color.Yellow
            txtUserHolidays.ForeColor = Color.Black

        End If

        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If

    End Sub

    Private Sub OnlyNumbersFromDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFromDate.KeyPress

        If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
                  Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            MessageBox.Show("Only numbers on this input.", "Worked Hours")
            e.Handled = True

            txtFromDate.BackColor = Color.Yellow
            txtFromDate.ForeColor = Color.Black

        End If

        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If

    End Sub
    Private Sub OnlyNumbersToDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtToDate.KeyPress

        If (Microsoft.VisualBasic.Asc(e.KeyChar) <> 8) And (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) _
                  Or (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) Then
            MessageBox.Show("Only numbers on this input.", "Worked Hours")
            e.Handled = True

            txtToDate.BackColor = Color.Yellow
            txtToDate.ForeColor = Color.Black

        End If

        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 8) Then
            e.Handled = False
        End If

    End Sub

    Private Sub dgvHolidaysRequest_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvHolidaysRequest.CellClick

        row = dgvHolidaysRequest.CurrentRow.Index

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        holidaysDataInstance.Delete(user.user_user_id, dgvHolidaysRequest.Item(6, row).Value())

    End Sub
End Class