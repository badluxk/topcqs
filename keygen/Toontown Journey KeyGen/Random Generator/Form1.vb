Public Class Form1
    Dim pool As String = ""
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        pool = ""

        If CheckBox1.Checked = True Then
            pool = pool & "01234567890"
        End If
        If CheckBox2.Checked = True Then
            pool = pool & "abcdefghijklmnopqrstuvwxyz"
        End If
        If CheckBox3.Checked = True Then
            pool = pool & "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        End If
        Dim count = 0
        Result.Text = ""

        Dim cc As New Random
        Dim strpos = ""
        While count <= Lengthh.Text
            strpos = cc.Next(0, pool.Length)

            Result.Text = Result.Text & pool(strpos)
            count = count + 1

        End While
    End Sub
End Class
