Public Class clsPersona
    ' POO: METODO CONSTRUCTOR
    ' En POO, un constructor es un Sub rutina cuyo objetivo es INICIALIZAR un objeto de una clase.
    ' Osea, en el constructor es el lugar donde se asignan los valores iniciales del nuevo objeto

    ' Con el constructor hacemos que sea obligatoria inicializar con valores las propiedades de nuestra clase y asi garantizar que funciones

    Dim nombre As String
    Dim edad As Integer

    ' Metodo Constructor
    Sub New(_nombre As String, _edad As Integer)
        If _nombre <> "" Then
            nombre = _nombre
        End If

        If _edad > 0 Then
            edad = _edad
        End If
    End Sub

    'Sub inicializar(_nombre As String, _edad As Integer) ' El guion bajo es para indicar que es un parametro
    '    If _nombre <> "" Then
    '        nombre = _nombre
    '    End If

    '    If _edad > 0 Then
    '        edad = _edad
    '    End If
    'End Sub

    Sub mostrarInfoPersona()
        Console.WriteLine("El nombre de la persona es = " & nombre & " y su edad es = " & edad)
    End Sub

End Class
