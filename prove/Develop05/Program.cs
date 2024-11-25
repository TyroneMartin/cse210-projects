using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        var tracker = new QuestTracker();
        Console.Clear();

        while (true)
        {
            Console.WriteLine("======================================");
            Console.WriteLine("The QuestTracker Program");
            Console.WriteLine("======================================\n");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event a Goal completion");
            Console.WriteLine("6. Remove Completed Goals");
            Console.WriteLine("7. Quit");
            Console.Write("\nSelect a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(tracker);
                    break;
                case "2":
                    tracker.ListGoals();
                    break;
                case "3":
                    Console.Write("Enter filename to save progress: ");
                    string saveFilename = Console.ReadLine();
                    tracker.SaveProgress(saveFilename);
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("===================");
                    Console.WriteLine("Search for a file!");
                    Console.WriteLine("===================");
                    Console.Write("\n     Enter filename to load progress: ");
                    string loadFilename = Console.ReadLine();
                    tracker.LoadProgress(loadFilename);
                    break;
                case "5":
                    tracker.RecordEvent();
                    break;
                case "6":
                    Console.Clear();
                    tracker.RemoveCompletedGoals();
                    Console.WriteLine(">>>>>>>>>>>>>>>>");
                    Console.WriteLine("----Note----\n<<<<<<<<<<<<<<<<");
                    Console.WriteLine("\n-> Completed goals have been removed. (Except Eternal Goals)");
                    Console.WriteLine("-> Points will roll over to continue your progress.\n");
                    break;
                case "7":
                    Console.WriteLine("Goodbye! Thank you for using the Goal Tracker!");
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void CreateGoal(QuestTracker tracker)
    {
        Console.Clear();
        Console.WriteLine("=================");
        Console.WriteLine("Create a New Goal!");
        Console.WriteLine("=================\n");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("\nChoose a goal type you want to create: ");
        string goalType = Console.ReadLine();

        Console.Write("\n-> Enter the goal name: ");
        string name = Console.ReadLine();

        Console.Write("\n-> Enter a short description: ");
        string description = Console.ReadLine();

        Console.Write("\n-> Enter the points associated: ");
        int points = int.Parse(Console.ReadLine());
        Console.Clear();

        switch (goalType)
        {
            case "1":
                tracker.AddGoal(new SimpleGoal(name, description, points));
                break;
            case "2":
                tracker.AddGoal(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("-> Enter the target count, or number of times to complete this goal? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("-> Enter the bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                tracker.AddGoal(new CheckList(name, description, points, bonus, target));
                break;
            default:
                Console.WriteLine("Invalid choice entered.\n");
                break;
        }
    }
}
