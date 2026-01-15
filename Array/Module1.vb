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

    Sub DimensionesArray()

        'Array unidimencional
        Dim equipos(2) As String

        equipos(0) = "Atl.Nacional"
        equipos(1) = "Real Madrid"
        equipos(2) = "Liverpool"

        Console.WriteLine(1) ' Imprime real madrid

        'Array Bidimencional (fila,columna)
        Dim jugadores(1, 2) As String

        jugadores(0, 0) = "Cristiano"
        jugadores(0, 1) = "Luchito Diaz"
        jugadores(0, 2) = "Neymar"

        jugadores(1, 0) = "Alexis Mejia"
        jugadores(1, 1) = "MAC"
        jugadores(1, 2) = "GIO
"
        'Array tridimencional (rango,fila,columna) -> Max 32 tablas (rango)


    End Sub


End Module
