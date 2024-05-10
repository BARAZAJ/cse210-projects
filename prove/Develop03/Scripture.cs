using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public IReadOnlyList<Word> Words => _words.AsReadOnly();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetDisplayText());
        foreach (var word in _words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }

    public bool HideRandomWord()
    {
        var visibleWords = _words.Where(word => !word.IsHidden).ToList();
        if (visibleWords.Count == 0)
            return false; // No more words to hide

        var random = new Random();
        var wordToHide = visibleWords[random.Next(visibleWords.Count)];
        wordToHide.Hide();
        return true;
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden);
    }
}
