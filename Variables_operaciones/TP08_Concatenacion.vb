Module TP08_Concatenacion
    Sub Main()
        'Declaracion de variables
        Dim empresa As String = "Ilolai"
        Dim calle As String = "Francisco de Haro"
        Dim altura As UShort = 5200
        Dim fecha_inicio_act As Date = #8-5-1988#
        'Convertir y mostrar informacion
        Console.WriteLine("Empresa {0} calle {1} altura {2} fehca de inicio de actividad {3}" _
                          , empresa, calle, CStr(altura), CStr(fecha_inicio_act))
        Console.WriteLine("Empresa {0} calle {1} altura {2} fehca de inicio de actividad {3}" _
                          , empresa, calle, altura, fecha_inicio_act)
        Console.ReadKey()
    End Sub
End Module