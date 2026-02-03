Imports System

Module Program
    Sub Main(args As String())

        Dim trabajador1 As New clsEmpleado("Felipe", 32)
        Dim trabajador2 As New clsEmpleado("Salome", 24)

        Console.WriteLine("Información trabajador1. Nombre = {0} | Edad = {1} | Recuento = {2}", trabajador1.Nombre, trabajador1.Edad, clsEmpleado.Recuento)
        Console.WriteLine("Información trabajador2. Nombre = {0} | Edad = {1} | Recuento = {2}", trabajador2.Nombre, trabajador2.Edad, clsEmpleado.Recuento)

        Console.WriteLine("---------------------------------------------------------------------------")
        clsEmpleado.Recuento = 10
        Console.WriteLine("---------------------------------------------------------------------------")

        Console.WriteLine("Información trabajador1. Nombre = {0} | Edad = {1} | Recuento = {2}", trabajador1.Nombre, trabajador1.Edad, clsEmpleado.Recuento)
        Console.WriteLine("Información trabajador2. Nombre = {0} | Edad = {1} | Recuento = {2}", trabajador2.Nombre, trabajador2.Edad, clsEmpleado.Recuento)

    End Sub
End Module
