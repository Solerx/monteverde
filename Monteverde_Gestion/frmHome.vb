﻿Imports System.Data.SqlClient

Imports Monteverde_Gestion.Userdata



Public Class frmHome

    Dim userdataInstance As Userdata = New Userdata

    Dim idRole = userdataInstance.GetRole(frmLogin.globalUserId)


    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        lblUserName.Text = userdataInstance.GetUserName(frmLogin.txtEmail.Text)

        lblUserEmail.Text = frmLogin.txtEmail.Text

        selectUserType(idRole)


    End Sub



    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles msiManageUsers.Click

        frmUserManagement.Show()
        Me.Close()

    End Sub


    Public Sub selectUserType(ByVal idRole As Integer)

        Select Case idRole

            Case 1

                lblUserRole.Text = "Parent-Administrator"

            Case 2

                lblUserRole.Text = "Administrator"

            Case 3

                lblUserRole.Text = "User"
                msiManageUsers.Visible = False
                msiManageWorkCategories.Visible = False
                msiManageProjects.Visible = False
                msiManageUserProjects.Visible = False
                msiViewUserRegs.Visible = False
                msiUserHolidays.Visible = False


            Case Else

        End Select


    End Sub

End Class

