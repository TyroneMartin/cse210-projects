
using System;
using System.Collections.Generic;

public class MultiplyOperation : Operation
{
    public MultiplyOperation() : base("Multiplication", "*") { }

    public override double Calculate(double baseValue, double multiplier)
    {
        return baseValue * multiplier;
    }
}