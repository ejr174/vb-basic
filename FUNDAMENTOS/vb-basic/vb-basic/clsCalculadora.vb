Public Class clsCalculadora

    Public Function suma(num1 As Integer, num2 As Integer) As Integer
        Dim resp As Integer = 0

        If num1 > 0 AndAlso num2 > 0 Then
            resp = num1 + num2
        Else
            resp = 0
        End If

        Return resp
    End Function

    Public Function resta(num1 As Integer, num2 As Integer) As Integer

        Dim resp As Integer = 0

        If num1 > 0 AndAlso num2 > 0 Then
            resp = num1 - num2
        Else
            resp = 0
        End If

        Return resp

    End Function

    Public Function multiplicar(num1 As Integer, num2 As Integer) As Integer

        Dim resp As Integer = 0

        If num1 > 0 AndAlso num2 > 0 Then
            resp = num1 * num2
        Else
            resp = 0
        End If

        Return resp

    End Function


    Public Function dividir(num1 As Double, num2 As Double) As Double

        Dim resp As Double = 0.0

        If num1 > 0 AndAlso num2 > 0 Then
            resp = num1 / num2
        Else
            resp = 0
        End If

        Return resp

    End Function



End Class
