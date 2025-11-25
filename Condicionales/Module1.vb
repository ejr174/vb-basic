Module Module1

    Sub Main()
        ' Operadores de comparacion
        ' = Igual que
        ' <> diferente que
        ' < menor que
        ' =< | <= igual o menor que | menor o igual que
        ' > mayor que
        ' => | >= igual o mayor que | mayor igual que
        ' Is
        ' IsNot
        ' Like

        selectCase()

        Console.ReadKey()

    End Sub

    Public Sub opcionesCajero()
        'Bienvenida al cajero
        Console.WriteLine("Bienvenido a su Cajero Automatico de confianza")
        Console.WriteLine("----------------------------------------------")
        Console.WriteLine()

        ' Listado de opciones del cajero
        Console.WriteLine("Menú principal")
        Console.WriteLine(" 1. Consultar saldo. ")
        Console.WriteLine(" 2. Ingresar saldo. ")
        Console.WriteLine(" 3. Retirar saldo. ")
        Console.WriteLine(" 4. Salir. ")
    End Sub
    Public Sub condicionalIf()

        opcionesCajero()

        'Leer la opcion seleccionada
        Console.WriteLine()
        Console.WriteLine("Por favor selecciona una opcion...")
        Dim opcionSeleccionada As Integer = CInt(Console.ReadLine())

        Console.WriteLine()
        Console.WriteLine("Opcion seleccionada " & opcionSeleccionada)

        ' Condicional: IF
        Console.WriteLine()
        Console.WriteLine("----------------------- PROCESANDO... -----------------------")
        If opcionSeleccionada = 1 Then
            Console.WriteLine("Su saldo es de $50.000")
        ElseIf opcionSeleccionada = 2 Then
            Console.WriteLine("Ingrese su saldo...")
            Dim saldoNuevo As Integer = CInt(Console.ReadLine)

            Console.WriteLine("Su saldo actual es de: " & saldoNuevo & "$")
        ElseIf opcionSeleccionada = 3 Then
            Console.WriteLine("Ingrese el saldo a retirar:")
            Dim saldoRetirado As Integer = CInt(Console.ReadLine)

            Console.WriteLine("El saldo que retiro es de: " & saldoRetirado & "$")
        ElseIf opcionSeleccionada = 4 Then
            Console.WriteLine("Muchas gracias por utilizarnos, vuelve pronto :)")
        Else
            Console.WriteLine("¡Lo sentimos!, la opción seleccionada no corresponde a las opciones del menú actual.")
        End If

    End Sub

    Public Sub selectCase()
        opcionesCajero()

        'Leer la opcion seleccionada
        Console.WriteLine()
        Console.WriteLine("Por favor selecciona una opcion...")
        Dim opcionSeleccionada As Integer = CInt(Console.ReadLine())

        Console.WriteLine()
        Console.WriteLine("Opcion seleccionada " & opcionSeleccionada)

        Dim saldo As Decimal = 500.5

        Select Case opcionSeleccionada
            Case 1
                Console.WriteLine("Su saldo es de $50.000")

            Case 2
                Console.WriteLine("Ingrese su saldo...")
                Dim saldoNuevo As Integer = CInt(Console.ReadLine)

                Console.WriteLine("Su saldo actual es de: " & saldo + saldoNuevo & "$")

            Case 3
                Console.WriteLine("Ingrese el saldo a retirar:")
                Dim saldoRetirado As Integer = CInt(Console.ReadLine)

                Console.WriteLine("El saldo que retiro es de: " & saldo - saldoRetirado & "$")

            Case 4
                Console.WriteLine("Muchas gracias por utilizarnos, vuelve pronto :)")

            Case 5, 6, 7
                Console.WriteLine("Opciones no validas ome, sea feo pero serio")

            Case 8 To 10
                Console.WriteLine("Si solo tenemos opciones del 1 al 4 que haces colocando este valor, cachon!")
            Case Else
                Console.WriteLine("¡Lo sentimos!, la opción seleccionada no corresponde a las opciones del menú actual.")
        End Select

    End Sub

End Module
