Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Decimal
        a = TextBox1.Text
        b = TextBox2.Text
        c = a * b
        TextBox3.Text = c
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a, b, c As Decimal
        a = TextBox1.Text
        b = TextBox2.Text
        c = a + b

        TextBox3.Text = c
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a, b, c As Decimal
        a = TextBox1.Text
        b = TextBox2.Text
        c = a / b
        TextBox3.Text = c
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a, b, c As Decimal
        a = TextBox1.Text
        b = TextBox2.Text
        c = a - b
        TextBox3.Text = c
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) 

    End Sub
End Class
