using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        

        // Intro to user
        Console.WriteLine("Guess a random number from 1-100");
        Console.WriteLine("");

        // Console.Write("What is the magic number? ");
        // string userRandomNumber = Console.ReadLine();

        // Get random number from 1-100
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 100);

       do 
       {
       // get user input
        Console.Write("What is your guess? ");
        string userGuess = Console.ReadLine();

        // Console.WriteLine($"The Random number is {randomNumber}"); 

        // convert user input to int
        int userNumber = int.Parse(userGuess);
        // convert user random number from string to int
        // int systemNumber = int.Parse(userRandomNumber);

        // check if guess is higher or lower than random number
        if (randomNumber > userNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (randomNumber < userNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it! The magic number was " + randomNumber);
            Console.WriteLine("");
            Console.Write($"Do you want to play again (yes or no)?  ");
            string playAgain = Console.ReadLine();
            if (playAgain == "yes")
            {
                continue;
            }
            else
            {
                Console.WriteLine("Thank you for playing! Goodbye!");
                break;
            }   
        }

       } while (true);       
    }

}