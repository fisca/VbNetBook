<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblEmployeeID = New System.Windows.Forms.Label()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblHireDate = New System.Windows.Forms.Label()
        Me.dtpHireDate = New System.Windows.Forms.DateTimePicker()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.chkFullTime = New System.Windows.Forms.CheckBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.dgvEmployees = New System.Windows.Forms.DataGridView()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HireDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullTimeDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeesDataSet = New InsertNewRecordDemo.EmployeesDataSet()
        Me.EmployeesTableAdapter = New InsertNewRecordDemo.EmployeesDataSetTableAdapters.EmployeesTableAdapter()
        Me.btnTotalSalary = New System.Windows.Forms.Button()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.AutoSize = True
        Me.lblEmployeeID.Location = New System.Drawing.Point(23, 34)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(67, 13)
        Me.lblEmployeeID.TabIndex = 2
        Me.lblEmployeeID.Text = "รหัสพนักงาน"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(96, 31)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(150, 20)
        Me.txtEmployeeID.TabIndex = 3
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(96, 57)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(150, 20)
        Me.txtFirstName.TabIndex = 4
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(70, 60)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(20, 13)
        Me.lblFirstName.TabIndex = 5
        Me.lblFirstName.Text = "ชื่อ"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(44, 86)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(46, 13)
        Me.lblLastName.TabIndex = 6
        Me.lblLastName.Text = "นามสกุล"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(96, 83)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(150, 20)
        Me.txtLastName.TabIndex = 7
        '
        'lblHireDate
        '
        Me.lblHireDate.AutoSize = True
        Me.lblHireDate.Location = New System.Drawing.Point(281, 34)
        Me.lblHireDate.Name = "lblHireDate"
        Me.lblHireDate.Size = New System.Drawing.Size(64, 13)
        Me.lblHireDate.TabIndex = 8
        Me.lblHireDate.Text = "วันที่เริ่มงาน"
        '
        'dtpHireDate
        '
        Me.dtpHireDate.Location = New System.Drawing.Point(351, 31)
        Me.dtpHireDate.Name = "dtpHireDate"
        Me.dtpHireDate.Size = New System.Drawing.Size(150, 20)
        Me.dtpHireDate.TabIndex = 9
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(351, 57)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(150, 20)
        Me.txtSalary.TabIndex = 10
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Location = New System.Drawing.Point(294, 60)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(51, 13)
        Me.lblSalary.TabIndex = 11
        Me.lblSalary.Text = "เงินเดือน"
        '
        'chkFullTime
        '
        Me.chkFullTime.AutoSize = True
        Me.chkFullTime.Location = New System.Drawing.Point(351, 86)
        Me.chkFullTime.Name = "chkFullTime"
        Me.chkFullTime.Size = New System.Drawing.Size(105, 17)
        Me.chkFullTime.TabIndex = 12
        Me.chkFullTime.Text = "พนักงาน full-time"
        Me.chkFullTime.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(217, 112)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(91, 34)
        Me.btnInsert.TabIndex = 13
        Me.btnInsert.Text = "เพิ่มข้อมูล"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'dgvEmployees
        '
        Me.dgvEmployees.AutoGenerateColumns = False
        Me.dgvEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.HireDateDataGridViewTextBoxColumn, Me.SalaryDataGridViewTextBoxColumn, Me.FullTimeDataGridViewCheckBoxColumn})
        Me.dgvEmployees.DataSource = Me.EmployeesBindingSource
        Me.dgvEmployees.Location = New System.Drawing.Point(26, 156)
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.ReadOnly = True
        Me.dgvEmployees.RowHeadersVisible = False
        Me.dgvEmployees.Size = New System.Drawing.Size(610, 219)
        Me.dgvEmployees.TabIndex = 14
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "รหัสพนักงาน"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        Me.EmployeeIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "ชื่อ"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "นามสกุล"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HireDateDataGridViewTextBoxColumn
        '
        Me.HireDateDataGridViewTextBoxColumn.DataPropertyName = "HireDate"
        Me.HireDateDataGridViewTextBoxColumn.HeaderText = "วันที่เริ่มงาน"
        Me.HireDateDataGridViewTextBoxColumn.Name = "HireDateDataGridViewTextBoxColumn"
        Me.HireDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SalaryDataGridViewTextBoxColumn
        '
        Me.SalaryDataGridViewTextBoxColumn.DataPropertyName = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.HeaderText = "เงินเดือน"
        Me.SalaryDataGridViewTextBoxColumn.Name = "SalaryDataGridViewTextBoxColumn"
        Me.SalaryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FullTimeDataGridViewCheckBoxColumn
        '
        Me.FullTimeDataGridViewCheckBoxColumn.DataPropertyName = "FullTime"
        Me.FullTimeDataGridViewCheckBoxColumn.HeaderText = "FullTime"
        Me.FullTimeDataGridViewCheckBoxColumn.Name = "FullTimeDataGridViewCheckBoxColumn"
        Me.FullTimeDataGridViewCheckBoxColumn.ReadOnly = True
        Me.FullTimeDataGridViewCheckBoxColumn.Width = 60
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.EmployeesDataSet
        '
        'EmployeesDataSet
        '
        Me.EmployeesDataSet.DataSetName = "EmployeesDataSet"
        Me.EmployeesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'btnTotalSalary
        '
        Me.btnTotalSalary.Location = New System.Drawing.Point(333, 112)
        Me.btnTotalSalary.Name = "btnTotalSalary"
        Me.btnTotalSalary.Size = New System.Drawing.Size(146, 34)
        Me.btnTotalSalary.TabIndex = 15
        Me.btnTotalSalary.Text = "รวมเงินเดือนพนักงาน"
        Me.btnTotalSalary.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 395)
        Me.Controls.Add(Me.btnTotalSalary)
        Me.Controls.Add(Me.dgvEmployees)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.chkFullTime)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.dtpHireDate)
        Me.Controls.Add(Me.lblHireDate)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.lblEmployeeID)
        Me.Name = "Form1"
        Me.Text = "InsertNewRecordDemo"
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEmployeeID As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblHireDate As System.Windows.Forms.Label
    Friend WithEvents dtpHireDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents lblSalary As System.Windows.Forms.Label
    Friend WithEvents chkFullTime As System.Windows.Forms.CheckBox
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents dgvEmployees As System.Windows.Forms.DataGridView
    Friend WithEvents EmployeesDataSet As InsertNewRecordDemo.EmployeesDataSet
    Friend WithEvents EmployeesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeesTableAdapter As InsertNewRecordDemo.EmployeesDataSetTableAdapters.EmployeesTableAdapter
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HireDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalaryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullTimeDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnTotalSalary As System.Windows.Forms.Button

End Class
