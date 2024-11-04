using System;
public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }

    public bool CheckWord(string guess)
    {
        return _text.Equals(guess, StringComparison.OrdinalIgnoreCase);
    }

    public string GetHint()
    {
        // return $"Starts with '{_text[0]}' and has {_text.Length} letters and ends with '{_text[_text.Length - 1]}'";
    return _text.Length > 2 
    ? $"Starts with '{_text[0]}' and has {_text.Length} letters and ends with '{_text[_text.Length - 1]}'"
    : $"Starts with '{_text[0]}' and has {_text.Length} letters";

    
    }
}
