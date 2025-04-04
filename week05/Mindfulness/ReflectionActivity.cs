using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?"
    };

    public ReflectionActivity() : base(
        "Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(30);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(_questions[random.Next(_questions.Count)]);
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}