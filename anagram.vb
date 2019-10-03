Module Module1

    Sub Main()
        Dim strin1, strin2 As String
        Dim instring1(), instring2() As String
        Dim unmatch As Integer = 0



        Console.WriteLine("enter text:")
        strin1 = Console.ReadLine
        For a As Integer = 1 To Len(strin1)
            instring1(a) = Mid(strin1, a, 1)
        Next
        Array.Sort(instring1)

        Console.WriteLine("enter second text:")
        strin2 = Console.ReadLine
        For b As Integer = 1 To Len(strin2)
            instring2(b) = Mid(strin2, b, 1)
            Console.WriteLine(instring2(b))
        Next
        Array.Sort(instring2)

        For c As Integer = 1 To Len(strin1)
            If instring1(c) <> instring2(c) Then
                unmatch = 1
            End If
            If unmatch = 1 Then
                c = instring1.Length
            End If
        Next

        If unmatch = 0 Then
            Console.WriteLine("this is anagram")
        ElseIf unmatch = 1 Then
            Console.WriteLine("this is not anagram")
        End If
        Console.ReadKey()


    End Sub

End Module
