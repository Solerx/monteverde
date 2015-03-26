Imports System.Data.SqlClient

Public Class Userdata

    Dim strConexion As String = "Data Source=SOLERPC\MONTEVERDE;Initial Catalog=Monteverdedb;Integrated Security=True"

    Dim connection As New SqlConnection(strConexion)

    Dim dataTableUsers As New DataTable

    Dim dataTableProyects As New DataTable

    Dim row As Integer

    Public Function Create_Data_Table_User() As DataTable

        'Create Users table
        dataTableUsers = New DataTable

        dataTableUsers.Columns.Add("Id")
        dataTableUsers.Columns.Add("Name")
        dataTableUsers.Columns.Add("Email")
        dataTableUsers.Columns.Add("Password")
        dataTableUsers.Columns.Add("Role")
        dataTableUsers.Columns.Add("Worked Hours")
        dataTableUsers.Columns.Add("Holydays")
        dataTableUsers.Columns.Add("Sign-in Date")
        dataTableUsers.Columns.Add("Status")
        Create_Data_Table_User = dataTableUsers


    End Function

    Public Function Fill_Data_Grid_View() As DataTable

        'Fill table created at Create_Data_Table_User() 

        dataTableUsers = Create_Data_Table_User()
        Dim userGridView As List(Of User)

        userGridView = List_Of_Users()

        Dim row As DataRow

        For i = 0 To userGridView.Count - 1 Step 1

            row = dataTableUsers.NewRow
            row("Id") = userGridView(i).user_user_id
            row("Name") = userGridView(i).user_name
            row("Email") = userGridView(i).user_email
            row("Password") = userGridView(i).user_password
            row("Role") = userGridView(i).user_user_role
            row("Worked Hours") = userGridView(i).user_worked_hours
            row("Holydays") = userGridView(i).user_holidays
            row("Sign-in Date") = userGridView(i).user_registered_date
            row("Status") = userGridView(i).user_is_active

            dataTableUsers.Rows.Add(row)

        Next

        Fill_Data_Grid_View = dataTableUsers

    End Function

    Public Function Get_User_From_Table(ByVal id As Integer) As User

        connection.Close()
        Dim cmdSelectUser As New SqlCommand("SELECT Id,name,email,password,worked_hours,holidays,registered_date,user_role,is_active FROM Usersdb WHERE Id = " & id, connection)
        connection.Open()
        Dim reader As SqlDataReader = cmdSelectUser.ExecuteReader()

        Dim user As New User

        reader.Read()
        user = New User

        user.user_user_id = reader.GetInt32(0)
        user.user_name = reader.GetString(1)
        user.user_email = reader.GetString(2)
        user.user_password = reader.GetString(3)
        user.user_worked_hours = reader.GetInt32(4)
        user.user_holidays = reader.GetInt32(5)
        user.user_registered_date = reader.GetDateTime(6)
        user.user_user_role = reader.GetInt32(7)
        user.user_is_active = reader.GetBoolean(8)

        Get_User_From_Table = user

    End Function



    Public Function List_Of_Users() As List(Of User)

        'From table Usersdb, obtain all the rows.
        connection.Close()
        Dim cmdSelectUser As New SqlCommand("select * FROM Usersdb", connection)
        connection.Open()

        Dim reader As SqlDataReader = cmdSelectUser.ExecuteReader()
        Dim userList As New List(Of User)

        Dim user As New User

        Do While reader.HasRows

            Do While reader.Read()

                user = New User
                user.user_user_id = reader.GetInt32(0)
                user.user_name = reader.GetString(1)
                user.user_email = reader.GetString(2)
                user.user_password = reader.GetString(3)
                user.user_worked_hours = reader.GetInt32(4)
                user.user_holidays = reader.GetInt32(5)
                user.user_registered_date = reader.GetDateTime(6)
                user.user_user_role = reader.GetInt32(7)
                user.user_is_active = reader.GetBoolean(8)

                userList.Add(user)


            Loop

            reader.NextResult()

        Loop

        connection.Close()
        List_Of_Users = userList


    End Function


    Public Sub Insert(ByVal user As User)

        Dim cmdInsert As New SqlCommand

        cmdInsert = New SqlCommand("insert into Usersdb(name,email,password,worked_hours,holidays,registered_date,user_role,is_active)" & _
                                   "values(@name,@email,@password,@worked_hours,@holidays,@registered_date,@user_role,@is_active)", connection)

        With cmdInsert

            .Parameters.AddWithValue("@name", user.user_name)
            .Parameters.AddWithValue("@email", user.user_email)
            .Parameters.AddWithValue("@password", user.user_password)
            .Parameters.AddWithValue("@worked_hours", user.user_worked_hours)
            .Parameters.AddWithValue("@holidays", user.user_holidays)
            .Parameters.AddWithValue("@registered_date", user.user_registered_date)
            .Parameters.AddWithValue("@user_role", user.user_user_role)
            .Parameters.AddWithValue("@is_active", user.user_is_active)


        End With


        connection.Open()
        cmdInsert.ExecuteNonQuery()
        connection.Close()

        MsgBox("User added successfully.")

    End Sub

    Public Sub Edit(ByVal User As User, ByVal id As Integer)

        connection.Close()

        Dim cmdUpdate As New SqlCommand

        cmdUpdate = New SqlCommand("UPDATE Usersdb SET " & _
                               "name = @name, " & _
                               "email = @email, " & _
                               "password = @password, " & _
                               "worked_hours = @worked_hours, " & _
                               "holidays = @holidays " & _
                               "registered_date = @registered_date " & _
                               "user_role = @user_role " & _
                               "is_active = @is_active " & _
                               "where Id = " & id, connection)

        With cmdUpdate

            .Parameters.AddWithValue("@name", User.user_name)
            .Parameters.AddWithValue("@email", User.user_email)
            .Parameters.AddWithValue("@password", User.user_password)
            .Parameters.AddWithValue("@worked_hours", User.user_worked_hours)
            .Parameters.AddWithValue("@holidays", User.user_holidays)
            .Parameters.AddWithValue("@registered_date", User.user_registered_date)
            .Parameters.AddWithValue("@user_role", User.user_user_role)
            .Parameters.AddWithValue("@is_active", User.user_is_active)

        End With

        connection.Open()
        cmdUpdate.ExecuteNonQuery()
        connection.Close()
        MsgBox("User edited successfully!")

    End Sub

    Public Sub Delete(ByVal indexRow As Integer, ByVal id As Integer)

        Dim cmdUpdate As New SqlCommand

        cmdUpdate = New SqlCommand("Delete from Usersdb " & _
        "where Id = " & id, connection)



        connection.Open()
        cmdUpdate.ExecuteNonQuery()
        Fill_Data_Grid_View()
        connection.Close()
        MsgBox("User removed successfully!")


    End Sub


    Public Function GetIsActive(ByVal email As String) As Boolean

        Dim IsActive As Boolean

        Dim cmdIsActive = New SqlCommand("SELECT is_active FROM Usersdb WHERE email= '" & email & "'", connection)

        Dim reader As SqlDataReader

        connection.Open()

        reader = cmdIsActive.ExecuteReader()

        If reader.Read Then

            IsActive = reader.GetBoolean(0)


        End If

        reader.Close()

        connection.Close()

        GetIsActive = IsActive

    End Function

    Public Function GetUserName(ByVal email As String) As String

        Dim userName As String = ""

        Dim cmdUserName = New SqlCommand("SELECT name FROM Usersdb WHERE email= '" & email & "'", connection)

        Dim reader As SqlDataReader

        connection.Open()

        reader = cmdUserName.ExecuteReader()

        If reader.Read Then

            userName = reader.GetString(0)

        End If

        reader.Close()

        connection.Close()

        GetUserName = userName

    End Function

    Public Function GetRole(ByVal email As String) As String

        Dim idRole As String = ""

        Dim cmdIdRole = New SqlCommand("SELECT role_name FROM Role, Usersdb WHERE Role.id=Usersdb.user_role and Usersdb.email= '" & email & "'", connection)
        Dim reader As SqlDataReader

        connection.Open()

        reader = cmdIdRole.ExecuteReader()

        If reader.Read Then


            idRole = (reader.GetString(0))


        End If

        reader.Close()

        connection.Close()

        GetRole = idRole

    End Function

End Class
