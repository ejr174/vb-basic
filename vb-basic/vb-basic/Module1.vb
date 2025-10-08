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

        '--------------------
        Console.WriteLine("------------ datosPorConsola() -----------")
        'datosPorConsola()

        Console.WriteLine("------------ CondicionalesIf() -----------")
        ' CondicionalesIf(8.8)


        Console.WriteLine("------------ Select case -----------")
        'Select Case: Sintaxis = Select Case opcion -> Case 1 -> Sección de cosido || Case 2 -> Sección de codigo
        Console.WriteLine("Ingresa un numero de 1 a 7")
        Dim num = Integer.Parse(Console.ReadLine())

        Select Case num
            Case 1
                Console.WriteLine("El numero seleccionado es = " & num & " y representa el lunes")
            Case 2
                Console.WriteLine("El numero seleccionado es = " & num & " y representa el martes")
            Case 3
                Console.WriteLine("El numero seleccionado es = " & num & " y representa el miercoles")
            Case Else
                Console.WriteLine("El numero seleccionado es = " & num & " pero no representa nada")
        End Select


        Console.WriteLine("------------ Exepciones - Try - Catch -----------")
        'Excepciones: Indican los problemas que se generan en nuestro codigo durante la ejecución.
        'Sintaxis : Try (intentar) - Catch ex As Exception (detectar-cacher) -> en ex guardamos el error
        'Try
        '    'Nuestor codigo
        'Catch ex As Exception
        '    ' En caso de existar un error
        'Finally 'Opcional
        '    'Se ejecuta en cualquiera de los casos
        'End Try

        Try
            Console.WriteLine("Por favor ingresa un número")
            Dim numString = Console.ReadLine()
            Dim numInteger = Integer.Parse(numString)

            Console.WriteLine("El valor ingresado es " & numInteger)
        Catch ex As Exception
            Console.WriteLine("Debe ingresar un valor númerico: " & ex.ToString())
        Finally ' Si ocurre algo aqui  podemos cerrar cualquier hilo de datos que quedara abierto
            Console.WriteLine("Se ejecuto finally")
        End Try

        Console.WriteLine("------------ Practica menu -----------")
        MenuBancario()


        Console.WriteLine("------------ Practica Copndiciones anidades -----------")
        EjercicioCondicionesAnidadas()

        Console.WriteLine("------------ Metodo random -----------")
        metodoRandom()
        '--------------------------------------------------------------------------------------
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

    ' Ingresar datos en consola: Para poder LEER los datos mediante la consola se utiliza la funcion Console.ReadLine()
    Sub datosPorConsola()
        Console.WriteLine("Ingresa tu nombre")
        Dim nombre = Console.ReadLine()

        Console.WriteLine(nombre & " en que año naciste?")
        Dim añoNacimiento = Integer.Parse(Console.ReadLine())

        Dim edad = DateTime.Now.Year - añoNacimiento

        Console.WriteLine(nombre & " cuanto ganas?")
        Dim sueldo As Single = Single.Parse(Console.ReadLine())

        Console.WriteLine("La edad de " & nombre & " es de: " & edad & " y tiene un sueldo de: " & sueldo)

    End Sub

    'Condicionales If - ElseIf - Else
    Sub CondicionalesIf(ByVal calificacion As Double)

        Dim calificacionRedondeada = Convert.ToInt32(Math.Round(calificacion))

        If calificacionRedondeada >= 0 AndAlso calificacionRedondeada <= 5 Then
            Console.WriteLine("Jodaaaaaaa, el estudiante perdió el año :(")
        ElseIf calificacionRedondeada >= 6 AndAlso calificacionRedondeada <= 9 Then
            Console.WriteLine("Bien papi, el estudiante aprobó el año :)")
        ElseIf calificacionRedondeada = 10 Then
            Console.WriteLine("Este muchacho me llena de orgullo, tuvo la nota maxima")
        Else
            Console.WriteLine("Parcero, el valor ingresado no corresponde a una califación válida, chupa monda")

        End If
    End Sub

    Public Sub MenuBancario()

        Try
            Dim saldoUsuario As Double = 100
            Console.WriteLine("Bienvenido al banco de mañe")
            Console.WriteLine("Selecciona una opción")
            Console.WriteLine("1- Ver saldo")
            Console.WriteLine("2- Ingresar dinero")
            Console.WriteLine("3- Sacar dinero")
            Console.WriteLine("4- Salir")

            Dim opcionSeleccionada As Integer = Integer.Parse(Console.ReadLine())
            Dim saldoIngresado As Double
            Dim saldoRetirado As Double

            Select Case opcionSeleccionada
                Case 1
                    Console.WriteLine("Su saldo es de: $" & saldoUsuario)
                Case 2
                    Console.WriteLine("Ingrese el valor a ingresar...")
                    saldoIngresado = Double.Parse(Console.ReadLine())

                    saldoUsuario = saldoUsuario + saldoIngresado

                    Console.WriteLine("Su saldo actual es de $ " & saldoUsuario)
                Case 3
                    Console.WriteLine("Cuanto vas a retirar?")
                    saldoRetirado = Double.Parse(Console.ReadLine())

                    If saldoRetirado > saldoUsuario Then
                        Console.WriteLine("Lo sentimos, no cuentas con fondos suficientes")
                    Else
                        saldoUsuario = saldoUsuario - saldoRetirado
                        Console.WriteLine("Su saldo actual es de $ " & saldoUsuario)
                    End If

                Case 4
                    Console.WriteLine("Gracias por visitarnos")
                Case Else
                    Console.WriteLine("No selecciono una opción valida, agvado")
            End Select

        Catch ex As Exception
            Console.WriteLine("Ocurrio un error: " & ex.ToString())
        End Try
    End Sub

    Public Sub EjercicioCondicionesAnidadas()
        Try
            Console.WriteLine("Ingrese un valor entre 1 y 999")
            Dim valorIngresado As Integer = Integer.Parse(Console.ReadLine())

            If valorIngresado >= 1 And valorIngresado <= 9 Then
                Console.WriteLine("El valor " & valorIngresado & " es UNIDAD")
            ElseIf valorIngresado >= 10 And valorIngresado <= 99 Then
                Console.WriteLine("El valor " & valorIngresado & " es DECENA")
            ElseIf valorIngresado >= 100 And valorIngresado <= 999 Then
                Console.WriteLine("El valor " & valorIngresado & " es CENTENA")
            Else
                Console.WriteLine("El valor " & valorIngresado & " No cumple")
            End If

        Catch ex As Exception
            Console.WriteLine("Error -> " & ex.Message)
        End Try
    End Sub

    Public Sub metodoRandom()
        ' La funcion random se utiliza principalmente para obtener un valor aleatorio. Puede recibir 0,1 o 2 parámetros
        ' Si se pasa 0 parametros entrega un numero aleatorio entre 0 y 32.000.000 
        ' Si se pasa 1 parametros entrega un numero aleatorio entre 0 hasta el numero ingresado -1 
        ' Si se pasa 2 parametros entrega un numero aleatorio entre el primer parametro y el segundo-1
        ' Sintaxis:
        Dim rand = New Random()

        Dim num1 = rand.Next
        Dim num2 = rand.Next(8)
        Dim num3 = rand.Next(8, 18)

        Console.WriteLine("El número generado es = " & num3)
    End Sub

End Module

