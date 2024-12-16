using System;
public class PowerOperation : Operation
{
    public PowerOperation() : base("Exponentiation", "^") { }

    public override double Calculate(double baseValue, double exponent)
    {
        return Math.Pow(baseValue, exponent);
    }
}