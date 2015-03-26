Imports System.Data.SqlClient

Imports Monteverde_Gestion.Userdata

Public Class frmLogin

    Dim userdataInstance As Userdata = New Userdata

    Dim strConexion As String = "Data Source=SOLERPC\MONTEVERDE;Initial Catalog=Monteverdedb;Integrated Security=True"

    Dim connection As New SqlConnection(strConexion)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Login()

        'Dim cmdLogin As New SqlCommand("select * from dbo.User", connection)

        Dim cmdLogin = New SqlCommand("SELECT email, password, is_active FROM Usersdb WHERE email= '" & txtEmail.Text & "'" & " and password= '" & txtPassword.Text & "'", connection)

        Dim isActive As Integer = True

        Dim reader As SqlDataReader

        connection.Open()

        reader = cmdLogin.ExecuteReader()

        If reader.HasRows Then

            connection.Close()

            isActive = userdataInstance.GetIsActive(txtEmail.Text)

            If isActive = True Then

                MsgBox("You logged in as: " & vbCrLf & txtEmail.Text)
                Me.Hide()
                connection.Close()
                frmHome.Show()

            Else

                MsgBox("The user """ & txtEmail.Text & """ is not active anymore." & vbCrLf & "Please contact an administrator.")

            End If


        Else

            MsgBox("Email or password invalid!")

        End If

        connection.Close()


    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        Login()

    End Sub
End Class
