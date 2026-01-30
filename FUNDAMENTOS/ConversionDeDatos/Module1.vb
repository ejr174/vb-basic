Module Module1

    Sub Main()
        Console.WriteLine("Bienvenido al módulo")

        Console.WriteLine("Ingresa el valor # 1")
        Dim num1 As Integer = CInt(Console.ReadLine()) ' Obtenemos el dato introducido por el usuario y lo convertimos en Integer

        Console.WriteLine("Ingrese el valor #2")
        Dim num2 As Integer = CInt(Console.ReadLine())

        Dim resultado As Integer = num1 + num2
        Console.WriteLine("El resultado de la suma de " & num1 & " y " & num2 & " es = " & resultado)

        Console.ReadKey()

        ' Tambien podemos utilizar metodos para convertir otro tipos de datos CBool - CChar - CDate ...etc
    End Sub

End Module
