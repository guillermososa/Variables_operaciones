Module TP17_Dias_de_semanavb
    Enum DiaSemana As UShort
        Domingo
        Lunes
        Martes
        Miercoles
        Jueves
        Viernes
        Sabado
    End Enum
    Sub Main()
        'Declaracion de variables
        Dim fecha As Date
        Dim dias As UShort
        Dim semana As DiaSemana
        'Ingreso de datos
        Console.Write("Ingrese fecha: ")
        fecha = Console.ReadLine()
        Console.Write("Ingrese dias: ")
        dias = Console.ReadLine()
        'Asignacion
        fecha = fecha.AddDays(dias)
        semana = fecha.DayOfWeek()
        'Mostrar informacion
        Console.WriteLine()
        Console.WriteLine("Fecha obtenida: " & fecha)
        Console.WriteLine("Dia de la Semana: " & semana.ToString)
        Console.ReadKey()
    End Sub
End Module