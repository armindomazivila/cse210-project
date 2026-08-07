using System;
using System.Collections.Generic;
using System.IO;


public class GoalManager
{
    private List<Goal> _goals;
    private Player _player;


    public GoalManager()
    {
        _goals = new List<Goal>();
        _player = new Player();
    }


    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }


    public void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string choice = Console.ReadLine();


        Console.Write("Name: ");
        string name = Console.ReadLine();


        Console.Write("Description: ");
        string description = Console.ReadLine();


        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());


        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }

        else if (choice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }

        else if (choice == "3")
        {
            Console.Write("How many times? ");
            int target;
            while (!int.TryParse(Console.ReadLine(), out target))
            {
                Console.Write("Please enter a valid number only: ");
            }

            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());


            _goals.Add(
                new ChecklistGoal(name, description, points, target, bonus));
        }

    }



    public void RecordEvent()
    {
        DisplayGoals();

        Console.Write("Choose goal: ");

        int choice = int.Parse(Console.ReadLine()) - 1;


        int points = _goals[choice].RecordEvent();

        _player.AddPoints(points);


        Console.WriteLine($"You earned {points} points!");
    }



    public void ShowScore()
    {
        Console.WriteLine($"Score: {_player.GetScore()}");
    }



    public void Save()
    {
        using (StreamWriter file = new StreamWriter("goals.txt"))
        {
            file.WriteLine(_player.GetScore());

            foreach (Goal goal in _goals)
            {
                file.WriteLine(goal.SaveString());
            }
        }
    }

}