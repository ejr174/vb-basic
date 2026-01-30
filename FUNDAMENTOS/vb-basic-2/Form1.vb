Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Variables: Es un espacio en memoria reservado para guardar un valor que puede variar en la ejecución del código.
        ' Constante: Es un espacio en memoria reservado para guardar un valor que no cambia en la ejecución del código.

        ' Declarar variables y constantes
        Dim edad As Integer
        Dim nombre As String

        ' Asignar valor
        edad = 27
        nombre = "Emmanuel"

        ' Declarar y asigna
        Dim fechaHoy As Date = "12/11/2025"
        Dim adulto As Boolean = True

        'Mostrar mensaje
        MsgBox("Este es el nombre asignado: " & nombre & " y su edad es: " & edad & ". La feha de hoy es: " & fechaHoy & " y el adultro es: " & adulto)

    End Sub
End Class
