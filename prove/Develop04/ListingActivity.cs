using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        // Add more prompts as needed
    };

    private int _count;

    public ListingActivity(int duration) 
        : base("Listing Activity", ".......", duration) 
    { }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        List<string> userResponses = GetListFromUser();
        _count = userResponses.Count;
        Console.WriteLine($"Number of items listed: {_count}");
        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        ShowCountDown(5); // Give them 5 seconds to prepare
    }

    private List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            if (!string.IsNullOrEmpty(response))
            {
                responses.Add(response);
            }
        }
        return responses;
    }
}
