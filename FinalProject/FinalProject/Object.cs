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

public class srObject
    {
        protected float srXCoor;
        protected float srYCoor;
        protected float srWidth;
        protected float srHeight;

        //Constructors
        public srObject()
        {
            srXCoor = 0;
            srYCoor = 0;
            srWidth = 1;
            srHeight = 1;
        }
        public srObject(float x, float y, float width, float height)
        {
            srXCoor = x;
            srYCoor = y;
            srWidth = width;
            srHeight = height;
        }
    }
