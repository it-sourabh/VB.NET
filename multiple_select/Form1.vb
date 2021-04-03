Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As String
        Dim j As Integer
        Dim k As Integer
        i = TextBox1.Text
        j = TextBox2.Text

        Select Case i
            Case "Jodhpur"
                Select Case j
                    Case 1
                        k = 1200 * 1
                    Case 2
                        k = 1200 * 2
                    Case 3
                        k = 1200 * 3
                    Case 4
                        k = 1200 * 4
                    Case 5
                        k = 1200 * 5
                    Case Else
                        MsgBox("You cannot enter more than 5 days")
                End Select
            Case "Jaipur"
                Select Case j
                    Case 1
                        k = 1300 * 1
                    Case 2
                        k = 1300 * 2
                    Case 3
                        k = 1300 * 3
                    Case 4
                        k = 1300 * 4
                    Case 5
                        k = 1300 * 5
                    Case Else
                        MsgBox("You cannot enter more than 5 days")
                End Select
            Case "Udaipur"
                Select Case j
                    Case 1
                        k = 2000 * 1
                    Case 2
                        k = 2000 * 2
                    Case 3
                        k = 2000 * 3
                    Case 4
                        k = 2000 * 4
                    Case 5
                        k = 2000 * 5
                    Case Else
                        MsgBox("You cannot enter more than 5 days")
                End Select
            Case Else
                MsgBox("City Not available")
        End Select
        Label4.Text = k
    End Sub


End Class
