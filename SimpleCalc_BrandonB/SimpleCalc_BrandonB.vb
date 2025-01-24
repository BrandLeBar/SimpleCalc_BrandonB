
Module SimpleCalc_BrandonB

    Sub Main()
        Dim Value1 As Int16
        Dim Value2 As Int16
        Dim Operation As String

        Value1 = Console.ReadLine()
        Value2 = Console.ReadLine()
        Operation = Console.ReadLine()

        If (Operation = "Add") Or (Operation = "+") Or (Operation = "add") Or (Operation = "Plus") Or (Operation = "plus") Then
            Console.WriteLine(Value1 + Value2)
        ElseIf (Operation = "Subtract") Or (Operation = "-") Or (Operation = "subtract") Or (Operation = "Minus") Or (Operation = "minus") Then
            Console.WriteLine(Value1 - Value2)
        End If

    End Sub

End Module
