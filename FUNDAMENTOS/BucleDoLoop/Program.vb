Imports System

Module Program
    Sub Main(args As String())
        ' A diferencia del bucle FOR que consiste en iterar una sección de código un numero de veces ya indicada (to i=10)
        ' El bucle Do Loop lo que hace es iterar una sección de código hasta que se cumpla una condición.

        Dim condicionParaParar As Integer = 0

        Do
            Console.WriteLine("Condicion 1. El valor es = " & condicionParaParar)
            condicionParaParar += 1

            If condicionParaParar = 10 Then
                Exit Do
            End If
        Loop

        ' Tenemos variable para el Ciclo Do... Podemo utilizar tambien While (Mientras) y Until (Hasta) al inicio o al ginal

        Dim condicionParaParar2 As Integer = 0

        Do While condicionParaParar2 < 5
            Console.WriteLine("Condicion 2, con While al inicio el valor es = " & condicionParaParar2)
            condicionParaParar2 += 1
        Loop

        'Condicion 3: Cuand  el While o el Until están al final se garantiza que se ejecute almenos una vez y luego valida
        Do
            Console.WriteLine("Condicion 3, con While al inicio el valor es = " & condicionParaParar2)
            condicionParaParar2 += 1
        Loop While condicionParaParar2 < 2

        Console.ReadKey()
    End Sub
End Module
