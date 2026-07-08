using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts;
    private Random _random;
    private string _lastPrompt;

    public PromptGenerator()
    {
        _random = new Random();
        _lastPrompt = string.Empty;

        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today",
            "What was  the most part of my day",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What made me smile today?",
            "What am I grateful for today?",
            "What is something I learned today?",
            "What is something I would like to improve?"
        };
    }

    public string GetRandomPrompt()
    {
        string prompt;

        do
        {
            prompt = _prompts[_random.Next(_prompts.Count)];
        }
        while (_prompts.Count > 1 && prompt == _lastPrompt);

        _lastPrompt = prompt;
        return prompt;
    }
}