using System;

public class CheckList : Goal
{
    private int _bonusPoints;
    private int _targetCount;
    private int _currentCount;

    public CheckList(string name, string description, int points, int bonusPoints, int targetCount, int currentCount)
        : base(name, description, points)
    {
        if (targetCount <= 0)
        {
            throw new ArgumentException("Target count must be greater than zero.");
        }

        _bonusPoints = bonusPoints;
        _targetCount = targetCount;
        _currentCount = currentCount;
    }

    public override void RecordEvent()
    {
        if (IsComplete())
        {
            Console.WriteLine("Checklist is already complete. No more events can be recorded.");
        }
        else
        {
            _currentCount++;
            Console.WriteLine($"Event recorded. Current count: {_currentCount}/{_targetCount}");
        }
    }

    // public override string GetProcess()
    // {
    //     return $"Progress: {_currentCount}/{_targetCount}";
    // }

    // public override bool IsComplete()
    // {
    //     return _currentCount >= _targetCount;
    // }

    // public override string GetProcess()
    // {
    //     return $"Checklist process: Complete {_targetCount} tasks to receive {_bonusPoints} bonus points.";
    // }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
}
