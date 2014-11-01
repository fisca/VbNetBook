Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeesDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.EmployeesDataSet.Employees)

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            EmployeesTableAdapter.Insert(CInt(txtEmployeeID.Text), txtFirstName.Text, txtLastName.Text, dtpHireDate.Value.Date, CDec(txtSalary.Text), chkFullTime.Checked)
            EmployeesTableAdapter.Fill(EmployeesDataSet.Employees)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ป้อนข้อมูลผิดพราด")
        End Try
    End Sub
   
    Private Sub btnTotalSalary_Click(sender As Object, e As EventArgs) Handles btnTotalSalary.Click
        Dim row As EmployeesDataSet.EmployeesRow
        Dim decTotalSalary As Decimal = 0

        For Each row In EmployeesDataSet.Employees.Rows
            decTotalSalary += row.Salary
        Next

        MessageBox.Show("รวมเงินเดือนพนักงานทั้งหมดเท่ากับ " & decTotalSalary.ToString("c"))

    End Sub
End Class
