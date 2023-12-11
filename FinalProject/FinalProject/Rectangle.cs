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

public class srRectangle : srShape
{
    //Constructors
    public srRectangle() : base()
    {
    }
    public srRectangle(float x, float y, float width, float height) : base(x, y, width, height)
    {
    }
    public srRectangle(float x, float y, float width, float height, Color color) : base(x, y, width, height, color)
    {
    }

    public override Rectangle srMakeShape()
    {
        // Create an ellipse
        Rectangle rect = new Rectangle();
        rect.Width = srWidth;
        rect.Height = srHeight;
        Canvas.SetTop(rect, srYCoor);
        Canvas.SetLeft(rect, srXCoor);
        rect.Fill = new SolidColorBrush(srColor);

        // Add the ellipse to the canvas
        return rect;
    }
}