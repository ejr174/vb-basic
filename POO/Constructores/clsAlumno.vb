Public Class clsAlumno
    Inherits clsPersonas

#Region "Propiedades y Atributos"
    Private _nota As Double
    Public Property Nota() As Double
        Get
            Return _nota
        End Get
        Set(ByVal value As Double)
            _nota = value
        End Set
    End Property

#End Region

#Region "Constructor"

    Public Sub New(ByVal nombre As String, ByVal edad As Integer, ByVal nota As Double)
        Me.Nombre = nombre
        Me.Edad = edad
        _nota = nota
    End Sub

#End Region

#Region "Metodos"
    Public Overloads Sub Hablar()
        MyBase.Hablar() ' LLama el metodo Hablar() de la clase principal (clsPersona). MyBase referencia a la clase principal.
        Console.WriteLine("Necesito descansar de la universidad, estoy muy estresado!")
    End Sub

#End Region



End Class
