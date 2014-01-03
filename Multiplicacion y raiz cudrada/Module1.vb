Module Module1

    Sub Main()
        'Creamos  5 variables de tipo double
        Dim a, b, c, d, e As Double
        'Cramos un mensaje
        Console.WriteLine("Introduzca Una Variable ")
        a = Double.Parse(Console.ReadLine())
        Console.WriteLine("Introduzca La Segunda Variable")
        b = Double.Parse(Console.ReadLine())
        c = a * b
        Console.WriteLine("El Producto de las variables es: " & c)
        d = c * c * c
        Console.WriteLine("El Cubo del producto es: " & d)
        'Saca la raiz cuadrada
        e = Math.Sqrt(d)
        Console.WriteLine("La Raiz Cuadrada Del Cubo es: " & e)
        Console.ReadLine()

    End Sub

End Module
