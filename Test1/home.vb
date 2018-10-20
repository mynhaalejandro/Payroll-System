Public Class frmHome
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim x As frmAdd = New frmAdd
        x.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim x As frmPaySlip = New frmPaySlip
        x.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        frmLogin.txtUserName.Clear()
        frmLogin.txtPassword.Clear()
        frmLogin.txtUserName.Focus()

        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim x As frmUpdate = New frmUpdate
        x.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim x As frmDelete = New frmDelete
        x.Show()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim x As frmRecords = New frmRecords
        x.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class