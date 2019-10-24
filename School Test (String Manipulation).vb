Module Module1

    Sub Main()
        Dim InpBinary, NextChar As String
        Dim Count, value, total, power As Integer
        Dim validBinaryString As Boolean

        InpBinary = ""

        Count = 0
        validBinaryString = True


        Console.Write("Enter a Binary Number: ")
        InpBinary = Console.ReadLine

        If Len(InpBinary) < 1 Or Len(InpBinary) > 8 Then
            validBinaryString = False

        Else

            For Count = 1 To Len(InpBinary)

                NextChar = Mid(InpBinary, Count, 1)
                If NextChar <> "0" Or NextChar <> "1" Then
                    validBinaryString = False
                End If
            Next
        End If


        value = 0
        total = 0
        power = 0


        If validBinaryString = True Then

            For Count = Len(InpBinary) To 1 Step -1
                NextChar = Mid(InpBinary, Count, 1)
                If Asc(NextChar) = 48 Then
                    value = 0
                    total = total + value
                Else : value = 2 ^ power
                    total = total + value

                End If
                power = power + 1
            Next

            Console.Write(InpBinary & " = " & total)

        ElseIf validBinaryString = False Then
            Console.WriteLine("Not a valid binary number...")
        Else : Console.WriteLine("")
        End If

        Console.ReadKey()

    End Sub

End Module
