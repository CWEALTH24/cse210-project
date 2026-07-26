using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "What is something that made you smile today?",
        "Who are you thankful for and why?",
        "What is one blessing in your life?",
        "What is something beautiful you noticed recently?",
        "What is an accomplishment you are grateful for?"
    };

    private Random _random = new Random();

    public GratitudeActivity()
        : base(
            "Gratitude Activity",
            "This activity helps you focus on the positive things in your life by thinking about something you are grateful for.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("Think about the following prompt:");
        Console.WriteLine();

        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine();
        Console.WriteLine("Take a moment to think...");
        ShowSpinner(GetDuration());

        Console.WriteLine();
        Console.WriteLine("Thank you for taking time to practice gratitude!");

        DisplayEndingMessage();
    }
}