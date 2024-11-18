using System;

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

    public void SaveEvent()
    {
        return; // To be implemented
    }

    public abstract void RecordEvent();

    public abstract float GetProcess();

    public abstract bool IsComplete();
}
