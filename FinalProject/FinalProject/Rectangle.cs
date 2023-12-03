using System;

public class srRectangle : srShape
{
    //Constructors
    public srRectangle() : base()
    {
    }
    public srRectangle(float x, float y, float width, float height) : base(x, y, width, height)
    {
    }
    public srRectangle(float x, float y, float width, float height, string color) : base(x, y, width, height, color)
    {
    }

    public override void srMakeShape()
    {
        throw new NotImplementedException();
    }
}