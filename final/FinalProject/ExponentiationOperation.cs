using System;
public class ExponentiationOperation : Operation
{
    public ExponentiationOperation() : base("Exponentiation", "^") { }

    public override double Calculate(double baseValue, double exponent)
    {
        return Math.Pow(baseValue, exponent);
    }
}