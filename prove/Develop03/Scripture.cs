
using System;
using System.Collections.Generic;
// class: Scripture
// Attributes: 
// * _ScriptureAdded : list
// * _scriptureManager

// * Behaviors/Methods:
// * +OptionMenu() 
// * AddScripture(Scripture : scripture) : void
// * RemoveScripture(Scripture : scripture) : void
// * GetRandomScripture() : scripture
// * ReferenceId() : string

public class Scripture
{
    private List<Scripture> _ScriptureAdded;
    private ScriptureManager _scriptureManager;  // default scripture added stored in object

    public Scripture()
    {
        _ScriptureAdded = new List<Scripture>();
        _scriptureManager = new ScriptureManager("John", 3, 16, "Love",
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        InitializeDefaultScripture();
    }

    //  for adding new scriptures to the list
    public Scripture(ScriptureManager scriptureManager)
    {
        _ScriptureAdded = new List<Scripture>();
        _scriptureManager = scriptureManager;
    }

    private void InitializeDefaultScripture()
    {
        // Instead for creating a new Scripture
        _ScriptureAdded.Add(this);
    }

    public void OptionMenu()
    {
        Console.Clear();
        Console.WriteLine("=================================");
        Console.WriteLine("Scripture Memorization Program");
        Console.WriteLine("=================================");
         Console.WriteLine("");
        Console.WriteLine("1. View All Scriptures");
        Console.WriteLine("2. Add Scripture");
        Console.WriteLine("3. Practice Memorization");
        Console.WriteLine("4. Remove Existing Scripture");
        Console.WriteLine("0. Exit");
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