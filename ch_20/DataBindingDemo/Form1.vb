Public Class Form1

    Private Sub EmployeesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmployeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EmployeesDataSet)

    End Sub


    Private Sub EmployeesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmployeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EmployeesDataSet)

    End Sub


    Private Sub EmployeesBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs) Handles EmployeesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmployeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EmployeesDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EmployeesDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.EmployeesDataSet.Employees)

    End Sub

    Private Sub EmployeesBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles EmployeesBindingSource.PositionChanged
        Dim CurrentRow As DataRowView = EmployeesBindingSource.Current
        Dim strMessage As String
        strMessage = CurrentRow.Item("FirstName") & Space(1) & CurrentRow.Item("LastName")
        MsgBox(strMessage)

    End Sub
End Class
