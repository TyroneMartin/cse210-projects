using System;
using System.Collections.Generic;

public class ModuloOperation
{
    private ModuloValidator _validator;

    public ModuloOperation()
    {
        _validator = new ModuloValidator();
    }

    public double Calculate(double a, double b)
    {
        _validator.Validator(b);
        return a % b;
    }

   
}
