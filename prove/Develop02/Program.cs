using System;
using System.Collections.Generic;

/*
Name: Journal Main Driver
Purpose: to make and manage a journal
Author: Sean Reading
Date: 10/3/2023
*/

class Program
{
    static void Main(string[] args)
    {
        bool srIsLooping = true;
        Random srRand = new Random();

        List<string> srMyPrompts = new List<string>();
        srMyPrompts.Add("Who was the most interesting person I interacted with today?");
        srMyPrompts.Add("What was the best part of my day?");
        srMyPrompts.Add("How did I see the hand of the Lord in my life today?");
        srMyPrompts.Add("What was the strongest emotion I felt today?");
        srMyPrompts.Add("If I had one thing I could do over today, what would it be?");

        srJournal srThisJournal = new srJournal();
        srThisJournal.srSetPrompts(srMyPrompts);

        while (srIsLooping)
        {
            //get the input from the user
            srThisJournal.srDisplayMenu();
            string srInput = Console.ReadLine();

            if (srInput == "1")
            {
                //Write
                string srThisPrompt = srMyPrompts[srRand.Next(6)];
                Console.Write(srThisPrompt + "\n> ");
                string srThisWords = Console.ReadLine();

                srThisJournal.srWriteEntry(srThisWords, srThisPrompt);
            }
            else if (srInput == "2")
            {
                //Display
                srThisJournal.srDisplay();
            }
            else if (srInput == "3")
            {
                //Load
                Console.WriteLine("What is the filename? ");
                string srThisFile = Console.ReadLine();
                srThisJournal.srLoad(srThisFile);
            }
            else if (srInput == "4")
            {
                //Save
                Console.WriteLine("What is the filename? ");
                string srThisFile = Console.ReadLine();
                srThisJournal.srSave(srThisFile);
            }
            else if (srInput == "5")
            {
                //quit
                srIsLooping = srThisJournal.srQuit();
            }
            else
            {
                //catch any other inputs
                Console.WriteLine("That isn't a valid input. Please enter a single digit number.");
            }
        }
    }
}