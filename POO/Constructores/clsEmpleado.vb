Public Class clsEmpleado
    Inherits clsPersonas

#Region "Propiedades y Atributos"
    Private _salario As Double
    Public Property Salario() As Double
        Get
            Return _salario
        End Get
        Set(ByVal value As Double)
            _salario = value
        End Set
    End Property
#End Region

#Region "Constructor"

    Public Sub New(ByVal nombre As String, ByVal edad As Integer, ByVal salario As Double)
        Me.Nombre = nombre
        Me.Edad = edad
        _salario = salario
    End Sub

#End Region


#Region "Metods"
    Public Overloads Sub Hablar()
        Console.WriteLine("Necesito descansar del trabajo, estoy muy estresado!")
    End Sub

#End Region


End Class
