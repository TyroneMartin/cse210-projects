using System;
using System.Collections.Generic;

public class Calculator
{
    private List<double> _history;
    // private double _a;
    // private double _b;    // to implement and add getter and setters for a and b

    private OperationManager _operationManager;

    public Calculator(OperationManager operationManager)
    {
        _history = new List<double>();
        _operationManager = operationManager;
    }

    public double Add(double a, double b)
    {
        double result = _operationManager.AddOperation.Calculate(a, b);
        _history.Add(result);
        return result;
    }

    public double Subtract(double a, double b)
    {
        double result = _operationManager.SubtractOperation.Calculate(a, b);
        _history.Add(result);
        return result;
    }

    public double Multiply(double a, double b)
    {
        double result = _operationManager.MultiplyOperation.Calculate(a, b);
        _history.Add(result);
        return result;
    }

    public double Divide(double a, double b)
    {
        double result = _operationManager.DivideOperation.Calculate(a, b);
        _history.Add(result);
        return result;
    }

    public double Modulo(double a, double b)
    {
        double result = _operationManager.ModuloOperation.Calculate(a, b);
        _history.Add(result);
        return result;
    }



    public void ClearHistory()
    {
        _history.Clear();
    }

    public List<double> GetHistory()
    {
        return new List<double>(_history);
    }
}