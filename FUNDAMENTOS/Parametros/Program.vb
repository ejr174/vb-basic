Imports System

Module Program
    Sub Main(args As String())
        ' PASO POR PARAMETROS (ByVal vs ByRef)
        ' ByVal (Valor predeterminado): envia como parametro una copia del valor original, protegiendo el valor de cambios dentro del procedimiento o funcion.
        ' ByRef: envia una referencia directa de memoria, permitiendo que el procedimiento o funcion MODIFIQUE la variable original.
        ' Optional: Permite que el parametro que anteponga esta palabra reservada puede ser omitido. Pero debe tener un valor por defecto declarado.
        ' ParamArray: Se utiliza cuando no sabemos la cantidad de parametros que necesitamos ingresas. No puede ir nunca por referencia debe ir con valor (ByVal).


        'Console.Write("Ingresa un número: ")
        'Dim num As Integer = Convert.ToInt32(Console.ReadLine())

        'Dim result As Integer = doble(num)
        'Console.WriteLine("El doble de " & num & " es " & result)

        'Dim resultSuma As Integer = suma(2, 2)
        'Console.WriteLine("El resultado de la suma es = {0}", resultSuma)

        Dim resultPromedio As Integer = promedio(5, 10)
        Console.WriteLine("El promedio es = {0}", resultPromedio)

        Console.ReadKey()
    End Sub

    Function doble(ByRef num As Integer) As Integer
        num *= 2 ' En este caso como estamos usando ByRef, el valor original de 'num' en Main se verá afectado.
        Return num
    End Function

    Function suma(ByVal num1 As Integer, ByVal num2 As Integer, Optional ByVal num3 As Integer = 10) As Integer
        Dim sumaTotal As Integer = num1 + num2 + num3

        Return sumaTotal
    End Function

    Function promedio(ParamArray ByVal nums() As Integer) As Integer

        Dim resultado As Integer = 0

        For i As Integer = 0 To nums.Length - 1
            resultado += nums(i)
        Next

        Return resultado \ nums.Length

    End Function

End Module
