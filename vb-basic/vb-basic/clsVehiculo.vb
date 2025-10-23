
' POO: SOBRECARGA DE METODOS

'En programación orientada a objetos la sobrecarga se refiere a la posibilidad de tener dos o más funciones con el mismo nombre
'pero funcionalidad diferente. Es decir, dos o más funciones con el mismo nombre realizan acciones diferentes.

Public Class clsVehiculo
    Private marca As String
    Private modelo As String
    Private sku As String

    'SOBRECARGA DE CONSTRUCTORES
    Public Sub New(_marca As String, _modelo As String)
        marca = _marca
        modelo = _modelo
    End Sub

    Public Sub New(_sku As String)
        sku = _sku
    End Sub

    'SOBRECARGA DE METODOS
    Public Sub acelera()
        If marca IsNot Nothing Then
            Console.WriteLine("El vehiculo con la marca " & marca & " y modelo" & modelo & " esta acelerando")
        Else
            Console.WriteLine("El vehiculo  " & sku & " esta acelerando")
        End If

    End Sub

    Public Sub acelera(kmh As Integer)
        Console.WriteLine("El vehiculo con la marca " & marca & " y modelo" & modelo & " esta acelerando a " & kmh & "kmh")
    End Sub


End Class
