Module Module1

    Sub Main()
        Dim PlayerName As String
        Dim MemberID As String
        Dim More As String

        PlayerName = ""
        MemberID = ""


        FileOpen(1, "D:Membership Data.txt", OpenMode.Input)
        Do
            Console.Write("Enter player name: ") : PlayerName = Console.ReadLine
            Console.Write("Enter member ID: ") : MemberID = Console.ReadLine

            Input(1, PlayerName)
            Input(1, MemberID)

            Console.WriteLine(" Do you want to add another record? (Y/N) ")
            More = Console.ReadLine

        Loop Until UCase(More) = "N"
        FileClose(1)


        Console.ReadKey()
    End Sub

End Module
