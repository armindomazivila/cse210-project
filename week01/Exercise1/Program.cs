using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, This is Exercise 1 project! ");

        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your full name is: {firstName} {lastName}");
    }
}