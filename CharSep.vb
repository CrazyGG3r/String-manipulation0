Module CharSep

    Sub Main()
        Dim instring As String
        Dim char2, charsmol, charCap, Numbers As String
        Dim symbols As String
        Dim c As Integer

        char2 = ""
        charsmol = ""
        charCap = ""
        Numbers = ""
        symbols = ""

        Console.WriteLine("eneter string")
        instring = Console.ReadLine

        For c = 1 To Len(instring)
            char2 = Mid(instring, c, 1)
            If Asc(char2) >= Asc("A") And Asc(char2) <= Asc("Z") Then
                charCap = charCap & char2
            ElseIf Asc(char2) >= Asc("a") And Asc(char2) <= Asc("z") Then
                charsmol = charsmol & char2
            ElseIf Asc(char2) >= Asc("0") And Asc(char2) <= Asc("9") Then
                Numbers = Numbers & char2
            Else : symbols = symbols & char2

            End If
        Next
        If charCap <> "" Then
            Console.WriteLine("Capital Alphabets:" & charCap)
        End If
        If charsmol <> "" Then
            Console.WriteLine("Smol Alphabets:" & charsmol)
        End If
        If Numbers <> "" Then
            Console.WriteLine("Numbers:" & Numbers)
        End If
        If symbols <> "" Then
            Console.WriteLine("Symbols:" & symbols)
        End If

        Console.ReadKey()
        Console.WriteLine("^__^")
        Console.ReadKey()

    End Sub

End Module
