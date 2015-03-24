Imports System.Data.SqlClient

Public Class frmLogin

    Dim strConexion As String = "Data Source=SOLERPC\MONTEVERDE;Initial Catalog=Monteverdedb;Integrated Security=True"

    Dim connection As New SqlConnection(strConexion)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Logins()

        'Dim cmdLogin As New SqlCommand("select * from dbo.User", connection)

        Dim cmdLogin = New SqlCommand("SELECT UserEmail, Password FROM Usersdb WHERE UserEmail= '" & txtEmail.Text & "'" & " and Password= '" & txtPassword.Text & "'", connection)

        Dim reader As SqlDataReader

        connection.Open()

        reader = cmdLogin.ExecuteReader()

        If reader.HasRows Then

            MsgBox("Bienvenido!!! " & vbCrLf & txtEmail.Text)
            Me.Hide()
            connection.Close()
            Get_User_Type(Id_Role_Request())


        Else

            MsgBox("Usuario y/o contraseña invalidos.")

        End If

        connection.Close()


    End Sub

    Public Function Id_Role_Request() As String

        Dim idRole As String = ""

        Dim cmdIdRole = New SqlCommand("SELECT UserType FROM Usersdb WHERE UserEmail= '" & txtEmail.Text & "'", connection)

        'SELECT role_name FROM Role, Usersdb WHERE Role.id_role=Usersdb.id_role and Usersdb.email="estean.sm@..."

        Dim reader As SqlDataReader

        connection.Open()

        reader = cmdIdRole.ExecuteReader()

        If reader.Read Then
            idRole = (reader.GetString(0))

        End If

        reader.Close()

        connection.Close()

        Id_Role_Request = idRole

    End Function

    Public Function Get_User_Type(ByVal idRole As String) As String

        Dim userRole As String = ""

        Select Case idRole

            Case "user"

                frmMainParentAdmin.Show()

                userRole = "Parent Administrator"
                Get_User_Type = userRole

            Case "parent-administrator"

                frmMainParentAdmin.Show()
                userRole = "Parent Administrator"
                Get_User_Type = userRole

            Case "administration"

                frmMainParentAdmin.Show()
                userRole = "Parent Administrator"
                Get_User_Type = userRole

        End Select


        Get_User_Type = userRole
    End Function


    Private Sub lnkLogOn_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkSignIn.LinkClicked


        'Dim newAccount As Form2
        'newAccount = New Form2
        'newAccount.Show()
        Me.Hide()

    End Sub



    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        Logins()

    End Sub

End Class
