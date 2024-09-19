using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // Letter grade converter program based off the scale
        // A >= 90
        // B >= 80
        // C >= 70
        // D >= 60
        // F < 60

        string plus = "+";
        string minus = "-";

        Console.WriteLine("This program will convert your grade percentage into a letter grade.");
        Console.WriteLine("Enter the number of your grade percentage only, ig. 100 or 90.");
        Console.WriteLine("--------------------------");
        Console.WriteLine("");

        // get user input
        Console.Write("Enter your grade percentage received using a number format: ");
        string gradeEntered = Console.ReadLine();
        int grade = int.Parse(gradeEntered);
        // Or I can use it in one line
        // int grade = int.Parse(Console.ReadLine());

        // convert grade    
        if (grade >= 90) 
        {
            Console.WriteLine("Your grade is an A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Your grade is a B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Your grade is a C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Your grade is a D");
        }
        else
        {
            Console.WriteLine("Your grade is a F");
        }

            if (grade >= 70)
            {
                Console.WriteLine("Congratulations, you passed!");
            }
            else
            {
                Console.WriteLine("Better luck next time.");
            }

        // end program
        Console.WriteLine("Goodbye!");
    }
}