// class: Words
// Attributes: 
// *_words : list
// *_isHidden : list
// *_Random : random
// *_remainingWords : int

// * Behaviors/Methods:
// * HideRandomWord() : bool
// * GetDisplayText() 
// * IsCompleted() : bool
// * CheckWord(string : guess, out string : hint) : bool


public class Words
{
    private List<string> _words;
    private List<bool> _isHidden;
    private Random _random;
    private int _remainingWords;

    public Words(string text)
    {
        _words = text.Split(' ').ToList();
        _isHidden = new List<bool>(_words.Count);
        _random = new Random();
        _remainingWords = _words.Count;

        // Initialize all words as visible
        for (int i = 0; i < _words.Count; i++)
        {
            _isHidden.Add(false);
        }
    }

    public bool HideRandomWord()
    {
        if (_remainingWords == 0) return false;

        int attempts = 0;
        while (attempts < _words.Count)
        {
            int index = _random.Next(_words.Count);
            if (!_isHidden[index])
            {
                _isHidden[index] = true;
                _remainingWords--;
                return true;
            }
            attempts++;
        }
        return false;
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        for (int i = 0; i < _words.Count; i++)
        {
            displayWords.Add(_isHidden[i] ? new string('_', _words[i].Length) : _words[i]);
        }
        return string.Join(" ", displayWords);
    }

    public bool CheckWord(string guess, out string hint)
    {
        hint = "";
        for (int i = 0; i < _words.Count; i++)
        {
            if (_isHidden[i] && _words[i].Equals(guess, StringComparison.OrdinalIgnoreCase))
            {
                _isHidden[i] = false;
                return true;
            }
        }

        // Provide hint for the first hidden word
        for (int i = 0; i < _words.Count; i++)
        {
            if (_isHidden[i])
            {
                hint = $"Hint: The word starts with '{_words[i][0]}' and has {_words[i].Length} letters";
                break;
            }
        }
        return false;
    }

    public bool IsCompleted()
    {
        return _remainingWords == 0;
    }
}