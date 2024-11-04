using System;
using System.Collections.Generic;

public class ScriptureManager
{
    private List<Scripture> _scriptures;

    public ScriptureManager()
    {
        _scriptures = new List<Scripture>();
        AddDefaultScripture();
    }

    private void AddDefaultScripture()
    {
        _scriptures.Add(new Scripture(
            "John", 3, 16, "Love",
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
        ));
    }

    public void ViewAllScriptures()
    {
        Console.Clear();
        Console.WriteLine("__________All Scriptures__________");
        for (int i = 0; i < _scriptures.Count; i++)
        {
            Console.WriteLine($"\n{i + 1}. {_scriptures[i]}");
        }
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    public void AddNewScripture()
    {
        Console.Clear();
        Console.Write("Enter book name (e.g., John): ");
        string book = Console.ReadLine();

        Console.Write("Enter chapter (e.g., 3): ");
        if (!int.TryParse(Console.ReadLine(), out int chapter))
        {
            Console.WriteLine("Invalid chapter number (e.g., 3). ");
            return;
        }

        Console.Write("Enter verse (e.g., 3): ");
        if (!int.TryParse(Console.ReadLine(), out int verse))
        {
            Console.WriteLine("Invalid verse number.");
            return;
        }

        Console.Write("Enter category (e.g., Love, Mercy): ");
        string category = Console.ReadLine();

        Console.Write("Enter scripture text: ");
        string text = Console.ReadLine();

        _scriptures.Add(new Scripture(book, chapter, verse, category, text));
        Console.WriteLine("\nScripture added successfully! Press any key to continue...");
        Console.ReadKey();
    }

    public void PracticeMemorization()
    {
        Scripture scripture = GetRandomScripture();
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

        bool practicing = true;
        while (practicing)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            // Console.WriteLine("");
            Console.WriteLine("\nPress Enter to hide more words, type a word to guess,");
            Console.Write("type 'hint' for a hint, or 'quit' to exit: ");

            string input = Console.ReadLine().Trim().ToLower();
            switch (input)
            {
                case "quit":
                    practicing = false;
                    break;
                case "hint":
                    string hint;
                    scripture.CheckWord("", out hint);
                    Console.WriteLine(hint);
                    break;
                case "":
                    if (!scripture.HideRandomWordGroup())
                    {
                        Console.WriteLine("\nAll words are hidden! Press any key to continue...");
                        scripture.HideRandomWordGroup();
                        Console.ReadKey();
                        RevealAllWords();

                        return; //return to main menu
                    }
                    break;
                default:
                    string guessHint;
                    if (scripture.CheckWord(input, out guessHint))
                    {
                        Console.WriteLine("Correct!");
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect. {guessHint}");
                    }
                    break;
            }

            if (scripture.IsCompleted())
            {
                Console.WriteLine("\nCongratulations! You've memorized the scripture!");
                Console.WriteLine("Press any key to return to the main menu...");
                Console.ReadKey();
                return; // Exit to return to the main menu after completion
            }

            if (input != "quit")
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
    public bool RemoveScripture()
    {
        Console.Clear();
        Console.WriteLine("Remove Scripture");

        if (_scriptures.Count <= 1)  // if logic
        {
            // Prevent user from deleting default scripture
            Console.WriteLine("Warning: (You are not allowed to remove the default scripture.");
            Console.WriteLine("         Try adding one of your own scriptures first to remove.) ");
            Console.ReadKey();
            return false;
        }

        ViewAllScriptures();
        Console.Write("\nEnter the number of the scripture to remove (1 is default and cannot be removed): ");

        if (int.TryParse(Console.ReadLine(), out int index) && index > 1 && index <= _scriptures.Count)
        {
            _scriptures.RemoveAt(index - 1);
            Console.WriteLine("Scripture removed successfully!");
            return true;
        }
        else
        {
            Console.WriteLine("Invalid selection or cannot remove default scripture.");
            return false;
        }
    }

    private Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0) return null;
        Random random = new Random();
        return _scriptures[random.Next(_scriptures.Count)];
    }

    private void RevealAllWords()
    {
        foreach (Scripture scripture in _scriptures)
        {
            Console.WriteLine(scripture.GetDisplayText());

        }

    }
}