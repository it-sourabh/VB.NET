Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        i = TextBox1.Text
        Select Case i
            Case 1
                TextBox2.Text = "one"
            Case 2
                TextBox2.Text = "two"
            Case 3
                TextBox2.Text = "three"
            Case 4
                TextBox2.Text = "four"
            Case 5
                TextBox2.Text = "five"
            Case Else
                TextBox2.Text = "Enter only [1-5]"
        End Select

    End Sub
End Class
