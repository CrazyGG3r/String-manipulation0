Module Module1

    Sub Main()
        Dim a, b, c, d, e As Integer
        Dim h, i, j, k As String

        h = ""
        i = " "
        j = " "
        k = "Y"

        Console.WriteLine("Welcome to triangle frenzy")

        Do Until k = "y"

            Console.WriteLine("Enter character to draw with :")
            h = Console.ReadLine

            Console.WriteLine("Enter height of triangle:")
            a = Console.ReadLine

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
            Console.WriteLine("Do You want to do it again? (Y/N)")
            k = UCase(Console.ReadLine)
        Loop

        Console.ReadKey()













    End Sub

End Module
