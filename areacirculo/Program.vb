Imports System

Module Program
    Sub Main()
        Console.Write("digite radio del círculo: ")
        Dim radio As Double = Convert.ToDouble(Console.ReadLine())

        Dim area As Double = Math.PI * Math.Pow(radio, 2)
        Console.WriteLine("El área es: " & area.ToString("F2"))
    End Sub

End Module
