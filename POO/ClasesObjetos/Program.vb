Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Clases y Objetos!")

        ' Instancia de la clase clsCalculadoraArea
        Dim miCalculadora As New clsCalculadoraArea

        ' Ahora la variable miCalculadora puede re utilizar los metodos de la clase
        Console.WriteLine(miCalculadora.areaTriangulo(2, 5))

    End Sub
End Module
