using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> srNums = new List<int>();
        int srNum = 1;
        int srSum = 0;
        float srAverage = 0;
        int srMax = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (srNum != 0)
            {
                Console.WriteLine("Enter number: ");
                string snInputtedNum = Console.ReadLine();
                srNum = int.Parse(snInputtedNum);

                srNums.Add(srNum);
            }
        
        foreach(int x in srNums)
        {
            srSum = srSum + x;
        }
        Console.WriteLine($"The sum is: {srSum}");

        srAverage = srSum / srNums.Count;
        Console.WriteLine($"The average is: {srAverage}");

        foreach (int x in srNums)
        {
            if (x > srMax) { srMax = x; }
        }
        Console.WriteLine($"The largest number is: {srMax}");
    }
}