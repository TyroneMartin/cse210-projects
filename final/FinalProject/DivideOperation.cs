using System;
using System.Collections.Generic;

public class DivideOperation : Operation
{
    public DivideOperation() : base("Division", "/") { }

    public override double Calculate(double numerator, double denominator)
    {
        while (denominator == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
            Console.Write("-> Enter a non-zero number: ");
            // if (double.TryParse(Console.ReadLine(), out b))
            if (double.TryParse(Console.ReadLine(), out double newDenominator) && newDenominator != 0)
            {
                // if (denominator != 0)
                //     break;
                denominator = newDenominator;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        return numerator / denominator;
    }

}
