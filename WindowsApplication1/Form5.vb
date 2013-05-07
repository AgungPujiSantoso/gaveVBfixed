Public Class Form5
        Dim p1, p2, p3 As Integer

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        p1 = Int(1 + Rnd() * 5)
        p2 = Int(1 + Rnd() * 5)
        p3 = Int(1 + Rnd() * 5)
        Select Case p1
            Case 1
                PictureBox1.Image = ImageList1.Images.Item(0)
            Case 2
                PictureBox1.Image = ImageList1.Images.Item(1)
            Case 3
                PictureBox1.Image = ImageList1.Images.Item(2)
            Case 4
                PictureBox1.Image = ImageList1.Images.Item(3)
            Case 5
                PictureBox1.Image = ImageList1.Images.Item(4)
        End Select
        Select Case p2
            Case 1
                PictureBox2.Image = ImageList1.Images.Item(0)
            Case 2
                PictureBox2.Image = ImageList1.Images.Item(1)
            Case 3
                PictureBox2.Image = ImageList1.Images.Item(2)
            Case 4
                PictureBox2.Image = ImageList1.Images.Item(3)
            Case 5
                PictureBox2.Image = ImageList1.Images.Item(4)
        End Select
        Select Case p3
            Case 1
                PictureBox3.Image = ImageList1.Images.Item(0)
            Case 2
                PictureBox3.Image = ImageList1.Images.Item(1)
            Case 3
                PictureBox3.Image = ImageList1.Images.Item(2)
            Case 4
                PictureBox3.Image = ImageList1.Images.Item(3)
            Case 5
                PictureBox3.Image = ImageList1.Images.Item(4)
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        If p1 = p2 Or p1 = p3 Or p2 = p3 Then
            MsgBox("BINGO !")
            TextBox1.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
        Else
            MsgBox("UPSS !")
            TextBox1.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
        End If
        Button1.Enabled = True
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub

        'Listing ini digunakan untuk menunjukan jika button3 diklik maka akan mengclose sendiri.
    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form2.Show()
        Me.Hide()
    End Sub

        'Listing ini digunakan untuk menunjukkan jika button4 diklik maka form2 akan muncul dan form 5 akan disembunyikan.
        Private Sub Button1_Click_1(ByVal sender As System.Object,
        ByVal e As System.EventArgs) Handles Button1.Click
            If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Maaf, kamu belum memasang taruhan dan uang")
                Timer1.Stop()
            ElseIf Val(TextBox2.Text) < "100" Then
            MsgBox("Minimal taruhan adalah 100")
                TextBox2.Text = "100"
        ElseIf Val(TextBox1.Text) < "5000" Then
            MsgBox("Minimal uang adalah 5000")
            ElseIf Val(TextBox1.Text) <= 0 Then
            MsgBox("Maaf kamu kalah, Game berakhir")
                Form4.Show()
                Me.Hide()
            Else
                PictureBox1.Text = CStr(Int(Rnd() * 5))
                PictureBox2.Text = CStr(Int(Rnd() * 5))
                PictureBox3.Text = CStr(Int(Rnd() * 5))
                Timer1.Enabled = True
            End If
            If Val(TextBox2.Text) > Val(TextBox1.Text) Then
            MsgBox("Uang kamu tidak cukup")
                TextBox2.Text = "0"
            End If
            If Timer1.Enabled = True Then
                PictureBox1.Text = ""
                PictureBox2.Text = ""
                PictureBox3.Text = ""
                Button1.Enabled = False
                Button2.Enabled = True
            End If
        End Sub

        Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        End Sub
        Private Sub TextBox1_TextChanged(ByVal sender As System.Object,
        ByVal e As System.EventArgs)
        If Val(TextBox1.Text) > "1000000" Then
            MsgBox("SELAMAT, KAU MENANG !")
            Form4.Show()
            Me.Hide()
        End If
        End Sub

End Class