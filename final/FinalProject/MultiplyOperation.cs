
using System;
public class MultiplyOperation : Operation
{
    public MultiplyOperation() : base("Multiplication", "*") { }

    public override double Calculate(double baseValue, double multiplier)
    {
        return baseValue * multiplier;
    }
}