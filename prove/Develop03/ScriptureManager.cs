// class: ScriptureManager
// Attributes: 
// *_Book : String
// *_Chapter : Int
// *_Verse : Int
// *_Category : String

// * Behaviors/Methods:
// * AddBook() 
// * AddChapter()
// * AddVerse()
// * AddCategory()
// * GetScripture() : string
// * GetCategory() : string
// * Scripture(Book: String, Chapter: Int, Verse : Int, Category: String) : void

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