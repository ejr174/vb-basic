Public Class clsMiClase
    'ATRIBUTOS ESTÁTICOS

    'En POO se utilizan los atributos estáticos para vincular un atributo a una clase.

    'Es como colocar una variable por defecto que estará en la clase, entonces cada vez que se haga una instancia de la clase, esta instancia ya estará tomando el atributo.

    'En resumen son variables y métodos que pertenecen a la clase en sí, no a instancias individuales.
    'Esto significa que solo hay una copia compartida por todas las instancias de la clase y se pueden usar sin crear un objeto. 

    'Para declararlos, se usa la palabra clave Shared (que es sinónimo de Static en VB.NET). 

    'Importante: Si una instancia cambia el valor de un atributo, se cambiara tambien para todas las intancias.

    Public normal As String = "Este es una atributo NORMAL"
    Public Shared estatico As String = "Este es un atributo estático"

    Public Shared Sub saludo()
        Console.WriteLine("Un saludo desde la clase MiClase, este saludo es desde un metodo estático")
    End Sub

End Class
