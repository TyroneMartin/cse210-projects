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
        Console.Write("Select a choice from the menu: ");
        string userChoice = Console.ReadLine();

         if (userChoice == "1")
        {
            Entry entry = new Entry("questionPrompt", "journal entry"); // Create a new entry object
            entry.GetDate();
            entry.GetQuestionPrompt();
            entry.GetJournalEntry();
            AddEntry(entry);
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
            Console.Write("Enter the name of the file to save: ");
            string fileName = Console.ReadLine();
            Console.WriteLine(" ");
            SaveToFile(fileName);
            DisplayMenu();
        }
        else if (userChoice == "5")
        {
            Console.WriteLine("Enter the name of the file to delete: ");
            string fileName = Console.ReadLine();
            Console.WriteLine("############################################################# ");
            Console.WriteLine($"Are you sure you want to delete this {fileName} file? (y/n)");
            string confirm = Console.ReadLine();
            Console.WriteLine("############################################################# ");

            if (fileName.Length > 0 && confirm.ToLower() == "yes" || confirm.ToLower() == "y") // check if file exists
            {
                Console.WriteLine($"File {fileName} deleted.");
                DeleteFile(fileName);
                Console.WriteLine(" ");
                DisplayMenu();

            }

            else if (confirm.ToLower() == "no" || confirm.ToLower() == "n")
            {
                Console.WriteLine(" ");
                Console.WriteLine($"File {fileName} not deleted.");
                DisplayMenu();

            }

            else
            {
                Console.WriteLine("############################################################# ");
                Console.WriteLine("Invalid choice. Please try again. \"Yes\" or \"No\" to confirm.");
                Console.WriteLine("############################################################# ");
                DisplayMenu();
            }
            DisplayMenu();
        }
        else if (userChoice == "6")
        {
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
    
    
    
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }


    public void LoadFromFile(string filename)
    {
        // Load entries from the specified file

        return;

    }

    public void SaveToFile(string filename)
    {
        // Save entries to the specified file

       return;
    }

    public void DeleteFile(string filename)
    {
        // Delete the specified file

        return;

    }

}
