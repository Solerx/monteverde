Imports System.Data.SqlClient

Public Class HolidaysData

    Dim strConexion As String = "Data Source=SOLERPC\MONTEVERDE;Initial Catalog=Monteverdedb;Integrated Security=True"

    Dim connection As New SqlConnection(strConexion)

    Dim userDataInstance As Userdata = New Userdata

    Dim user As User

    Dim dataTableRequested As New DataTable

    Public Function CreateDataTable() As DataTable

        'Create Users table
        dataTableRequested = New DataTable

        dataTableRequested.Columns.Add("User")
        dataTableRequested.Columns.Add("Holidays Available")
        dataTableRequested.Columns.Add("Holidays Requested")
        dataTableRequested.Columns.Add("Date Requested")
        dataTableRequested.Columns.Add("Status")
        dataTableRequested.Columns.Add("Notes")

        CreateDataTable = dataTableRequested


    End Function

    Public Function FillDataGridView(ByVal idUser As Integer) As DataTable

        dataTableRequested = CreateDataTable()

        Dim requestGridView As List(Of Holidays)

        requestGridView = ListOfRequests()

        Dim row As DataRow

        For i = 0 To requestGridView.Count - 1 Step 1

            row = dataTableRequested.NewRow
            row("User") = requestGridView(i).hUser.user_name
            row("Holidays Available") = userDataInstance.GetUserFromTable(requestGridView(i).hUser.user_user_id).user_holidays
            row("Holidays Requested") = requestGridView(i).hRequested
            row("Date Requested") = requestGridView(i).hDate
            row("Status") = requestGridView(i).hStatus
            row("Notes") = requestGridView(i).hNotes
            dataTableRequested.Rows.Add(row)

        Next

        FillDataGridView = dataTableRequested

    End Function

    'Public Function GetUserFromTable(ByVal id As Integer) As User

    '    connection.Close()
    '    Dim cmdSelectUser As New SqlCommand("SELECT id_user,name,email,password,worked_hours,holidays,registered_date,is_active,user_role FROM Role,Usersdb WHERE Role.id_role=Usersdb.user_role and Usersdb.id_user = " & id, connection)
    '    connection.Open()
    '    Dim reader As SqlDataReader = cmdSelectUser.ExecuteReader()

    '    Dim user As New User

    '    reader.Read()
    '    user = New User

    '    user.user_user_id = reader.GetInt32(0)
    '    user.user_name = reader.GetString(1)
    '    user.user_email = reader.GetString(2)
    '    user.user_password = reader.GetString(3)
    '    user.user_worked_hours = reader.GetInt32(4)
    '    user.user_holidays = reader.GetInt32(5)
    '    user.user_registered_date = reader.GetDateTime(6)
    '    user.user_is_active = reader.GetBoolean(7)
    '    user.user_user_role = GetRoleByUser(reader.GetInt32(8))

    '    reader.Close()

    '    GetUserFromTable = user

    'End Function

    Public Function ListOfRequests() As List(Of Holidays)

        'From table Usersdb, obtain all the rows.
        connection.Close()

        Dim cmdSelectUser As New SqlCommand("SELECT id_user,holidays_requested,date_requested,status,notes FROM User_Holidays", connection)
        connection.Open()

        Dim reader As SqlDataReader = cmdSelectUser.ExecuteReader()

        Dim resquestList As New List(Of Holidays)

        Dim request As New Holidays

        Do While reader.HasRows

            Do While reader.Read()

                request = New Holidays
                request.hUser = userDataInstance.GetUserFromTable(reader.GetInt32(0))
                request.hRequested = reader.GetInt16(1)
                request.hDate = reader.GetDateTime(2)
                request.hStatus = reader.GetString(3)
                request.hNotes = reader.GetString(4)
                resquestList.Add(request)

            Loop

            reader.NextResult()

        Loop

        reader.Close()
        connection.Close()
        ListOfRequests = resquestList


    End Function




End Class
