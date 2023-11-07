using System;

public class srRectangle : srShape
{
    protected double srLength;
    protected double srWidth;

    //constructors
    public srRectangle() : base()
    {
        srLength = 1;
        srWidth = 1;
    }
    public srRectangle(double length, double width) : base()
    {
        srLength = length;
        srWidth = width;
    }
    public srRectangle(double length, double width, string color) : base(color)
    {
        srLength = length;
        srWidth = width;
    }

    //overridden get area method
    public override double srGetArea()
    {
        return srLength * srWidth;
    }
}