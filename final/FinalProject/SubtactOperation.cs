
using System;
using System.Collections.Generic;

public class SubtractOperation : Operation
{
    public SubtractOperation() : base("Subtraction") { }

    public override double Calculate(double a, double b) 
    {
        return a - b;
    }
}