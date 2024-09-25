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
  
        
        // Store user numbers in a list of float numbers
        List<float> numbers = new List<float>();


        // Initialize variables
        float sum = 0;  
        float average = 0;
        float max = 0;
        float smallestPositive = 0;


        while (number != 0)
        {
            numbers.Add(number);
            sum += number;

            average = sum / numbers.Count;
            max = numbers.Max();


            Console.Write("Enter number: ");
            number = float.Parse(Console.ReadLine());
        }

        // smallestPositive = numbers.Find(x => x > 0);

        smallestPositive = numbers.Find(numbers => numbers > 0);


    // Need to fix smallestPositive logic


        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The list numbers are: {numbers.Count}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

    }
}