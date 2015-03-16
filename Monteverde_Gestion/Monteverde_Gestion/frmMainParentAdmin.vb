Public Class frmMainParentAdmin

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

 
    Private Sub frmMainParentAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblUserEmail.Text = frmLogin.txtEmail.Text

    End Sub
End Class