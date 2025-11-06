'Los modulos permiten separar las diferentes secciones en .vb
Module Module1
    ' Dentro de los módulo tenemos "sub rutinas"
    Sub Main()


        'Console.WriteLine("------------ POO: CLASE AUTO -----------")
        'instanciarAuto()

        'Console.WriteLine("------------ POO: CLASE CALCULADORA -----------")
        'intanciarClsCalculadora()

        'Console.WriteLine("------------ POO: CLASE PERSONA -----------")
        'instanciarClsPersona()

        'Console.WriteLine("------------ POO: CLASE VEHICULO -----------")
        'instanciarClcVehiculo()

        'Console.WriteLine("------------ POO: CLASE MATEMATICAS -----------")
        'instanciarMatematicas()

        'Console.WriteLine("------------ POO: CLASE EMPLEADO -----------")
        'intanciarClsEmpleado()

        'Console.WriteLine("------------ POO: CLASE MiClase que contiene información sobre atributos estátcos -----------")
        'instanciarAtributosEstaticos()

        'Console.WriteLine("------------ POO: HERENCIA -----------")
        'instanciarHerenciaPOO()

        instanciarSobreEscrituraMetodo()
        '--------------------------------------------------------------------------------------
        'Metodo para mantener la consola abierta hasta que presione una letra
        Console.ReadKey() 'También podríamos utiliza Console.Read() Console.ReadLine() 
    End Sub



    ' POO
    ' POO: Es un paradigma de programación; Es una manera de programar especifica, donde se organiza el código en unidades denominadas clases.
    ' Las clases crean objetos que se relacioan entre sí para conseguir los objetivos de las aplicaciones.

    ' La POO es una forma especial de programar, más cercana a cómo expresaríamos las cosas en la vida real que otros tipo de progración.

    ' Ejemplo: Tenemos un OBJETO carro, este carro  tiene CARACTERISTICAS como: Color - Marca - Modelo.
    ' El carro tambien tiene unas FUNCIOANLIDADES como: Encender - Apagar- Acelerar - Frenar

    ' Entonces en POO, una CLASE es una abstracción de un OBJETO. Retomando el ejemplo del auto...
    ' la CLASE Auto tiene unos ATRIBUTOS (caracteristicas) y tambien MÉTODOS (funcionalidades)

    ' Instancia: Cuando se crea un objeto apartir de una clase. Entonces el nuevo objeto creado es una instancia de la clase.
    ' Las instancias ya tienen atributos y metodos definidos por la clase, pero estos se pueden modificar si es necesario.

    ' MÉTODOS Y ATRIBUTOS PUBLICOS Y PRIVADOS
    ' En POO podemos definitr si los atributo o metodos son "PUBLIC" o "PRIVATE", con esto podemos determinar cuales de ellos pueden ser
    ' utlizados por cualquer persona (public) o si por el contrario debe tener un tipo de acceso.


    Sub instanciarAuto()
        Dim carroInstancia1 = New clsAuto() ' Instancia

        carroInstancia1.color = "Verde"
        'carroInstancia1.modelo = 2016
        carroInstancia1.marca = "Toyota
"
        'carroInstancia1.acelerarAuto()
        carroInstancia1.meterLlave("1234")
        carroInstancia1.mando("Acelerar")
        carroInstancia1.frenarAuto()

        'Console.WriteLine("El carro instancia 1, tiene un color " & carroInstancia1.color & " y es modelo " & carroInstancia1.modelo)


        Dim carroInstancia2 = New clsAuto() ' Instancia
        carroInstancia2.color = "Gris"
        'carroInstancia2.modelo = 2023

        'Console.WriteLine("El carro instancia 2, tiene un color " & carroInstancia2.color & " y es modelo " & carroInstancia2.modelo)
    End Sub

    Sub intanciarClsCalculadora()

        Dim calculadoraPrincipal = New clsCalculadora()
        Dim res = 0
        Dim resDouble = 0.0
        Dim num1 = 1
        Dim num2 = 2

        Console.WriteLine("Bienvenido a tu calculadora de confianza")
        Console.WriteLine("Los número a evaluar hoy son: num1 = " & num1 & " - num2 = " & num2)

        res = calculadoraPrincipal.suma(num1, num2)
        Console.WriteLine("La suma de los números es " & res)

        res = calculadoraPrincipal.resta(num1, num2)
        Console.WriteLine("La resta de los números es " & res)

        res = calculadoraPrincipal.multiplicar(num1, num2)
        Console.WriteLine("La multiplicación de los números es " & res)

        resDouble = calculadoraPrincipal.dividir(num1, num2)
        Console.WriteLine("La divición de los números es " & resDouble)

    End Sub

    Sub instanciarClsPersona()
        Dim persona1 = New clsPersona("Emmanuel", 29) ' El constructor obliga a ingresar la información de las propiedades de la clase cuando se intancia

        'persona1.inicializar("Emmanuel", 29)
        persona1.mostrarInfoPersona()
    End Sub

    Sub instanciarClcVehiculo()
        Dim vehiculo1 = New clsVehiculo("Nissan", "2019")
        vehiculo1.acelera()
        vehiculo1.acelera(23)

        Dim vehiculo2 = New clsVehiculo("sku5362")
        vehiculo2.acelera()
    End Sub

    Sub instanciarMatematicas()
        Dim mat = New Trigonometria.clsMatematicas(5, 7)
        Console.WriteLine("El resultado es = " & mat.suma())

        Dim personjeX = New Trigonometria.clsPersonajes()
        personjeX.decirPersonaje()

    End Sub


    Sub intanciarClsEmpleado()
        Dim empleado1 = New Encapsulamiento.clsEmpleado()

        empleado1.setNombre("Itachi Uchija")
        Dim nombreEmpleado = empleado1.getNombre()

        empleado1.setEdad(29)
        Dim edadEmpleado As String = empleado1.getEdad()

        Console.WriteLine("El empleado del mes se llama " & nombreEmpleado & " y tiene una edad de " & edadEmpleado)
    End Sub

    Sub instanciarAtributosEstaticos()
        clsMiClase.saludo()

        Dim obj1 = New clsMiClase()
        Dim obj2 = New clsMiClase()

        Console.WriteLine("Atributo normal obj1 = " & obj1.normal)
        Console.WriteLine("Atributo normal obj2 = " & obj2.normal)

        obj1.normal = "Cambio desde módulo principal"
        obj2.normal = "Cambio desde módulo principal"

        Console.WriteLine("Atributo normal modificado obj1 = " & obj1.normal)
        Console.WriteLine("Atributo normal modificado obj2 = " & obj2.normal)

        Console.WriteLine("Estáticos")
        Console.WriteLine("Atributo Estático obj1 = " & obj1.estatico)
        Console.WriteLine("Atributo Estático obj2 = " & obj2.estatico)

        obj2.estatico = "Cambio desde módulo principal al Estático obj2" ' Con modificar aqui, todas las intancias tambien recibiran el cambio

        Console.WriteLine("Atributo Estático modificado obj1 = " & obj1.estatico)
        Console.WriteLine("Atributo Estático modificado obj2 = " & obj2.estatico)
    End Sub

    Sub instanciarHerenciaPOO()

        Dim persona1 = New clsPersonas("Emmanuel", "Jaramillo", 29)

        Console.WriteLine("El nombre de la instancia persona1 es:" & persona1.getFirtsName & " " & persona1.getLastName & ". Tiene la edad de " & persona1.getAge)

        Dim estudiante1 = New Estudiantes("Juan", "Perez", 30, "123", 4.2)

        Console.WriteLine("El nombre de la instancia estudiante1 es:" & estudiante1.getFirtsName & " " & estudiante1.getLastName & ". Tiene la edad de " & estudiante1.getAge & vbCrLf & "El código del estudiante es: " & estudiante1.getCodigoEstudiante & ". Su calificación fue de: " & estudiante1.getCalificacion)
    End Sub

    Public Sub instanciarSobreEscrituraMetodo()
        ' La sobre escritura de metodo (override) se refiere a la posibilidad de que una clase hija (sub clase) tenga el mismo nombre de un metodo que ya tenga la clase Padre pero
        ' Tiene un comportarmiento diferente.

        ' Para poder sobre escribir un metodo de una clase padre en una clase hija primero debemos indicar que este se puede sobreescribir.
        ' Para lograr esto debemos poner Overridable en el metodo de la clase principal, y  Overrides en el metodo de la clase hija - Ejm: Clase Padre - Public Overridable Sub nombreMetodo() | Clase Hija -> Public Overrides Sub nombreMetodo()

        Console.WriteLine("SobreEscritura de Metodos - Override")

        Dim animal = New Animal
        animal.comer()
        animal.correr()

        Dim humano = New Humano
        humano.correr()
        humano.comer()

        Dim pajaro = New Pajaro
        pajaro.comer()
        pajaro.volar()

        Dim perro = New Perro
        perro.comer()
        perro.correr()
    End Sub
End Module

