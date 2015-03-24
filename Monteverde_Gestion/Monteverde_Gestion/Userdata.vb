Imports System.Data.SqlClient

Public Class Userdata

    Dim strConexion As String = "Data Source=SOLERPC\MONTEVERDE;Initial Catalog=Monteverdedb;Integrated Security=True"

    Dim connection As New SqlConnection(strConexion)

    Dim dataTableUsers As New DataTable

    Dim dataTableProyects As New DataTable

    Dim row As Integer



    Private Sub frmMainParentAdmin1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        

    End Sub


    Public Function Create_Data_Table_User() As DataTable

        dataTableUsers = New DataTable

        dataTableUsers.Columns.Add("Sigla")
        dataTableUsers.Columns.Add("Nombre")
        dataTableUsers.Columns.Add("Correo electrónico")
        dataTableUsers.Columns.Add("Horas trabajadas")
        dataTableUsers.Columns.Add("Tipo de usuario")
        dataTableUsers.Columns.Add("Dias de vacaciones")
        dataTableUsers.Columns.Add("Ultimo ingreso")

        Create_Data_Table_User = dataTableUsers


    End Function

    Public Function Fill_Data_Grid_View() As DataTable



        dataTableUsers = Create_Data_Table_User()
        Dim userGridView As List(Of User)

        userGridView = List_Of_Users()

        Dim row As DataRow

        For i = 0 To userGridView.Count - 1 Step 1

            row = dataTableUsers.NewRow
            row("Sigla") = userGridView(i).user_UserId
            row("Nombre") = userGridView(i).user_Name
            row("Correo Electrónico") = userGridView(i).user_Email
            row("Tipo de usuario") = userGridView(i).user_UserType
            row("Horas Trabajadas") = userGridView(i).user_WorkedHours
            row("Dias de vacaciones") = userGridView(i).user_VacationDays
            row("Ultimo ingreso") = userGridView(i).user_LastLogin

            dataTableUsers.Rows.Add(row)

        Next

        Fill_Data_Grid_View = dataTableUsers

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
                user.user_UserId = reader.GetInt32(0)
                user.user_UserType = reader.GetSqlInt16(8)
                user.user_VacationDays = reader.IsDBNull(6)
                user.user_Name = reader.GetString(1)
                user.user_Email = reader.GetString(2)

                userList.Add(user)


            Loop

            reader.NextResult()

        Loop

        connection.Close()
        List_Of_Users = userList


    End Function

    Public Function Ask_User_Inputs() As User

        Dim userName As String
        Dim userEmail As String
        Dim password As String
        Dim userType As Integer


        Dim newUser As New User

        userName = InputBox("Ingrese el nombre: ")
        userEmail = InputBox("Ingrese el correo electrónico: ")
        password = InputBox("Ingrese la contraseña: ")
        userType = CInt(InputBox("Ingrese el numero del tipo de usuario: " & vbCrLf & "1. Administrador Padre" & vbCrLf & "2. Administrador" & vbCrLf & "3. Usuario"))

        'Here we create the object

        newUser.user_Name = userName
        newUser.user_Email = userEmail
        newUser.user_Password = password
        newUser.user_UserType = userType


        'return course
        Ask_User_Inputs = newUser


    End Function

    Public Sub Insert(ByVal user As User)

        Dim cmdInsert As New SqlCommand

        cmdInsert = New SqlCommand("insert into Usersdb(UserName,UserEmail,Password,UserType)" & _
                                   "values(@UserName,@UserEmail,@Password,@UserType)", connection)

        With cmdInsert

            .Parameters.AddWithValue("@UserName", user.user_Name)
            .Parameters.AddWithValue("@UserEmail", user.user_Email)
            .Parameters.AddWithValue("@Password", user.user_Password)
            .Parameters.AddWithValue("@UserType", user.user_UserType)


        End With

        connection.Open()
        cmdInsert.ExecuteNonQuery()
        connection.Close()

        MsgBox("Curso ingresado con éxito en la vase de datos.")

    End Sub

    Public Sub Modify(ByVal course As User)

        Dim cmdUpdate As New SqlCommand
        Dim id As String, name As String, userEmail As String, userType As String
        id = InputBox("Ingrese el id: ")
        name = InputBox("Ingrese el nombre: ")
        userEmail = InputBox("Ingrese el nivel: ")
        userType = CInt(InputBox("Ingrese tipo de usuario: "))


        Dim identifier As Integer = dgvUsers.Item(0, row).Value

        cmdUpdate = New SqlCommand("update Usersdb set " & _
                               "Id = @id, " & _
                               "name = @name, " & _
                               "course_level = @level, " & _
                               "credits = @credits, " & _
                               "capacity = @capacity, " & _
                               "professor = @professor " & _
                               "where Id = " & identifier, connection)

        With cmdUpdate

            .Parameters.AddWithValue("@Id", id)
            .Parameters.AddWithValue("@UserName", name)
            .Parameters.AddWithValue("@UserEmail", userEmail)
            .Parameters.AddWithValue("@UserType", userType)

        End With

        connection.Open()
        cmdUpdate.ExecuteNonQuery()
        Fill_Data_Grid_View()
        connection.Close()
        MessageBox.Show("Usuario modificado con éxito!")


    End Sub



    Public Sub Delete()

        Dim cmdUpdate As New SqlCommand
        Dim identifier As Integer = dgvUsers.Item(0, row).Value()

        cmdUpdate = New SqlCommand("Delete from Usersdb " & _
        "where Id = " & identifier, connection)
        MessageBox.Show("Usuario!" & identifier)

        connection.Open()
        cmdUpdate.ExecuteNonQuery()
        Fill_Data_Grid_View()
        connection.Close()
        MessageBox.Show("Usuario eliminado con éxito!" & identifier)


    End Sub

End Class
