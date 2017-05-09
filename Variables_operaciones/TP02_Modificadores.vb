Module TP02_Modificadores
    'Modificadores: Public=Solución Frien=Proyecto Private=Modulo Dim=Local
    'Declaracion de variables
    Public nombre As String = "Guillermo Sosa"
    Friend tipodni As String = "DNI"
    Friend dni As Integer = 33721489
    Friend fecha_nac As Date = #08-05-1988#
    Private Localidad As String = "Posadas"
    Private altura As Single = 1.75
    Private est_civ As String = "Casado"
    Private argentino As String = "Si"
    Sub Main()
        Dim edad As Byte = 28
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