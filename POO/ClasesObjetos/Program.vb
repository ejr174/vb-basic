Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Clases y Objetos!")

        ' Instancia de la clase clsCalculadoraArea
        Dim miCalculadora As New clsCalculadoraArea

        ' Ahora la variable miCalculadora puede re utilizar los metodos de la clase
        Console.WriteLine(miCalculadora.areaTriangulo(2, 5))

        ' Uso de la propiedad Publica m2 de la clase clsCalculadoraArea 
        ' Mala practica: Modificar su valor desde otra clase
        miCalculadora.m2 = -10
        Console.WriteLine("El valor de m2 es: " & miCalculadora.m2)

        ' Al intentar modicar el valor de la propiedad m1 podemos evaluar el valor que se manda
        ' En este caso estamos intentando enviar un valor negativo ( < 0 ) y en la propiedad de la clase no lo dejamos
        miCalculadora.m1 = -20
        Console.WriteLine("El valor de m2 es: " & miCalculadora.m1)

    End Sub
End Module
