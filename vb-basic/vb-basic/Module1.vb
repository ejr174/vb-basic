'Los modulos permiten separar las diferentes secciones en .vb
Module Module1
    ' Dentro de los módulo tenemos "sub rutinas"
    Sub Main()
        ' -------------- 
        ' MANEJANDO LA CONSOLA
        ' -------------- 
        'Diseño de la consola (opcional-practica)
        Console.ForegroundColor = ConsoleColor.White 'Foreground es el frente
        Console.BackgroundColor = ConsoleColor.Black ' Background es el fondo
        Console.Clear() ' Ayuda a corregir un problema con las consolas cuando se les modifica las propiedades

        'Mensajes que se muestran en consola 
        Console.WriteLine("Hola, la consola se ejecuto correctamente.")


        ' -------------- 
        ' TIPOS DE DATOS - PRACTICA
        ' -------------- 
        'Declara 2 variables enteras y asignar valor
        Dim varInt1 As Integer = 5
        Dim varInt2 As Integer = 10

        'Declara otra variable y asigna la suma de las 2 variables anteriores
        Dim sumVarInt As Integer = varInt1 + varInt2
        Console.WriteLine("La suma de las variables enteras fue: " & sumVarInt & "Y el tipo de dato de la suma es: " & sumVarInt.GetType.ToString())

        'Declara 3 variables de tipo entera en una sola lina
        Dim varInt3, varInt4, varInt5 As Integer

        ' Declara 2 variables tipo doble y asigna valor
        Dim varDouble As Double = 3.15
        Dim varDoble2 As Double = 2.88

        ' Declara terver variable tipo doble y asigna suma de las 2 variblas entera y las 2 variables 
        Dim sumVarDouble = varDouble + varDoble2
        Console.WriteLine("La suma de variables dobule fue: " & sumVarDouble & "Y el tipo de dato de la suma es: " & sumVarDouble.GetType.ToString())

        Dim valorFloat As Single = 3.3

        Dim sumTotal = sumVarInt + sumVarDouble + valorFloat
        Console.WriteLine("La suma de los totales de las varias int y double fue: " & sumTotal & "Y el tipo de dato de la suma es: " & sumTotal.GetType.ToString())

        'Metodo para mantener la consola abierta hasta que presione una letra
        Console.ReadKey() 'También podríamos utiliza Console.Read() Console.ReadLine()

    End Sub

End Module
