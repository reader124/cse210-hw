using System;

//Assignment class
class srAssignment
{
    protected string srStudentName;
    protected string srTopic;

    //constructors
    public srAssignment()
    {
        srStudentName = "John Jones";
        srTopic = "Cheese";
    }
    public srAssignment(string name, string topic)
    {
        srStudentName = name;
        srTopic = topic;
    }

    //get summary method
    public string srGetSummary()
    {
        return srStudentName + " - " + srTopic;
    }
}