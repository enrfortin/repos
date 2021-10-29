Public Class Form3
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox2.Text= encriptar.Encriptar(textbox1.text)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
            TextBox3.Text= encriptar.Desencriptar(textbox2.text)
    End Sub
End Class