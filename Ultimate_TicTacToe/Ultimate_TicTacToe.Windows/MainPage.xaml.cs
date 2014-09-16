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
        }

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
            int pen = 1;
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
            int pen = 2;
        }

        private void Highlight_Button_Click(object sender, RoutedEventArgs e)
        {
            //SolidColorBrush brushRectangle = new SolidColorBrush();
            //brushRectangle.Color = Color.FromArgb(225, 100, 100, 100);
            //RectHigh.Fill = brushRectangle;
            Back_1x1.Opacity = 0.15;
        }
    }
}
