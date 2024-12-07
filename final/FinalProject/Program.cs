using System;
using System.Security.Cryptography;
class Program
{
    static void Main(string[] args)

    {
        Console.Clear();
        // TODO: Add a menu for the user to choose from 
        // for each operation

        // bool running = true;
        // while (running)
        // {
        Console.WriteLine("======================================");
        Console.WriteLine("Welcome to the Calculator!");
        Console.WriteLine("======================================");
        // Console.WriteLine("\nMenu Options:");
        // Console.WriteLine(" 1. Addition");
        // Console.WriteLine(" 2. Subtraction");
        // Console.WriteLine(" 3. Multiplication");
        // Console.WriteLine(" 4. Division");
        // Console.WriteLine(" 5. Modulo");
        // Console.WriteLine(" 7. View History");
        // Console.WriteLine(" 6. Clear History");
        // Console.WriteLine(" 4. Quit");
        // Console.Write("\nSelect a choice from the menu: ");
        // string choice = Console.ReadLine();

        // if (choice == "1")
        // {
        // return;
        // }

        //     if (choice == "4")
        //     {
        //         Console.WriteLine("Goodbye!");
        //         return;
        //     }
        // }


        OperationManager operationManager = new OperationManager();
        Calculator calculator = new Calculator(operationManager);

        // Test cases for each operation
        Console.Write("\nTest cases for each operation: \n");

        Console.WriteLine($"\nAddition: System answer = {calculator.Add(1, 4)} |  (1 + 4) = 5");
        Console.WriteLine($"\nSubtraction: System answer = {calculator.Subtract(10, 5)} | (10 - 5) = 5");
        Console.WriteLine($"\nMultiplication: System answer = {calculator.Multiply(6, 7)}| (6 * 7) = 42");
        Console.WriteLine($"\nDivision: System answer = {calculator.Divide(15, 3)} | (15 / 3) = 5");
        Console.WriteLine($"\nModulo: System answer = {calculator.Modulo(17, 5)} | (17 % 5) = 2");

        Console.WriteLine("\nTest Calculation History:");
        foreach (var result in calculator.GetHistory())
        {
            Console.WriteLine(result);
        }

        calculator.ClearHistory();
    }
}