Imports System
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frmRecords
    Dim connStr As String
    Dim sql As String
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim rdr As MySqlDataReader
    Dim ds As New DataSet
    Dim adpt As MySqlDataAdapter
    Dim dt As New DataTable
    Dim bs As New BindingSource
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        connStr = "server=localhost;user=root;database=payrollsystem;port=3306;password=;"
        conn = New MySqlConnection(connStr)

        Try
            conn.Open()
            sql = "SELECT * FROM employees WHERE id='" & txtID.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            rdr = cmd.ExecuteReader()

            While (rdr.Read())
                List.Items.Add("{" + rdr(0) + "} {" + rdr(1) + "} {" + rdr(2) + "} {" + rdr(3) + "}")
            End While
            rdr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()

        End Try
        conn.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmHome.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        connStr = "server=localhost;user=root;database=payrollsystem;port=3306;password=;"
        conn = New MySqlConnection(connStr)

        Try
            conn.Open()
            sql = "SELECT * FROM employees"
            cmd = New MySqlCommand(sql, conn)
            rdr = cmd.ExecuteReader()

            While (rdr.Read())
                List.Items.Add("{" + rdr(0) + "} {" + rdr(1) + "} {" + rdr(2) + "} {" + rdr(3) + "}")
            End While
            rdr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()

        End Try
        conn.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        connStr = "server=localhost;user=root;database=payrollsystem;port=3306;password=;"
        conn = New MySqlConnection(connStr)

        Try
            conn.Open()
            sql = "SELECT * FROM employees WHERE id='" & txtID.Text & "'"
            cmd = New MySqlCommand(sql, conn)
            rdr = cmd.ExecuteReader()

            While (rdr.Read())
                List.Items.Clear()
            End While
            rdr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()

        End Try
        conn.Close()
    End Sub
End Class