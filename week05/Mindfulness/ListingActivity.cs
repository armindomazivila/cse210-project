using System;
using System.Collections.Generic;


public class ListingActivity : Activity
{

    private List<string> _prompts;


    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can.")
    {

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }


    public void Run()
    {
        Start();


        Random random = new Random();

        Console.WriteLine();

        Console.WriteLine(
            _prompts[random.Next(_prompts.Count)]
        );


        Console.WriteLine();
        Console.WriteLine("Start thinking...");
        Countdown(5);


        Console.WriteLine();
        Console.WriteLine("Begin listing:");

        List<string> items = new List<string>();


        DateTime end = DateTime.Now.AddSeconds(GetDuration());


        while (DateTime.Now < end)
        {
            Console.Write("> ");

            string item = Console.ReadLine();

            if (item != "")
            {
                items.Add(item);
            }
        }


        Console.WriteLine();
        Console.WriteLine(
            $"You listed {items.Count} items!"
        );


        End();
    }
}