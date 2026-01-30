Namespace Trigonometria
    ' El namespace es una forma de agrupar clases, módulos, interfaces, estructuras y enumeraciones dentro de un mismo proyecto.
    ' Su funcion principal es evitar conflictos de nombres y mantener el codifo ordenado y facil de mantener.
    Public Class clsMatematicas
        Private n1 As Integer
        Private n2 As Integer

        Public Sub New(_n1 As Integer, _n2 As Integer)
            n1 = _n1
            n2 = _n2
        End Sub

        Public Function suma()
            Return n1 + n2
        End Function

        Public Function resta()
            Return n1 + n2
        End Function

        Public Function multiplicacion()
            Return n1 * n2
        End Function
    End Class

    Class clsPersonajes
        Public Sub decirPersonaje()
            Console.WriteLine("Tanjirooooooooooooooooooooooooooo!!!")
        End Sub

    End Class

End Namespace
