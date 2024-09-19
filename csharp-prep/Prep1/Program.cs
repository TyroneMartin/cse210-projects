using System;

class Program
{
    static void Main(string[] args)
    {
        // Practice assignment
        // Get user's first and last name
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();
        Console.WriteLine("");
        // Print user's full name
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}