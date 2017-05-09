Module TP05_Ecuacion
    Sub Main()
        'Declaracion de variables y asignacion
        Dim a As Short = 1
        Dim b As Short = 5
        Dim c As Short = 2
        Dim x As Single
        'Calculo
        x = (b ^ 2 - 4 * a * c) / 2 * a
        'Mostrar informcion
        Console.WriteLine("El resultado es: " & x)
        Console.ReadKey()
    End Sub
End Module