using System;

class Program
{
    static void Main(string[] args)
    {
        bool srGotIt = false;

        //Console.WriteLine("What is the magic number? ");
        //string srInputtedNum = Console.ReadLine();
        //int srMagicNum = int.Parse(srInputtedNum);

        Random srRandom = new Random();
        int srMagicNum = srRandom.Next(1, 100);

        while (!srGotIt)
        {
            Console.WriteLine("What is your guess? ");
            string srInputtedGuess = Console.ReadLine();
            int srGuess = int.Parse(srInputtedGuess);

            if (srGuess > srMagicNum)
            {
                Console.WriteLine("Lower");
            }
            else if (srGuess < srMagicNum)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                srGotIt = true;
            }
        }
    }
}