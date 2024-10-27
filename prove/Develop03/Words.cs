// class: Words
// Attributes: 
// *_HideWord : string
// *_ShowWord : string

// * Behaviors/Methods:
// * HideWord()
// * ShowWord() 

public class Words
{
    private List<string> _Words;
    private List<bool> _IsHidden;
    private Random _Random;
    private int _RemainingWords;

    public Words(string text)
    {
        _Words = text.Split(' ').ToList();
        _IsHidden = new List<bool>(_Words.Count);
        _Random = new Random();
        _RemainingWords = _Words.Count;
        
        // Initialize all words as visible
        for (int i = 0; i < _Words.Count; i++)
        {
            _IsHidden.Add(false);
        }
    }

    public bool HideRandomWord()
    {
        if (_RemainingWords == 0) return false;

        int attempts = 0;
        while (attempts < _Words.Count)
        {
            int index = _Random.Next(_Words.Count);
            if (!_IsHidden[index])
            {
                _IsHidden[index] = true;
                _RemainingWords--;
                return true;
            }
            attempts++;
        }
        return false;
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        for (int i = 0; i < _Words.Count; i++)
        {
            displayWords.Add(_IsHidden[i] ? new string('_', _Words[i].Length) : _Words[i]);
        }
        return string.Join(" ", displayWords);
    }

    public bool CheckWord(string guess, out string hint)
    {
        hint = "";
        for (int i = 0; i < _Words.Count; i++)
        {
            if (_IsHidden[i] && _Words[i].Equals(guess, StringComparison.OrdinalIgnoreCase))
            {
                _IsHidden[i] = false;
                return true;
            }
        }
        
        // Provide hint for the first hidden word
        for (int i = 0; i < _Words.Count; i++)
        {
            if (_IsHidden[i])
            {
                hint = $"Hint: The word starts with '{_Words[i][0]}' and has {_Words[i].Length} letters";
                break;
            }
        }
        return false;
    }

    public bool IsCompleted()
    {
        return _RemainingWords == 0;
    }
}