using System;
using System.Drawing;

public abstract class srShape : srObject
{
    Color srColor;

    //Constructors
    public srShape() : base()
    {
        srColor = Color.FromName("White");
    }
    public srShape(float x, float y, float width, float height) : base(x, y, width, height)
    {
        srColor = Color.FromName("White");
    }
    public srShape(float x, float y, float width, float height, string color) : base(x, y, width, height)
    {
        srColor = Color.FromName(color);
    }

    //change the color of the shape
    public void srChangeColor()
    {
        //stuff
    }

    //draw the shape on the canvas
    public abstract void srMakeShape();
}