using System;
using System.Collections.Generic;

public class ModuloOperation : Operation
{
    private ModuloValidator _validator;

    public ModuloOperation(ModuloValidator validator) : base("Modulo", "%")
    {
        _validator = validator;
    }

    public override double Calculate(double dividend, double divisor)
    {
        // _validator.Validator(divisor);
        // return dividend % divisor;
        var (updatedDividend, updatedDivisor) = _validator.Validator(dividend, divisor); // use to update divisor with the validated value
        return updatedDividend % updatedDivisor;
    }

}