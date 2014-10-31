
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub rblNickname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rblNickname.SelectedIndexChanged
        Dim strFilename As String = ""
        If rblNickname.SelectedIndex = 0 Then
            strFilename = "kid01.jpg"
        ElseIf rblNickname.SelectedIndex = 1 Then
            strFilename = "kid02.jpg"
        ElseIf rblNickname.SelectedIndex = 2 Then
            strFilename = "kid03.jpg"
        End If

        imgPhoto.ImageUrl = "Images/" + strFilename
        lblFilename.Text = strFilename


    End Sub

    Protected Sub rblBorderStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rblBorderStyle.SelectedIndexChanged
        If rblBorderStyle.SelectedIndex = 0 Then
            imgPhoto.BorderStyle = BorderStyle.None
        ElseIf rblBorderStyle.SelectedIndex = 1 Then
            imgPhoto.BorderStyle = BorderStyle.Solid
        ElseIf rblBorderStyle.SelectedIndex = 2 Then
            imgPhoto.BorderStyle = BorderStyle.Inset
        End If
    End Sub

    Protected Sub chkFilename_CheckedChanged(sender As Object, e As EventArgs) Handles chkFilename.CheckedChanged
        lblFilename.Visible = chkFilename.Checked
    End Sub
End Class
