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

public class srOval : srShape
{
    //Constructors
    public srOval() : base()
    {
    }
    public srOval(float x, float y, float width, float height) : base(x, y, width, height)
    {
    }
    public srOval(float x, float y, float width, float height, Color color) : base(x, y, width, height, color)
    {
    }

    public override Ellipse srMakeShape()
    {
        // Create an ellipse
        Ellipse ellipse = new Ellipse();
        ellipse.Width = srWidth;
        ellipse.Height = srHeight;
        ellipse.Margin = new Thickness(srWidth, srHeight, srWidth, srHeight);
        Canvas.SetTop(ellipse, srYCoor);
        Canvas.SetLeft(ellipse, srXCoor);
        ellipse.Fill = new SolidColorBrush(srColor);

        // Add the ellipse to the canvas
        return ellipse;
    }
}