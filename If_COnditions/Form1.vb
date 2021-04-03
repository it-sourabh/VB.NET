Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim age As Integer
        Dim gender As String
        age = TextBox1.Text
        gender = TextBox2.Text
        If (gender = "Male" Or gender = "male" Or gender = "MALE") Then
            If (age >= 21) Then
                MsgBox("You can get married")
            Else
                MsgBox("You cannot get married")
            End If
        ElseIf (gender = "Female" Or gender = "female" Or gender = "FEMALE") Then
            If (age >= 18) Then
                MsgBox("You can get married")
            Else
                MsgBox("You cannot get married")
            End If
        Else
            MsgBox("Enter The values correctly")


        End If
        TextBox1.Clear()
        TextBox2.Clear()


    End Sub
End Class
