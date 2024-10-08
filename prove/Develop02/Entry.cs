

// Class: 
// Attributes:  
// * _date : DateTime
// * _questionPrompt : string
// * _journalEntry : string

// * Behaviors/Methods:
// * DisplayEntry() : void
// * GetDate() : DateTime
// * GetQuestionPrompt() : string
// * GetJournalEntry() : string


// Responsibilities:
//  All the user to create an entry for the journal.

public class Entry 
{
    private DateTime _date;
    private string _questionPrompt;
    private string _journalEntry;

    public void DisplayEntry() 
    {
        Console.WriteLine($"Date-{_date}: {_questionPrompt}");
        Console.WriteLine($"Entry: {_journalEntry}");
    }

    public DateTime GetDate() 
    {
        return _date;
    }

    public string GetQuestionPrompt() 
    {
        return _questionPrompt;
    }

    public string GetJournalEntry() 
    {
        return _journalEntry;
    }


        public Entry(string questionPrompt, string journalEntry) 
    {
        _date = DateTime.Now;  // Automatically set the timestamp
        _questionPrompt = questionPrompt;
        _journalEntry = journalEntry;
    }








}











// public Entry(DateTime date, String questionPrompt, String journalEntry) {
//     this.date = date;
//     this.questionPrompt = questionPrompt;
//     this.journalEntry = journalEntry;
// }



// public class Entry {
//     private DateTime date;
//     private String questionPrompt;
    
//     public Entry(DateTime date, String questionPrompt) {
//         // 'this' distinguishes the instance variable from the parameter
//         this.date = date;
//         this.questionPrompt = questionPrompt;
//     }
// }
