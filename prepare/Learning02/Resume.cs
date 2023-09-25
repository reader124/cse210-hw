using System;
using System.Collections.Generic;

public class Resume
{
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}\nJobs:");
        foreach(Job i in _jobs)
        {
            i.Display();
        }
    }
}