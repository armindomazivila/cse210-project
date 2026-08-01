using System;

public class BreathingActivity : Activity
{

    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }


    public void Run()
    {
        Start();

        int elapsed = 0;

        while (elapsed < GetDuration())
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            Countdown(4);

            elapsed += 4;

            Console.WriteLine();
            Console.Write("Breathe out...");
            Countdown(4);

            elapsed += 4;
        }

        End();
    }
}