using System;
using System.Collections.Generic;


public class ReflectionActivity : Activity
{

    private List<string> _prompts;
    private List<string> _questions;


    public ReflectionActivity()
        : base(
            "Reflection Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {

        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };


        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different?",
            "What did you learn about yourself?",
            "How can you keep this experience in mind?"
        };
    }


    public void Run()
    {
        Start();


        Random random = new Random();


        Console.WriteLine();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);

        ShowSpinner(3);


        DateTime end = DateTime.Now.AddSeconds(GetDuration());


        while (DateTime.Now < end)
        {
            Console.WriteLine();

            Console.WriteLine(
                _questions[random.Next(_questions.Count)]
            );

            ShowSpinner(5);
        }


        End();
    }
}