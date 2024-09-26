using System;

class Program
{
    // Main method
    static void Main(string[] args)
    {
          
        DisplayWelcome();  // Display WelcomeMessage 

        // set variables and call methods
        string userName = PromptUserName("userName");
        int userNumber =  PromptUserNumber();
        int square = SquareNumber(userNumber);
        // DisplayResult method
        DisplayResult(userName, userNumber, square);
    }

    // Display WelcomeMessage method with void return type and outside the Main method
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
        Console.WriteLine("");

    }

    static string PromptUserName(string userName)
    {
        Console.Write("Please enter your name: ");
        userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userNumber = Console.ReadLine();
        int number2 = int.Parse(userNumber);
        return number2;
    }


    static int SquareNumber(int square)
    {
        square = square * square;
        return square;
    }


static void DisplayResult(string userName, int userNumber, int square)
    {
        Console.WriteLine("");
        Console.WriteLine($"> Hello, {userName}!");
        Console.WriteLine($"> Your favorite number is: {userNumber}");
        Console.WriteLine($"> {userName}. the square of your number is: {square}");
        Console.WriteLine("");
    }

}
