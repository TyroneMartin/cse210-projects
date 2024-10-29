public class User
{
    private string _userName;

    public User()
    {
        Console.Clear();
        Console.WriteLine("============================");
        Console.WriteLine("Welcome to the e-journal!");
        Console.WriteLine("============================");
        Console.WriteLine("");
    }

    public void InitializeUser()
    {
        Console.Write("Please enter your name: ");
        _userName = Console.ReadLine();

        if (string.IsNullOrEmpty(_userName))
        {
            Console.WriteLine("User name cannot be empty. Please try again.");
            InitializeUser(); // if the name is empty it ask user again
        }
    }

    public string GetUserName()
    {
        return _userName;
    }

    public string SetUserName()
    {
        return _userName;
    }

    public void DisplayUserName()
    {
        Console.WriteLine($"Hello, {_userName}, please choose from the options below:");
    }
}

