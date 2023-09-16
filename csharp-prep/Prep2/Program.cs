using System;

class Program
{
    static void Main(string[] args)
    {
        bool srPassing = true;
        string srLetterGrade = "";

        Console.WriteLine("Please enter your grade: ");
        string srInputtedGrade = Console.ReadLine();
        int srGrade = int.Parse(srInputtedGrade);

        if (srGrade >= 90) { srLetterGrade = "A"; }
        else if (srGrade >= 80) { srLetterGrade = "B"; }
        else if (srGrade >= 70) { srLetterGrade = "C"; }
        else if (srGrade >= 60) { srLetterGrade = "D"; srPassing = false; }
        else { srLetterGrade = "F"; srPassing = false; }

        Console.WriteLine($"Your grade is {srLetterGrade}.");

        if (srPassing) { Console.WriteLine("Well Done!"); }
        else { Console.WriteLine("Better luck next time!"); }
    }
}