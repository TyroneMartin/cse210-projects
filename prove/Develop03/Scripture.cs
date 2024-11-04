using System;
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private string _category;
    private Random _random;
    private const int GROUP_WORDS = 3;

    public Scripture(string book, int chapter, int verse, string category, string text)
    {
        _reference = new Reference(book, chapter, verse);
        _category = category;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
        _random = new Random();
    }

    //  public bool HideRandomWord()
    //     {
    //         if (_RemainingWords == 0) return false;

    //         int attempts = 0;
    //         while (attempts < _Words.Count)
    //         {
    //             int index = _Random.Next(_Words.Count);
    //             if (!_IsHidden[index])
    //             {
    //                 _IsHidden[index] = true;
    //                 _RemainingWords--;
    //                 return true;
    //             }
    //             attempts++;
    //         }
    //         return false;
    //     }


    public bool HideRandomWordGroup()
    {
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        if (visibleWords.Count == 0) return false; // No words left to hide

        int wordsToHide = Math.Min(GROUP_WORDS, visibleWords.Count);
        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex = _random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex);
        }
        return true;
    }

    public void RevealAllWords()
    {
        foreach (var word in _words)
        {
            word.Show(); // Make each word visible
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference}\n{string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
    }

    public bool CheckWord(string guess, out string hint)
    {
        hint = "";
        var hiddenWords = _words.Where(w => w.IsHidden()).ToList();

        foreach (var word in hiddenWords)
        {
            if (word.CheckWord(guess))
            {
                word.Show();
                return true;
            }
        }

        if (hiddenWords.Any())
        {
            hint = hiddenWords.First().GetHint();
        }
        return false;
    }

    public bool IsCompleted()
    {
        return !_words.Any(w => w.IsHidden());
    }

    public string GetCategory()
    {
        return _category;
    }

    public override string ToString()
    {
        return $"{_reference} (Category: {_category})\n{string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
    }
}
