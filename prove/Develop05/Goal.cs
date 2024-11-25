using System;
using System.Dynamic;

public abstract class Goal
{
    public string _name;
    public int _points;
    public string _description;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // public string GetName()
    // {
    //     return _name;
    // }

    //   public string  SetName()
    // {
    //     return _name;
    // }

    public abstract int RecordEvent();

    public abstract int GetProgress();

    public abstract bool IsComplete();


    public virtual string MenuOption()
    {
        return $"{_name} ({_description})";
    }

    public virtual Dictionary<string, object> SaveEvent()
    {
        return new Dictionary<string, object>
        {
            { "type", GetType().Name },
            { "name", _name },
            { "description", _description },
            { "points", _points }
        };
    }

    public override string ToString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_name} ({_description})";
    }
}
