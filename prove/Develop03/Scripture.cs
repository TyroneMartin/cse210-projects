
using System;
using System.Collections.Generic;
// class: Scripture
// Attributes: 
// * _DefaultScripture : string
// * _ScriptureList : List<string>

// * Behaviors/Methods:
// * +OptionMenu() 
// * AddScripture(Scripture : scripture) : void
// * RemoveScripture(Scripture : scripture) : void
// * GetRandomScripture() : scripture
// * ReferenceId() : string


public class Scripture
{
    private List<Scripture> _ScriptureAdded;
    private ScriptureManager _scriptureManager;
    private string _DefaultScriptureVerse;

    public Scripture()
    {
        _ScriptureAdded = new List<Scripture>();
        _scriptureManager = new ScriptureManager("John", 3, 16, "Gospel", 
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        AddDefaultScripture();
    }

    private void AddDefaultScripture()
    {
        Scripture defaultScripture = new Scripture();
        defaultScripture._scriptureManager = _scriptureManager;
        _ScriptureAdded.Add(defaultScripture);
    }

    public void OptionMenu()
    {
        Console.Clear();
        Console.WriteLine("Scripture Memorization Program");
        Console.WriteLine("1. View All Scriptures");
        Console.WriteLine("2. Add Scripture");
        Console.WriteLine("3. Practice Memorization");
        Console.WriteLine("4. Exit");
    }

    public void AddEntry(Scripture scripture)
    {
        _ScriptureAdded.Add(scripture);
    }

    public List<Scripture> GetAllScriptures()
    {
        return _ScriptureAdded;
    }

    public Scripture GetRandomScripture()
    {
        if (_ScriptureAdded.Count == 0) return null;
        Random random = new Random();
        return _ScriptureAdded[random.Next(_ScriptureAdded.Count)];
    }

    public ScriptureManager GetScriptureManager()
    {
        return _scriptureManager;
    }

    public override string ToString()
    {
        return _scriptureManager.ToString();
    }
}
