using System;
using System.Collections.Generic;

public class GuestTracker
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GuestTracker(List<Goal> goals, int score)
    {
        _goals = goals;
        _score = score;
    }

    public void AddGoals(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ListGoals()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.ToString());
        }
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }

    public void SetGoals(List<Goal> goals)
    {
        _goals = goals;
    }

    // public int GetScore()
    // {
    //     return _score;
    // }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void SaveProgress()
    {

    }

    public void LoadProgress()
    {

    }

}
