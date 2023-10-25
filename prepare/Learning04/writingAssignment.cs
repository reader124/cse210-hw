using System;

//writing assignment class
class srWritingAssignment : srAssignment
{
    string srTitle;

    //constructors
    public srWritingAssignment() : base()
    {
        srTitle = "Howdy";
    }
    public srWritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        srTitle = title;
    }

    //get information method
    public string srGetWritingInformation()
    {
        return srTitle + " by " + srStudentName;
    }
}