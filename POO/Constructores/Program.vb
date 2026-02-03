Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("CONSTRUCTORES")
        Console.WriteLine("==============")

        Dim persona1 As New clsPersonas()
        'Console.WriteLine("Nombre: " & persona1.Nombre)
        'Console.WriteLine("Edad: " & persona1.Edad)

        'Console.WriteLine("==============")

        'Dim persona2 As New clsPersonas("Emmanuel", 29)
        'Console.WriteLine("Nombre: " & persona2.Nombre)
        'Console.WriteLine("Edad: " & persona2.Edad)

        Console.WriteLine("HERENCIA")
        Console.WriteLine("==============")

        Dim estudiante1 As New clsAlumno("Matias", 12, 4.5)
        Dim empleado1 As New clsEmpleado("Carlos", 35, 5000000)

        persona1.Hablar()
        Console.WriteLine("El empleado se llama: " & empleado1.Nombre)
        estudiante1.Hablar()
        Console.WriteLine("El estudiante {0} tiene una nota de: {0}", estudiante1.Nombre, estudiante1.Nota)


    End Sub
End Module
