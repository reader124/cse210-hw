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
    public void srChangeThickness( int newThickness)
    {
        srThickness = newThickness;
    }

    public Line srMakeLine()
    {
        Line line = new Line();
        line.X1 = srXCoor;
        line.Y1 = srYCoor;
        line.X2 = srXCoor + srWidth;
        line.Y2 = srYCoor + srHeight;
        Canvas.SetTop(line, srYCoor);
        Canvas.SetLeft(line, srXCoor);
        line.Stroke = System.Windows.Media.Brushes.Black;
        line.StrokeThickness = srThickness;

        return line;
    }
}