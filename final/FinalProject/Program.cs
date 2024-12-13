class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("============================================");
        Console.WriteLine("Welcome to the Basic Calculator Program!");
        Console.WriteLine("============================================");
        Console.WriteLine("\nInstructions:");
        Console.WriteLine("1. Enter a number.");
        Console.WriteLine("2. Choose an operator.");
        Console.WriteLine("3. Enter another number.");
        Console.WriteLine("4. Continue calculations or return to the main menu.");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();

        var calculator = new Calculator(0);
        var helper = new CalculatorHelper(calculator);
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("\nMain Menu Options:");
            Console.WriteLine("1. Start New Calculation");
            Console.WriteLine("2. View Calculation History");
            Console.WriteLine("3. Clear History");
            Console.WriteLine("4. Quit");
            Console.Write("\nSelect an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    helper.PerformCalculations();
                    break;
                case "2":
                    helper.DisplayHistory();
                    break;
                case "3":
                    calculator.Reset();
                    Console.WriteLine("History cleared! Press any key to return to the menu.");
                    Console.ReadKey();
                    break;
                case "4":
                    running = false;
                    Console.Clear();
                    Console.WriteLine("Thanks for using the calculator! Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
