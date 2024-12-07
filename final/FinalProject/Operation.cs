using System;
using System.Collections.Generic;
public abstract class Operation
{
    private string _name;
    public Operation(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public abstract double Calculate(double a, double b);
}

