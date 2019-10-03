Module Module1

    Sub Main()
        Dim STR1, STR2, Char1, Char2, NextChar As String
        Dim Count As Integer

        STR1 = ""
        STR2 = ""
        Char1 = ""
        Char2 = ""
        NextChar = ""
        Count = 0

        Console.Write("Please Enter Your String: ")
        STR1 = Console.ReadLine
        Console.Write("Please Enter The Character You Want To Remove: ")
        Char1 = Console.ReadLine
        Console.Write("Please Enter The Character You Want To Replace With: ")
        Char2 = Console.ReadLine

        For Count = 1 To Len(STR1)
            NextChar = Mid(STR1, Count, 1)
            If NextChar = Char1 Then
                NextChar = Char2
            End If
            STR2 = STR2 & NextChar
        Next
        Console.Write("Your String Output is: " & STR2)

        Console.ReadKey()

    End Sub
End Module
