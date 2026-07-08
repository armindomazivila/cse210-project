using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Menu");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.Write("Select an option (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();

                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    Entry entry = new Entry();
                    entry.Date = DateTime.Now.ToShortDateString();
                    entry.Prompt = prompt;
                    entry.Response = response;

                    journal.AddEntry(entry);
                    Console.WriteLine("Entry added successfully!");

                    break;
                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Filename: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    Console.WriteLine("Journal loaded successfully!");
                    break;

                case "4":
                    Console.Write("Filename: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    Console.WriteLine("Journal saved successfully!");
                    break;


                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;

            }
        }
    }
}