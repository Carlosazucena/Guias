Imports System

Module Program
    Sub main()
        Console.Write("ingrese numero")
        Dim num As Integer = Convert.ToInt32(Console.ReadLine())

        For i As Integer = 1 To 10
            Console.WriteLine(num & "x" & i & (num * i))
        Next
    End Sub
End Module
