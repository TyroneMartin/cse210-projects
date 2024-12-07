using System;
using System.Collections.Generic;

public class ModuloValidator  
// might add this as a helper function to ModuloOperation instead of a separate class
{
    public void Validator(double divisor)
    {
        if (divisor == 0)
            throw new DivideByZeroException("Cannot calculate modulo by zero");
    }
}

