Module Module1

    Sub Main()

        Dim numero As Integer
        Dim esPrimo As Boolean

        ' Solicitar al usuario que ingrese un número
        Console.Write("Ingrese un número: ")
        numero = (Console.ReadLine())

        ' Verificar si el número es primo o compuesto
        esPrimo = NumeroPrimo(numero)

        ' Mostrar el resultado
        If esPrimo Then
            Console.WriteLine("El número " & numero & " es primo.")
        Else
            Console.WriteLine("El número " & numero & " es compuesto.")
        End If

        Console.ReadLine() ' Pausa para ver el resultado final
    End Sub

    ' Función para determinar si un número es primo
    Function NumeroPrimo(ByVal num As Integer) As Boolean
        If num <= 1 Then
            Return False
        End If

        For i As Integer = 2 To Math.Sqrt(num)
            If num Mod i = 0 Then
                Return False
            End If
        Next

        Return True
    End Function


End Module
