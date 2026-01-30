Imports System

Module Program
    Sub Main(args As String())

        ' EXCEPCIONES:
        ' Las excepcions son errores que se generan en tiempo de ejecución y que no han sido controlados.

        ' Para poder controlar una excepción, se utilizan las estructuras Try...Catch...Finally.

        ' El bloque Try contiene el código que puede generar una excepción.
        ' Cuando lo detecta inmediatamente pasa al bloque catch y deja de ejecutar el codigo del bloque Try.
        ' El bloque Catch contiene el código que se ejecuta si se produce una excepción.

        ' Finally es un bloque opcional que se ejecuta siempre, haya o no habido una excepción.

        Console.WriteLine("!EXCEPCIONES¡")
        Console.WriteLine("----------------------------------------------------------------")
        Console.WriteLine()

        Dim dividendo As Integer
        Dim divisor As Integer

        Dim repite As Boolean = True

        Do While repite

            Try

                Console.Write("Ingrese valor 1: ")
                dividendo = Console.ReadLine()

                Console.Write("Ingrese valor 2: ")
                divisor = Console.ReadLine()

                repite = False

            Catch ex As Exception

                Console.WriteLine("Se ha producido el siguiente error: {0}", ex.Message)
                Console.WriteLine()
                Console.WriteLine("!Intenta ingresar el valor nuevamente¡")


            Finally
                Console.WriteLine(" Soy el finally")
            End Try

        Loop


        Console.WriteLine("El cociente de la division es: {0}", dividir(dividendo, divisor))


    End Sub

    Function dividir(ByVal num1 As Integer, ByVal num2 As Integer) As Double

        Dim resultado As Double
        resultado = num1 / num2

        Return resultado

    End Function

End Module
