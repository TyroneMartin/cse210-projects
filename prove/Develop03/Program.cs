using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Scripture scriptureManager = new Scripture();
        Generator generator = new Generator();
        bool isRunning = true;

        while (isRunning)
        {
            scriptureManager.OptionMenu();
            Console.Write("\nSelect an option (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewAllScriptures(scriptureManager.GetAllScriptures());
                    break;
                case "2":
                    AddNewScripture(scriptureManager);
                    break;
                case "3":
                    PracticeMemorization(scriptureManager.GetRandomScripture());
                    break;
                case "4":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void ViewAllScriptures(List<Scripture> scriptures)
    {
        Console.Clear();
        Console.WriteLine("All Scriptures:");
        foreach (var scripture in scriptures)
        {
            Console.WriteLine(scripture.ToString());
        }
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    static void AddNewScripture(Scripture scriptureManager)
    {
        Console.Clear();
        Console.Write("Enter book: ");
        string book = Console.ReadLine();
        
        Console.Write("Enter chapter: ");
        if (!int.TryParse(Console.ReadLine(), out int chapter))
        {
            Console.WriteLine("Invalid chapter number.");
            return;
        }
        
        Console.Write("Enter verse: ");
        if (!int.TryParse(Console.ReadLine(), out int verse))
        {
            Console.WriteLine("Invalid verse number.");
            return;
        }
        
        Console.Write("Enter category (e.g., Gospel, Prophecy): ");
        string category = Console.ReadLine();
        
        Console.Write("Enter scripture text: ");
        string text = Console.ReadLine();

        // Create new scripture with ScriptureManager constructor
        ScriptureManager newManager = new ScriptureManager(book, chapter, verse, category, text);
        Scripture newScripture = new Scripture(newManager);

        scriptureManager.AddEntry(newScripture);
        Console.WriteLine("\nScripture added successfully! Press any key to continue...");
        Console.ReadKey();
    }

    static void PracticeMemorization(Scripture scripture)
    {
        if (scripture == null)
        {
            Console.WriteLine("No scriptures available for practice.");
            Console.ReadKey();
            return;
        }

        Console.Clear();
        Console.WriteLine("Scripture Memorization Practice");
        Console.WriteLine("Press Enter to hide words, type 'quit' to exit, or 'hint' for help.");
        Console.WriteLine("\nOriginal scripture:");
        Console.WriteLine(scripture.ToString());
        Console.WriteLine("\nPress Enter to begin...");
        Console.ReadKey();

        Words words = new Words(scripture.GetScriptureManager().GetText());
        bool practicing = true;

        while (practicing)
        {
            Console.Clear();
            Console.WriteLine($"Reference: {scripture.GetScriptureManager().GetReference()}");
            Console.WriteLine("\nCurrent state:");
            Console.WriteLine(words.GetDisplayText());
            Console.Write("\nEnter a guess, 'hint', or 'quit': ");
            
            string input = Console.ReadLine().Trim();
            
            if (input.ToLower() == "quit")
            {
                practicing = false;
            }
            else if (input.ToLower() == "hint")
            {
                string hint;
                words.CheckWord("", out hint);
                Console.WriteLine(hint);
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadKey();
            }
            else if (string.IsNullOrEmpty(input))
            {
                if (!words.HideRandomWord())
                {
                    Console.WriteLine("All words are hidden! Try guessing them.");
                    Console.ReadKey();
                }
            }
            else
            {
                string hint;
                if (words.CheckWord(input, out hint))
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Incorrect. " + hint);
                }
                Console.WriteLine("\nPress Enter to continue...");
                Console.ReadKey();
            }

            if (words.IsCompleted())
            {
                Console.WriteLine("\nCongratulations! You've memorized the scripture!");
                Console.WriteLine("Press any key to return to the main menu...");
                Console.ReadKey();
                practicing = false;
            }
        }
    }
}