using System;
using System.Collections.Generic;

public class ModuloOperation
{
    private Validator _validator;

    public ModuloOperation()
    {
        _validator = new Validator();
    }

    public double Calculate(double a, double b)
    {
        _validator.ModuloValidator(b);
        return a % b;
    }

    public class Validator  
    {
        public void ModuloValidator(double divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException("Cannot calculate modulo by zero");
        }
    }
}
