Imports System
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmDelete
    Dim connStr As String
    Dim sql As String
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim rdr As MySqlDataReader
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        connStr = "server=localhost;user=root;database=payrollsystem;port=3306;password=;"
        conn = New MySqlConnection(connStr)

        Try
            conn.Open()
            sql = "DELETE FROM employees WHERE id='" & txtId.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            rdr = cmd.ExecuteReader()
            conn.Close()
            conn.Open()
            sql = "DELETE FROM salary WHERE id='" & txtId.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            rdr = cmd.ExecuteReader()
            conn.Close()
            conn.Open()
            sql = "DELETE FROM earnings WHERE id='" & txtId.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            rdr = cmd.ExecuteReader()
            conn.Close()
            conn.Open()
            sql = "DELETE FROM deductions WHERE id='" & txtId.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            rdr = cmd.ExecuteReader()
            conn.Close()
            MessageBox.Show("Deleted Successfully!")
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

    Private Sub btnClear_Click(sender As Object, e As EventArgs)

    End Sub
End Class