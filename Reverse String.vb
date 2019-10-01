Module Module1

    Sub Main()
        Dim InString, NextChar, OutString As String
        Dim Counter As Integer

        InString = " "
        OutString = " "
        NextChar = " "
        Counter = 0

        Console.Write("Please enter the string to be reversed: ")
        InString = Console.ReadLine

        For Counter = Len(InString) To 1 Step -1
            NextChar = Mid(InString, Counter, 1)
            OutString = OutString & NextChar
        Next
        Console.WriteLine(OutString)
        Console.ReadKey()
    End Sub

End Module
