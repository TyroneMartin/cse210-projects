using System;
class Program
{
    static void Main(string[] args)
    {
        OperationManager operationManager = new OperationManager();

        Calculator calculator = new Calculator(operationManager);

        // Test cases for each operation
        Console.Clear();
        Console.WriteLine($"Addition: System answer = {calculator.Add(1, 4)} | (1 + 4) = 5");
        Console.WriteLine($"Subtraction: {calculator.Subtract(10, 5)} | (10 - 5) = 5");
        Console.WriteLine($"Multiplication: {calculator.Multiply(6, 7)} | (6 * 7) = 42");
        Console.WriteLine($"Division: {calculator.Divide(15, 3)} | (15 / 3) = 5");
        // Console.WriteLine($"Modulo: {calculator.Modulo(17, 5)} | (17 % 5) = 2");

        Console.WriteLine("\nCalculation History:");
        foreach (var result in calculator.GetHistory())
        {
            Console.WriteLine(result);
        }

        calculator.ClearHistory();
    }
}