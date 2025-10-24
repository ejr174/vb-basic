Namespace Encapsulamiento

    ' En POO el principio de encapsulamiento indica que todos los atributos de la clase deben ser privado para evitar que sean accesibles fuera de la clase.
    ' Solo la clase tendría el poder de escribir y leer las propiedas que tiene.

    ' Lo que debe de hacerse es crear métodos publicos que sustituyan una u otra operacion.
    ' Estos metodos se denominan setter's y getter's
    Public Class clsEmpleado
        Private edad As Integer
        Private nombre As String

        Public Sub setEdad(_edad As Integer)
            If _edad < 0 Then
                Console.WriteLine("Lo sentimos la edad no puede ser menos a 0,  es como bien gvon, Cachon!")
            Else
                edad = _edad
            End If
        End Sub

        Public Function getEdad()
            Return edad
        End Function

        Public Sub setNombre(_nombre As String)
            If _nombre = "" Then
                Console.WriteLine("El nombre no puede estar vacio")
            Else
                nombre = _nombre
            End If
        End Sub

        Public Function getNombre()
            Return nombre.ToUpper()
        End Function
    End Class
End Namespace

