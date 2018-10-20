Imports System
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class frmPaySlip
    Dim connStr As String
    Dim sql As String
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim rdr As MySqlDataReader
    Dim ds As New DataSet
    Dim adpt As MySqlDataAdapter
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtMonthly.TextChanged

    End Sub

    Private Sub frmPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles txtTax.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles txtGsis.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles lblTax.Click

    End Sub

    Private Sub lblEarnings_Click(sender As Object, e As EventArgs) Handles lblEarnings.Click

    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnNetPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim earnings As Double
        Dim deductions As Double
        Dim pay As Double

        earnings = CDbl(lblEarning.Text)
        deductions = CDbl(lblDeduction.Text)

        pay = earnings - deductions

        lblPay.Text = pay.ToString()

        connStr = "server=localhost;user=root;database=payrollsystem;port=3306;password=;"
        conn = New MySqlConnection(connStr)

        Try
            conn.Open()
            sql = "INSERT INTO salary VALUES ('" + txtID.Text + "','" + lblEarning.Text + "','" + lblDeduction.Text + "','" + lblPay.Text + "')"
            cmd = New MySqlCommand(sql, conn)
            rdr = cmd.ExecuteReader()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()

        End Try


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnPaySlip_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEarnings.Click
        Dim monthly As Double
        Dim increase As Double
        Dim allowance As Double
        Dim differential As Double
        Dim earnings As Double

        monthly = CDbl(txtMonthly.Text)
        allowance = CDbl(txtAllowance.Text)
        differential = CDbl(txtDifferential.Text)

        increase = monthly * 0.12
        earnings = monthly + increase + allowance + differential

        txtIncrease.Text = increase.ToString()
        lblEarning.Text = earnings.ToString()

        connStr = "server=localhost;user=root;database=payrollsystem;port=3306;password=;"
        conn = New MySqlConnection(connStr)

        Try
            conn.Open()
            sql = "INSERT INTO earnings VALUES ('" + txtID.Text + "','" + txtMonthly.Text + "','" + txtIncrease.Text + "','" + txtAllowance.Text + "','" + txtDifferential.Text + "')"
            cmd = New MySqlCommand(sql, conn)
            rdr = cmd.ExecuteReader()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()

        End Try
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles btnDeduction.Click
        Dim earnings As Double
        Dim tax As Double
        Dim gsis As Double
        Dim loan As Double
        Dim deductions As Double

        gsis = CDbl(txtGsis.Text)
        loan = CDbl(txtLoan.Text)
        earnings = CDbl(lblEarning.Text)

        tax = earnings * 0.2
        deductions = tax + gsis + loan

        txtTax.Text = tax.ToString()
        lblDeduction.Text = deductions.ToString()

        connStr = "server=localhost;user=root;database=payrollsystem;port=3306;password=;"
        conn = New MySqlConnection(connStr)

        Try
            conn.Open()
            sql = "INSERT INTO deductions VALUES ('" + txtID.Text + "','" + txtGsis.Text + "','" + txtLoan.Text + "','" + txtTax.Text + "')"
            cmd = New MySqlCommand(sql, conn)
            rdr = cmd.ExecuteReader()
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

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblDeduction_Click(sender As Object, e As EventArgs) Handles lblDeduction.Click

    End Sub
End Class
