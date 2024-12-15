using System;
using System.Collections.Generic;

public class Calculator
{
    private readonly List<CalculationRecord> _history = new();

    private double _currentResult;

    public Calculator(double currentResult)
    {
        _currentResult = currentResult;
    }

    public double CurrentResult
    {
        get { return _currentResult; }
    }


    public void Reset()
    {
        _history.Clear();
        _currentResult = 0;
    }

    public double PerformOperation(Operation operation, double operand)
    {
        _currentResult = operation.Calculate(_currentResult, operand);
        _history.Add(new CalculationRecord(operation.GetName(), operation.GetSign(), _currentResult));
        return _currentResult;
    }

    public List<CalculationRecord> GetHistory()
    {
        return new List<CalculationRecord>(_history);
    }

    public double GetUserInput(string prompt)
    {
        Console.Write(prompt);
        double input;
        while (!double.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("\n->    Invalid input. Please enter a valid number.");
            Console.Write(prompt);
        }
        return input;
    }

    public void SetCurrentResult(double value)
    {
        _currentResult = value;
    }

}
