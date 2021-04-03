Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim un, total As Decimal
        un = TextBox1.Text
        If (RadioButton1.Checked = True) Then
            total = (un * 7)
        ElseIf (RadioButton2.Checked = True) Then
            total = (un * 10)
        Else
            MsgBox("Error: Please Select Use")
        End If
        Label6.Text = "$" + Str(total)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        Form2.Show()
    End Sub
End Class
