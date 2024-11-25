using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class QuestTracker
{
    private List<Goal> goals;
    private int score;

    public QuestTracker()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void AddGoal(Goal goal) => goals.Add(goal);

    public void RemoveCompletedGoals()
    {
        goals = goals.Where(goal => !goal.IsComplete() || goal is EternalGoal).ToList();
    }

    public void ListGoals()
    {
        if (!goals.Any())
        {
            Console.Clear();
            Console.WriteLine("\nNo goals created yet! \nCreate a new goal to get started.\n");
            return;
        }

        Console.Clear();
        Console.WriteLine("=================");
        Console.WriteLine("List of Goals!");
        Console.WriteLine("=================");
        Console.WriteLine("\nThe goals are:");

        // Display each goal
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i]}");
        }

        int totalProgress = CalculateTotalProgress();

        DisplayProgressAnimation(totalProgress);

        Console.WriteLine($"You have {score} points.\n");
    }

    private int CalculateTotalProgress()
    {
        var validGoals = goals.Where(g => !(g is EternalGoal)).ToList();
        if (!validGoals.Any()) return 0;
        return (int)validGoals.Average(g => g.GetProgress());
    }

    private void DisplayProgressAnimation(int progress)
    {
        Console.Clear();
        Console.WriteLine("=================");
        Console.WriteLine("Loading progress!");
        Console.WriteLine("=================");

        if (!goals.Any())
        {
            Console.WriteLine("\nNo goals available. Please add goals first!\n");
            Console.Write("\nGetting progress: ");

            // Display a placeholder animation
            for (int i = 0; i < 6; i++)
            {
                Console.Write("*");
                Console.Out.Flush();
                Thread.Sleep(500);
            }

            Console.WriteLine("\n\n—> No progress to display as there are no goals.");
            return;
        }

        Console.Clear();
        Console.WriteLine("Your Goals:\n");
        for (int i = 0; i < goals.Count; i++)
        {
            string goalStatus = goals[i].IsComplete() ? "[X]" : "[ ]";
            string goalType = goals[i].GetType().Name.Replace("Goal", "");
            Console.WriteLine($"{i + 1}. {goalStatus} {goals[i]._name} ({goals[i]._description}) - {goalType}");
        }

        Console.Write("\nGetting progress: ");

        int stars = (int)((progress / 100.0) * 6);
        string animation = new string('*', stars) + new string('*', 6 - stars);

        foreach (char c in animation)
        {
            Console.Write(c);
            Console.Out.Flush();
            Thread.Sleep(500);
        }

        if (progress <= 0)
        {
            Console.WriteLine("\n\n—> Remember to complete your goals to earn points!");
        }
        else
        {
            Console.WriteLine($"\nCongrats! You've earned {progress}% completion!\n");
            Console.WriteLine($"-> Please note eternal goals are counted as completed.\n");

        }
    }



    public void RecordEvent()
    {
        // Display the list of goals
        Console.Clear();
        Console.WriteLine("=====================");
        Console.WriteLine("Record Goal Progress");
        Console.WriteLine("=====================\n");

        if (!goals.Any())
        {
            Console.WriteLine("-> No progress to record.\n");
            Console.WriteLine("-> No goals available. Please add goals first!\n");
            return;
        }

        for (int i = 0; i < goals.Count; i++)
        {
            string goalType = goals[i].GetType().Name.Replace("Goal", "");
            Console.WriteLine($"{i + 1}. {goals[i]} ({goalType})");
        }

        Console.Write("\nWhich goal did you accomplish? Enter the number: ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= goals.Count)
        {
            Goal selectedGoal = goals[choice - 1];
            int pointsEarned = selectedGoal.RecordEvent();

            if (selectedGoal is EternalGoal)
            {
                Console.WriteLine($"\nProgress recorded for Eternal Goal. You earned {pointsEarned} points.");
            }
            else if (selectedGoal.IsComplete())
            {
                Console.WriteLine($"\nGoal marked as completed! You earned {pointsEarned} points.");
            }
            else
            {
                Console.WriteLine($"\nProgress recorded! You earned {pointsEarned} points.");
            }

            score += pointsEarned;
            Console.WriteLine($"Your total score is now {score} points.\n");
        }
        else
        {
            Console.WriteLine("\nInvalid choice. Please try again.");
        }
    }


    // public void SaveProgress(string filename)
    // {
    //     if (!goals.Any())
    //     {
    //         Console.Clear();
    //         Console.WriteLine("=================");
    //         Console.WriteLine("Save Failed!");
    //         Console.WriteLine("=================\n");
    //         Console.WriteLine("-> No goals available to save! Please add a goal first.\n");
    //         return;
    //     }

    //     var data = new Dictionary<string, object>
    // {
    //     { "timestamp", DateTime.Now },
    //     { "score", score },
    //     { "goals", goals.Select(g => g.SaveEvent()).ToList() }
    // };

    //     Console.Clear();
    //     File.WriteAllText(filename, JsonSerializer.Serialize(data));
    //     Console.WriteLine($"Progress saved to {filename}");
    // }


    public void SaveProgress(string filename)
    {
        Console.Clear();
        Console.WriteLine("=================");
        Console.WriteLine("Saving Progress!");
        Console.WriteLine("=================");

        if (goals == null || !goals.Any())
        {
            Console.WriteLine("-> No goals available to save! Please add a goal first.\n");
            return;
        }

        // Prepare data for saving
        var data = new Dictionary<string, object>
    {
        { "timestamp", DateTime.Now },
        { "score", score },
        { "goals", goals.Select(g => g.SaveEvent()).ToList() }
    };

        try
        {
            File.WriteAllText(filename, JsonSerializer.Serialize(data));
            Console.WriteLine($"\nProgress saved successfully to {filename}.\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine("\n-> Error: Save Failed!");
            Console.WriteLine($"Error: {ex.Message}\n");
        }
    }
    public void LoadProgress(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"\n-> File not found for ({filename})!\n");
            return;
        }

        var data = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(File.ReadAllText(filename));
        score = data["score"].GetInt32();
        goals.Clear();

        foreach (var goalData in data["goals"].EnumerateArray())
        {
            var type = goalData.GetProperty("type").GetString();
            var name = goalData.GetProperty("name").GetString();
            var description = goalData.GetProperty("description").GetString();
            var points = goalData.GetProperty("points").GetInt32();

            Goal goal = type switch
            {
                "SimpleGoal" => CreateSimpleGoal(goalData, name, description, points),
                "EternalGoal" => CreateEternalGoal(goalData, name, description, points),
                "ChecklistGoal" => CreateChecklistGoal(goalData, name, description, points),
                _ => throw new Exception("Unknown goal type")
            };

            goals.Add(goal);
        }

        Console.WriteLine($"\n-> Progress loaded from ({filename}).\n");
    }

    private SimpleGoal CreateSimpleGoal(JsonElement goalData, string name, string description, int points)
    {
        var goal = new SimpleGoal(name, description, points);
        if (goalData.TryGetProperty("isComplete", out JsonElement isComplete) && isComplete.GetBoolean())
        {
            goal.RecordEvent(); // Mark the goal completed
        }
        return goal;
    }

    private EternalGoal CreateEternalGoal(JsonElement goalData, string name, string description, int points)
    {
        var goal = new EternalGoal(name, description, points);
        if (goalData.TryGetProperty("completeCount", out JsonElement completeCount))
        {
            int count = completeCount.GetInt32();
            for (int i = 0; i < count; i++)
            {
                goal.RecordEvent();
            }
        }
        return goal;
    }

    private CheckList CreateChecklistGoal(JsonElement goalData, string name, string description, int points)
    {
        int targetCount = goalData.GetProperty("targetCount").GetInt32();
        int bonusPoints = goalData.GetProperty("bonusPoints").GetInt32();
        var goal = new CheckList(name, description, points, bonusPoints, targetCount);

        if (goalData.TryGetProperty("currentCount", out JsonElement currentCount))
        {
            int count = currentCount.GetInt32();
            for (int i = 0; i < count; i++)
            {
                goal.RecordEvent();
            }
        }
        return goal;
    }
}
