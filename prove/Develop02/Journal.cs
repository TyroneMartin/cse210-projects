using System;
using System.Collections.Generic;
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
        else if (userChoice == "4")
        {
            Console.Write("Enter the name of the file to save: ");
            string fileName = Console.ReadLine();
            SaveToFile(fileName);
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
            Console.WriteLine("######################################################### ");
            Console.WriteLine("Invalid choice selection from the menu options [1-6].");
            Console.WriteLine("######################################################### ");
            DisplayMenu();
        }
    }

    // Method to add a new journal entry
    private void AddNewEntry()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string questionPrompt = promptGenerator.RandomQuestion();

        Console.WriteLine("Journal Prompt: " + questionPrompt);
        Console.Write("Your response: ");
        string journalEntry = Console.ReadLine();

        Entry newEntry = new Entry(questionPrompt, journalEntry);
        AddEntry(newEntry);

        Console.WriteLine("Journal entry saved.");
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found, please add an entry first :)");
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
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            // _entries.Clear();  // Clear current entries
            foreach (var line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 2)
                {
                    Entry entry = new Entry(parts[0], parts[1]);
                    _entries.Add(entry);
                }
            }

            Console.WriteLine($"Loaded {_entries.Count} entries from {filename}.");
            DisplayEntries();
        }
        else
        {
            Console.WriteLine($"File {filename} does not exist.");
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry.GetQuestionPrompt()}|{entry.GetJournalEntry()}");
            }
        }

        Console.WriteLine($"Journal saved to {filename}.");
    }

    private void DeleteFile()
    {
        Console.Write("Enter the name of the file to delete: ");
        string fileName = Console.ReadLine();
        Console.Write($"Are you sure you want to delete {fileName}? (y/n): ");
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
