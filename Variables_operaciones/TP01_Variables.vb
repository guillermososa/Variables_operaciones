Module TP01_Variables
    'Tipo de Variables: Boolean, Char, String, Date
    'Numeros: Byte, Short, Integer, Long
    'PtoFlotante: Single, Double, Decimal
    Sub main()
        'Declaracion de variables y asignacion
        Dim nombre As String = "Guillermo Sosa"
        Dim tipodni As String = "DNI"
        Dim dni As Integer = 33721489
        Dim Localidad As String = "Posadas"
        Dim fecha_nac As Date = #8-5-1988#
        Dim edad As Byte = 28
        Dim altura As Single = 1.75
        Dim est_civ As String = "Casado"
        Dim argentino As String = "Si"
        'Mostrar informacion
        Console.WriteLine("Datos Personales")
        Console.WriteLine("Nombre: " & nombre)
        Console.WriteLine("Tipo: " & tipodni)
        Console.WriteLine("Numero: " & dni)
        Console.WriteLine("Localidad: " & Localidad)
        Console.WriteLine("Fecha de Nac.: " & fecha_nac)
        Console.WriteLine("Edad: " & edad)
        Console.WriteLine("Altura: " & altura)
        Console.WriteLine("Estado Civil: " & est_civ)
        Console.WriteLine("Argentino: " & argentino)
        Console.ReadKey()
    End Sub
End Module