Imports System
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmUpdate
    Dim connStr As String
    Dim sql As String
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim rdr As MySqlDataReader
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        connStr = "server=localhost;user=root;database=payrollsystem;port=3306;password=;"
        conn = New MySqlConnection(connStr)

        Try
            conn.Open()
            sql = "UPDATE employees SET id='" & txtId.Text & "',name='" & txtName.Text & "',position='" & cmbPosition.Text & "',department='" & cmbDepartment.Text & "' WHERE id='" & txtId.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            rdr = cmd.ExecuteReader()
            MessageBox.Show("Updated Successfully!")
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()

        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmHome.Show()
        Me.Hide()
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged

    End Sub
End Class