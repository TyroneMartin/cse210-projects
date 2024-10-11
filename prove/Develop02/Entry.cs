using System;

public class Entry
{
    private DateTime _date;
    private string _questionPrompt;
    private string _journalEntry;

    public Entry(string questionPrompt, string journalEntry)
    {
        _date = DateTime.Now;  // Automatically set the current timestamp
        _questionPrompt = questionPrompt;
        _journalEntry = journalEntry;
    }

    // Display the journal entry
    public void DisplayEntry()
    {
        Console.WriteLine("Prompt: " + _questionPrompt);
        Console.WriteLine($"Date: {_date.ToShortDateString()}");
        Console.WriteLine("Entry: " + _journalEntry);
        Console.WriteLine();
    }

    // Return the date of the entry
    public DateTime GetDate()
    {
        return _date;
    }

    // Return the question prompt
    public string GetQuestionPrompt()
    {
        return _questionPrompt;
    }

    // Return the journal entry
    public string GetJournalEntry()
    {
        return _journalEntry;
    }
}
