Public Class Form1


    Sub rando()
        'buat a menjadi integer
        'lalu buat value menjadi integer juga, tapi dengan ketentuan
        'menjadi random, alias ngepick angka acak menggunakan Rnd() dan Randomize()
        Dim a As Integer
        Dim value As Integer = CInt(Int(TextBox1.Text + TextBox2.Text * Rnd()))
        ' clear dlu labelnya
        out_text.Text = ""
        ' masukan value CInt diatas, taruh di label
        out_text.Text = CInt(Int((TextBox1.Text + TextBox2.Text * Rnd())))
        ' jadian label menjadi integer a
        a = out_text.Text
        ' acak sekarang
        Randomize()

    End Sub

    Sub delete_all()
        out_text.Text = ""
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        out_text.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' panggil sub rando
        rando()
        sign_text.Text = "Here is your lucky number"
    End Sub

    Private Sub Clr_btn_Click(sender As Object, e As EventArgs) Handles clr_btn.Click
        delete_all()
        sign_text.Text = "Input Number From Anything u want"
    End Sub
End Class
