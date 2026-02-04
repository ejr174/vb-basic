Public Module modCalculadoraArea


#Region "Atributos & Propiedades"
    ' CAMPOS
    Private pi As Double = 3.1216

    Private _m1 As Double
    Public m2 As Double

    ' PROPIEDADES
    Public Property m1() As Double
        ' Bloquse de codigo para obtener (Get) y asignar(Set) valores
        Get
            Return _m1
        End Get
        Set(value As Double)
            If value < 0 Then
                Console.WriteLine("El area no es valida")
            Else
                _m1 = value
            End If
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Function areaTriangulo(ByVal base As Double, ByVal altura As Double) As Double

        Return (base * altura) / 2

    End Function

    Public Function areaCudrado(ByVal lado As Double) As Double

        Return lado + lado

    End Function

    Public Function areaRectangulo(ByVal base As Double, ByVal altura As Double) As Double

        Return base * altura

    End Function

    Public Function areaCircunferencia(ByVal radio As Double) As Double

        Return pi * (radio + radio)

    End Function

#End Region


End Module
