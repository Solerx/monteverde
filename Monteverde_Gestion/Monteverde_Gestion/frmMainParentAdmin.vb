Imports System.Data.SqlClient

Public Class frmMainParentAdmin

    Dim strConexion As String = "Data Source=SOLERPC\MONTEVERDE;Initial Catalog=Monteverdedb;Integrated Security=True"

    Dim connection As New SqlConnection(strConexion)

    Dim adap As SqlDataAdapter

    Dim dataTableUsers As New DataTable

    Dim dataTableProyects As New DataTable


    Private Sub frmMainParentAdmin1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.dgvUsers.DataSource = vbNull
        Fill_Data_Grid_View()
        lblUserEmail.Text = frmLogin.txtEmail.Text()

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

    Public Sub Fill_Data_Grid_View()


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

        Me.dgvUsers.DataSource = userGridView

    End Sub



    Public Function List_Of_Users() As List(Of User)

        'From table Usersdb, obtain all the rows.
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

    Public Function Ask_Course_Inputs() As User

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
        Ask_Course_Inputs = newUser


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

    Public Sub Delete_Row()


        dgvUsers.AllowUserToDeleteRows = True


        Dim adapter = New SqlDataAdapter("SELECT Id, category_name FROM Usersdb", connection)
        connection.Open()

        Dim builder As New SqlCommandBuilder(adap)
        adapter.DeleteCommand = builder.GetDeleteCommand()

        dataTableUsers = New DataTable()
        adap.Fill(dataTableUsers)

        dgvUsers.DataSource = dataTableUsers

        Try
            dgvUsers.Rows.RemoveAt(dgvUsers.SelectedRows(0).Index)
        Catch ex As Exception
            MessageBox.Show("Error removing row")
        End Try
        connection.Close()
    End Sub


    Public Sub Update_Row()

        dgvUsers.AllowUserToDeleteRows = True


        Dim adapter = New SqlDataAdapter("SELECT id_category, category_name FROM Work_Category", connection)
        connection.Open()

        Dim builder As New SqlCommandBuilder(adap)
        adapter.UpdateCommand = builder.GetUpdateCommand()

        dataTableUsers = New DataTable()
        adap.Fill(dataTableUsers)

        dgvUsers.DataSource = dataTableUsers

        Try
            adap.Update(dataTableUsers)
            MessageBox.Show("Saved successfully")
        Catch ex As Exception
            MessageBox.Show("Error updating database")
        End Try
        connection.Close()

    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click

        Insert(Ask_Course_Inputs())

    End Sub

    Private Sub btnUpdateUserGriedView_Click(sender As Object, e As EventArgs) Handles btnUpdateUserGriedView.Click
        Fill_Data_Grid_View()
    End Sub

    
    Private Sub btnRemoveUserFromDataBase_Click(sender As Object, e As EventArgs) Handles btnRemoveUserFromDataBase.Click
        Delete_Row()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Update_Row()
    End Sub
End Class

