using System;
public class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isCompleted = false;
    }

    public override bool IsComplete() => _isCompleted;

    public override int RecordEvent()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            return _points;
        }
        return 0;
    }

    public override int GetProgress()
    {
        return _isCompleted ? 100 : 0;
    }

    public override Dictionary<string, object> SaveEvent()
    {
        var data = base.SaveEvent();
        data.Add("isComplete", _isCompleted);
        return data;
    }
}
