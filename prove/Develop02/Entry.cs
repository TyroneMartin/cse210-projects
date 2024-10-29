using System;
public class Entry
{
    private DateTime _date;
    private string _questionPrompt;
    private string _journalEntry;
    private User _userName;  // referencing user class object

    public Entry(User user, DateTime date, string questionPrompt, string journalEntry)
    {
        _userName = user;
        _date = date; // date when the Entry is created
        _questionPrompt = questionPrompt;
        _journalEntry = journalEntry;
    }


    // Display the journal entry
    public void DisplayEntry()
    {

        Console.WriteLine("User: " + _userName.GetUserName());
        Console.WriteLine($"Date: {_date.ToShortDateString()} {_date.Hour}:{_date.Minute}");
        Console.WriteLine("Prompt: " + _questionPrompt);
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
