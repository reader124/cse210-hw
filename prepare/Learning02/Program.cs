using System;

class Program
{
    static void Main(string[] args)
    {
        Job srJobOne = new Job();
        srJobOne._company = "Nintendo";
        srJobOne._jobTitle = "Developer";
        srJobOne._startYear = 2000;
        srJobOne._endYear = 2010;

        Job srJobTwo = new Job();
        srJobTwo._company = "Mojang";
        srJobTwo._jobTitle = "QA Tester";
        srJobTwo._startYear = 2020;
        srJobTwo._endYear = 2024;

        Resume srMyResume = new Resume();
        srMyResume._name = "Sean Reading";
        srMyResume._jobs.Add(srJobOne);
        srMyResume._jobs.Add(srJobTwo);

        srMyResume.Display();
    }
}