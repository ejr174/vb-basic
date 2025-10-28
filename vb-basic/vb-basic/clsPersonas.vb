Public Class clsPersonas
    ' ATRIBUTOS 
    Private nombre As String
    Private apellido As String
    Private edad As String

    'CONSTRUCTOR
    Public Sub New(_nombre As String, _apellido As String, _edad As Integer)
        nombre = _nombre
        apellido = _apellido
        edad = _edad
    End Sub

    'METODOS
    Public Function getFirtsName()
        Return nombre
    End Function

    Public Function getLastName()
        Return apellido
    End Function

    Public Function getAge()
        Return edad
    End Function
End Class
