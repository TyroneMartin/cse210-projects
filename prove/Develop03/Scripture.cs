
using System;
using System.Collections.Generic;
// class: Scripture
// Attributes: 
// * _scriptureAdded : list
// * _scriptureManager

// * Behaviors/Methods:
// * +OptionMenu() 
// * AddScripture(Scripture : scripture) : void
// * RemoveScripture(Scripture : scripture) : void
// * GetRandomScripture() : scripture
// * ReferenceId() : string

public class Scripture
{

    private List<Scripture> _scriptureAdded;
    private ScriptureManager _scriptureManager;  // default scripture added stored in object

    public Scripture()
    {
        _scriptureAdded = new List<Scripture>();
        _scriptureManager = new ScriptureManager("John", 3, 16, "Love",
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        InitializeDefaultScripture();
    }

    //  for adding new scriptures to the list
    public Scripture(ScriptureManager scriptureManager)
    {
        _scriptureAdded = new List<Scripture>();
        _scriptureManager = scriptureManager;
    }

    private void InitializeDefaultScripture()
    {
        // Instead for creating a new Scripture
        _scriptureAdded.Add(this);
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
        _scriptureAdded.Add(scripture);
    }

    public List<Scripture> GetAllScriptures()
    {
        return _scriptureAdded;
    }

    public Scripture GetRandomScripture()
    {
        if (_scriptureAdded.Count == 0) return null;
        Random random = new Random();
        return _scriptureAdded[random.Next(_scriptureAdded.Count)];
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