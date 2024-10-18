using System;

// UML diagram
// Class: Fraction
// Attributes:
// * _numerator : int     // top
// * _denominator : int  // bottom

// Behaviors/Methods:
// * Fraction() : void
// * Fraction(wholeNumber : int) : void
// * Fraction(numerator : int, denominator : int) : void

// * GetNumerator() : int
// * GetDenominator() : int
// * SetNumerator(numerator : int) : void
// * SetDenominator(denominator : int) : void

// * GetFractionString() : string
// * GetDecimalValue() : double

class Fraction 
{
    private int _numerator;
    private int _denominator;

    // Constructor

    public Fraction()
    {
        _numerator = 1/1;
        _denominator = 1/1;
    }

    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }


    // Methods

    public int GetNumerator()
    {
        return _numerator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }


}

