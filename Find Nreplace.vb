Module Module1

    Sub Main()
        Dim instr, again, Charreplace, charfind, charcontain, outstring As String
        Dim count, c As Integer

        Console.WriteLine("Howmany times do you want to do this?")
        count = Console.ReadLine
        c = 1
        again = "Y"
        While c <> count Or again = "Y"
            Charreplace = ""
            charcontain = ""
            charfind = ""
            instr = ""
            outstring = ""

            Console.WriteLine("Enter text :")
            instr = Console.ReadLine
            Console.WriteLine("Enter character to find :")
            charfind = Console.ReadLine
            Console.WriteLine("enter character to replace with :")
            Charreplace = Console.ReadLine

            For a As Integer = 1 To Len(instr)
                charcontain = Mid(instr, a, 1)
                If Asc(charcontain) = Asc(charfind) Then
                    charcontain = Charreplace
                End If
                outstring = outstring & charcontain
            Next
            Console.WriteLine(outstring)
            Console.ReadKey()
            Console.Write("again? (Y/N):")
            again = Console.ReadLine
            UCase(again)
            c = c + 1
        End While


    End Sub

End Module
