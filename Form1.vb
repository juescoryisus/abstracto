Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim abs As New Abstracta2
        abs.Numero1 = 10
        abs.Numero2 = 8

        MsgBox(abs.Sumar)
        MsgBox(abs.Multiplicar)

    End Sub
End Class
