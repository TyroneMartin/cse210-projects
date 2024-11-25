using System;

public class CheckList : Goal
{
    private int _bonusPoints;
    private int _targetCount;
    private int _currentCount;

    public CheckList(string name, string description, int points, int bonusPoints, int targetCount)
        : base(name, description, points)
    {
        // if (targetCount <= 0)
        // {
        //     throw new ArgumentException("Target count must be greater than zero.");
        // }

        _bonusPoints = bonusPoints;
        _targetCount = targetCount;
        _currentCount = 0;
    }


    public override bool IsComplete() => _currentCount >= _targetCount;

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            _currentCount++;
            if (IsComplete())
                return _points + _bonusPoints;
            return _points;
        }
        return 0;
    }

    public override int GetProgress()
    {
        return (int)((float)_currentCount / _targetCount * 100);
        // return (_currentCount * 100) / _targetCount;
    }

    public override Dictionary<string, object> SaveEvent()
    {
        var data = base.SaveEvent();
        data.Add("targetCount", _targetCount);
        data.Add("bonusPoints", _bonusPoints);
        data.Add("currentCount", _currentCount);
        return data;
    }

    public override string ToString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_name} ({_description}) -- Currently completed: {_currentCount}/{_targetCount}";
    }
}