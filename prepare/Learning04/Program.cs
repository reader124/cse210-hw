using System;

class Program
{
    static void Main(string[] args)
    {
        srAssignment srNewAssignment = new srAssignment("Sean Reading", "Intro to Classes");
        Console.WriteLine(srNewAssignment.srGetSummary());

        Console.WriteLine();

        srMathAssignment srNewMath = new srMathAssignment("Sean Reading", "Calculus", "3.5", "1-21 odds");
        Console.WriteLine(srNewMath.srGetSummary());
        Console.WriteLine(srNewMath.srGetHomeworkList());

        Console.WriteLine();

        srWritingAssignment srNewWrite = new srWritingAssignment("Sean Reading", "Creative Writing", "What About Dragons?");
        Console.WriteLine(srNewWrite.srGetSummary());
        Console.WriteLine(srNewWrite.srGetWritingInformation());
    }
}