using System;
using System.Collections.Generic;

public class DivideOperation : Operation
{
    public DivideOperation() : base("Division") { }

    public override double Calculate(double a, double b)
    {
        if (b == 0) throw new DivideByZeroException("Cannot divide by zero");
        return a / b;
    }
}
