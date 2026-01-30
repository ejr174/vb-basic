Public Class clsCalculadoraArea

#Region "Atributos"
    Dim pi As Double = 3.1216
    Dim m1 As Double
    Dim m2 As Double
#End Region

#Region "Metodos"

    Function areaTriangulo(ByVal base As Double, ByVal altura As Double) As Double

        Return (base * altura) / 2

    End Function

    Function areaCudrado(ByVal lado As Double) As Double

        Return lado + lado

    End Function

    Function areaRectangulo(ByVal base As Double, ByVal altura As Double) As Double

        Return base * altura

    End Function

    Function areaCircunferencia(ByVal radio As Double) As Double

        Return pi * (radio + radio)

    End Function

#End Region

End Class
