Imports System

Module Program
    Sub Main(args As String())
        ' SOBRE CARGA DE METODOS
        ' Permite definir varios procedimientos (Sub o Function) con el mismo nombre dentro de una misma clase.
        ' Pero con diferente firma (diferente número, tipo u orden de parametros).
        ' El compilador selecciona automáticamente la versión correcta SEGÚN LOS ARGUMENTOS QUE SE LE PASAN AL LLAMAR AL MÉTODO.


        Dim result As Double = promedio(5, 5.1, 10)
        Console.WriteLine("El promedio es = {0}", result)

    End Sub

    Function promedio(ByVal num1 As Integer, ByVal num2 As Integer) As Double
        Return (num1 + num2) / 2
    End Function

    Function promedio(ByVal num1 As Integer, ByVal num2 As Integer, ByVal num3 As Integer) As Double
        Return (num1 + num2) / 2
    End Function

    Function promedio(ByVal num1 As Double, ByVal num2 As Integer, ByVal num3 As Integer) As Double
        Return (num1 + num2) / 2
    End Function

    Function promedio(ByVal num1 As Integer, ByVal num2 As Double, ByVal num3 As Integer) As Double
        Return (num1 + num2) / 2
    End Function
End Module
