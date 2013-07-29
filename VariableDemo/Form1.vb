Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FirstName As String
        FirstName = "Suttipong"
        Label1.Text = FirstName
        FirstName = "Fisca"
        Label2.Text = FirstName
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Promt, FullName As String
        Promt = "กรุณาป้อนชื่อและนามสกุลของคุณ"
        FullName = InputBox(Promt)
        Label1.Text = FullName
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Promt, FullName As String
        Promt = "กรุณาป้อนชื่อและนามสกุลของคุณ"
        FullName = InputBox(Promt)
        MsgBox(FullName, , "ชื่อและนามสกุลของคุณ")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub
   
End Class
