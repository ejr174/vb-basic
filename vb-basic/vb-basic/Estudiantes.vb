Public Class Estudiantes
    Inherits clsPersonas 'Indicamos que la clase Estudiantes Hereda de la clsPersona

    Private codigoEstudiante As String
    Private calificacion As Double

    Public Sub New(_nombre As String, _apellido As String, _edad As Integer, _codigoEstudiando As String, _calificacion As Double)

        ' Llama al constructor de la clase base (clsPersonas) para inicializar los miembros heredados antes de que se ejecute el codigo del constructor de la clase hija
        'Herencia: Se usa en el contexto de la herencia para que una clase hija pueda asegurarse de que la clase padre está correctamente construida antes de que la clase hija complete su propia inicialización.
        MyBase.New(_nombre, _apellido, _edad)

        codigoEstudiante = _codigoEstudiando
        calificacion = _calificacion
    End Sub

    Public Function getCodigoEstudiante()
        Return codigoEstudiante
    End Function

    Public Function getCalificacion()
        Return calificacion
    End Function
End Class
