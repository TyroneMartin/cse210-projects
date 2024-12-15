using System;

public class DivideOperation : Operation
{
    public DivideOperation() : base("Division", "/") { }

    public override double Calculate(double numerator, double denominator)
    {
        while (denominator == 0)
        {
            Console.WriteLine("\nError in divide operation");
            Console.WriteLine("-> Cannot divide by zero.");
            Console.Write("\nEnter a non-zero divisor: ");
            if (double.TryParse(Console.ReadLine(), out denominator) && denominator != 0)
            {
                break;
            }
            Console.WriteLine("Invalid input. Try again.");
        }
        return numerator / denominator;
    }
}
