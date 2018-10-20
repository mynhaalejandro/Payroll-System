<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHome
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.lblPayrollSystem = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.txtEMPS = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Green
        Me.btnAdd.Location = New System.Drawing.Point(102, 101)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(141, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Employee"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Green
        Me.btnDelete.Location = New System.Drawing.Point(102, 182)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(141, 23)
        Me.btnDelete.TabIndex = 1
        Me.btnDelete.Text = "Delete Emloyee"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Green
        Me.btnUpdate.Location = New System.Drawing.Point(102, 143)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(141, 23)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update Employee"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLogOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.Green
        Me.btnLogOut.Location = New System.Drawing.Point(187, 221)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(141, 23)
        Me.btnLogOut.TabIndex = 3
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnView.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.Green
        Me.btnView.Location = New System.Drawing.Point(265, 143)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(141, 62)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "View Employee Records"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'lblPayrollSystem
        '
        Me.lblPayrollSystem.AutoSize = True
        Me.lblPayrollSystem.BackColor = System.Drawing.Color.Transparent
        Me.lblPayrollSystem.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayrollSystem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPayrollSystem.Location = New System.Drawing.Point(124, 29)
        Me.lblPayrollSystem.Name = "lblPayrollSystem"
        Me.lblPayrollSystem.Size = New System.Drawing.Size(282, 42)
        Me.lblPayrollSystem.TabIndex = 10
        Me.lblPayrollSystem.Text = "PAYROLL SYSTEM"
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.Color.Green
        Me.btnCompute.Location = New System.Drawing.Point(265, 101)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(141, 23)
        Me.btnCompute.TabIndex = 11
        Me.btnCompute.Text = "Compute Salary"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'txtEMPS
        '
        Me.txtEMPS.AutoSize = True
        Me.txtEMPS.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEMPS.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEMPS.Location = New System.Drawing.Point(153, 300)
        Me.txtEMPS.Name = "txtEMPS"
        Me.txtEMPS.Size = New System.Drawing.Size(235, 15)
        Me.txtEMPS.TabIndex = 12
        Me.txtEMPS.Text = "Payroll System | All Rights Reserved 2017"
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(529, 324)
        Me.Controls.Add(Me.txtEMPS)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lblPayrollSystem)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "frmHome"
        Me.Text = "Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnView As Button
    Friend WithEvents lblPayrollSystem As Label
    Friend WithEvents btnCompute As Button
    Friend WithEvents txtEMPS As Label
End Class
