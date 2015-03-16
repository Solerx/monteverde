Imports System.Data.SqlClient

Public Class frmLogin

    Dim strConexion As String = "Data Source=SOLERPC\MONTEVERDE;Initial Catalog=Clessidra;Integrated Security=True"

    Dim connection As New SqlConnection(strConexion)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Login()

        'Dim cmdLogin As New SqlCommand("select * from dbo.User", connection)

        Dim cmdLogin = New SqlCommand("SELECT user_name, password FROM [User] WHERE user_name= '" & txtEmail.Text & "'" & " and password= '" & txtPassword.Text & "'", connection)

        Dim reader As SqlDataReader

        connection.Open()

        reader = cmdLogin.ExecuteReader()

        If reader.HasRows Then

            MsgBox("Bienvenido!!! " & vbCrLf & txtEmail.Text)
            Me.Hide()
            connection.Close()
            frmMainWindow.Show()

        Else

            MsgBox("Usuario y/o contraseña invalidos.")

        End If

        connection.Close()


    End Sub

    Public Function Id_Role_Request() As Integer

        Dim idRole As Integer

        Dim cmdIdRole = New SqlCommand("SELECT id_role FROM [User] WHERE user_name= '" & txtEmail.Text & "'", connection)

        Dim reader As SqlDataReader

        connection.Open()

        reader = cmdIdRole.ExecuteReader()

        If reader.Read Then
            idRole = CInt(reader.Item("id_role"))

        End If

        reader.Close()

        connection.Close()

        Return idRole

    End Function


    Private Sub lnkLogOn_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkSignIn.LinkClicked


        'Dim newAccount As Form2
        'newAccount = New Form2
        'newAccount.Show()
        Me.Hide()

    End Sub

    

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Login()

    End Sub
End Class
