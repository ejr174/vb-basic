Imports System

Module Program
    Sub Main(args As String())

        ' PROCEDIMIENTO O SUB RUTINA
        ' Es un bloque de código que se utilizará unicamente cuando se llame, sino se llama jamas se ejecutara

        Encabezado("Bienvenidos al tema de hoy: !PROCEDIMIENTOS O SUB RUTINAS¡")

        Console.Write("Ingrese el valor 1 que desea multiplicar: ")
        Dim valor1 As Integer = CInt(Console.ReadLine())

        Console.Write("Ingrese el valor 2 que desea multiplicar: ")
        Dim valor2 As Integer = CInt(Console.ReadLine())

        Encabezado("RESULTADO DE LA MULPLICACIÓN")

        Multiplicar(valor1, valor2)
    End Sub

    Private Sub Encabezado(ByRef titulo As String)
        Console.WriteLine("-------------------------------------------------------")
        Console.WriteLine(titulo)
        Console.WriteLine("-------------------------------------------------------")
    End Sub

    Private Sub Multiplicar(ByRef num1 As Integer, ByRef num2 As Integer)
        Dim resultado As Integer
        resultado = num1 * num2
        Console.WriteLine("El resultado de multiplicar " & num1 & " x " & num2 & " es = " & resultado)
    End Sub
End Module
