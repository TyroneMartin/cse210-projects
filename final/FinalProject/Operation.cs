using System;
using System.Collections.Generic;


public abstract class Operation
{
    private string _operationName;
    private string _operationSign;

    public Operation(string name, string sign)
    {
        _operationName = name;
        _operationSign = sign;
    }

    public string GetName()
    {
        return _operationName;
    }

    public string GetSign()
    {
        return _operationSign;
    }

    public abstract double Calculate(double operand1, double operand2);
}
