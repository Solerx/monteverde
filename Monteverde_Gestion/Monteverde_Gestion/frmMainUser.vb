﻿Public Class frmMainUser

    Private Sub frmMainUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblUserEmail.Text = frmLogin.txtEmail.Text

    End Sub
End Class