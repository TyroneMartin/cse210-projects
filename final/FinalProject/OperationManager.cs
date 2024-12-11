using System;
using System.Collections.Generic;

public class OperationManager
{
    private AddOperation _addOperation;
    private SubtractOperation _subtractOperation;
    private MultiplyOperation _multiplyOperation;
    private DivideOperation _divideOperation;
    private ModuloOperation _moduloOperation;

    public OperationManager()
    {
        var moduloValidator = new ModuloValidator();
        _addOperation = new AddOperation();
        _subtractOperation = new SubtractOperation();
        _multiplyOperation = new MultiplyOperation();
        _divideOperation = new DivideOperation();
        _moduloOperation = new ModuloOperation(moduloValidator);
    }

    public AddOperation AddOperation
    {
        get { return _addOperation; }
    }
    public SubtractOperation SubtractOperation
    {
        get { return _subtractOperation; }
    }
    public MultiplyOperation MultiplyOperation
    {
        get { return _multiplyOperation; }
    }
    public DivideOperation DivideOperation
    {
        get { return _divideOperation; }
    }
    public ModuloOperation ModuloOperation
    {
        get { return _moduloOperation; }
    }
}