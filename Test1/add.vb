Imports System
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class frmAdd
    Dim connStr As String
    Dim sql As String
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim rdr As MySqlDataReader
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim id = txtId.Text()
        Dim name = txtName.Text()
        Dim position = cmbPosition.Text()
        Dim department = cmbDepartment.Text()

        connStr = "server=localhost;user=root;database=payrollsystem;port=3306;password=;"
        conn = New MySqlConnection(connStr)

        Try
            conn.Open()
            sql = "INSERT INTO employees VALUES ('" + id + "','" + name + "','" + position + "','" + department + "')"
            cmd = New MySqlCommand(sql, conn)
            rdr = cmd.ExecuteReader()
            MessageBox.Show("Added Successfully!")
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