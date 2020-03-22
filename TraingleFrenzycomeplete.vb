Module Module1

    Sub Main()
        Dim a As String
        Dim t As Integer
        Dim ans As String = "Y"

        Console.WriteLine("welcome to triangle frenzy")

        Do Until ans <> "Y"
            Console.WriteLine(" ")
            Console.WriteLine("1) Uptriangle")
            Console.WriteLine("2) Downtriangle")
            Console.WriteLine("3) Text Clearing ")

            Console.WriteLine("4) Hollow triangle")
            Console.WriteLine("5) Hollow Triangle Upside down")

            t = Console.ReadLine


            If t = 3 Then
                clearing()

            ElseIf t = 1 Then
                Console.WriteLine("Enter string : ")
                a = Console.ReadLine
                DownTriangle(a)

            ElseIf t = 2 Then
                Console.WriteLine("Enter string : ")
                a = Console.ReadLine
                Uptriangle(a)

            ElseIf t = 4 Then
                Console.WriteLine("Enter Height of triangle:")
                a = Console.ReadLine
                HollowTriangle(a)

            ElseIf t = 5 Then
                Console.WriteLine("Enter Height of triangle:")
                a = Console.ReadLine
                Hollowupsidedown(a)
            End If
            Console.WriteLine("Do you want to do this again? (Y/N)")
            ans = UCase(Console.ReadLine)
        Loop

        Console.ReadKey()



    End Sub

    Sub Uptriangle(ByVal a As String)
        Dim b, c, d As String
        Dim e, f, g, h, i As Integer

        b = " "

        For i = 5 To 1 Step -1
            h = (i - 5) * -1

            If h <> 0 Then
                For count = 1 To h
                    b = b + " "
                Next
            End If

            e = i * 2
            For count2 = 1 To e
                b = b + a
            Next

            If h <> 0 Then
                For count = 1 To h
                    b = b + " "
                Next
            End If
            Console.WriteLine(b)
            b = " "

        Next
        Console.ReadKey()

    End Sub
    Sub DownTriangle(ByVal a As String)
        Dim b, c, d As String
        Dim e, f, g, h, i As Integer

        b = " "

        For i = 1 To 5
            h = (i - 5) * -1

            If h <> 0 Then
                For count = 1 To h
                    b = b + " "
                Next
            End If

            e = i * 2
            For count2 = 1 To e
                b = b + a
            Next

            If h <> 0 Then
                For count = 1 To h
                    b = b + " "
                Next
            End If
            Console.WriteLine(b)
            b = " "

        Next
        Console.ReadKey()

    End Sub
    Sub clearing()
        Dim a, b, c, d, e As String
        Dim f, g, h As Integer

        Console.WriteLine("Enter text to clear")
        a = Console.ReadLine
        Console.WriteLine("enter character to remove")
        b = Console.ReadLine

        For count = 1 To Len(a)
            c = Mid(a, count, 1)

            If c <> b Then
                d = d + c
            End If
        Next
        Console.WriteLine("Your Cleared text:" & d)
    End Sub
    Sub HollowTriangle(ByVal a As Integer)
        Dim b, c, d, e As Integer
        Dim h, i, j, k As String

        h = ""
        i = " "
        j = " "
        k = "Y"


        Console.WriteLine("Enter character to draw with :")
        h = Console.ReadLine

        For count = 1 To a

            b = a - count
            e = (2 * count) - 3
            c = (2 * a)
            d = (2 * a) + 1
            If count = 1 Then

                j = " "

                For countspace1 = 1 To b
                    j = j + " "
                Next

                j = j + h

                For countspace2 = 1 To b
                    j = j + " "
                Next
                Console.WriteLine(j)

            End If

            j = " "


            Do Until Len(j) = c Or count = 1

                For countspace1 = 1 To b
                    j = j + " "
                Next

                j = j + h

                For countspacemid = 1 To e
                    j = j + " "
                Next

                j = j + h

                For countspace2 = 1 To b
                    j = j + " "
                Next
                Console.WriteLine(j)
            Loop
            j = " "
            If count = a Then

                j = ""

                For countlastrow = 1 To d
                    j = j + h
                Next

                Console.WriteLine(j)
            End If
        Next

    End Sub
    Sub Hollowupsidedown(ByVal a As Integer)

        Dim b, c, d, e As Integer
        Dim h, i, j, k As String

        h = "u"
        i = " "
        j = " "
        k = "Y"


        Console.WriteLine("Enter character to draw with :")
        h = Console.ReadLine

        For count = a To 1 Step -1

            b = a - count
            e = (2 * count) - 3
            c = (2 * a)
            d = (2 * a) - 1


            If count = a Then
                j = " "
                For countfirstrow = 1 To d
                    j = j + h
                Next
                Console.WriteLine(j)
            End If



            j = " "
            Do Until Len(j) = c Or count = a Or count = 1
                If b > 0 Then
                    For countspace1 = 1 To b
                        j = j + " "
                    Next
                End If

                j = j + h

                For countspacemid = 1 To e
                    j = j + " "
                Next

                j = j + h

                If b > 0 Then
                    For countspace2 = 1 To b
                        j = j + " "
                    Next
                End If
                Console.WriteLine(j)
            Loop

            j = " "

            If count = 1 Then
                j = " "
                For countspace1 = 1 To b
                    j = j + " "
                Next

                j = j + h
                For countspace2 = 1 To b
                    j = j + " "
                Next
                Console.WriteLine(j)
            End If
            

        Next

    End Sub
End Module
