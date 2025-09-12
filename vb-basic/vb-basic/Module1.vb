'Los modulos permiten separar las diferentes secciones en .vb
Module Module1
    ' Dentro de los módulo tenemos "sub rutinas"
    Sub Main()
        'Diseño de la consola (opcional-practica)
        Console.ForegroundColor = ConsoleColor.White 'Foreground es el frente
        Console.BackgroundColor = ConsoleColor.Cyan ' Background es el fondo
        Console.Clear() ' Ayuda a corregir un problema con las consolas cuando se les modifica las propiedades

        'Mensajes que se muestran en consola 
        Console.WriteLine("Hola, la consola se ejecuto correctamente.")
        Console.WriteLine("Presiona una letra para salir ->")

        'Metodo para mantener la consola abierta hasta que presione una letra
        Console.ReadKey() 'También podríamos utiliza Console.ReadLine
    End Sub

End Module
