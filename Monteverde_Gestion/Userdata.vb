Imports System.Data.SqlClient

Public Class Userdata

    Dim strConexion As String = "Data Source=SOLERPC\MONTEVERDE;Initial Catalog=Monteverdedb;Integrated Security=True"

    Dim connection As New SqlConnection(strConexion)

    Dim connection2 As New SqlConnection(strConexion)

    Dim dataTableUsers As New DataTable

    Dim row As Integer



    Public Function Create_Data_Table_User() As DataTable

        'Create Users table
        dataTableUsers = New DataTable

        dataTableUsers.Columns.Add("ID")
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
            row("Role") = userGridView(i).user_user_role.role_role_name
            row("Worked Hours") = userGridView(i).user_worked_hours
            row("Holydays") = userGridView(i).user_holidays
            row("Sign-in Date") = userGridView(i).user_registered_date
            row("Status") = userGridView(i).user_is_active

            dataTableUsers.Rows.Add(row)

        Next

        Fill_Data_Grid_View = dataTableUsers

    End Function

    Public Function GetUserFromTable(ByVal id As Integer) As User

        connection.Close()
        Dim cmdSelectUser As New SqlCommand("SELECT id_user,name,email,password,worked_hours,holidays,registered_date,is_active,user_role FROM Role,Usersdb WHERE Role.id_role=Usersdb.user_role and Usersdb.id_user = " & id, connection)
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
        user.user_is_active = reader.GetBoolean(7)
        user.user_user_role = GetRoleByUser(reader.GetInt32(8))




        reader.Close()

        GetUserFromTable = user

    End Function



    Public Function List_Of_Users() As List(Of User)

        'From table Usersdb, obtain all the rows.
        connection.Close()
        Dim cmdSelectUser As New SqlCommand("SELECT id_user,name,email,password,worked_hours,holidays,registered_date,is_active,user_role FROM Role,Usersdb WHERE Role.id_role=Usersdb.user_role", connection)
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
                user.user_is_active = reader.GetBoolean(7)
                user.user_user_role = GetRoleByUser(reader.GetInt32(8))


                userList.Add(user)

            Loop

            reader.NextResult()

        Loop

        reader.Close()
        connection.Close()
        List_Of_Users = userList


    End Function


    Public Sub Insert(ByVal user As User)

        connection.Close()

        Dim cmdInsert As New SqlCommand

        cmdInsert = New SqlCommand("insert into Usersdb(name,email,password,worked_hours,holidays,registered_date,user_role,is_active)" & _
                                   "values(@name,@email,@password,@worked_hours,@holidays,@registered_date,@user_role,@is_active)", connection)
        connection.Open()

        With cmdInsert

            .Parameters.AddWithValue("@name", user.user_name)
            .Parameters.AddWithValue("@email", user.user_email)
            .Parameters.AddWithValue("@password", user.user_password)
            .Parameters.AddWithValue("@worked_hours", user.user_worked_hours)
            .Parameters.AddWithValue("@holidays", user.user_holidays)
            .Parameters.AddWithValue("@registered_date", user.user_registered_date)
            .Parameters.AddWithValue("@user_role", user.user_user_role.role_id_role)
            .Parameters.AddWithValue("@is_active", user.user_is_active)

        End With

        cmdInsert.ExecuteNonQuery()
        MsgBox("User added successfully.")
        connection.Close()

    End Sub

    Public Function GetUserIfAssigned(ByVal idUser As Integer, ByVal idProject As Integer) As Boolean

        Dim cmdGetUser As New SqlCommand("SELECT * FROM User_Project WHERE id_user = " & idUser & "AND id_project = " & idProject, connection)

        connection.Open()

        Dim reader As SqlDataReader = cmdGetUser.ExecuteReader()

        If reader.HasRows Then

            GetUserIfAssigned = True

            connection.Close()
        Else

            GetUserIfAssigned = False

        End If

        connection.Close()

    End Function

    Public Function GetRoleByUser(idUser As Integer) As Role

        Dim cmdSelectUser As New SqlCommand("SELECT role_name FROM Role, Usersdb WHERE Role.id_role = Usersdb.user_role AND Usersdb.user_role='" & idUser & "'", connection2)

        connection2.Open()

        Dim reader As SqlDataReader = cmdSelectUser.ExecuteReader()

        Dim role As New Role

        If reader.HasRows Then

            If reader.Read() Then

                role.role_role_name = reader.GetString(0)
                connection2.Close()

            End If

        End If

        GetRoleByUser = role
        connection2.Close()

    End Function

    Public Function GetRoleByRoleName(idRole As Integer) As Role

        Dim cmdSelectUser As New SqlCommand("SELECT id_role FROM Role, Usersdb WHERE Role.id_role = Usersdb.user_role AND Usersdb.user_role='" & idRole & "'", connection2)

        connection2.Open()

        Dim reader As SqlDataReader = cmdSelectUser.ExecuteReader()

        Dim role As New Role

        If reader.HasRows Then

            If reader.Read() Then

                role.role_id_role = reader.GetInt32(0)
                connection2.Close()

            End If

        End If

        GetRoleByRoleName = role
        connection2.Close()

    End Function

    Public Sub Edit(ByVal User As User, ByVal id As Integer)

        Dim cmdUpdate As New SqlCommand

        cmdUpdate = New SqlCommand("UPDATE Usersdb SET " & _
                               "name = @name, " & _
                               "email = @email, " & _
                               "password = @password, " & _
                               "worked_hours = @worked_hours, " & _
                               "holidays = @holidays, " & _
                               "user_role = @user_role, " & _
                               "is_active = @is_active " & _
                               "WHERE id_user = " & id, connection)
        ' "registered_date = @registered_date " & _

        With cmdUpdate

            .Parameters.AddWithValue("@name", User.user_name)
            .Parameters.AddWithValue("@email", User.user_email)
            .Parameters.AddWithValue("@password", User.user_password)
            .Parameters.AddWithValue("@worked_hours", User.user_worked_hours)
            .Parameters.AddWithValue("@holidays", User.user_holidays)
            '.Parameters.AddWithValue("@registered_date", User.user_registered_date)
            .Parameters.AddWithValue("@user_role", User.user_user_role.role_id_role)
            .Parameters.AddWithValue("@is_active", User.user_is_active)

        End With


        cmdUpdate.ExecuteNonQuery()
        connection.Close()
        MsgBox("User edited successfully!")

    End Sub

    Public Sub EditProfile(ByVal User As User, ByVal id As Integer)

        Dim cmdUpdate As New SqlCommand

        cmdUpdate = New SqlCommand("UPDATE Usersdb SET " & _
                               "name = @name, " & _
                               "email = @email, " & _
                               "password = @password " & _
                               "WHERE id_user = " & id, connection)


        With cmdUpdate

            .Parameters.AddWithValue("@name", User.user_name)
            .Parameters.AddWithValue("@email", User.user_email)
            .Parameters.AddWithValue("@password", User.user_password)

        End With


        cmdUpdate.ExecuteNonQuery()
        connection.Close()
        MsgBox("User edited successfully!")

    End Sub

    Public Sub delete(ByVal indexRow As Integer, ByVal id As Integer)

        connection.Close()

        Dim cmdUpdate As New SqlCommand

        cmdUpdate = New SqlCommand("Delete from Usersdb " & _
        "where id_user = " & id, connection)

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
            reader.Close()


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
            reader.Close()

        End If

        reader.Close()

        connection.Close()

        GetUserName = userName

    End Function

    Public Function GetRole(ByVal id_user As Integer) As Integer

        connection.Close()

        Dim idRole As String = ""

        Dim cmdIdRole = New SqlCommand("SELECT id_role FROM Role, Usersdb WHERE Role.id_role=Usersdb.user_role and Usersdb.id_user= '" & id_user & "'", connection)
        Dim reader As SqlDataReader

        connection.Open()

        reader = cmdIdRole.ExecuteReader()

        If reader.Read Then

            idRole = (reader.GetInt32(0))
            reader.Close()

        End If

        reader.Close()

        connection.Close()

        GetRole = idRole

    End Function

End Class
