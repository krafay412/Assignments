Module Module1

    Sub Main()
        Dim Str1 As String
        Dim alpha As String
        Dim ispangram As Boolean
        Dim thischar, char1 As Char
        Dim i As Integer
        Dim thischarpos As Integer



        Str1 = ""
        alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        ispangram = True
        thischar = ""
        i = 0
        char1 = ""
        thischarpos = 0


        Console.Write("Enter Sentence: ")
        Str1 = Console.ReadLine
        Str1 = UCase(Str1)

        For i = 1 To Len(alpha)
            thischar = Mid(alpha, i, 1)
            thischarpos = InStr(Str1, thischar)

            If thischarpos = 0 Then
                ispangram = False
                Exit For

            End If





        Next

        If ispangram = True Then
            Console.Write("The Entered Sentence contain all alphabets")
        Else
            Console.Write("Entered sentence does not contain all alphabets")
        End If
        Console.ReadKey()


    End Sub

End Module
