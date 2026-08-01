using System;


class Program
{
    static void Main(string[] args)
    {

        // Exceeding Requirement:
        // Added multiple random prompts and questions
        // to make each activity different every time.

        while (true)
        {

            Console.Clear();

            Console.WriteLine("Mindfulness Program");
            Console.WriteLine();

            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();


            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }


            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
            }


            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }


            else if (choice == "4")
            {
                break;
            }


            else
            {
                Console.WriteLine("Invalid option.");
            }


            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}