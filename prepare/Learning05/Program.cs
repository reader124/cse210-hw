using System;

class Program
{
    static void Main(string[] args)
    {
        srRectangle srMyRect = new srRectangle(2, 3, "blue");
        srSquare srMySquare = new srSquare(4, "green");
        srCircle srMyCircle = new srCircle(5, "yellow");

        List<srShape> srShapes = new List<srShape>();

        srShapes.Add(srMyRect);
        srShapes.Add(srMySquare);
        srShapes.Add(srMyCircle);

        foreach (srShape i in srShapes)
        {
            Console.Write(i.srGetColor() + " ");
            Console.WriteLine(i.srGetArea());
        }
    }
}