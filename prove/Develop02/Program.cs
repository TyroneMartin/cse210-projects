using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the User
        User user = new User();
        user.DisplayUserName();  // Display the user's name

        // Create an instance of the Journal
        Journal journal = new Journal();

        // Display the journal menu
        journal.DisplayMenu();
    }
}
