using System;
using System.Collections.Generic;

public class ModuloValidator
{
    // might add this as a helper function to ModuloOperation instead of a separate class
    public (double dividend, double divisor) Validator(double dividend, double divisor)
    {
        while (divisor == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
            Console.Write("-> Enter a non-zero number: ");
            if (double.TryParse(Console.ReadLine(), out double newDivisor) && newDivisor != 0)
            {
                return (dividend, newDivisor); // return the updated values, if divisor was equal to zero
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
        return (dividend, divisor);  // Return original values if divisor is not equal to zero
    }
}