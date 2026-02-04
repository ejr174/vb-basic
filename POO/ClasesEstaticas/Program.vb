Imports System

Module Program
    Sub Main(args As String())

        ' Las clases estaticas nos ayudan a tener las funcionales de un objeto dentro de una clase (modulo).

        ' En este ejemplo para usar el metodo areaTriangulo necesitamos instanciar o crear un objeto.
        ' Pero para este ejemplo es necesario crear varias intancias para utilizar el metodo areaTriangulo
        ' La respuesta es NO. Con un solo objeto tendríamos.

        Dim calculadora1 As New clsCalculadoraArea()
        Dim calculadora2 As New clsCalculadoraArea()

        Console.WriteLine(calculadora1.areaTriangulo(10, 10))

        ' Al crear una clase estatica o modulo no podemos crear...
        ' Ya no necesitamos instanciar un objeto para utilizar las funcionalidades, ahoram llamos al modulo
        Console.WriteLine(modCalculadoraArea.areaTriangulo(10, 10))


    End Sub
End Module
