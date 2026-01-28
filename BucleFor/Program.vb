Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        Dim tarjetas(2, 2) As String

        'Ingresar los datoas de la tarjeta
        tarjetas(0, 0) = "000000"
        tarjetas(0, 1) = "0000"
        tarjetas(0, 2) = "500"

        tarjetas(1, 0) = "111111"
        tarjetas(1, 1) = "1111"
        tarjetas(1, 2) = "34500"

        tarjetas(2, 0) = "222222"
        tarjetas(2, 1) = "2222"
        tarjetas(2, 2) = "1500"

        Console.WriteLine("Ingresa la tarjeta: ")
        Dim tarjetaIngresada As String = Console.ReadLine()

        Console.WriteLine("Ingrese el PIN: ")
        Dim pinIngresado As String = Console.ReadLine()

        Dim encontrada As Boolean = False
        Dim saldo As Decimal
        For i As Integer = 0 To 2

            If tarjetaIngresada = tarjetas(i, 0) AndAlso pinIngresado = tarjetas(i, 1) Then
                encontrada = True
                saldo = CDec(tarjetas(i, 2))

                If encontrada Then
                    Console.WriteLine("El saldo de la tarjeta ingresada es: " & saldo)
                End If

            End If

        Next



        Console.ReadKey()
    End Sub
End Module
