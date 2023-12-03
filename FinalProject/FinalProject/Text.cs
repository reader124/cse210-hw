using System;

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
    public void srChangeFontSize()
    {
        //stuff
    }
}