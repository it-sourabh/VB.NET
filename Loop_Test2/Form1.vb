Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim k As Integer
        k = ListBox1.Items.Count - 1
        For i = 0 To k
            ListBox2.Items.Add(ListBox1.Items(i))
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
    End Sub
End Class
