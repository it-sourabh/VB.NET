Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Clear()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (ListBox1.SelectedItem = TextBox2.Text) Then
            MsgBox("Hey " & ListBox1.SelectedItem & " you have selected the correct item")
        Else
            MsgBox("You have selected the wrong item")
        End If
    End Sub
End Class
