Module TP10_Interes_Producido
    Sub Main()
        'Declaracion de variables
        Dim m_monto As Single
        Dim r_interes As Single
        Dim t_dias As UShort
        Dim i_interes_prod As Single
        'Ingrear datos
        Console.WriteLine("Ingrese Datos")
        Console.WriteLine()
        Console.Write("Monto: ")
        m_monto = Console.ReadLine()
        Console.Write("Interes: ")
        r_interes = Console.ReadLine()
        Console.Write("Dias: ")
        t_dias = Console.ReadLine()
        'Calculo
        i_interes_prod = (m_monto * r_interes * t_dias) / (360 * 100)
        'Mostrar informacion
        Console.WriteLine()
        Console.WriteLine("El interes producido es: " & i_interes_prod)
        Console.WriteLine("El capital acumulado es: " & i_interes_prod + m_monto)
        Console.ReadKey()
    End Sub
End Module