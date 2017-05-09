Module TP15_Ingreso_Date
    Sub Main()
        'Declaracion de variables
        Dim dia As UShort
        Dim hora As UShort
        Dim variable As Date
        'Ingreso de datos
        Console.Write("Ingrese dia (1-30): ")
        dia = Console.ReadLine()
        Console.Write("Ingrese hora (0-23): ")
        hora = Console.ReadLine()
        Console.WriteLine()
        'Crear variable tipo date
        variable = New Date(Now.Year, Now.Month, dia, hora, 0, 0)
        'Mostrar informacion
        Console.WriteLine("El valor de la variable es: " & variable)
        Console.ReadKey()
    End Sub
End Module