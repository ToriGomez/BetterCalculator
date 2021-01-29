'Tori Gomez
'RCET0265
'Spring 2021
'https://github.com/ToriGomez/BetterCalculator.git

Option Explicit On
Option Strict On
Option Compare Binary

Module BetterCalculator

    Sub Main()
        Dim userInput As String
        Dim quit As Boolean = False
        Dim problem As Boolean = True
        Dim functionProblem As String
        Dim firstNumber As Decimal
        Dim secondNumber As Decimal

        Console.WriteLine("Please enter two numbers. Enter ""Q"" at any time to quit.")
        Console.Read()
        userInput = Console.ReadLine()

        While problem = True And userInput <> "Q" And userInput <> "q"
            Console.WriteLine("Choose a Number:")
            Try
                userInput = Console.ReadLine()
                firstNumber = CInt(userInput)
                problem = False
            Catch ex As Exception
                Console.Beep(500, 700)
                Console.WriteLine($"You entered {userInput}, please enter a whole number.")
                problem = True
            End Try
        End While

        problem = True

        If userInput <> "Q" Or userInput <> "q" Or problem = True Then
            While problem = True And userInput <> "Q" And userInput <> "q"
                Console.WriteLine("Choose a Number:")
                Try
                    userInput = Console.ReadLine()
                    secondNumber = CInt(userInput)
                    problem = False
                Catch ex As Exception
                    Console.Beep(500, 700)
                    Console.WriteLine($"You entered {userInput}, please enter a whole number.")
                    problem = True
                End Try
            End While
        End If

        problem = True

        If userInput = "Q" Or userInput = "q" Then
            quit = True
        ElseIf userInput <> "Q" Or userInput <> "q" And problem = True Then
            Console.WriteLine("Choose one of the following options:")
            Console.WriteLine("1. Add")
            Console.WriteLine("2. Subtract")
            Console.WriteLine("3. Multipuly")
            Console.WriteLine("4. Divide")
            userInput = Console.ReadLine()
        End If

        If userInput = "q" Or userInput = "Q" Then
            quit = True
        ElseIf userInput = CStr(userInput) Or userInput > CStr(4) Then
            While problem = True And userInput = CStr(userInput) Or userInput > CStr(4)
                Console.Beep(500, 700)
                Console.WriteLine($"You entered {userInput}.")
                Console.WriteLine("Choose one of the following options:")
                Console.WriteLine("1. Add")
                Console.WriteLine("2. Subtract")
                Console.WriteLine("3. Multipuly")
                Console.WriteLine("4. Divide")
                Try
                    userInput = Console.ReadLine()
                    functionProblem = userInput
                    problem = False
                Catch ex As Exception
                    Console.Beep(500, 700)
                    Console.WriteLine($"You entered {userInput}.")
                    problem = True
                End Try
            End While
        End If

        If userInput = "1" Then
            Console.WriteLine()
            Console.WriteLine($"You entered, {userInput}")
            Console.Write($"{firstNumber} + {secondNumber} = ")
            Console.WriteLine((CInt(firstNumber)) + (CInt(secondNumber)))
            Console.ReadLine()
        ElseIf userInput = "2" Then
            Console.WriteLine()
            Console.WriteLine($"You entered, {userInput}")
            Console.Write($"{firstNumber} - {secondNumber} = ")
            Console.WriteLine((CInt(firstNumber)) - (CInt(secondNumber)))
            Console.ReadLine()
        ElseIf userInput = "3" Then
            Console.WriteLine()
            Console.WriteLine($"You entered, {userInput}")
            Console.Write($"{firstNumber} * {secondNumber} = ")
            Console.WriteLine((CInt(firstNumber)) * (CInt(secondNumber)))
            Console.ReadLine()
        ElseIf userInput = "4" Then
            Console.WriteLine()
            Console.WriteLine($"You entered, {userInput}")
            Console.Write($"{firstNumber} / {secondNumber} = ")
            Console.WriteLine((CInt(firstNumber)) / (CInt(secondNumber)))
            Console.ReadLine()
        End If

        If userInput = "Q" Or userInput = "q" Or quit Then
            Console.Clear()
            Console.WriteLine($"You Entered: {userInput}")
            Console.WriteLine("Have a nice day")
            Console.ReadLine()
            End
        End If
        Console.ReadLine()
    End Sub

End Module
