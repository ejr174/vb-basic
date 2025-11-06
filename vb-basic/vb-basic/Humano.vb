Public Class Humano

    Inherits Animal

    Public Overrides Sub comer()
        Console.WriteLine("El Humano come en un plato!")
    End Sub

    Public Overrides Sub correr()
        Console.WriteLine("El Humano corre con tenis!")
    End Sub
End Class
