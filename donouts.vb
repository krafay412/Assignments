Module Module1

    Sub Main()
        Dim donots As Integer


        donots = 0

        Console.Write("Enter Number of Donouts: ")
        donots = Console.ReadLine
        If donots < 10 Then
            Console.Write("The Number of donouts ordered are: " & donots)
        ElseIf donots >= 10 Then
            Console.Write("The number of donouts: Many")

        End If
        Console.ReadKey()

    End Sub

End Module
