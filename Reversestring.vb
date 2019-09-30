Module Reversestring

    Sub Main()
        Dim inputstring As String
        Dim outstring As String
        Dim a As String
        Dim count, count1, supercount As Integer
        Console.WriteLine("Welcome to String Reversinator")
        Console.WriteLine("how many times do you want to do this? :")
        supercount = Console.ReadLine
        inputstring = ""
        count = 0
        a = ""
        For count = 1 To supercount
            outstring = ""
            Console.WriteLine("Enter your string to be reversed :")
            inputstring = Console.ReadLine
            For count1 = Len(inputstring) To 1 Step -1
                a = Mid(inputstring, count1, 1)
                outstring = outstring & a
            Next
            Console.WriteLine("Your string reversed:" & outstring)
        Next
        Console.ReadKey()

    End Sub

End Module
