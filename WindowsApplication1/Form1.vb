Public Class Form1
        Private Sub Button1_Click_1(ByVal sender As System.Object,
        ByVal e As System.EventArgs) Handles Button1.Click
            Form2.Show()
            Me.Hide()
        End Sub
    'Listing ini digunakan untuk memulai game, yaitu dengan memunculkan form2
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("TERIMA KASIH")
        Close()
    End Sub
    'Listing ini digunakan untuk menutup program aplikasi, yaitu dengan menutup form1

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form7.Show()
        Me.Hide()
    End Sub
End Class
