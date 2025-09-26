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

        ' -------------- 
        ' DECLARACIÓN IMPLÍCITA Y EXPLÍCITA
        ' -------------- 
        'Declaración explícitas: Indica al IDE  cómo se llama y de que tipo son. Ejemplo:
        Dim nombre As String = "Emmanuel"

        'Declaración implícitas: Variables sin declarar, su tipo de dato se define apartir del valor MÁS GRANDE que se le asigne. Ejemplo:
        Dim nombre2 = "Juan"


        ' -------------- 
        ' TIPO DE DATO STRING
        ' -------------- 
        Dim miPagina = "paginaWeb.com"
        Dim presentacionPagina = "Mi pagina web es de ejemplo: "

        'Convertir a mayuscula       
        Console.WriteLine("String en mayuscula = " & miPagina.ToUpper())

        'Convertir a minuscula
        Console.WriteLine("String en minuscula = " & miPagina.ToLower())

        'Reemplazar el .com por un .mx
        Console.WriteLine("Reemplazar de mni pagina el .com por .mx = " & miPagina.Replace(".com", ".mx"))


        ' -------------- 
        ' PROPIEDAD Parse : Permite cambiar el tipo de dato
        ' -------------- 

        Dim numString1 = "15.66"
        Dim numString2 = 15

        ' De STRING a INT
        Dim numInt = Integer.Parse(numString2)

        ' De STRING a FLOAT
        Dim numFloat = Single.Parse(numString1)

        ' De STRING a DOUBLE
        Dim numDouble = Double.Parse(numString1)


        ' -------------- 
        ' OPERADORES LOGICOS : Or, & And, Not
        ' -------------- 
        Dim a = True
        Dim b = False

        Dim resultadoOperadorOr = a Or b 'True
        Dim resultadoOperadorAnd = a And b ' Falsa
        'Dim resultadoOperadorNot = a Not b


        Console.WriteLine("resultadoOperadorOr = " & resultadoOperadorOr)
        Console.WriteLine("resultadoOperadorAnd = " & resultadoOperadorAnd)
        ' Console.WriteLine("resultadoOperadorNot = " & resultadoOperadorNot)

        'Constantes: Es un valor que no cambiara en el flujo de nuestro codigo
        Const PI = 3.14
        Const idUser = 960505

        Console.WriteLine("-------- Constantes ---------")
        Console.WriteLine("Pi = " & PI & " y el id es = " & idUser)

        'Operadores aritmetico: Sirven para realizar operaicones matematicas + - * / %
        Dim num1 = 3, num2 = 2
        Dim suma = num1 + num2
        Dim resta = num1 - num2
        Dim residuo = num1 Mod num2 ' % -> Residuo  en vb  es mod

        Console.WriteLine("---------- Operadores aritmeticos ----")
        Console.WriteLine("Suma de " & num1 & " + " & num2 & " es = " & suma)


        ' Sub rutina: Es un bloque de codigo  que contiene instrucciones.
        ' Un programa ejecuta las intrucciones llamando la sub y especificando los argumento necesarios
        ' Sintaxis:
        'Public Sub nombreSubRutina(argumentos)
        '    '       Cuerpo instrucciones sub rutina
        'End Sub
        'Llado de la subrutina; nombreSubRutina(parametros)


        Console.WriteLine("---------- Sub rutina ----")
        saludo("Enrique Manuel")

        Console.WriteLine("------------ EJERCICIO 1 -----------")
        ejercicio1()

        Console.WriteLine("------------ EJERCICIO 2 -----------")
        ejercicio2(1996)

        Console.WriteLine("------------ EJERCICIO 2 Refactorizado de SUB -> FUNCTION -----------")

        Dim edadUsuario = calculaEdad(1997)
        Console.WriteLine("La edad del usuario en la refactorizacion del metodo SUB -> FUNCTION es de: " & edadUsuario)
        ' ----------------------------------
        'Metodo para mantener la consola abierta hasta que presione una letra
        Console.ReadKey() 'También podríamos utiliza Console.Read() Console.ReadLine()

    End Sub

    Sub saludo(ByVal nombre As String)
        Console.WriteLine("Un saludo muy especial para " & nombre & " desde la sub rutina saludo()")
    End Sub

    'Ejercicio 1: Concatenar y flujo del codigo vb
    Public Sub ejercicio1()
        Dim name As String = "Trunks"
        Dim apellido As String = "Brief"
        Dim nombreCompleto = name + " " + apellido

        Console.WriteLine("Nombre completo inicial: " & nombreCompleto)

        apellido = "Principe Saiyajins"
        nombreCompleto = name + " " + apellido
        Console.WriteLine("Nombre completo modificado: " & nombreCompleto)
    End Sub

    ' Ejercicio 2: Mostrar la edad del usuario
    Sub ejercicio2(ByVal nacimiento As Integer)
        Dim anioActual = DateTime.Now.Year
        Dim anioNacimiento = nacimiento

        Dim edad = anioActual - anioNacimiento

        Console.WriteLine("La edad del usuario nacido en el año " & anioNacimiento & " es de " & edad & " años.")

    End Sub

    'Sub VS Function: Ambas permiten contenter un bloque de codigo que puede ser re utilizado.
    ' La diferencia principal es que Function retorna un valor y Sub no.

    'Esta es una refactorizacion de la sub "ejercicio2()" 
    Function calculaEdad(ByVal anioNacimiento As Integer)
        Dim anioActual = DateTime.Now.Year

        Dim edad = anioActual - anioNacimiento

        Return edad
    End Function

End Module
