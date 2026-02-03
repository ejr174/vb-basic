Public Class clsEmpleado

#Region "Atributos y Propiedades"
    Private _nombre As String ' Atributo
    Public Property Nombre() As String 'Propiedad
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
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

    Private _sueldo As Double
    Public Property Sueldo() As Double
        Get
            Return _sueldo
        End Get
        Set(ByVal value As Double)
            _sueldo = value
        End Set
    End Property

    Private Shared _recuento As Integer ' Atributo de la CLASE no del objeto
    Public Shared Property Recuento() As Integer ' Propiedad de la CLASE no del objeto
        Get
            Return _recuento
        End Get
        Set(ByVal value As Integer)
            _recuento = value
        End Set
    End Property
#End Region

#Region "Constructor"

    Public Sub New(ByVal nombre As String, ByVal edad As Integer)
        _nombre = nombre
        _edad = edad
        _sueldo = 2500
        _recuento += 1
    End Sub

#End Region

#Region "Metodos"

#End Region



End Class
