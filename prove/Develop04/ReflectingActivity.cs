using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        // Add more prompts as needed
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        // Add more questions as needed
    };

    public ReflectingActivity(int duration)
        : base("Reflecting activity","Get ready....", duration)
    { }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        Console.WriteLine("Press Enter when you are ready to start answering questions...");
        Console.ReadLine();

        ShowCountDown(5); // Prepare for the follow-up questions
        DisplayQuestions();
        DisplayEndingMessage();
    }

    private void DisplayPrompt()
    {
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
    }

    private void DisplayQuestions()
    {
        Random rand = new Random();
        List<string> questionsToAsk = new List<string>(_questions);
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime && questionsToAsk.Count > 0)
        {
            string question = questionsToAsk[rand.Next(questionsToAsk.Count)];
            Console.WriteLine($"Question: {question}");
            questionsToAsk.Remove(question);
            ShowSpinner(5); 

            if (questionsToAsk.Count == 0)
            {
                // If all questions are asked, refill the list to avoid repetition in the same session
                questionsToAsk = new List<string>(_questions);
            }
        }
    }
}

