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

public class srText : srObject
{
    string srTextContent;
    int srFontSize;

    //Constructors
    public srText() : base()
    {
        srTextContent = "Lorem ipsum dolor sit amet";
        srFontSize = 11;
    }
    public srText(float x, float y, float width, float height, string text) : base(x, y, width, height)
    {
        srTextContent = text;
        srFontSize = 11;
    }
    public srText(float x, float y, float width, float height, string text, int fontSize) : base(x, y, width, height)
    {
        srTextContent = text;
        srFontSize = fontSize;
    }

    //change how big the text is
    public void srChangeFontSize( int newFont)
    {
        srFontSize = newFont;
    }

    public TextBlock srMakeText()
    {
        TextBlock srNew = new TextBlock();
        srNew.Text = srTextContent;
        srNew.FontSize = srFontSize;
        Canvas.SetTop(srNew, srYCoor);
        Canvas.SetLeft(srNew, srXCoor);
        return srNew;
    }
}