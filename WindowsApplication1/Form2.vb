Public Class Form2
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()
    End Sub
    'Listing ini digunakan untuk memulai permainan Casino dengan angka, yaitu dengan memunculkan form3.
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form5.Show()
        Me.Hide()
    End Sub
    'Listing ini digunakan untuk memulai permainan Casino dengan gambar, yaitu dengan memunculkan form5

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class