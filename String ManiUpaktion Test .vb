Module Module1

    Sub Main()
        Dim ValidBinaryString As Boolean
        Dim binarystring, charb, chara As String
        Dim sumworth, denary, power, worth, countworth As Integer

        ValidBinaryString = True

        Console.WriteLine("Enter Binary Number:")
        binarystring = Console.ReadLine

        If Len(binarystring) > 8 Or Len(binarystring) < 1 Then
            ValidBinaryString = False
        Else

            For count As Integer = 1 To Len(binarystring)

                chara = Mid(binarystring, count, 1)

                If chara <> "1" And chara <> "0" Then
                    ValidBinaryString = False
                    Exit For
                End If
            Next
        End If

        If ValidBinaryString = True Then
            power = Len(binarystring)
            worth = 1

            For countworth = 1 To power
                worth = worth * 2
            Next

            For count2 = 1 To Len(binarystring)

                charb = Mid(binarystring, count2, 1)

                If charb = "1" Then
                    sumworth = (worth / 2) * 1
                    denary = denary + sumworth
                End If

                worth = worth / 2

            Next


            Console.WriteLine(binarystring & ":" & denary)
            Console.ReadKey()

        ElseIf ValidBinaryString = False Then

            Console.Write("Not a valid binary number ...")
            Console.ReadKey()

        End If



    End Sub

End Module
