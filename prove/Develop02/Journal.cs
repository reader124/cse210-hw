using System;
using System.Collections.Generic;

/*
Name: Journal Class
Purpose: to take an input from the user and store it in a list of Entry objects
Author: Sean Reading
Date: 10/2/2023
*/

class srJournal
{
    List<string> srEntries = new List<string>();
    List<string> srPrompts = new List<string>();
    string srFile;

    //set the values of the srPrompts list
    public void srSetPrompts(List<string> srNewPrompts)
    {
        srPrompts = srNewPrompts;
    }

    //print out each item in the srEntries list
    public void srDisplay()
    {
        Console.WriteLine(srFile);

        foreach(string i in srEntries)
        {
            Console.WriteLine(i);
        }
    }

    //create a new srEntry item and add it to the srEntries list
    public void srWriteEntry(string srInputWords, string srInputPrompt)
    {
        int srInputDate = 2023; //Getting the actual year is a hassle, and this should be good enough for this project

        srEntry srNewEntry = new srEntry();
        srNewEntry.srSetWords(srInputWords);
        srNewEntry.srSetPrompt(srInputPrompt);
        srNewEntry.srSetDate(srInputDate);

        srEntries.Add(srNewEntry.srPrintEntry());
    }

    //find a file based on the provided path and set srFileName to the new file
    public void srLoad(string srNewFile)
    {
        srFile = File.ReadAllText(srNewFile);
    }

    //write the srEntries list to the srFileName file
    public void srSave(string srNewFile)
    {
        string srToBeSaved = srFile + "\n";

        foreach(string i in srEntries)
        {
            srToBeSaved = srToBeSaved + i + "\n";
        }

        File.WriteAllText(srNewFile, srToBeSaved);
    }

    //print out the main menu statement
    public void srDisplayMenu()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        Console.Write("What would you like to do? ");
    }

    //use this to end a while loop in the main function
    public bool srQuit()
    {
        return false;
    }
}