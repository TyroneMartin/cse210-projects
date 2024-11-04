using System;

class Program
{
    static void Main(string[] args)
    {
        ScriptureManager scripture = new ScriptureManager();
        bool isRunning = true;

        while (isRunning)
        {
            Console.Clear();
            DisplayMenu();
            Console.Write("\nSelect an option (1-4) or type '0' to exit: ");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    scripture.ViewAllScriptures();
                    break;
                case "2":
                    scripture.AddNewScripture();
                    break;
                case "3":
                    scripture.PracticeMemorization();
                    break;
                case "4":
                    scripture.RemoveScripture();
                    break;
                case "0":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("=================================");
        Console.WriteLine("Scripture Memorization Program");
        Console.WriteLine("=================================");
        Console.WriteLine("");
        Console.WriteLine("1. View All Scriptures");
        Console.WriteLine("2. Add New Scripture");
        Console.WriteLine("3. Practice Memorization");
        Console.WriteLine("4. Remove Scripture");
        Console.WriteLine("0. Exit");
    }
}
