Module TP07_Semanas
    Sub Main()
        'Declaracion de variables
        Const dias_anio As Short = 365
        Const dias_sem As Short = 7
        Const dias_lab As Short = 5
        'Calculo y mostrar informacion
        Console.WriteLine("El año tiene {0} semanas", CInt(dias_anio / dias_sem))
        Console.WriteLine("De las cuales, {0} semanas son laborables", CInt(dias_anio / dias_sem * dias_lab / dias_sem))
        Console.ReadKey()
    End Sub
End Module