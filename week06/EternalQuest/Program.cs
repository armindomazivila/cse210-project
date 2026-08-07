using System;

class Program
{
    static void Main()
    {

        GoalManager manager = new GoalManager();


        while (true)
        {
            Console.WriteLine("\nEternal Quest");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Quit");


            string choice = Console.ReadLine();


            if (choice == "1")
            {
                manager.CreateGoal();
            }

            else if (choice == "2")
            {
                manager.DisplayGoals();
            }

            else if (choice == "3")
            {
                manager.RecordEvent();
            }

            else if (choice == "4")
            {
                manager.ShowScore();
            }

            else if (choice == "5")
            {
                manager.Save();
            }

            else if (choice == "6")
            {
                break;
            }

        }

    }
}
