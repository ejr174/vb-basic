Public Class clsPersonas

#Region "Propiedades"
    Private _nombre As String ' Campo de clase

    Public Property Nombre() As String ' Propiedad
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Private _edad As Integer
    Public Property Edad() As Integer
        Get
            Return _edad
        End Get
        Set(ByVal value As Integer)
            _edad = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New()
        _nombre = "Nombre de la persona no ingresado"
        _edad = 0
    End Sub

    'Sobre carga de constructores
    Public Sub New(ByVal nombre As String, ByVal edad As Integer)
        _nombre = nombre
        _edad = edad
    End Sub

#End Region

#Region "Métodos"

    Public Sub Hablar()

    End Sub

    Public Sub Comer()

    End Sub
#End Region

End Class
