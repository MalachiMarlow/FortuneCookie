'Malachi Marlow
'Spring 2025
'RCET2265
'Fortune Cookie
'https://github.com/MalachiMarlow/FortuneCookie.git

Option Explicit On
Option Compare Text
Option Strict On
Module fortuneCookie

    Sub Main()
        Console.WriteLine("Feeling lucky punk?")
        Console.WriteLine("Y/N") 'The illusion of choice
        Console.Read()

        Select Case Luck(1, 3)
            Case 1
                Console.WriteLine("Gamble more!")
            Case 2
                Console.WriteLine("Keep calm and kirchoff it out.")
            Case 3
                Console.WriteLine("Eat healthy.")

        End Select

    End Sub

    Function Luck(min As Integer, max As Integer) As Integer
        Randomize()
        Return CInt((max - min) * Rnd() + min)
    End Function


End Module
