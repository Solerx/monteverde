﻿Imports System.Data.SqlClient

Imports Monteverde_Gestion.Userdata

Public Class frmLogin

    Dim userdataInstance As Userdata = New Userdata

    Dim strConexion As String = "Data Source=SOLERPC\MONTEVERDE;Initial Catalog=Monteverdedb;Integrated Security=True"

    Dim connection As New SqlConnection(strConexion)

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
        txtPassword.ResetText()

    End Sub
End Class
