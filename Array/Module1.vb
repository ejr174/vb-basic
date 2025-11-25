Module Module1

    Sub Main()

        'Declaracion de Array
        Dim miArray() As String = {"Emmanuel", "Rose", "Aleja", "Jota"}

        Console.WriteLine(miArray(1))

        ' Declarar array y luego asignar valor
        Dim personajes(2) As String ' Debemos indicarle número máximo de indices que tendrá el array.
        personajes(0) = "Itachi"
        personajes(1) = "Tomioka"
        personajes(2) = "Mañe"

        Console.WriteLine("El personajes es: " & personajes(1))

        ' Tambien podemos re dimensionar nuestro array
        ReDim Preserve personajes(1) ' Se debe colocar la palabra reservada "Preserve" porque sino la información del array se pierde
        'personajes(0) = "Falcao"
        'personajes(1) = "Emmanuel"
        Console.WriteLine("El personaje re dimensionado es: " & personajes(1))

        Console.ReadLine()

    End Sub

End Module
