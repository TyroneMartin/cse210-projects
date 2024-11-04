// class: ScriptureManager
// Attributes: 
// * _book : string
// * _chapter : int
// * _verse : int
// * _category : string
// * _text : string

// * Behaviors/Methods:
// * ScriptureManager(string book, int chapter, int verse, string category, string text)
// * GetReference() : string
// * GetCategory() : string
// * GetText() : string
// * ToString() : string


public class ScriptureManager
{
    private string _book;
    private int _chapter;
    private int _verse;
    private string _category;
    private string _text;

    public ScriptureManager(string book, int chapter, int verse, string category, string text)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _category = category;
        _text = text;
    }

    public string GetReference()
    {
        return $"{_book} {_chapter}:{_verse}";
    }

    public string GetCategory()
    {
        return _category;
    }

    public string GetText()
    {
        return _text;
    }

    public override string ToString()
    {
        return $"{GetReference()} - {_text}";
    }
}