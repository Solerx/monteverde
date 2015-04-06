Public Class frmProfile


    Dim userdataInstance As New Userdata


    Private Sub frmProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Fill_Inputs(userdataInstance.Get_User_From_Table(frmLogin.globalUserId))
        txtUserRegisteredDate.Enabled = False

    End Sub

    Public Function User_Inputs() As User

        Dim userName As String = " "
        Dim userEmail As String = " "
        Dim password As String = " "
        'Dim memberSince As DateTime

        Dim newUser As New User


        userName = txtUserName.Text
        userEmail = txtUserEmail.Text
        password = txtUserPassword.Text



        newUser.user_name = userName
        newUser.user_email = userEmail
        newUser.user_password = password



        User_Inputs = newUser

    End Function

    Public Sub Fill_Inputs(ByVal user As User)

        txtUserName.Text = user.user_name
        txtUserEmail.Text = user.user_email
        txtUserPassword.Text = user.user_password
        txtUserRegisteredDate.Text = user.user_registered_date

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()
        frmHome.Show()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtUserName.Text = vbNullString Or txtUserEmail.Text = vbNullString Or txtUserPassword.Text = vbNullString Or txtUserRegisteredDate.Text = vbNullString Then

            MsgBox("You can't leave any space blank.")

        Else

            Dim alert = MsgBox("Are you sure you want to save changes?", MsgBoxStyle.YesNo, "Saving!")

            If alert = MsgBoxResult.Yes Then

                userdataInstance.EditProfile(User_Inputs, frmLogin.globalUserId)

            End If

        End If

    End Sub

End Class