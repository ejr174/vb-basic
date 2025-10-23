Public Class clsAuto

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


    'Atributos (caracteristicas)
    Public color = ""
    Private modelo = 0
    Public marca = ""
    Private acceso = False

    ' Metodos (funcionalidades)
    Public Sub meterLlave(llave As String)
        If llave = "1234" Then
            acceso = True
            Console.WriteLine("Llave correcta")
        Else
            acceso = False
            Console.WriteLine("Llave incorrecta")
        End If
    End Sub

    Public Sub mando(accion As String)
        If acceso = True Then
            If accion = "Acelerar" Then
                acelerarAuto()
            End If
        Else
            Console.WriteLine("No se puede hacer la accion: " & accion)
        End If
    End Sub

    Public Sub encenderAuto()
        Console.WriteLine("Auto encendido sin problema.")
    End Sub

    Private Sub acelerarAuto()
        Console.WriteLine("El auto acelera sin problema")
    End Sub

    Public Sub frenarAuto()
        Console.WriteLine("El auto frena sin problema")
    End Sub
End Class
