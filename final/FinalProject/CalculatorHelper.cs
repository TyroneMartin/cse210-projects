using System;
using System.Collections.Generic;

public class CalculatorHelper
{
    private readonly Calculator _calculator;
    private readonly Dictionary<string, Operation> _operations;

    public CalculatorHelper(Calculator calculator)
    {
        _calculator = calculator;
        _operations = new Dictionary<string, Operation>
        {
            { "*", new MultiplyOperation() },
            { "/", new DivideOperation() },
            { "+", new AddOperation() },
            { "-", new SubtractOperation() },
            { "%", new ModuloOperation() },
            { "^", new PowerOperation() }
        };
    }

    public void PerformCalculations()
    {
        Console.Clear();
        double firstNumber = _calculator.GetUserInput("Enter the first number: ");
        _calculator.Reset();
        _calculator.SetCurrentResult(firstNumber);

        bool continueCalculating = true;
        while (continueCalculating)
        {
            Console.WriteLine($"\n->    Current result:  [ {_calculator.CurrentResult} ] ");
            Console.Write("->    Choose an operator: Ex. (*, /, +, -, %, ^): ");
            string operatorInput = Console.ReadLine();

            if (!_operations.ContainsKey(operatorInput))
            {
                Console.WriteLine("->    Invalid operator. Please try again.");
                continue;
            }

            double nextNumber = _calculator.GetUserInput("->    Enter the next number: ");
            _calculator.PerformOperation(_operations[operatorInput], nextNumber);
            Console.WriteLine($"\n->    Updated result:   [ {_calculator.CurrentResult} ]");

            Console.Write("\nDo you want to perform another operation? (y/n): ");
            string response = Console.ReadLine()?.ToLower().Trim();

            if (response == "y" || response == "yes")
            {
                continueCalculating = true;
            }
            else if (response == "n" || response == "no")
            {
                continueCalculating = false;
            }
            else
            {
                Console.WriteLine("\n~~ Error: Invalid choice. Please try again. ~~");
                while (true)
                {
                    Console.Write("Please enter 'y' for yes or 'n' for no: ");
                    response = Console.ReadLine()?.ToLower().Trim();

                    if (response == "y" || response == "yes")
                    {
                        continueCalculating = true;
                        break;
                    }
                    else if (response == "n" || response == "no")
                    {
                        continueCalculating = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Try again.");
                    }
                }
            }
        }
    }

    public void DisplayHistory()
    {
        Console.Clear();
        var history = _calculator.GetHistory();
        if (history.Count == 0)
        {
            Console.WriteLine("No calculations have been performed yet.");
        }
        else
        {
            Console.WriteLine("~~ Calculation History ~~");
            foreach (var record in history)
            {
                Console.WriteLine($"\n  -> Operation performed: {record.OperationName}, Result: {record.Result}");
            }
        }
        Console.WriteLine("\nPress any key to return to the main menu...");
        Console.ReadKey();
    }
}
