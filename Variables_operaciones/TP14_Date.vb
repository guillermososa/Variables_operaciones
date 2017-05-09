Module TP14_Date
    Sub Main()
        'Declaracion de variables y asignacion
        Dim fecha As Date
        fecha = Now
        'Mostrar dias del año, mes, hora y minuto
        Console.WriteLine("Dias del año: " & fecha.DayOfYear())
        Console.WriteLine("Mes: " & fecha.Month())
        Console.WriteLine("Hora: " & fecha.Hour())
        Console.WriteLine("Minuto: " & fecha.Minute())
        Console.ReadKey()
    End Sub
End Module