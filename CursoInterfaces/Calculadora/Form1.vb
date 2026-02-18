Public Class frmPrincipal
    Private Sub clickBotonesNumeros(sender As Button, e As EventArgs) Handles btnComa.Click, btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click
        txtDisplay.Text += sender.Text
    End Sub
End Class
