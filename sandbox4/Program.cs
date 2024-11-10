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
        Console.WriteLine(addNum); // Display the stored variable number of 48

        string color = "blue";
        Console.WriteLine("The color is " + color); // Display the stored variable color of blue
        // string user_color;
        Console.Write("What is your favorite color? "); // Get user input for favorite color
        string user_color = Console.ReadLine(); // Store user input for favorite color
        Console.WriteLine("Your favorite color is " + user_color); 
        Console.WriteLine($"I like that color too. My favorite color is {color} and your favorite color is {user_color}");


    }
}


// A code template for the category of things known as Person. The
    // responsibility of a Person is to hold and display personal information.
    public class Person
    {
        // The C# convention is to start member variables with an underscore _
        public string _givenName = "Tyrone";
        public string _familyName = "Martin";

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Person()
        {
        }

        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        public void ShowEasternName()
        {
            Console.WriteLine($"{_familyName}, {_givenName}");
        }

        // A method that displays the person's full name as used in western 
        // countries or <given name family name>.
        public void ShowWesternName()
        {
            Console.WriteLine($"{_givenName} {_familyName}");
        }

        



// Class: Person
// Attributes  properties or member variables:  
// * _givenName : string
// * _familyName : string

// Behaviors:
// * ShowEasternName() : void
// * ShowWesternName() : void

    }




// Week 03 ULM Class Design
// Understanding ULM Class Design 
// https://www.youtube.com/watch?v=6XrL5jXmTwM
