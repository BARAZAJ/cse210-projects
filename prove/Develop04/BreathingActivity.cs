using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) 
        : base(" Breathing activity", ".......", duration) 
    { }

    public void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration; i += 5)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3); // Count down from 5
            Console.WriteLine("Breathe out...");
            ShowCountDown(3); // Count down from 5
        }
        DisplayEndingMessage();
    }
}
