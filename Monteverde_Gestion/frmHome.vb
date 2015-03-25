Imports System.Data.SqlClient

Imports Monteverde_Gestion.Userdata

Public Class frmHome

    Dim userdataInstance As Userdata = New Userdata


    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click

        frmUserManagement.Show()
        Me.Close()

    End Sub

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblUserName.Text = userdataInstance.GetUserName(frmLogin.txtEmail.Text)

        lblUserEmail.Text = frmLogin.txtEmail.Text

        lblUserRole.Text = userdataInstance.GetRole(frmLogin.txtEmail.Text)

    End Sub

End Class

