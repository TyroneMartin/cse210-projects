using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
           Console.WriteLine("This is in C#.");

        int addNum;
        int number = 42;
        addNum = number + 6;
        Console.WriteLine(addNum);

        string color = "blue";
        Console.WriteLine("The color is " + color);
        // string user_color;
        Console.Write("What is your favorite color? ");
        string user_color = Console.ReadLine();
        Console.WriteLine("Your favorite color is " + user_color);
        Console.WriteLine($"I like that color too. My favorite color is {color} and your favorite color is {user_color}");

    }
}