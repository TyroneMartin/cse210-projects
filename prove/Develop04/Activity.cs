using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public abstract void Run();

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Well done!");
        Spinner(3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        Spinner(3);
    }

    public void Spinner(int seconds)
    {
        // or https://video.byui.edu/media/t/1_soxhacuf
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[i]);
            Thread.Sleep(250);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("");
            i = (i + 1) % animationStrings.Count;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rYou may begin in: {i} seconds"); // \r is used to overwrite line
            Thread.Sleep(1000);
        }

        Console.Write("\r                            "); // clear the line
        Console.WriteLine(); 
    }

    public int GetDuration()
    {
        return _duration;
    }
}
