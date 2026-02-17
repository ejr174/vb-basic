Public Class frmPrincipal
    Private Sub btnSaludo_Click(sender As Object, e As EventArgs) Handles btnSaludo.Click
        MsgBox("Hola Mundo")
    End Sub

    Private Sub btnSaludo_MouseHover(sender As Object, e As EventArgs) Handles btnSaludo.MouseHover
        MsgBox("Que pasa chico? Vas a dar click o no?")
    End Sub
End Class
