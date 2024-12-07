using System;
using System.Collections.Generic;

public class AddOperation : Operation
{
    public AddOperation() : base("Addition") { }

    public override double Calculate(double a, double b) 
    {
        return a + b;
    }
}