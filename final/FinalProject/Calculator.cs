using System;
using System.Collections.Generic;

public class Calculator
{
    private List<CalculationRecord> _calculationHistory;
    private double _operandA;
    private double _operandB;

    public Calculator()
    {
        _calculationHistory = new List<CalculationRecord>();
    }

    public double OperandA
    {
        get { return _operandA; }
        set { _operandA = value; }
    }

    public double OperandB
    {
        get { return _operandB; }
        set { _operandB = value; }
    }

    public double PerformOperation(Operation operation, double operandA, double operandB)
    {
        double result = operation.Calculate(operandA, operandB);
        _calculationHistory.Add(new CalculationRecord(operation.GetName(), operation.GetSign(), result));
        return result;
    }

    public void ClearHistory()
    {
        _calculationHistory.Clear();
    }

    public List<CalculationRecord> GetCalculationHistory()
    {
        return new List<CalculationRecord>(_calculationHistory);
    }
}