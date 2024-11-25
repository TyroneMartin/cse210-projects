using System;
public class EternalGoal : Goal
{
    private int _completeCount;

    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _completeCount = 0;
    }

    public override bool IsComplete() => false;

    public override int RecordEvent()
    {
        _completeCount++;
        return _points;
    }

    public override int GetProgress()
    {
        return -1;
    }



    public override Dictionary<string, object> SaveEvent()
    {
        var data = base.SaveEvent();
        data.Add("completeCount", _completeCount);
        return data;
    }

    public override string ToString()
    {
        return $"[ ] {_name} ({_description}) -- Completed {_completeCount} times";
    }

}