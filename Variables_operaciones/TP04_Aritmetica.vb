Module TP04_Aritmetica
    Sub Main()
        'Declaración de variables y asignacion
        Dim ent1 As Short = 3
        Dim ent2 As Short = 5
        Dim flo1 As Single = 1.5
        Dim flo2 As Single = 2.5
        'Mostrar informacion
        Console.WriteLine("Operaciones Aritmeticas")
        Console.WriteLine()
        Console.WriteLine("Suma:")
        Console.WriteLine("{0} + {1} = " & ent1 + ent2, ent1, ent2)
        Console.WriteLine("{0} + {1} = " & ent1 + flo2, ent1, flo2)
        Console.WriteLine("{0} + {1} = " & flo1 + flo2, flo1, flo2)
        Console.WriteLine()
        Console.WriteLine("Resta:")
        Console.WriteLine("{0} - {1} = " & ent1 - ent2, ent1, ent2)
        Console.WriteLine("{0} - {1} = " & ent1 - flo2, ent1, flo2)
        Console.WriteLine("{0} - {1} = " & flo1 - flo2, flo1, flo2)
        Console.WriteLine()
        Console.WriteLine("Multiplicacion:")
        Console.WriteLine("{0} * {1} = " & ent1 * ent2, ent1, ent2)
        Console.WriteLine("{0} * {1} = " & ent1 * flo2, ent1, flo2)
        Console.WriteLine("{0} * {1} = " & flo1 * flo2, flo1, flo2)
        Console.WriteLine()
        Console.WriteLine("Division:")
        Console.WriteLine("{0} / {1} = " & ent1 / ent2, ent1, ent2)
        Console.WriteLine("{0} / {1} = " & ent1 / flo2, ent1, flo2)
        Console.WriteLine("{0} / {1} = " & flo1 / flo2, flo1, flo2)
        Console.ReadKey()
    End Sub
End Module