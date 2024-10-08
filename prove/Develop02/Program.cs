using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Get the user's name name and welcome them to the e-journal.
        User user = new User();  
        user.DisplayUserName();  // maybe write a if statement to check if user exists

        // add menu options here, ie AddEntry, LoadFromFile, SaveToFile, DeleteFile
        Journal journal = new Journal();
        journal.DisplayMenu();

       




        // journal.DisplayEntries();





  


    }
}
