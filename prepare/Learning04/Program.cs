using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // Create a base "Assignment" object
        Assignment assignment1 = new Assignment("\nSamuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary()); // name + topic

        // Now create the derived class assignments
        MathAssignment assignment2 = new MathAssignment("\nRoberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assignment2.GetSummary()); // name + topic 
        Console.WriteLine(assignment2.GetHomeworkList()); // name + topic + problem/s

        WritingAssignment assignment3 = new WritingAssignment("\nMary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assignment3.GetSummary()); // name + topic
        Console.WriteLine(assignment3.GetWritingInformation()); //  title + student name
        Console.WriteLine("");
    }
}
