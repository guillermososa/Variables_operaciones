﻿Module TP16_Fecha
    Sub Main()
        'Declaracion de variables
        Dim fecha As Date
        Dim dias As UShort
        'Ingreso de datos
        Console.Write("Ingrese fecha: ")
        fecha = Console.ReadLine()
        Console.Write("Ingrese dias: ")
        dias = Console.ReadLine()
        'Mostrar informacion
        Console.WriteLine("Fecha obtenida: " & fecha.AddDays(dias))
        Console.ReadKey()
    End Sub
End Module