using System;
using System.Collections.Generic;

class Program
{
    static void DisplayWelcomeBanner()
    {
        Console.WriteLine("=================================");
        Console.WriteLine("Scripture Memorization Program");
        Console.WriteLine("=================================");
    }

    static void Main(string[] args)
    {
        DisplayWelcomeBanner();

        // Initialize core objects
        Scripture scriptureManager = new Scripture();
        Generator generator = new Generator();
        List<Scripture> scriptures = new List<Scripture>();

        bool isRunning = true;
        while (isRunning)
        {
            try
            {
                scriptureManager.OptionMenu();
                Console.Write("\nSelect a menu option (1-5): ");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1": // Add Scripture
                        AddNewScripture(scriptures);
                        break;

                    case "2": // Remove Scripture
                        RemoveExistingScripture(scriptures);
                        break;

                    case "3": // Random Scripture
                        generator.ScriptureGenerator(scriptures);
                        break;

                    case "4": // Practice Mode
                        PracticeMemorization(scriptureManager, scriptures);
                        break;

                    case "5": // Exit
                        isRunning = false;
                        Console.WriteLine("\nThank you for using the Scripture Memorization Program!");
                        break;

                    default:
                        Console.WriteLine("\nInvalid option. Please select a number between 1-5.");
                        break;
                }

                if (isRunning)
                {
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                    Console.Clear();
                    DisplayWelcomeBanner();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nAn error occurred: {ex.Message}");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                Console.Clear();
                DisplayWelcomeBanner();
            }
        }
    }

    static void AddNewScripture(List<Scripture> scriptures)
    {
        Console.WriteLine("\n--- Add New Scripture ---");
        
        Console.Write("Enter Book (e.g., John): ");
        string book = Console.ReadLine();

        Console.Write("Enter Chapter: ");
        if (!int.TryParse(Console.ReadLine(), out int chapter))
        {
            throw new FormatException("Chapter must be a number.");
        }

        Console.Write("Enter Verse: ");
        if (!int.TryParse(Console.ReadLine(), out int verse))
        {
            throw new FormatException("Verse must be a number.");
        }

        Console.Write("Enter Category (e.g., Gospel, Prophecy): ");
        string category = Console.ReadLine();

        ScriptureManager newScripture = new ScriptureManager(book, chapter, verse, category);
        scriptures.Add(newScripture);
        Console.WriteLine("\nScripture added successfully!");
    }

    static void RemoveExistingScripture(List<Scripture> scriptures)
    {
        if (scriptures.Count == 0)
        {
            Console.WriteLine("\nNo scriptures available to remove.");
            return;
        }

        Console.WriteLine("\n--- Available Scriptures ---");
        for (int i = 0; i < scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {scriptures[i]}");
        }

        Console.Write("\nEnter the number of the scripture to remove: ");
        if (!int.TryParse(Console.ReadLine(), out int removeIndex) || 
            removeIndex < 1 || 
            removeIndex > scriptures.Count)
        {
            throw new ArgumentException("Invalid scripture selection.");
        }

        scriptures.RemoveAt(removeIndex - 1);
        Console.WriteLine("Scripture removed successfully!");
    }

    static void PracticeMemorization(Scripture scriptureManager, List<Scripture> scriptures)
    {
        if (scriptures.Count == 0)
        {
            Console.WriteLine("\nNo scriptures available for practice. Please add some scriptures first.");
            return;
        }

        Scripture randomScripture = scriptureManager.GetRandomScripture();
        if (randomScripture != null)
        {
            Words wordHandler = new Words(randomScripture.ToString());
            
            Console.WriteLine("\n--- Memorization Practice ---");
            Console.WriteLine("\nOriginal Scripture:");
            Console.WriteLine(wordHandler.UnhiddenWord());
            
            Console.WriteLine("\nPress Enter when ready to hide random words...");
            Console.ReadLine();
            
            wordHandler.HideRandomWords();
            Console.WriteLine("\nTry to remember the hidden words:");
            Console.WriteLine(wordHandler.GetHiddenWord());
            
            Console.WriteLine("\nPress Enter to reveal the original scripture...");
            Console.ReadLine();
            
            Console.WriteLine("\nOriginal Scripture:");
            Console.WriteLine(wordHandler.UnhiddenWord());
        }
    }
}