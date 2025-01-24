Option Explicit On
Option Strict On

'Brandon Barrera
'Spring 2025
'RCET2235
'Simple Calculator
'https://github.com/BrandLeBar/SimpleCalc_BrandonB.git

Imports System.Configuration

Module SimpleCalc_BrandonB

    Sub Main()
        Dim Value1 As Integer
        Dim Value2 As Integer
        Dim Operation As String

        Console.WriteLine("Enter a number")
        Value1 = CInt(Console.ReadLine()) 'Convert user input into an integer
        Console.WriteLine("You chose: " & Value1)
        Console.WriteLine()

        Console.WriteLine("Enter another number")
        Value2 = CInt(Console.ReadLine())
        Console.WriteLine("You chose: " & Value2)
        Console.WriteLine()

        Console.WriteLine("Choose a operation to perform" _
                          & vbNewLine & "1. Add" _
                          & vbNewLine & "2. Subtract")
        Operation = Console.ReadLine()

        If Operation = "1" Then
            Console.WriteLine("You chose: Additon")
            Console.WriteLine()
            Console.WriteLine($"{Value1} + {Value2} = " & Value1 + Value2)
        ElseIf Operation = "2" Then
            Console.WriteLine("You chose: Subtraction")
            Console.WriteLine()
            Console.WriteLine($"{Value1} - {Value2} = " & Value1 - Value2)
        Else Console.WriteLine("Wrong! Try again.")

        End If

    End Sub

End Module
