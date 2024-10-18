using System;
using System.Xml.Schema;

// https://byui-cse.github.io/cse210-course-2023/unit03/prepare.html

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Fraction class  
        // Fraction faction = new Fraction();

        Fraction faction1 = new Fraction();
        Console.WriteLine(faction1.GetFractionString());
        Console.WriteLine(faction1.GetDecimalValue());

        Fraction faction2 = new Fraction(5);
        Console.WriteLine(faction2.GetFractionString());
        Console.WriteLine(faction2.GetDecimalValue());

        Fraction faction3 = new Fraction(3, 4);
        Console.WriteLine(faction3.GetFractionString());
        Console.WriteLine(faction3.GetDecimalValue());

        Fraction faction4 = new Fraction(1, 3);
        Console.WriteLine(faction4.GetFractionString());
        Console.WriteLine(faction4.GetDecimalValue());



    }
}