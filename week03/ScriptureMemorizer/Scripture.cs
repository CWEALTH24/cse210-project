using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Reuse one Random object for the entire class
    private static Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        string text = "";

        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return $"{_reference.GetDisplayText()} {text.Trim()}";
    }

    public void HideRandomWords()
    {
        int hiddenCount = 0;

        while (hiddenCount < 3 && !IsCompletelyHidden())
        {
            int index = _random.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }

    // Creativity feature
    public int GetHiddenWordCount()
    {
        int count = 0;

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                count++;
            }
        }

        return count;
    }

    // Creativity feature
    public int GetTotalWordCount()
    {
        return _words.Count;
    }
}