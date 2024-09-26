using System;
using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;


class Program

{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        Console.WriteLine("");
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
            Console.Write("Enter number: ");
            number = float.Parse(Console.ReadLine());
        }


        // additional logic to calculate variables
        average = sum / numbers.Count;
        max = numbers.Max();
        smallestPositive = numbers.Where(n => n > 0).Min();   
        // Find the smallest positive number lambda expression
        // can also use the if statement to find the smallest positive in the list 
        // e.g. if (n > 0) { smallestPositive = n; }

        numbers.Sort();
        string sortedList = string.Join(", ", numbers);


        // print out the results
        Console.WriteLine("");
        Console.WriteLine($"> The sum is: {sum}");
        Console.WriteLine($"> The average is: {average}");
        Console.WriteLine($"> The largest number is: {max}");
        Console.WriteLine($"> The smallest positive number is: {smallestPositive}");
        Console.WriteLine($"> The total number count in the list is: {numbers.Count}");
        Console.WriteLine("########################################################");
        Console.WriteLine($"> The sorted list is: {sortedList}");
        Console.WriteLine("########################################################");
        Console.WriteLine("");

    }
}


