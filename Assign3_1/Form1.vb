Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.Items.Add("z")
        ComboBox1.Items.Add("b")
        ComboBox1.Items.Add("a")
        ComboBox1.Items.Add("h")
        ComboBox1.Items.Add("y")
        ComboBox1.Items.Add("o")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListBox1.Items.Contains(ComboBox1.SelectedItem) Then
            MsgBox("Duplicate Value")
        Else
            ListBox1.Items.Add(ComboBox1.SelectedItem)
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Sorted = True


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox1.Items.Clear()
        ListBox1.Items.Clear()
    End Sub
End Class
