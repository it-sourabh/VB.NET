Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uname, pass As String
        uname = TextBox1.Text
        pass = TextBox2.Text
        If (uname = "sourabh" And pass = "password") Then
            Hide()
            Form1.Show()
        Else
            MsgBox("Wrong Username or Password")
        End If
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()

    End Sub
End Class