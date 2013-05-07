Public Class Form3
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = Int(Rnd() * 10)
        Label2.Text = Int(Rnd() * 10)
        Label3.Text = Int(Rnd() * 10)
    End Sub
    'Listing ini berisi source code yang membantu dalam proses pengacakan angka, yaitu mengacak angka dari 0-10. Hal ini karena datanya berupa Integer.
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        If Label1.Text = Label2.Text Or Label1.Text = Label3.Text Or
        Label2.Text = Label3.Text Or Label1.Text = Label2.Text = Label3.Text Then
            MsgBox("BINGO !")
            TextBox1.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
        Else
            MsgBox("UPSS !")
            TextBox1.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
        End If
        Button1.Enabled = True
        Button2.Enabled = False
    End Sub
    ' Listing ini digunakan untuk menghentikan pengacakan angka dan akan menampilkan message box tertentu apabila kita menang atau kita kalah dalam game
    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Close()
    End Sub
    'Listing ini digunakan untuk keluar dari permainan game
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form2.Show()
        Me.Hide()
    End Sub
    'Listing ini digunakan agar game kembali ke menu utama, yaitu form2. Dan untuk form permainan game menutup.
    Private Sub Button1_Click_1(ByVal sender As System.Object,
    ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Maaf, kamu belum memasang taruhan dan uang") 'Sorry you have not put the bet and your money
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
            Label1.Text = CStr(Int(Rnd() * 10))
            Label2.Text = CStr(Int(Rnd() * 10))
            Label3.Text = CStr(Int(Rnd() * 10))
            Timer1.Enabled = True
        End If
        If Val(TextBox2.Text) > Val(TextBox1.Text) Then
            MsgBox("Uang kamu tidak cukup")
            TextBox2.Text = "0"
        End If
        If Timer1.Enabled = True Then
            Label1.Text = ""
            Label2.Text = ""
            Label3.Text = ""
            Button1.Enabled = False
            Button2.Enabled = True
        End If
    End Sub
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object,
    ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If Val(TextBox1.Text) > "1000000" Then
            MsgBox("SELAMAT, KAMU MENANG !")
            Form4.Show()
            Me.Hide()
        End If
    End Sub
    'Listing digunakan untuk menunjukkan jika uang lebih dari 250000 maka muncul message box : CONGRATS, YOU WIN ! dan form 4 diperlihatkan sedangkan from sebelumnya disembunyikan
End Class