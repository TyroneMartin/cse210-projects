// Class: User
// Attributes:  
// * _userName: string

// * Behaviors/Methods:
// * GetUserName() : string
// * SetUserName(string userName) : void
// * DisplayUserName() : void

// Responsibilities:
//  Allows the user to enter their name.


class User
{
    private string _userName;

    public User()
    {
        _userName = GetUserName();  // Set username as an object
    }

    public string GetUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();  // Returns the inputted name
    }

    public void SetUserName(string userName)
    {
        _userName = userName;  // Set the private variable to the passed-in value
    }

    public void DisplayUserName()
    {
        Console.WriteLine("");
        Console.WriteLine($"Hello, {_userName}, welcome to the e-journal!");
    }
}