Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usr, pass As String
        usr = TextBox1.Text
        pass = TextBox2.Text
        If (usr = "sourabh" And pass = "sourabh") Then
            Form2.Show()
            Hide()
        Else
            MsgBox("Invalid Credentials")
        End If
    End Sub
End Class
