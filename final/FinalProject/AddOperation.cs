using System;

public class AddOperation : Operation
{
    public AddOperation() : base("Addition", "+") { }

    public override double Calculate(double value1, double value2)
    {
        return value1 + value2;
    }
}