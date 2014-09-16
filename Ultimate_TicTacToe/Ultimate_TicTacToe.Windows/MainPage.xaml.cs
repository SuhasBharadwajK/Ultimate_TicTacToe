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

        int pen;

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
            //((global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_1x1_1x1")).Text = "X";
            ButtonY.IsEnabled = false;
            pen = 1;
            var info = ((Button)e.OriginalSource).DataContext;
            TestTextBox.Text = info.ToString();
        }

        private void ButtonY_Click(object sender, RoutedEventArgs e)
        {
            /*for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    for (int k = 1; k <= 3; k++)
                    {
                        for (int l = 1; l <= 3; l++)
                        {
                            ((global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + i.ToString() + "x" + j.ToString() + "_" + k.ToString() + "x" + l.ToString())).Text = "O";
                        }
                    }
                }
            }*/
            ButtonX.IsEnabled = false;
            pen = 2;
        }

        private void Highlight_Button_Click(object sender, RoutedEventArgs e) //Remove this
        {
            //SolidColorBrush brushRectangle = new SolidColorBrush();
            //brushRectangle.Color = Color.FromArgb(225, 100, 100, 100);
            //RectHigh.Fill = brushRectangle;
            Back_1x1.Opacity = 0.15;
            var value = ((Button)sender).Tag;
            var button = sender as Button;
            //var code = ((Button)sender).
            TestTextBox.Text = (value.ToString()).Substring(2,1);
        }

        public void Play( int pen )
        {
            int counter = 0;
            if (pen == 1)
            {

            }
            else
            {
                //(global::Windows.UI.Xaml.Controls.Canvas)
            }
        }

        public void NullifyAll()
        {
            for (int i = 1; i <= 3; i++)
                for (int j = 1; j <= 3; j++)
                {
                    ((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + i + "x" + j)).IsTapEnabled = false;
                }
        }

        public void Activate(int p, int q)
        {
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
            Play(pen);
        }

        private void Back_1x1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Canvas.SetZIndex(Back_1x1, 0);
            Play(pen);
        }

        private void Back_1x2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Canvas.SetZIndex(Back_1x2, 0);
            Play(pen);
        }

        private void Back_1x3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Canvas.SetZIndex(Back_1x3, 0);
            Play(pen);
        }

        private void Back_2x1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Canvas.SetZIndex(Back_2x1, 0);
            Play(pen);
        }

        private void Back_2x2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Canvas.SetZIndex(Back_2x2, 0);
            Play(pen);
        }

        private void Back_2x3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Canvas.SetZIndex(Back_2x3, 0);
            Play(pen);
        }

        private void Back_3x1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Canvas.SetZIndex(Back_3x1, 0);
            Play(pen);
        }

        private void Back_3x2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Canvas.SetZIndex(Back_3x2, 0);
            Play(pen);
            var info = ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource).DataContext;
            //TestTextBox.Text = info.ToString();
            //ButtonX.Content = info.ToString();
        }

        private void TextBlock_1x1_Tapped(object sender, TappedEventHandler e, int p, int q)
        {

        }

        private void TextBlock_1x2_Tapped(object sender, TappedEventHandler e, int p, int q)
        {

        }

        private void TextBlock_1x3_Tapped(object sender, TappedEventHandler e, int p, int q)
        {

        }

        private void TextBlock_2x1_Tapped(object sender, TappedEventHandler e, int p, int q)
        {

        }

        private void TextBlock_2x2_Tapped(object sender, TappedEventHandler e, int p, int q)
        {

        }

        private void TextBlock_2x3_Tapped(object sender, TappedEventHandler e, int p, int q)
        {

        }

        private void TextBlock_3x1_Tapped(object sender, TappedEventHandler e, int p, int q)
        {

        }

        private void TextBlock_3x2_Tapped(object sender, TappedEventHandler e, int p, int q)
        {

        }

        private void TextBlock_3x3_Tapped(object sender, TappedEventHandler e, int p, int q)
        {

        }
    }
}