using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
// Class: 
// Attributes:  
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
     
     /// Add entry
            DisplayMenu();
        
        }
        else if (userChoice == "2")
        {
            DisplayEntries();
            DisplayMenu();
        }
        else if (userChoice == "3")
        {
        
        Console.WriteLine("Enter the name of the file to load: ");
        string fileName = Console.ReadLine();

        if (fileName.Length > 0 && fileName.ToLower() != "quit")
        {
            // Need to complete LoadFromFile() 
            Console.WriteLine($"Loading your journal entries from {fileName}."); 
            LoadFromFile(fileName);  // check if file name is valid
        }
        else if (fileName.ToLower() == "quit")
        {
            return;  // Exit the function if the user types "quit"
        }
        else
        {
            Console.WriteLine("############################################################# ");
            Console.WriteLine("Invalid file name. Please try again. Or type 'quit' to exit.");
            fileName = Console.ReadLine(); 
            Console.WriteLine("############################################################# ");
            if (fileName.ToLower() == "quit")
            {
                return;  // Exit function if user types "quit"
            }
            else
            {
                Console.WriteLine("############################################################# ");
                Console.WriteLine($"Loading your journal entries from {fileName}.");
                LoadFromFile(fileName);
                Console.WriteLine("############################################################# ");

            }
        }

        DisplayMenu();  // Show the menu once file is loaded or if the user quits program


        }
        else if (userChoice == "4")
        {
            SaveToFile("filename");  // Save entries to "filename");
            DisplayMenu();
        }
        else if (userChoice == "5")
        {
            DeleteFile();
            DisplayMenu();
        }
        else if (userChoice == "6")
        {
            return;  // Exit the program
        }
        else
        {
            Console.WriteLine("######################################################### ");
            Console.WriteLine("Invalid choice selection from the menu options [1-6].");
            Console.WriteLine("######################################################### ");

            DisplayMenu();
        }
    
    }


    public void DisplayEntries()
    {

        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found, please add an entry first :)");
            return;
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
            // _entries.Clear(); 

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
        Console.WriteLine("######################################################### ");
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
