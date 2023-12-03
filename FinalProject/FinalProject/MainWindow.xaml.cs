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

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void srDoThing(object sender, RoutedEventArgs e)
        {
            // Create an ellipse
            Ellipse ellipse = new Ellipse();
            ellipse.Width = 100;
            ellipse.Height = 50;
            ellipse.Fill = new SolidColorBrush(Colors.Red);

            // Add the ellipse to the canvas
            myCanvas.Children.Add(ellipse);
        }
        void srDoThingTwo(object sender, RoutedEventArgs e)
        {
            srObject srNew = new srObject();
            Ellipse ellipse = srNew.srStuff()
            myCanvas.Children.Add(ellipse);
        }
    }
}
