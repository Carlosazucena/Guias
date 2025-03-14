Imports System

Module suma2numeros
    Sub main()
        Console.Write("ingrese numero")
        Dim num1 As Integer = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("ingrese numero")
        Dim num2 As Integer = Convert.ToInt32(Console.ReadLine())

        Dim suma As Integer = num1 + num2
        Console.WriteLine("la suma es: " & suma)
    End Sub
End Module