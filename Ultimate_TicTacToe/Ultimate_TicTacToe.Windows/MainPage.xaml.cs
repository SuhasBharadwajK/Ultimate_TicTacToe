using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Media;
using Windows.Graphics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Ultimate_TicTacToe
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //Highlight_Button.Click += delegate(object sender, RoutedEventArgs e) { Highlight_Button_Click(sender, e, 1); };
        }

        //int pen;
        string pen = "";

        private void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //this.FindName("TextBlock_1x1_1x1").Text = "O";
            //((global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_1x1_1x1")).Text = "";
        }

        private void TextBlock_1x1_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonX_Click(object sender, RoutedEventArgs e)
        {
            /*for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    for (int k = 1; k <= 3; k++)
                    {
                        for (int l = 1; l <= 3; l++)
                        {
                            ((global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + i.ToString() + "x" + j.ToString() + "_" + k.ToString() + "x" + l.ToString())).Text = "X";
                        }
                    }
                }
            }*/
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Canvas.SetZIndex(((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + i + "x" + j)), 10);
                }
            }
            //((global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_1x1_1x1")).Text = "X";
            ButtonY.IsEnabled = false;
            pen = "X";
            //var info = ((Button)e.OriginalSource).DataContext;
            //TestTextBox.Text = info.ToString();
            ButtonX.IsEnabled = false;
        }

        private void ButtonY_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Canvas.SetZIndex(((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + i + "x" + j)), 10);
                }
            }
            ButtonX.IsEnabled = false;
            pen = "O";
            ButtonY.IsEnabled = false;
        }

        private void Highlight_Button_Click(object sender, RoutedEventArgs e) //Remove this
        {
            //SolidColorBrush brushRectangle = new SolidColorBrush();
            //brushRectangle.Color = Color.FromArgb(225, 100, 100, 100);
            //RectHigh.Fill = brushRectangle;
            Back_1x1.Opacity = 0.15;
            var value = ((Button)sender).Name;
            var button = sender as Button;
            //var code = ((Button)sender).
            TestTextBox.Text = (value.ToString()).Substring(0,10);
        }

        public void Play( string pen ) //Useless function
        {
            //int counter = 0;
            if (pen == "X")
            {

            }
            else
            {
                //(global::Windows.UI.Xaml.Controls.Canvas)
            }
        }

        public void NullifyAll( int p, int q )
        {
            for (int i = 1; i <= 3; i++)
                for (int j = 1; j <= 3; j++)
                {
                    ((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + i + "x" + j)).IsTapEnabled = false;
                    Canvas.SetZIndex(((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + i + "x" + j)), 0);
                }
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3 ; j++)
                {
                    for (int k = 1; k <= 3; k++)
                    {
                        for (int l = 1; l <= 3; l++)
                        {
                            //if(i != p && j != q)
                                ((global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + i + "x" + j + "_" + k + "x" + l)).IsTapEnabled = false;
                        }
                    }
                }
            }
        }

        public void Activate(int p, int q)
        {
            NullifyAll(p, q);
            for (int i = 1; i <= 3; i++)
                for (int j = 1; j <= 3; j++)
                    ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + p + "x" + q + "_" + i + "x" + j)).IsTapEnabled = true;
        }

        private void Back_3x3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //ButtonX.Content = "Works!";
            //SetZIndex();
            //Back_3x3.
            Canvas.SetZIndex(Back_3x3, 0);
            //ButtonY.Content = (Canvas.GetZIndex(Back_3x3)).ToString();
            Back_3x3.Opacity = 0.15;
            Activate(3, 3);
        }

        private void Back_1x1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Canvas.SetZIndex(Back_1x1, 0);
            Back_1x1.Opacity = 0.15;
            Activate(1, 1);
        }

        private void Back_1x2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Canvas.SetZIndex(Back_1x2, 0);
            Back_1x2.Opacity = 0.15;
            Activate(1, 2);
        }

        private void Back_1x3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Canvas.SetZIndex(Back_1x3, 0);
            Back_1x3.Opacity = 0.15;
            Activate(1, 3);
        }

        private void Back_2x1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Canvas.SetZIndex(Back_2x1, 0);
            Back_2x1.Opacity = 0.15;
            Activate(2, 1);
        }

        private void Back_2x2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Canvas.SetZIndex(Back_2x2, 0);
            Back_2x2.Opacity = 0.15;
            Activate(2, 2);
        }

        private void Back_2x3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Canvas.SetZIndex(Back_2x3, 0);
            Back_2x3.Opacity = 0.15;
            Activate(2, 3);
        }

        private void Back_3x1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Canvas.SetZIndex(Back_3x1, 0);
            Back_3x1.Opacity = 0.15;
            Activate(3, 1);
        }

        private void Back_3x2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Canvas.SetZIndex(Back_3x2, 0);
            Back_3x2.Opacity = 0.15;
            Activate(3, 2);
            //var info = ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource).DataContext;
            //TestTextBox.Text = info.ToString();
            //ButtonX.Content = info.ToString();
        }

        public void Played(int p, int q, int r, int s)
        {
            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + p + "x" + q + "_" + r + "x" + s)).Text = pen;
        }

        private void TextBlock_1x1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //14 16
            var info = ((TextBlock)sender).Name;
            string r = info.Substring(10, 1);
            string s = info.Substring(12, 1);
            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + "1x1")).Text = pen;
        }

        private void TextBlock_1x2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var info = ((TextBlock)sender).Name;
            string r = info.Substring(10, 1);
            string s = info.Substring(12, 1);
            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + "1x2")).Text = pen;
        }

        private void TextBlock_1x3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var info = ((TextBlock)sender).Name;
            string r = info.Substring(10, 1);
            string s = info.Substring(12, 1);
            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + "1x3")).Text = pen;
            //((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_1x3_" + r + "x" + s)).Text = pen;
        }

        private void TextBlock_2x1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var info = ((TextBlock)sender).Name;
            string r = info.Substring(10, 1);
            string s = info.Substring(12, 1);
            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + "2x1")).Text = pen;
        }

        private void TextBlock_2x2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var info = ((TextBlock)sender).Name;
            string r = info.Substring(10, 1);
            string s = info.Substring(12, 1);
            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_2x2")).Text = pen;
        }

        private void TextBlock_2x3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var info = ((TextBlock)sender).Name;
            string r = info.Substring(10, 1);
            string s = info.Substring(12, 1);
            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + "2x3")).Text = pen;
        }

        private void TextBlock_3x1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var info = ((TextBlock)sender).Name;
            string r = info.Substring(10, 1);
            string s = info.Substring(12, 1);
            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + "3x1")).Text = pen;
        }

        private void TextBlock_3x2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var info = ((TextBlock)sender).Name;
            string r = info.Substring(10, 1);
            string s = info.Substring(12, 1);
            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + "3x2")).Text = pen;
        }

        private void TextBlock_3x3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var info = ((TextBlock)sender).Name;
            string r = info.Substring(10, 1);
            string s = info.Substring(12, 1);
            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + "3x3")).Text = pen;
        }
    }
}