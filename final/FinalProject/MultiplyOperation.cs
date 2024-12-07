
using System;
using System.Collections.Generic;

public class MultiplyOperation : Operation
{
    public MultiplyOperation() : base("Multiplication") { }

    public override double Calculate(double a, double b) => a * b;
}