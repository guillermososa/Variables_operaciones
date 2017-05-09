Module TP06_Sumatoria_y_Media
    Sub Main()
        'Declaracion de variables
        Dim ent1 As Short
        Dim ent2 As Short
        Dim ent3 As Short
        Dim ent4 As Short
        'Ingreso de valores
        Console.WriteLine("Ingrese 4 valores enteros:")
        Console.WriteLine()
        Console.Write("Primero: ")
        ent1 = Console.ReadLine()
        Console.Write("Segundo: ")
        ent2 = Console.ReadLine()
        Console.Write("Tercero: ")
        ent3 = Console.ReadLine()
        Console.Write("Cuarto: ")
        ent4 = Console.ReadLine()
        'Calcular y mostrar informacion
        Console.WriteLine()
        Console.WriteLine("La sumatoria es: " & ent1 + ent2 + ent3 + ent4)
        Console.WriteLine("La media es: " & (ent1 + ent2 + ent3 + ent4) / 4)
        Console.ReadKey()
    End Sub
End Module