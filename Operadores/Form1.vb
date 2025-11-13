Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Declaración e inicialiazación de variables
        Dim valor1 As Double = 3
        Dim valor2 As Double = 10
        Dim resultado As Double

        'Operamos con las variables
        resultado = valor1 + valor2 ' Suma
        resultado = valor1 - valor2 ' Resta
        resultado = valor1 / valor2 ' División
        resultado = valor1 * valor2 ' Multiplicación
        resultado = valor1 ^ valor2 ' Exponente
        resultado = valor1 Mod valor2 ' Mod

        MsgBox("El resultado es = " & resultado)
    End Sub
End Class
