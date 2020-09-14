'Justine Hoffa
'RCET0265
'Fall2020
'FortuneCookie
'https://github.com/justinehoffa/FortuneCookie

Option Strict On
Option Explicit On
Option Compare Text

Module FortuneCookie

    Sub Main()
        Dim randomNumber As Integer
        Randomize()
        Dim quit As String


        Do
            Console.WriteLine("Press enter for your fourtune.")
            quit = Console.ReadLine()
            If quit = "q" Then
                Exit Sub
            End If

            randomNumber = GetRandomNumber(1, 2)

            Select Case randomNumber
                Case 1
                    Console.WriteLine("dee dee mega doo doo")
                Case 2
                    Console.WriteLine("Yeahhhhh boiiiiii")
                Case 3
                    Console.WriteLine("yeet")
            End Select

            quit = Console.ReadLine()
            If quit = "q" Then
                Exit Sub
            End If
            Console.Clear()
        Loop

    End Sub

    Function GetRandomNumber(ByVal Minimum As Integer, ByVal Maximum As Integer) As Integer
        Dim value As Single
        value = ((Maximum - Minimum + 1) * Rnd()) + Minimum
        Return CInt(value)
    End Function

End Module
