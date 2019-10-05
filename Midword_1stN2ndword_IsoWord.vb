Module Midword_1stn2ndword_IsoWords

    Sub Main()
        Dim name1, subname1, subname2, name2, namespace1, namespace2, g, h, i As String
        Dim instring, j As String
        Dim a, b, c As Integer
        Dim l, m, n As String
        Dim d, e, f As String
        Dim c1, c2, space As Integer
        Dim answer As String


        Console.WriteLine("How many times you want to do this? :")
        a = Console.ReadLine

        For b = 1 To a
            Console.WriteLine("1>Pick out Middle word.")
            Console.WriteLine("2>First name of str1 and second name of str2 together")
            Console.WriteLine("3>Show Isolated words of an STR")
            c = Console.ReadLine

            If c = 1 Then
                Console.Write("Enter string:")
                instring = Console.ReadLine
                c1 = 0
                Do Until space = 1
                    c1 = c1 + 1
                    d = Mid(instring, c1, 1)
                    If d = " " Then

                        space = 1
                    End If
                Loop

                f = ""
                Do Until space = 2
                    c1 = c1 + 1
                    e = Mid(instring, c1, 1)
                    If e = " " Then
                        space = 2
                    Else
                        f = f & e
                    End If
                Loop
                Console.WriteLine("Middle Word:" & f)

            ElseIf c = 2 Then

                Console.WriteLine("Enter Name 1:")
                name1 = Console.ReadLine

                Console.WriteLine("Enter Name 2:")
                name2 = Console.ReadLine

                namespace1 = 0
                c2 = 0
                subname1 = ""

                Do Until namespace1 = 1
                    c2 = c2 + 1
                    g = Mid(name1, c2, 1)
                    If g = " " Then
                        namespace1 = 1
                    Else : subname1 = subname1 & g
                    End If
                Loop

                h = ""
                i = 0
                namespace2 = 0
                subname2 = ""

                Do Until namespace2 = 1
                    h = Mid(name2, Len(name2) - i, 1)
                    i = i + 1
                    If h = " " Then
                        namespace2 = 1
                    Else : subname2 = subname2 & h
                    End If
                Loop

                n = ""
                For r As Integer = Len(subname2) To 1 Step -1
                    j = Mid(subname2, r, 1)
                    n = n & j
                Next

                Console.WriteLine(subname1 & " " & n)
                Console.ReadKey()



            ElseIf c = 3 Then

                Console.Write("Enter string:")
                instring = Console.ReadLine

                m = ""
                For y As Integer = 1 To Len(instring)
                    l = Mid(instring, y, 1)
                    If l = " " Then
                        Console.WriteLine(m)
                        m = ""
                    ElseIf y = Len(instring) Then
                        m = m & l
                        Console.WriteLine(m)
                        m = ""
                    Else
                        m = m & l
                    End If
                Next
                Console.ReadKey()


            End If


            Console.WriteLine("Do you want to do this again? (y/n)")
            answer = UCase(Console.ReadLine)
            If answer = "N" Then
                b = a
            End If



        Next

    End Sub

End Module
