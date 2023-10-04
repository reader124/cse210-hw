using System;
using System.Collections.Generic;

/*
Name: Entry Class
Purpose: To contain the input, prompt, and date of a single entry of the journal
Author: Sean Reading
Date: 10/2/2023
*/

class srEntry
{
    string srWords;
    string srPrompt;
    int srDate;

    //set the value of each attribute
    public void srSetWords(string srNewWords)
    {
        srWords = srNewWords;
    }
    public void srSetPrompt(string srNewPrompt)
    {
        srPrompt = srNewPrompt;
    }
    public void srSetDate(int srNewDate)
    {
        srDate = srNewDate;
    }

    //get the value of each attribute
    public string srGetWords()
    {
        return srWords;
    }
    public string srGetPrompt()
    {
        return srPrompt;
    }
    public int srGetDate()
    {
        return srDate;
    }

    public string srPrintEntry()
    {
        return srGetDate() + ": Prompt- " + srGetPrompt() + ": " + srGetWords();
    }
}