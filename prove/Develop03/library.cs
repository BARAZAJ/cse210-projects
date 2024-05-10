using System;
using System.Collections.Generic;

public class Library
{
    private List<Scripture> _scriptures;
    private Random _random;

    public Library()
    {
        _scriptures = new List<Scripture>();
        _random = new Random();
    }

    public void AddScripture(Reference reference, string text)
    {
        var scripture = new Scripture(reference, text);
        _scriptures.Add(scripture);
    }

    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0)
            return null;

        return _scriptures[_random.Next(_scriptures.Count)];
    }
}
