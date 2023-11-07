using System;

public class srCircle : srShape
{
    protected double srRadius;

    //constructors
    public srCircle() : base()
    {
        srRadius = 1;
    }
    public srCircle(double radius) : base()
    {
        srRadius = radius;
    }
    public srCircle(double radius, string color) : base(color)
    {
        srRadius = radius;
    }

    //overridden get area method
    public override double srGetArea()
    {
        return srRadius * srRadius * Math.PI;
    }
}