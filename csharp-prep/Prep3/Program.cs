using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int numberOfGuesses = 0;


        // Intro to user
        Console.WriteLine("Guess a magic number from 1-100");
        Console.WriteLine("");

        // For Part 3, where we use assigned a random number
        // Console.Write("What is the magic number? ");
        // string userRandomNumber = Console.ReadLine();
        // convert user random number from string to int
        // int systemNumber = int.Parse(userRandomNumber);

        // Get random number from 1-100
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 100);

       do 
       {
       // get user input
        Console.Write("What is your guess? ");
        string userGuess = Console.ReadLine();

        // convert user input to int
        int userNumber = int.Parse(userGuess);

       // increment number of guesses
        if (userNumber != randomNumber)
        {
        numberOfGuesses++;
        }

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
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("You guessed it! The magic number was " + randomNumber + ", and you made " + numberOfGuesses + " number of guesses!");
            Console.WriteLine("");
            Console.Write("> Would you want to play again (yes or no)?  ");
            string playAgain = Console.ReadLine();
            if (playAgain == "yes" || playAgain == "y" || playAgain == "Yes" || playAgain == "Y" || playAgain == "YES")  
            {
            Console.WriteLine("");
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