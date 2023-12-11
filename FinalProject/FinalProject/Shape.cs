using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

public abstract class srShape : srObject
{
    protected Color srColor;

    //Constructors
    public srShape() : base()
    {
        srColor = Colors.White;
    }
    public srShape(float x, float y, float width, float height) : base(x, y, width, height)
    {
        srColor = Colors.White;
    }
    public srShape(float x, float y, float width, float height, Color color) : base(x, y, width, height)
    {
        srColor = color;
    }

    //change the color of the shape
    public void srChangeColor()
    {
        //stuff
    }

    //draw the shape on the canvas
    public abstract Shape srMakeShape();
}