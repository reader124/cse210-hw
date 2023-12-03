using System;

public class srOval : srShape
{
    //Constructors
    public srOval() : base()
    {
    }
    public srOval(float x, float y, float width, float height) : base(x, y, width, height)
    {
    }
    public srOval(float x, float y, float width, float height, string color) : base(x, y, width, height, color)
    {
    }

    public override void srMakeShape()
    {
        throw new NotImplementedException();
    }
}