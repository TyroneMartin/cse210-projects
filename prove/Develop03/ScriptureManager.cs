// class: ScriptureManager
// Attributes: 
// * _Book : string
// * _Chapter : int
// * _Verse : int
// * _Category : string
// * _Text : string

// * Behaviors/Methods:
// * ScriptureManager(string book, int chapter, int verse, string category, string text)
// * GetReference() : string
// * GetCategory() : string
// * GetText() : string
// * ToString() : string


public class ScriptureManager
{
    private string _Book;
    private int _Chapter;
    private int _Verse;
    private string _Category;
    private string _Text;

    public ScriptureManager(string book, int chapter, int verse, string category, string text)
    {
        _Book = book;
        _Chapter = chapter;
        _Verse = verse;
        _Category = category;
        _Text = text;
    }

    public string GetReference()
    {
        return $"{_Book} {_Chapter}:{_Verse}";
    }

    public string GetCategory()
    {
        return _Category;
    }

    public string GetText()
    {
        return _Text;
    }

    public override string ToString()
    {
        return $"{GetReference()} - {_Text}";
    }
}