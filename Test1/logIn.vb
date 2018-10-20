Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogIn_Click_1(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If txtUserName.Text = "a" And txtPassword.Text = "a" Then
            frmHome.Show()
            Me.Hide()
        Else
            MsgBox("Wrong username or password.!!", MsgBoxStyle.OkOnly, "Invalid")
            txtUserName.Focus()
            txtPassword.Clear()

        End If
    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Exit...") = MsgBoxResult.Yes Then
            Me.Close()

        ElseIf MsgBoxResult.No Then
            btnLogIn.Focus()
        End If
    End Sub
End Class