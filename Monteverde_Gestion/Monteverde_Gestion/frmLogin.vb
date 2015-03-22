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

    Public Function Id_Role_Request() As Integer

        Dim idRole As Integer

        Dim cmdIdRole = New SqlCommand("SELECT UserType FROM Usersdb WHERE UserEmail= '" & txtEmail.Text & "'", connection)

        Dim reader As SqlDataReader

        connection.Open()

        reader = cmdIdRole.ExecuteReader()

        If reader.Read Then
            idRole = CInt(reader.Item("UserType"))

        End If

        reader.Close()

        connection.Close()

        Return idRole

    End Function

    Public Sub Get_User_Type(ByVal idRole As Integer)

        Select Case idRole

            Case 1

                frmMainParentAdmin.Show()

            Case 2

                frmMainAdmin.Show()

            Case 3

                frmMainUser.Show()


        End Select


    End Sub


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
