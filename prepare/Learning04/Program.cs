using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a base "Assignment" object
        Console.Clear();
        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());

        // Now create the derived class assignments
        MathAssignment assignment2 = new MathAssignment("\nRoberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("\nMary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
        Console.WriteLine("");
    }
}
