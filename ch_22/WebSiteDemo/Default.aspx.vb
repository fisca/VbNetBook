
Partial Class _Default
    Inherits Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblCurrentDateTime.Text = Date.Now.ToString()
    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        lblMessage.Text = txtMessage.Text
    End Sub
End Class