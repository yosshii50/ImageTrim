
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        For c As Integer = 0 To 1000
            FileLoadTrimSave.LoadTrimSave("C:\!Delete\000.jpg", "C:\!Delete\000_SV.jpg", c, 100, 100, 200)

            Button1.Text = c
            Button1.Refresh()
        Next

    End Sub

End Class
