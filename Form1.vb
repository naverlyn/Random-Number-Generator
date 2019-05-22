Public Class Form1


    Sub rando()
        Dim a As Integer
        Dim value As Integer = CInt(Int(TextBox1.Text + TextBox2.Text * Rnd()))
        out_text.Text = ""
        out_text.Text = CInt(Int((TextBox1.Text + TextBox2.Text * Rnd())))
        a = out_text.Text
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
        rando()
        sign_text.Text = "Here is your lucky number"
    End Sub

    Private Sub Clr_btn_Click(sender As Object, e As EventArgs) Handles clr_btn.Click
        delete_all()
        sign_text.Text = "Input Number From Anything u want"
    End Sub
End Class
