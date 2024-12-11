
using System;
using System.Collections.Generic;

public class SubtractOperation : Operation
{
    public SubtractOperation() : base("Subtraction", "-") { }

    public override double Calculate(double minuend, double subtrahend) 
    {
        return minuend - subtrahend;
    }
}