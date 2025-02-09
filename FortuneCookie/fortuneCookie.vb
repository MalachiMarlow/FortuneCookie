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
                Console.WriteLine("Buy more lottery tickets to avoid danger.")
            Case 2
                Console.WriteLine("Something is going to happen to you...")
            Case 3
                Console.WriteLine("The road ahead will be filled with peril.")

        End Select

    End Sub

    Function Luck(min As Integer, max As Integer) As Integer
        Randomize()
        Return CInt((max - min) * Rnd() + min)
    End Function


End Module
