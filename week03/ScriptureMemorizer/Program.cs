using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        // This program loads multiple scriptures from a file
        // and randomly selects one scripture for memorization.
        // This allows users to practices more than on scripture.

        List<Scripture> scriptures = LoadScriptures();

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (!scripture.IsCompletelyHidden())

        {

            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();

            Console.WriteLine("Press Enter to hide words or type quit:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")

            {

                break;

            }

            scripture.HideRandomWords(3);

        }

        Console.Clear();

        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine("\nGood job memorizing!");

    }

    static List<Scripture> LoadScriptures()

    {

        List<Scripture> scriptures = new List<Scripture>();

        string[] lines = File.ReadAllLines("scriptures.txt");

        foreach (string line in lines)

        {

            string[] parts = line.Split('|');

            string book = parts[0];

            int chapter = int.Parse(parts[1]);

            int verse = int.Parse(parts[2]);

            string text = parts[3];

            Reference reference =

                new Reference(book, chapter, verse);

            Scripture scripture =

                new Scripture(reference, text);

            scriptures.Add(scripture);

        }

        return scriptures;

    }

}
