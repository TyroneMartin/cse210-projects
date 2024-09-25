using System;
using System.Diagnostics.CodeAnalysis;

class Program

{
    static void Main(string[] args)
    {
        // using System.Collections.Generic;


        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        Console.Write("");
        Console.Write("Enter number: ");
        float number = float.Parse(Console.ReadLine());
  
        // Console.Write("Enter number: ");

        
        // Store user numbers in a list of floategers
        List<float> numbers = new List<float>();


        // float total.sum(numbers);
        float total = 0;  
        float average = 0;
        float max = 0;


        while (number != 0)
        {
            numbers.Add(number);
            total += number;

            average = total / numbers.Count;
            max = numbers.Max();

            Console.Write("Enter number: ");
            number = float.Parse(Console.ReadLine());
        }

     
        Console.WriteLine($"The total is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The list numbers are: {numbers.Count}");

    }
}