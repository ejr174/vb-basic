Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("CONSTRUCTORES")
        Console.WriteLine("==============")

        Dim persona1 As New clsPersonas()
        Console.WriteLine("Nombre: " & persona1.Nombre)
        Console.WriteLine("Edad: " & persona1.Edad)

        Console.WriteLine("==============")

        Dim persona2 As New clsPersonas("Emmanuel", 29)
        Console.WriteLine("Nombre: " & persona2.Nombre)
        Console.WriteLine("Edad: " & persona2.Edad)
    End Sub
End Module
