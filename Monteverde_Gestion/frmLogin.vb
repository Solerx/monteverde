Imports System.Data.SqlClient

Imports Monteverde_Administrator.Userdata

Public Class frmLogin

    Dim userdataInstance As Userdata = New Userdata

    Dim strConexion As String = "Data Source=SOLERPC\MONTEVERDE;Initial Catalog=Monteverdedb;Integrated Security=True"

    'Dim strConexion As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\MonteverdeDataBase.mdf;Integrated Security=True;Connect Timeout=30"

    Dim connection As New SqlConnection(strConexion)

    Dim userName As String

    Dim password As String

    Public globalUserId As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

      

    End Sub

    Public Sub Login()

        'Dim cmdLogin As New SqlCommand("select * from dbo.User", connection)

        Dim cmdLogin = New SqlCommand("SELECT id_user ,name , email, password, is_active FROM Usersdb WHERE email= '" & txtEmail.Text & "'" & " and password= '" & txtPassword.Text & "'", connection)

        Dim cmdvalidation = New SqlCommand("SELECT email FROM Usersdb WHERE email= '" & txtEmail.Text & "'", connection)

        Dim isActive As Integer = True

        Dim reader As SqlDataReader

        connection.Open()

        reader = cmdvalidation.ExecuteReader()

        If reader.HasRows Then

            reader.Close()

            reader = cmdLogin.ExecuteReader()

            If reader.HasRows Then

                isActive = userdataInstance.GetIsActive(txtEmail.Text)

                If isActive = True Then

                    reader.Read()
                    globalUserId = reader.GetInt32(0)
                    reader.Close()
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

        Else

            MsgBox("The email provided does not have an account yet.")

        End If

        connection.Close()


    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        Login()
        If cbxRecordLog.Checked Then

            userName = txtEmail.Text
            password = txtPassword.Text

        Else
            txtPassword.ResetText()

        End If


    End Sub

    Private Sub cbxRecordLog_CheckedChanged(sender As Object, e As EventArgs) Handles cbxRecordLog.CheckedChanged



    End Sub
End Class
