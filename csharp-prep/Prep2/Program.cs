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

        string letter = "";
        string letterSign = "";

        // if (grade >= 70)
        // exceptional cases for not assigning a letter sign to A+, F+, or F-.
        if (grade >= 90 || grade <= 69)
        {
            letterSign = "";
        }
        else if (grade >= 70)
       
        {
            letterSign = "+";
        }
        else
        {
            letterSign = "-";
        }

        // convert grade to letter   
        if (grade >= 90) 
        {
            // Console.WriteLine("Your grade is an A");
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // print letter grade output

        Console.WriteLine($"Your grade is an {letter}{letterSign}");

    
      // grade pass/fail message output
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time.");
        }

    }
}