Imports System.Data.SqlClient

Public Class HolidaysData

    Dim strConexion As String = "Data Source=SOLERPC\MONTEVERDE;Initial Catalog=Monteverdedb;Integrated Security=True"

    'Dim strConexion As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\MonteverdeDataBase.mdf;Integrated Security=True;Connect Timeout=30"

    Dim connection As New SqlConnection(strConexion)

    Dim userDataInstance As Userdata = New Userdata

    Dim user As User

    Dim dataTableRequested As New DataTable

    Public acceptedRequest As New Integer

    Public pendingRequests As New Integer

    Public Function CreateDataTable() As DataTable

        'Create Users table
        dataTableRequested = New DataTable

        dataTableRequested.Columns.Add("User")
        dataTableRequested.Columns.Add("Holidays Available")
        dataTableRequested.Columns.Add("Holidays Requested")
        dataTableRequested.Columns.Add("From Date")
        dataTableRequested.Columns.Add("To Date")
        dataTableRequested.Columns.Add("Status")
        dataTableRequested.Columns.Add("Notes")

        CreateDataTable = dataTableRequested


    End Function

    Public Function FillDataGridViewUser(ByVal idUser As Integer) As DataTable

        dataTableRequested = CreateDataTable()

        Dim requestGridView As List(Of Holidays)

        requestGridView = ListOfRequests()

        Dim row As DataRow

        For i = 0 To requestGridView.Count - 1 Step 1

            row = dataTableRequested.NewRow
            row("User") = requestGridView(i).hUser.user_name
            row("Holidays Available") = userDataInstance.GetUserFromTable(requestGridView(i).hUser.user_user_id).user_holidays
            row("Holidays Requested") = requestGridView(i).hRequested
            row("From Date") = requestGridView(i).hFromDate
            row("To Date") = requestGridView(i).hToDate
            row("Status") = requestGridView(i).hStatus
            row("Notes") = requestGridView(i).hNotes

            If requestGridView(i).hUser.user_user_id = idUser Then

                dataTableRequested.Rows.Add(row)

            End If


        Next

        FillDataGridViewUser = dataTableRequested

    End Function

    Public Function FillDataGridView() As DataTable

        dataTableRequested = CreateDataTable()

        Dim requestGridView As List(Of Holidays)

        requestGridView = ListOfRequests()

        Dim row As DataRow

        For i = 0 To requestGridView.Count - 1 Step 1

            row = dataTableRequested.NewRow
            row("User") = requestGridView(i).hUser.user_name
            row("Holidays Available") = userDataInstance.GetUserFromTable(requestGridView(i).hUser.user_user_id).user_holidays
            row("Holidays Requested") = requestGridView(i).hRequested
            row("From Date") = requestGridView(i).hFromDate
            row("To Date") = requestGridView(i).hToDate
            If requestGridView(i).hStatus = "Pending" Then

                pendingRequests = pendingRequests + 1

            End If
            row("Status") = requestGridView(i).hStatus
            row("Notes") = requestGridView(i).hNotes
            dataTableRequested.Rows.Add(row)

        Next

        FillDataGridView = dataTableRequested

    End Function

    Public Function ListOfRequests() As List(Of Holidays)

        'From table Usersdb, obtain all the rows.
        connection.Close()

        Dim cmdSelectUser As New SqlCommand("SELECT id_user,holidays_requested,date_from,date_to,status,notes FROM User_Holidays", connection)
        connection.Open()

        Dim reader As SqlDataReader = cmdSelectUser.ExecuteReader()

        Dim resquestList As New List(Of Holidays)

        Dim request As New Holidays

        Do While reader.HasRows

            Do While reader.Read()

                request = New Holidays
                request.hUser = userDataInstance.GetUserFromTable(reader.GetInt32(0))
                request.hRequested = reader.GetInt16(1)
                request.hFromDate = reader.GetDateTime(2)
                request.hToDate = reader.GetDateTime(3)
                request.hStatus = reader.GetString(4)
                request.hNotes = reader.GetString(5)
                resquestList.Add(request)

            Loop

            reader.NextResult()

        Loop

        reader.Close()
        connection.Close()
        ListOfRequests = resquestList


    End Function

    Public Sub InsertRequest(ByVal request As Holidays)

        connection.Close()

        Dim cmdInsert As New SqlCommand

        cmdInsert = New SqlCommand("insert into User_Holidays(id_user,holidays_requested,date_from,date_to,status,notes)" & _
                                   "values(@id_user,@holidays_requested,@date_from,@date_to,@status,@notes)", connection)
        connection.Open()

        With cmdInsert

            .Parameters.AddWithValue("@id_user", request.hUser.user_user_id)
            .Parameters.AddWithValue("@holidays_requested", request.hRequested)
            .Parameters.AddWithValue("@date_from", request.hFromDate)
            .Parameters.AddWithValue("@date_to", request.hToDate)
            .Parameters.AddWithValue("@status", request.hStatus)
            .Parameters.AddWithValue("@notes", request.hNotes)

        End With

        cmdInsert.ExecuteNonQuery()
        MsgBox("Holidays request successfull.")
        connection.Close()

    End Sub

    Public Sub Delete(ByVal idUser As Integer, ByVal notes As String)

        connection.Close()

        Dim cmdUpdate As New SqlCommand

        cmdUpdate = New SqlCommand("Delete from User_Holidays " & _
                                   "where id_user = " & idUser & "AND notes = '" & notes & "'", connection)

        connection.Open()
        cmdUpdate.ExecuteNonQuery()
        connection.Close()
        MsgBox("Request canceled successfully!")


    End Sub

    Public Sub Edit(ByVal status As String, idUser As Integer, ByVal notes As String)

        connection.Open()

        Dim cmdUpdate As New SqlCommand

        cmdUpdate = New SqlCommand("UPDATE User_Holidays SET " & _
                                   "status = @status " & _
                                   "where id_user = " & idUser & "AND notes = '" & notes & "'", connection)

        With cmdUpdate

            .Parameters.AddWithValue("@status", status)

        End With


        cmdUpdate.ExecuteNonQuery()
        connection.Close()
        MsgBox("User edited successfully!")

    End Sub

End Class
