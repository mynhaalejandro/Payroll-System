<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPaySlip
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblEarnings = New System.Windows.Forms.Label()
        Me.lblMonthly = New System.Windows.Forms.Label()
        Me.txtMonthly = New System.Windows.Forms.TextBox()
        Me.lblIncrease = New System.Windows.Forms.Label()
        Me.txtIncrease = New System.Windows.Forms.TextBox()
        Me.lblAllowance = New System.Windows.Forms.Label()
        Me.txtAllowance = New System.Windows.Forms.TextBox()
        Me.lblDifferential = New System.Windows.Forms.Label()
        Me.txtDifferential = New System.Windows.Forms.TextBox()
        Me.lblDeductions = New System.Windows.Forms.Label()
        Me.lblGsis = New System.Windows.Forms.Label()
        Me.txtGsis = New System.Windows.Forms.TextBox()
        Me.lblLoan = New System.Windows.Forms.Label()
        Me.txtLoan = New System.Windows.Forms.TextBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnEarnings = New System.Windows.Forms.Button()
        Me.btnDeduction = New System.Windows.Forms.Button()
        Me.lblDeduction = New System.Windows.Forms.Label()
        Me.lblEarning = New System.Windows.Forms.Label()
        Me.lblPay = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEarnings
        '
        Me.lblEarnings.AutoSize = True
        Me.lblEarnings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEarnings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblEarnings.Location = New System.Drawing.Point(167, 55)
        Me.lblEarnings.Name = "lblEarnings"
        Me.lblEarnings.Size = New System.Drawing.Size(56, 13)
        Me.lblEarnings.TabIndex = 6
        Me.lblEarnings.Text = "Earnings"
        '
        'lblMonthly
        '
        Me.lblMonthly.AutoSize = True
        Me.lblMonthly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMonthly.Location = New System.Drawing.Point(22, 82)
        Me.lblMonthly.Name = "lblMonthly"
        Me.lblMonthly.Size = New System.Drawing.Size(76, 13)
        Me.lblMonthly.TabIndex = 7
        Me.lblMonthly.Text = "Monthly Salary"
        '
        'txtMonthly
        '
        Me.txtMonthly.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtMonthly.Location = New System.Drawing.Point(104, 74)
        Me.txtMonthly.Name = "txtMonthly"
        Me.txtMonthly.Size = New System.Drawing.Size(179, 20)
        Me.txtMonthly.TabIndex = 8
        '
        'lblIncrease
        '
        Me.lblIncrease.AutoSize = True
        Me.lblIncrease.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblIncrease.Location = New System.Drawing.Point(18, 107)
        Me.lblIncrease.Name = "lblIncrease"
        Me.lblIncrease.Size = New System.Drawing.Size(80, 13)
        Me.lblIncrease.TabIndex = 9
        Me.lblIncrease.Text = "Salary Increase"
        '
        'txtIncrease
        '
        Me.txtIncrease.Enabled = False
        Me.txtIncrease.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncrease.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtIncrease.Location = New System.Drawing.Point(104, 100)
        Me.txtIncrease.Name = "txtIncrease"
        Me.txtIncrease.Size = New System.Drawing.Size(179, 20)
        Me.txtIncrease.TabIndex = 10
        '
        'lblAllowance
        '
        Me.lblAllowance.AutoSize = True
        Me.lblAllowance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAllowance.Location = New System.Drawing.Point(42, 133)
        Me.lblAllowance.Name = "lblAllowance"
        Me.lblAllowance.Size = New System.Drawing.Size(56, 13)
        Me.lblAllowance.TabIndex = 11
        Me.lblAllowance.Text = "Allowance"
        '
        'txtAllowance
        '
        Me.txtAllowance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAllowance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtAllowance.Location = New System.Drawing.Point(104, 126)
        Me.txtAllowance.Name = "txtAllowance"
        Me.txtAllowance.Size = New System.Drawing.Size(179, 20)
        Me.txtAllowance.TabIndex = 12
        '
        'lblDifferential
        '
        Me.lblDifferential.AutoSize = True
        Me.lblDifferential.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDifferential.Location = New System.Drawing.Point(41, 155)
        Me.lblDifferential.Name = "lblDifferential"
        Me.lblDifferential.Size = New System.Drawing.Size(57, 13)
        Me.lblDifferential.TabIndex = 13
        Me.lblDifferential.Text = "Differential"
        '
        'txtDifferential
        '
        Me.txtDifferential.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDifferential.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtDifferential.Location = New System.Drawing.Point(104, 152)
        Me.txtDifferential.Name = "txtDifferential"
        Me.txtDifferential.Size = New System.Drawing.Size(179, 20)
        Me.txtDifferential.TabIndex = 14
        '
        'lblDeductions
        '
        Me.lblDeductions.AutoSize = True
        Me.lblDeductions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeductions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDeductions.Location = New System.Drawing.Point(441, 55)
        Me.lblDeductions.Name = "lblDeductions"
        Me.lblDeductions.Size = New System.Drawing.Size(71, 13)
        Me.lblDeductions.TabIndex = 15
        Me.lblDeductions.Text = "Deductions"
        '
        'lblGsis
        '
        Me.lblGsis.AutoSize = True
        Me.lblGsis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblGsis.Location = New System.Drawing.Point(352, 81)
        Me.lblGsis.Name = "lblGsis"
        Me.lblGsis.Size = New System.Drawing.Size(32, 13)
        Me.lblGsis.TabIndex = 20
        Me.lblGsis.Text = "GSIS"
        '
        'txtGsis
        '
        Me.txtGsis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGsis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtGsis.Location = New System.Drawing.Point(391, 78)
        Me.txtGsis.Name = "txtGsis"
        Me.txtGsis.Size = New System.Drawing.Size(179, 20)
        Me.txtGsis.TabIndex = 21
        '
        'lblLoan
        '
        Me.lblLoan.AutoSize = True
        Me.lblLoan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblLoan.Location = New System.Drawing.Point(322, 107)
        Me.lblLoan.Name = "lblLoan"
        Me.lblLoan.Size = New System.Drawing.Size(62, 13)
        Me.lblLoan.TabIndex = 22
        Me.lblLoan.Text = "Coop. Loan"
        '
        'txtLoan
        '
        Me.txtLoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtLoan.Location = New System.Drawing.Point(391, 107)
        Me.txtLoan.Name = "txtLoan"
        Me.txtLoan.Size = New System.Drawing.Size(179, 20)
        Me.txtLoan.TabIndex = 23
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTax.Location = New System.Drawing.Point(300, 133)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(84, 13)
        Me.lblTax.TabIndex = 24
        Me.lblTax.Text = "Withholding Tax"
        '
        'txtTax
        '
        Me.txtTax.Enabled = False
        Me.txtTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTax.Location = New System.Drawing.Point(391, 133)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(179, 20)
        Me.txtTax.TabIndex = 25
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.ForeColor = System.Drawing.Color.Green
        Me.btnPay.Location = New System.Drawing.Point(52, 207)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(192, 22)
        Me.btnPay.TabIndex = 26
        Me.btnPay.Text = "Compute Net Take Home Pay"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'btnEarnings
        '
        Me.btnEarnings.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEarnings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEarnings.ForeColor = System.Drawing.Color.Green
        Me.btnEarnings.Location = New System.Drawing.Point(52, 178)
        Me.btnEarnings.Name = "btnEarnings"
        Me.btnEarnings.Size = New System.Drawing.Size(75, 23)
        Me.btnEarnings.TabIndex = 28
        Me.btnEarnings.Text = "Earnings"
        Me.btnEarnings.UseVisualStyleBackColor = False
        '
        'btnDeduction
        '
        Me.btnDeduction.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDeduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeduction.ForeColor = System.Drawing.Color.Green
        Me.btnDeduction.Location = New System.Drawing.Point(355, 178)
        Me.btnDeduction.Name = "btnDeduction"
        Me.btnDeduction.Size = New System.Drawing.Size(80, 23)
        Me.btnDeduction.TabIndex = 29
        Me.btnDeduction.Text = "Deductions"
        Me.btnDeduction.UseVisualStyleBackColor = False
        '
        'lblDeduction
        '
        Me.lblDeduction.AutoSize = True
        Me.lblDeduction.BackColor = System.Drawing.Color.Green
        Me.lblDeduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeduction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDeduction.Location = New System.Drawing.Point(441, 183)
        Me.lblDeduction.Name = "lblDeduction"
        Me.lblDeduction.Size = New System.Drawing.Size(0, 13)
        Me.lblDeduction.TabIndex = 36
        '
        'lblEarning
        '
        Me.lblEarning.AutoSize = True
        Me.lblEarning.BackColor = System.Drawing.Color.Green
        Me.lblEarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEarning.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblEarning.Location = New System.Drawing.Point(133, 183)
        Me.lblEarning.Name = "lblEarning"
        Me.lblEarning.Size = New System.Drawing.Size(0, 13)
        Me.lblEarning.TabIndex = 38
        '
        'lblPay
        '
        Me.lblPay.AutoSize = True
        Me.lblPay.BackColor = System.Drawing.Color.Green
        Me.lblPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPay.Location = New System.Drawing.Point(261, 212)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(0, 13)
        Me.lblPay.TabIndex = 39
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtID.Location = New System.Drawing.Point(121, 21)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(140, 20)
        Me.txtID.TabIndex = 47
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNumber.Location = New System.Drawing.Point(33, 24)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(82, 13)
        Me.lblNumber.TabIndex = 46
        Me.lblNumber.Text = "Employee ID:"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Green
        Me.btnBack.Location = New System.Drawing.Point(355, 206)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(99, 23)
        Me.btnBack.TabIndex = 48
        Me.btnBack.Text = "Go Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmPaySlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(597, 269)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.lblPay)
        Me.Controls.Add(Me.lblEarning)
        Me.Controls.Add(Me.lblDeduction)
        Me.Controls.Add(Me.btnDeduction)
        Me.Controls.Add(Me.btnEarnings)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.txtLoan)
        Me.Controls.Add(Me.lblLoan)
        Me.Controls.Add(Me.txtGsis)
        Me.Controls.Add(Me.lblGsis)
        Me.Controls.Add(Me.lblDeductions)
        Me.Controls.Add(Me.txtDifferential)
        Me.Controls.Add(Me.lblDifferential)
        Me.Controls.Add(Me.txtAllowance)
        Me.Controls.Add(Me.lblAllowance)
        Me.Controls.Add(Me.txtIncrease)
        Me.Controls.Add(Me.lblIncrease)
        Me.Controls.Add(Me.txtMonthly)
        Me.Controls.Add(Me.lblMonthly)
        Me.Controls.Add(Me.lblEarnings)
        Me.Name = "frmPaySlip"
        Me.Text = "Pay Slip"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEarnings As Label
    Friend WithEvents lblMonthly As Label
    Friend WithEvents txtMonthly As TextBox
    Friend WithEvents lblIncrease As Label
    Friend WithEvents txtIncrease As TextBox
    Friend WithEvents lblAllowance As Label
    Friend WithEvents txtAllowance As TextBox
    Friend WithEvents lblDifferential As Label
    Friend WithEvents txtDifferential As TextBox
    Friend WithEvents lblDeductions As Label
    Friend WithEvents lblGsis As Label
    Friend WithEvents txtGsis As TextBox
    Friend WithEvents lblLoan As Label
    Friend WithEvents txtLoan As TextBox
    Friend WithEvents lblTax As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents btnPay As Button
    Friend WithEvents btnEarnings As Button
    Friend WithEvents btnDeduction As Button
    Friend WithEvents lblDeduction As Label
    Friend WithEvents lblEarning As Label
    Friend WithEvents lblPay As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblNumber As Label
    Friend WithEvents btnBack As Button
End Class
