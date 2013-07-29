Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Visible = False
        Label1.Text = CStr(Int(Rnd() * 10))
        Label2.Text = CStr(Int(Rnd() * 10))
        Label3.Text = CStr(Int(Rnd() * 10))
        Label1.ForeColor = Color.Black
        Label2.ForeColor = Color.Black
        Label3.ForeColor = Color.Black

        If (Label1.Text = "9") Then
            Label1.ForeColor = Color.Red
            PictureBox1.Visible = True
            Beep()
        End If

        If (Label2.Text = "9") Then
            Label2.ForeColor = Color.Red
            PictureBox1.Visible = True
            Beep()
        End If

        If (Label3.Text = "9") Then
            Label3.ForeColor = Color.Red
            PictureBox1.Visible = True
            Beep()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub
End Class
