using System;
using System.Collections.Generic;

public class CalculationRecord : Operation
{
    private double _result;

    public CalculationRecord(string name, string sign, double result)
        : base(name, sign)
    {
        _result = result;
    }

    public double Result
    {
        get { return _result; }
    }

    public override double Calculate(double operand1, double operand2)
    {
        return _result;
    }
}