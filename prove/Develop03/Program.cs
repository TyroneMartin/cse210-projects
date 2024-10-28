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
            Console.Write("\nSelect an option (1-6) or type '0' to exit: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewAllScriptures(scriptureManager.GetAllScriptures()); // View all scriptures
                    break;
                case "2":
                    AddNewScripture(scriptureManager); // Add new scripture
                    break;
                case "3":
                    PracticeMemorization(scriptureManager.GetRandomScripture()); // Practice memorization
                    break;
                case "4":   // Remove existing scripture 
                    RemoveExistingScripture(scriptureManager.GetAllScriptures());
                    break;
                case "0": // Exit
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
        Console.Write("Enter book names only e.g., (John): ");
        string book = Console.ReadLine();

        Console.Write("Enter chapter: ");
        if (!int.TryParse(Console.ReadLine(), out int chapter))
        {
            Console.WriteLine("Invalid chapter number, please enter a valid number.");
            return;
        }

        Console.Write("Enter verse: ");
        if (!int.TryParse(Console.ReadLine(), out int verse))
        {
            Console.WriteLine("Invalid verse number, please enter a valid number.");
            return;
        }

        Console.Write("Enter category (e.g., Love, Mercy): ");
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

    //  static void RemoveExistingScripture(List<Scripture> scriptures)
    //     {
    //         if (scriptures.Count == 0)
    //         {
    //             Console.WriteLine("\nNo scriptures available to remove.");
    //             return;
    //         }

    //         Console.WriteLine("\n--- Available Scriptures ---");
    //         for (int i = 0; i < scriptures.Count; i++)
    //         {
    //             Console.WriteLine($"{i + 1}. {scriptures[i]}");
    //         }

    //         Console.Write("\nEnter the number of the scripture to remove: ");
    //         if (!int.TryParse(Console.ReadLine(), out int removeIndex) || 
    //             removeIndex < 1 || 
    //             removeIndex > scriptures.Count)
    //         {
    //             throw new ArgumentException("Invalid scripture selection.");
    //         }

    //         scriptures.RemoveAt(removeIndex - 1);
    //         Console.WriteLine("Scripture removed successfully!");
    //     }


    static void RemoveExistingScripture(List<Scripture> scriptures)
    {
        if (scriptures.Count == 0)
        {
            Console.WriteLine("\nNo scriptures available to remove.");
            return;
        }

        // Display available scriptures
        Console.WriteLine("\n--- Available Scriptures ---");
        for (int i = 0; i < scriptures.Count; i++)
        {
            // Console.WriteLine($"{i + 1}. {scriptures.ElementAt(i)}");
            var scripture = scriptures.ElementAt(i);
            var reference = scripture.GetScriptureManager().GetReference();
            var text = scripture.GetScriptureManager().GetText().TrimEnd('.');
            var category = scripture.GetScriptureManager().GetCategory();
            Console.WriteLine($"{i + 1}. {reference} (Category: {category}) - {text}");
        }
        Console.WriteLine("");
        Console.WriteLine("Enter 0 to go back to the main menu.");

        while (true)
        {
            Console.Write("\nEnter the number of the scripture to remove or '0' to go back: ");

            if (int.TryParse(Console.ReadLine(), out int removeIndex))
            {
                if (removeIndex == 0)
                {
                    // Exit to the main menu
                    Console.WriteLine("Returning to main menu...");
                    return;
                }
                else if (removeIndex == 1)
                {
                    // Prevent user from deleting default scripture
                    Console.WriteLine("Notice: (You are not allowed to remove the default scripture.");
                    Console.WriteLine("         Try adding one of your own scriptures first to remove.) ");
                }
                else if (removeIndex > 1 && removeIndex <= scriptures.Count)
                {
                    scriptures.RemoveAt(removeIndex - 1);
                    Console.WriteLine("Scripture removed successfully!");
                    return; // Exit 
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please enter a valid scripture number or '0' to go back.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number or type '0' to go back.");
            }
        }
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
            Console.WriteLine("\nInstructions: Press the Enter key to hide a word then type");
            Console.Write(" in your guess, or type'hint,' to get a hint or 'quit' to exit.");

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