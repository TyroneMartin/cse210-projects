using System;

public class CalculationRecord
{
    private readonly string _operationName;
    private readonly string _operationSign;
    private readonly double _result;

    public CalculationRecord(string name, string sign, double result)
    {
        _operationName = name;
        _operationSign = sign;
        _result = result;
    }

    public string OperationName
    {
        get { return _operationName; }
    }
    public string OperationSign
    {
        get { return _operationSign; }
    }
    public double Result
    {
        get { return _result; }
    }

}
