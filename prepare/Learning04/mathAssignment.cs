using System;

//math assignment class
class srMathAssignment : srAssignment
{
    private string srTextbookSection;
    private string srProblems;

    //constructors
    public srMathAssignment() : base()
    {
        srTextbookSection = "1.0";
        srProblems = "All";
    }
    public srMathAssignment(string name, string topic, string textbook, string problems) : base(name, topic)
    {
        srTextbookSection = textbook;
        srProblems = problems;
    }

    //get homework list
    public string srGetHomeworkList()
    {
        return "Section " + srTextbookSection + " Problems " + srProblems;
    }
}