﻿'Justine Hoffa
'RCET0265
'Fall2020
'

Option Strict On
Option Explicit On
Option Compare Text

Module FortuneCookie

    Sub Main()
        Dim randomNumber As Integer
        Randomize()

        Console.WriteLine("Press enter for your fourtune.")
        Do
            randomNumber = GetRandomNumber(1, 2)


            Select Case randomNumber
                Case 1
                    Console.WriteLine("dee dee mega doo doo")
                Case 2
                    Console.WriteLine("Yeahhhhh boiiiiii")
                Case 3
                    Console.WriteLine("yeet")
            End Select

            Console.ReadLine()

        Loop

    End Sub

    Function GetRandomNumber(ByVal Minimum As Integer, ByVal Maximum As Integer) As Integer
        Dim value As Single
        value = ((Maximum - Minimum + 1) * Rnd()) + Minimum
        Return CInt(value)
    End Function

End Module