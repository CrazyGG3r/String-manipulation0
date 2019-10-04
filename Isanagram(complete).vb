Module IsAnagram

    Sub Main()
        Dim chara, charb, answer, strin1, strin2 As String
        Dim instring2(30) As String
        Dim instring1(30) As String
        Dim oof As Integer = 0

        Dim a, count, count1, count2, count3, supercount As Integer

        Console.WriteLine("How many times do you want to do this?: ")
        supercount = Console.ReadLine

        For count = 1 To supercount
            Console.WriteLine("enter 1st string :")
            strin1 = UCase(Console.ReadLine)
            Console.WriteLine("enter  2nd string :")
            strin2 = UCase(Console.ReadLine)
            oof = 0
            count1 = 0
            count2 = 0
            count3 = 0



            If Len(strin1) = Len(strin2) Then
                a = Len(strin1)

                ReDim instring1(a)
                For count1 = 1 To a
                    instring1(count1) = Mid(strin1, count1, 1)
                Next
                Array.Sort(instring1)

                ReDim instring2(a)
                For count2 = 1 To a
                    instring2(count2) = Mid(strin2, count2, 1)
                Next
                Array.Sort(instring2)

                count3 = 1
                Do Until oof = 1 Or count3 = a
                    chara = instring1(count3)
                    charb = instring2(count3)

                    If chara = charb Then
                        count3 = count3 + 1
                    Else
                        oof = 1
                    End If
                Loop


                If oof = 0 Then
                    Console.WriteLine("this is an Anagram")
                    Console.WriteLine("Do you want to repeat? (y/n)")
                    answer = Console.ReadLine
                    answer = UCase(answer)


                    If answer = "N" Then
                        count = supercount
                        Console.WriteLine("Ok. Hope to see you again.")
                        Console.WriteLine(":)")
                        Console.ReadKey()
                    End If

                ElseIf oof = 1 Then
                    Console.WriteLine("this is not an anagram")
                    Console.WriteLine("Do you want to repeat? (y/n)")
                    answer = Console.ReadLine
                    answer = UCase(answer)

                End If

            Else
                Console.WriteLine("This is not an Anagram")
                Console.WriteLine("Do you want to repeat? (y/n)")
                answer = Console.ReadLine
                answer = UCase(answer)


                If answer = "N" Then
                    count = supercount
                    Console.WriteLine("Ok. Hope to see you again.")
                    Console.WriteLine(":)")
                    Console.ReadKey()
                End If

            End If

        Next


    End Sub


End Module
