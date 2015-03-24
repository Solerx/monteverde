Imports System.Data.SqlClient

Imports Monteverde_Gestion.Userdata

Public Class UsersForm

    Dim userdataInstance As Userdata = New Userdata


    Dim row As Integer


    Private Sub UsersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.dgvUsers.DataSource = userdataInstance.Fill_Data_Grid_View()

    End Sub


    Private Sub btnAddUser_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnUpdateUserGriedView_Click(sender As Object, e As EventArgs)
        userdataInstance.Fill_Data_Grid_View()
    End Sub


    Private Sub btnRemoveUserFromDataBase_Click(sender As Object, e As EventArgs)
        userdataInstance.Delete()

    End Sub

    Private Sub btnEditUser_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub dgvUsers_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

        row = dgvUsers.CurrentRow.Index

    End Sub


End Class