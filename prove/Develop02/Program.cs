using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the User
        User user = new User();
        user.InitializeUser(); // get user name
        user.DisplayUserName();
        // Pass  user instance to the Journal
        Journal journal = new Journal(user);
        journal.DisplayMenu(); // display menu
    }
}
