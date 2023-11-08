using System;

public class srSquare : srRectangle
{
    //constructors
    public srSquare() : base() {}
    public srSquare(double length) : base(length, length) {}
    public srSquare(double length, string color) : base(length, length, color) {}
}