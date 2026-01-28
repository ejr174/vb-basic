Module Module1

    Sub Main()
        Console.WriteLine("Bienvenido a este espacio de pruebas")

        Console.WriteLine("Ingresa el valor 1: ")
        Dim valor1 As Integer = CInt(Console.ReadLine())

        Console.WriteLine("Ingrese valor 2: ")
        Dim valor2 As Integer = CInt(Console.ReadLine())

        Console.WriteLine("La suma de valor1 + valor2 es = " & valor1 + valor2)

        If valor1 > valor2 Then
            Console.WriteLine("El valor " & valor1 & " es mayor que el " & valor2)
        ElseIf valor2 > valor1 Then
            Console.WriteLine("El valor " & valor2 & " es mayor que el " & valor1)
        End If

        ' Condicional - Select Case
        Select Case valor1
            Case 1
                Console.WriteLine("El valor es 1")
            Case 2
                Console.WriteLine("El valor es 2")
            Case Else
                Console.WriteLine("El valor es diferente de 1 o 2")
        End Select





        Console.ReadKey()
    End Sub

End Module
