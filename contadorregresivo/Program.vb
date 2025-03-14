Imports System

Module contador
    Sub Main()
        Console.WriteLine("ingresa numero")
        Dim num As Integer = Convert.ToInt32(Console.ReadLine())

        For i As Integer = num To 0 Step 1
            Console.WriteLine(i)
        Next
    End Sub
End Module
