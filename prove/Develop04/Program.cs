using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new BreathingActivity(),
            new ReflectionActivity(),
            new ListingActivity()
        };

        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("======================================");
            Console.WriteLine("Welcome to the Mindfulness  Program");
            Console.WriteLine("======================================");
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflection activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("\nSelect a choice from the menu: ");

            string choice = Console.ReadLine();
            Console.Clear();

            if (choice == "4")
            {
                running = false;
                continue;
            }

            if (int.TryParse(choice, out int index) && index >= 1 && index <= 3)
            {
                activities[index - 1].Run();
            }
            else
            {
                Console.WriteLine("Invalid option selected. Please try again.");
                Console.WriteLine("(select a number between 1 and 4).\n");
                // Console.WriteLine("Press any key to continue...");
                // Console.ReadKey();
                Thread.Sleep(1000); 

            }
        }
    }



}
