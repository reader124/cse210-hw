using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string sr_first = Console.ReadLine();

        Console.Write("What is your last name? ");
        string sr_last = Console.ReadLine();

        Console.WriteLine($"Your name is {sr_last}, {sr_first} {sr_last}.");
    }
}