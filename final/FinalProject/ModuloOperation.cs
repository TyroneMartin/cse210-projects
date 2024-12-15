using System;
public class ModuloOperation : Operation
{
    public ModuloOperation() : base("Modulo", "%") { }

    public override double Calculate(double dividend, double divisor)
    {
        while (divisor == 0)
        {
            Console.WriteLine("\nError in modulo operation");
            Console.WriteLine("-> Cannot use zero for modulo.");
            Console.Write("\nEnter a non-zero divisor: ");
            if (double.TryParse(Console.ReadLine(), out divisor) && divisor != 0)
            {
                break;
            }
            Console.WriteLine("Invalid input. Try again.");
        }
        return dividend % divisor;
    }
}
