using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

// Class: 
// Attributes: Journal
// * _entries : List<Entry>

// * Behaviors/Methods:
// * DisplayMenu() : void
// * AddEntry(Entry entry) : void
// * LoadFromFile(filename : string) : void
// * SaveToFile(filename : string) : void
// * DeleteFile(filename : string) : void

// Responsibilities:
//  Display a menu of options to the user. And allows them to add, load, save, and delete entries from a journal.


public class Journal
{
    private User _user;
    private List<Entry> _entries = new List<Entry>();


    public void DisplayMenu()
    {
        Console.WriteLine(" ");
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Write a new entry");
        Console.WriteLine(" 2. Display all entries");
        Console.WriteLine(" 3. Load entries from a file");
        Console.WriteLine(" 4. Save entries to a file");
        Console.WriteLine(" 5. Delete a file");
        Console.WriteLine(" 6. Quit");
        Console.WriteLine(" ");
        Console.Write("Select a choice from the menu: ");
        string userChoice = Console.ReadLine();

        if (userChoice == "1")
        {
            AddNewEntry();
            DisplayMenu();
        }
        else if (userChoice == "2")
        {
            DisplayEntries();
            DisplayMenu();
        }
        else if (userChoice == "3")
        {
            Console.Write("Enter the name of the file to load: ");
            string fileName = Console.ReadLine();
            LoadFromFile(fileName);
            DisplayMenu();
        }
        else if (userChoice == "4" && _entries.Count > 0)
        {
            Console.Write("Enter the name of the file to save: ");
            string fileName = Console.ReadLine();
            SaveToFile(fileName);
            DisplayMenu();
        }
        else if (userChoice == "4" && _entries.Count == 0)
        {
            Console.WriteLine("######################################################### ");
            Console.WriteLine("-- No entries found, please add an entry first :)");
            Console.WriteLine("######################################################### ");
            DisplayMenu();
        }

        else if (userChoice == "5")
        {
            DeleteFile();
            DisplayMenu();
        }
        else if (userChoice == "6")
        {
            Console.WriteLine("Exiting the program. Goodbye!");
            return;
        }
        else
        {
            Console.WriteLine("Invalid choice selection from the menu options [1-6].");
            Console.WriteLine("######################################################### ");
            DisplayMenu();
        }
    }

    // Method to add a new journal entry
    public void AddNewEntry()
    {
        // PromptGenerator promptGenerator = new PromptGenerator();
        // string questionPrompt = promptGenerator.RandomQuestion();
        //  Entry._user 
        //  Entry._date = DateTime.Now; 
        // Console.WriteLine("Journal Prompt: " + questionPrompt);
        // Console.Write("Your response: ");
        // string journalEntry = Console.ReadLine();

        // Entry newEntry = new Entry( _user, questionPrompt, journalEntry);
        // AddEntry(newEntry);



        PromptGenerator promptGenerator = new PromptGenerator();
        string questionPrompt = promptGenerator.RandomQuestion(); // Get a random question prompt
        User user = _user;
        DateTime date = DateTime.Now;
        Console.WriteLine("Journal Prompt: " + questionPrompt);
        Console.Write("Your response: ");
        string journalEntry = Console.ReadLine();

        // Create a new Entry object with the User, question prompt, journal entry, and date
        Entry newEntry = new Entry(user, date, questionPrompt, journalEntry);
        AddEntry(newEntry);

        // Console.WriteLine("######################################################### ");
        // Console.WriteLine("--Journal entry saved, remember to save it to a file.");
        // Console.WriteLine("######################################################### ");

        if (_entries.Count == 1)
        {
            Console.WriteLine("################################################################## ");
            Console.WriteLine("--Journal entry saved, remember to save your entry to a file.");
            Console.WriteLine("################################################################## ");
        }

        else
        {
            Console.WriteLine("################################################################### ");
            Console.WriteLine("--Journal entry saved, remember to save your entries to a file.");
            Console.WriteLine("################################################################### ");
        }

    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("######################################################### ");
            Console.WriteLine("-- No entries found, please add an entry first :)");
            Console.WriteLine("######################################################### ");

        }
        else
        {
            Console.WriteLine("Entries:");
            foreach (Entry entry in _entries)
            {
                entry.DisplayEntry();
            }
        }
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
        string userChoice;

        do
        {
            Console.Write("Would you like to add another entry? (y/n): ");
            userChoice = Console.ReadLine()?.ToLower();

            while (userChoice != "y" && userChoice != "yes" && userChoice != "n" && userChoice != "no")
            {
                Console.WriteLine("");
                Console.Write("> Invalid choice, please enter (Yes or No) to add another entry: ");
                userChoice = Console.ReadLine()?.ToLower();
            }

            if (userChoice == "y" || userChoice == "yes")
            {
                AddNewEntry(); // Adds a new entry if yes
                DisplayMenu(); // Break out of loop if no (shortcut)
            }
            else if (userChoice == "n" || userChoice == "no")
            {

                break; // Exits the loop if no
            }

        } while (userChoice == "y" || userChoice == "yes");
    }


    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                string[] parts = line.Split("|", StringSplitOptions.TrimEntries);
                if (parts.Length == 4)
                {
                    // Create a new User instance with the username from file
                    User user = new User();
                    user.SetUserName(parts[0]); // Make sure you have this method in your User class

                    DateTime date = DateTime.Parse(parts[1]);
                    string questionPrompt = parts[2];
                    string journalEntry = parts[3];

                    Entry entry = new Entry(user, date, questionPrompt, journalEntry);
                    _entries.Add(entry);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("######################################################### ");
            Console.WriteLine($" Loaded {_entries.Count} entries from {filename}.");
            Console.WriteLine("######################################################### ");

            DisplayEntries();
        }
        else
        {
            Console.WriteLine($"-- File {filename} does not exist.");
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{_user.GetUserName()} |{entry.GetDate()}|{entry.GetQuestionPrompt()}|{entry.GetJournalEntry()}");
            }
        }
        Console.WriteLine("######################################################### ");
        Console.WriteLine($"Journal saved to {filename}.");
        Console.WriteLine("######################################################### ");
    }



    public void DeleteFile()
    {
        Console.Write("Enter the name of the file to delete: ");
        string fileName = Console.ReadLine();
        Console.WriteLine("######################################################### ");
        Console.Write($" -- Are you sure you want to delete {fileName}? (y/n): ");
        string deleteConfirm = Console.ReadLine();
        Console.WriteLine("######################################################### ");

        if (deleteConfirm.ToLower() == "y" || deleteConfirm.ToLower() == "yes")
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                Console.WriteLine($"File {fileName} deleted.");
            }
            else
            {
                Console.WriteLine($"File {fileName} not found.");
            }
        }
        else
        {
            Console.WriteLine("File deletion canceled.");
        }
    }
}
