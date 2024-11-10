using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating an instance of FullName with default values
        // FullName person = new FullName();
        // person1.SetFirstLastName("John", "Doe");
        // Console.WriteLine("Person 1 Full Name: " + person1.GetFullName());

        // // Creating an instance of FullName with initial values
        // FullName person2 = new FullName("Jane", "Smith");
        // Console.WriteLine("Person 2 Full Name: " + person2.GetFullName());

        // // Updating person2's name using the setter method
        // person2.SetFirstLastName("Emily", "Jones");
        // Console.WriteLine("Updated Person 2 Full Name: " + person2.GetFullName());

        FullName person = new FullName();

        // Setting first and last name
        person.SetFirstLastName("John", "Doe");

        // Printing full name
        Console.WriteLine("Person Full Name: " + person.GetFullName());
    }
}
