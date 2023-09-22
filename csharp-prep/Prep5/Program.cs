using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string srName = PromptUserName();
        int srNum = PromptUserNumber();
        int srSquared = SquareNumber(srNum);
        DisplayResult(srName, srSquared);
    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string srInputtedNum = Console.ReadLine();
        return int.Parse(srInputtedNum);
    }

    static int SquareNumber(int srNum)
    {
        return srNum * srNum;
    }

    static void DisplayResult(string srName, int srSquared)
    {
        Console.WriteLine($"{srName}, the square of your number is {srSquared}.");
    }
}