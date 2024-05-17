using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}...");
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {_duration} seconds");
        ShowSpinner(3); // Pause for 3 seconds
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine($"Congratulations! You completed the {_name}.");
        Console.WriteLine($"You have completed {_duration} seconds of the game!");
        Console.WriteLine("Well done!");
        ShowSpinner(3); // Pause for 3 seconds
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds * 2; i++) // Double the duration for a smoother animation
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b");
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = 1; i <= seconds; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }
}
