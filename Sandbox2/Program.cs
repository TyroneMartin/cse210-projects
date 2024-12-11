using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating a Student instance which has GetName() and GetNumber() methods
        Console.Clear();
        Student student = new Student();
        string name = student.GetName();
        string number = student.GetNumber();
        Console.WriteLine("Student 1:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Number: " + number);

        // Creating a Student2 instance with a name and number
        Student2 student2 = new Student2("Brigham", "234");
        string name2 = student2.GetName();
        string number2 = student2.GetNumber();
        Console.WriteLine("\nStudent 2:");
        Console.WriteLine("Name: " + name2);
        Console.WriteLine("Number: " + number2);
        Console.WriteLine("\n" + student2.GetStudentInfo() + "\n");
    }

    // Regular Person class
    public class Person
    {
        public string GetName()
        {
            return "Joseph";
        }
    }

    // Student class that inherits from Person
    public class Student : Person
    {
        public string GetNumber()
        {
            return "0123456789";
        }
    }

    // New Person2 class to set a name through a constructor
    public class Person2
    {
        private string _operationName;

        public Person2(string name)
        {
            _operationName = name;
        }

        public string GetName()
        {
            return _operationName;
        }
    }

    // Student2 class inheriting from Person2 to utilize its constructor
    public class Student2 : Person2
    {
        private string _number;

        // Calling the parent constructor using "base"
        public Student2(string name, string number) : base(name)
        {
            _number = number;
        }

        public string GetNumber()
        {
            return _number;
        }


        public string GetStudentInfo()
        {
            // return $"Name: {base.GetName()}, Number: {GetNumber()}";

            return $"Name: {GetName()}, Number: {_number}";
            // I can also set the variable user that stores GetName() to protected 
            //allowing it to be used in the class variable directly _operationName2
        }



    }
}
