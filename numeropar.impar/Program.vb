Imports System

Module numeroparimpar

    Sub main()
        Console.Write("digite numero")
        Dim num As Integer = Convert.ToUInt32(Console.ReadLine())

        If num Mod 2 = 0 Then
            Console.WriteLine("numero par")
        Else
            Console.WriteLine("numero impar")
        End If
    End Sub

End Module
