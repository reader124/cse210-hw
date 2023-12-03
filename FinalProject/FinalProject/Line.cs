using System;

public class srLine : srObject
{
    int srThickness;

    //Constructors
    public srLine() : base()
    {
        srThickness = 1;
    }
    public srLine(float x, float y, float width, float height) : base(x, y, width, height)
    {
        srThickness = 1;
    }
    public srLine(float x, float y, float width, float height, int thickness) : base(x, y, width, height)
    {
        srThickness = thickness;
    }

    //change how thick the line is
    public void srChangeThickness()
    {
        //stuff
    }
}