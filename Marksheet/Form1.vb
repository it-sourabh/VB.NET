Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Hin, eng, sci, sst, mat, Total, per As Decimal
        Hin = TextBox1.Text
        eng = TextBox2.Text
        sci = TextBox3.Text
        sst = TextBox4.Text
        mat = TextBox5.Text
        Total = Hin + eng + sci + sst + mat
        per = (Total / 500) * 100
        TextBox6.Text = Total
        TextBox7.Text = per
        If (per >= 60) Then
            TextBox8.Text = "First Division"
        ElseIf (per >= 49 And per <= 59) Then
            TextBox8.Text = "Second Division"
        ElseIf (per >= 34 And per <= 48) Then
            TextBox8.Text = "Third Division"
        Else
            TextBox8.Text = "Fail"
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()

    End Sub
End Class
