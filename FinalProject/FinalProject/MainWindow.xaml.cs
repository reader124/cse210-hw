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
        UIElement srDrag;
        Point srOffset;

        public MainWindow()
        {
            InitializeComponent();
        }

        //button methods
        void srDoThing(object sender, RoutedEventArgs e)
        {
            srRectangle srNew = new srRectangle(20, 100, 50, 50, Colors.Red);
            Rectangle rect = srNew.srMakeShape();
            rect.PreviewMouseDown += srOnMouseDown;

            ContextMenu srRightClickMenu = new ContextMenu();

            MenuItem srDelete = new MenuItem();
            srDelete.Header = "Delete";
            srDelete.Click += srDeleteItem;
            srDelete.Tag = rect;
            srRightClickMenu.Items.Add(srDelete);

            rect.ContextMenu = srRightClickMenu;
            myCanvas.Children.Add(rect);
        }
        void srDoThingTwo(object sender, RoutedEventArgs e)
        {
            srOval srNew = new srOval(100, 100, 50, 50, Colors.Green);
            Ellipse ellipse = srNew.srMakeShape();
            ellipse.PreviewMouseDown += srOnMouseDown;

            ContextMenu srRightClickMenu = new ContextMenu();

            MenuItem srDelete = new MenuItem();
            srDelete.Header = "Delete";
            srDelete.Click += srDeleteItem;
            srDelete.Tag = ellipse;
            srRightClickMenu.Items.Add(srDelete);

            ellipse.ContextMenu = srRightClickMenu;
            myCanvas.Children.Add(ellipse);
        }
        void srDoThingThree(object sender, RoutedEventArgs e)
        {
            srLine srNew = new srLine(100, 50, 50, 50, 5);
            Line line = srNew.srMakeLine();
            line.PreviewMouseDown += srOnMouseDown;

            ContextMenu srRightClickMenu = new ContextMenu();

            MenuItem srDelete = new MenuItem();
            srDelete.Header = "Delete";
            srDelete.Click += srDeleteItem;
            srDelete.Tag = line;
            srRightClickMenu.Items.Add(srDelete);

            line.ContextMenu = srRightClickMenu;
            myCanvas.Children.Add(line);
        }
        void srDoThingFour(object sender, RoutedEventArgs e)
        {
            srText srNew = new srText(300, 100, 50, 50, inputText.Text, 25);
            TextBlock text = srNew.srMakeText();
            text.PreviewMouseDown += srOnMouseDown;

            ContextMenu srRightClickMenu = new ContextMenu();

            MenuItem srDelete = new MenuItem();
            srDelete.Header = "Delete";
            srDelete.Click += srDeleteItem;
            srDelete.Tag = text;
            srRightClickMenu.Items.Add(srDelete);

            text.ContextMenu = srRightClickMenu;
            myCanvas.Children.Add(text);
        }

        //drag and drop methods
        void srOnMouseMove(object sender, MouseEventArgs e)
        {
            if (this.srDrag == null)
            {
                return;
            }
            var srPosition = e.GetPosition(sender as IInputElement);
            Canvas.SetTop(this.srDrag, srPosition.Y - this.srOffset.Y);
            Canvas.SetLeft(this.srDrag, srPosition.X - this.srOffset.X);
        }
        void srOnMouseUp(object sender, MouseEventArgs e)
        {
            this.srDrag = null;
            this.myCanvas.ReleaseMouseCapture();
        }
        void srOnMouseDown(object sender, MouseEventArgs e)
        {
            this.srDrag = sender as UIElement;
            this.srOffset = e.GetPosition(this.myCanvas);
            this.srOffset.Y = Canvas.GetTop(this.srDrag);
            this.srOffset.X = Canvas.GetLeft(this.srDrag);
            this.myCanvas.CaptureMouse();
        }

        //right click menu methods
        void srDeleteItem(object sender, RoutedEventArgs e)
        {
            UIElement srItem = (UIElement)((MenuItem)sender).Tag;
            myCanvas.Children.Remove(srItem);
        }
    }
}
