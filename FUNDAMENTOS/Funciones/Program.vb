Imports System

Module Program
    Sub Main(args As String())
        ' FUNCIONES
        ' Las funciones tambien son un bloque de código que solo se ejecuta cuando se llama.
        ' A diferencia de las Procedimientos, las funciones deben retornan un valor.

        ' AreaTriangulo = (AltoTriangulo * AnchoTriangulo) / 2

        Console.Write("Ingrese el alto del triangulo: ")
        Dim altoTriangulo As Integer = CInt(Console.ReadLine())

        Console.Write("Ingrese el ancho del triangulo:")
        Dim anchoTriangulo As Integer = CInt(Console.ReadLine())

        'Area(altoTriangulo, anchoTriangulo)

        Dim areaTriangulo As Double = AreaTriaungulo(altoTriangulo, anchoTriangulo)
        Console.WriteLine("El area del triangulo es {0}, porque el alto es = {1} y el ancho es = {2}", areaTriangulo, altoTriangulo, anchoTriangulo)
    End Sub

    Sub Area(al As Integer, an As Integer)
        Dim miArea As Double = (al * an) / 2
        Console.WriteLine("El area del triangulo es {0}", miArea)
    End Sub

    Function AreaTriaungulo(al As Integer, an As Integer) As Double
        Dim miArea As Double = (al * an) / 2

        Return miArea
    End Function
End Module
