﻿using System;
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
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    for (int k = 1; k <= 3; k++)
                    {
                        for (int l = 1; l <= 3; l++)
                        {
                            ((global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + i + "x" + j + "_" + k + "x" + l)).IsTapEnabled = false;
                            //((global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("WinText_" + i + "x" + j)).Text = winner[i-1, j-1].ToString();
                        }
                    }
                }
            }
            
            /*Loaded += (s, e) =>
            {
                Back_1x1.IsTapEnabled = false;
                Back_1x2.IsTapEnabled = false;
                Back_1x3.IsTapEnabled = false;
                Back_2x1.IsTapEnabled = false;
                Back_2x2.IsTapEnabled = false;
                Back_2x3.IsTapEnabled = false;
                Back_3x1.IsTapEnabled = false;
                Back_3x2.IsTapEnabled = false;
                Back_3x3.IsTapEnabled = false;
            };*/
            /*ButtonX.IsEnabled = false;
            Back_1x1.IsTapEnabled = false;
            Back_1x2.IsTapEnabled = false;
            Back_1x3.IsTapEnabled = false;
            Back_2x1.IsTapEnabled = false;
            Back_2x2.IsTapEnabled = false;
            Back_2x3.IsTapEnabled = false;
            Back_3x1.IsTapEnabled = false;
            Back_3x2.IsTapEnabled = false;
            Back_3x3.IsTapEnabled = false;*/
            //Highlight_Button.Click += delegate(object sender, RoutedEventArgs e) { Highlight_Button_Click(sender, e, 1); };
        }

        //int pen;
        string pen = "";
        //int counter = 0;
        //int[,] winner = new int[3, 3];
        int[,] winner = new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        //int[,] counter = new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        //int WinFlag = 0;
        int countX = 0;
        int countY = 0;
        int[,] IndieCountX = new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        int[,] IndieCountY = new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        int Vacancy = 9;
        int Victory = 0;
        //int bigCountx = 0;
        //int bigCountY = 0;
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
            //MoveBox.Text = pen + "'s turn";
            //var info = ((Button)e.OriginalSource).DataContext;
            //TestTextBox.Text = info.ToString();
            ButtonX.IsEnabled = false;
            StatusBlock.Text = pen + "'s turn";
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
            //MoveBox.Text = pen + "'s turn";
            ButtonY.IsEnabled = false;
            StatusBlock.Text = pen + "'s turn";
        }

        private void Highlight_Button_Click(object sender, RoutedEventArgs e) //Remove this
        {
            //SolidColorBrush brushRectangle = new SolidColorBrush();
            //brushRectangle.Color = Color.FromArgb(225, 100, 100, 100);
            //RectHigh.Fill = brushRectangle;
            Back_1x1.Opacity = 0.15;
            var value = ((Button)sender).Name;
            //var button = sender as Button;//
            //var code = ((Button)sender).
            //TestTextBox.Text = (value.ToString()).Substring(0,10);
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

        public void NullifyAll( )
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

        public void Played( int r, int s, int p, int q )
        {
            //counter++;
            //int diff = q - p;
            //counter[r - 1, s - 1]++;
            int sum = p + q;
            VictoryFlag.Text = Vacancy.ToString();
            //WinnerBox.Text = Victory.ToString();
            //((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + q))
            if (sum % 4 == 0) //1x3 and 3x1
            {
                if (p == 1) //1x3
                {
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q - 1))).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q - 2))).Text == pen)
                        {
                            //StatusBlock.Text = pen + " Won!";
                            //winner[r-1, s-1] = 1;
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p + 1) + "x" + q)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p + 2) + "x" + q)).Text == pen)
                        {
                            //StatusBlock.Text = pen + " Won!";
                            //winner[r-1, s-1] = 1;
                            Won(r, s, p, q , pen);
                        }
                    }
                    if(((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 2 + "x" + 2)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p + 2) + "x" + (q - 2))).Text == pen)
                        {
                            ////StatusBlock.Text = pen + " Won!";
                            //winner[r-1, s-1] = 1;
                            Won(r, s, p, q , pen);
                        }
                    }
                }
                else if (p == 3) //3x1
                {
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p - 1) + "x" + q)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p - 2) + "x" + q)).Text == pen)
                        {
                            ////StatusBlock.Text = pen + " Won!";
                            //winner[r-1, s-1] = 1;
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q + 1))).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q+2))).Text == pen)
                        {
                            ////StatusBlock.Text = pen + " Won!";
                            //winner[r-1, s-1] = 1;
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 2 + "x" + 2)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p - 2) + "x" + (q + 2))).Text == pen)
                        {
                            ////StatusBlock.Text = pen + " Won!";
                            //winner[r-1, s-1] = 1;
                            Won(r, s, p, q , pen);
                        }
                    }
                }
                else if (p == 2)
                {
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 1 + "x" + 1)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 3 + "x" + 3)).Text == pen)
                        {
                            ////StatusBlock.Text = pen + " Won!";
                            //winner[r - 1, s - 1] = 1;
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 1 + "x" + 2)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 3 + "x" + 2)).Text == pen)
                        {
                            ////StatusBlock.Text = pen + " Won!";
                            //winner[r - 1, s - 1] = 1;
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 2 + "x" + 1)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 2 + "x" + 3)).Text == pen)
                        {
                            ////StatusBlock.Text = pen + " Won!";
                            //winner[r - 1, s - 1] = 1;
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 1 + "x" + 3)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 3 + "x" + 1)).Text == pen)
                        {
                            //Win
                            //StatusBlock.Text = "1 , 3 + 3, 1";
                            ////StatusBlock.Text = pen + " Won!";
                            //winner[r - 1, s - 1] = 1;
                            Won(r, s, p, q , pen);
                        }
                    }
                }
            }
            else if (sum % 4 == 2)
            {
                if (p == 1) //1x1
                {
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 2 + "x" + 2)).Text == pen)
                    {
                        if(((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 3 + "x" + 3)).Text == pen) {
                            //StatusBlock.Text = pen + " Won!";
                            //winner[r-1, s-1] = 1;
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q + 1))).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q + 2))).Text == pen)
                        {
                            //StatusBlock.Text = pen + " Won!";
                            //winner[r-1, s-1] = 1;
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p + 1) + "x" + q)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p + 2) + "x" + q)).Text == pen)
                        {
                            //StatusBlock.Text = pen + " Won!";
                            //winner[r-1, s-1] = 1;
                            Won(r, s, p, q , pen);
                        }
                    }
                }
                else if (p == 3) //3x3
                {
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p - 1) + "x" + q)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p - 2) + "x" + q)).Text == pen)
                        {
                            //StatusBlock.Text = pen + " Won!";
                            //winner[r-1, s-1] = 1;
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q - 1))).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q - 2))).Text == pen)
                        {
                            //StatusBlock.Text = pen + " Won!";
                            //winner[r-1, s-1] = 1;
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p - 1) + "x" + (q - 1))).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p - 2) + "x" + (q - 2))).Text == pen)
                        {
                            //StatusBlock.Text = pen + " Won!";
                            //winner[r-1, s-1] = 1;
                            Won(r, s, p, q, pen);
                        }
                    }
                }
            }
            else if (p == 2 && p != q)
            {
                if (q == 1) //2x1
                {
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p - 1) + "x" + q)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p + 1) + "x" + q)).Text == pen)
                        {
                            //StatusBlock.Text = pen + " Won!";
                            //winner[r-1, s-1] = 1;
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 2 + "x" + 2)).Text == pen)
                    {
                        if(((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q + 2))).Text == pen) {
                            //StatusBlock.Text = pen + " Won!";
                            //winner[r-1, s-1] = 1;
                            Won(r, s, p, q , pen);
                        }
                    }
                }
                else //2x3
                {
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p - 1) + "x" + q)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p + 1) + "x" + q)).Text == pen)
                        {
                            //StatusBlock.Text = pen + " Won!";
                            //winner[r-1, s-1] = 1;
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 2 + "x" + 2)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q - 2))).Text == pen)
                        {
                            //StatusBlock.Text = pen + " Won!";
                            ////winner[r-1, s-1] = 1;
                            Won(r, s, p, q , pen);
                        }
                    }
                }
            }
            else if (q == 2 && p != q)
            {
                if (p == 1) //1x2
                {
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q - 1))).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q + 1))).Text == pen)
                        {
                            //StatusBlock.Text = pen + " Won!";
                            //winner[r-1, s-1] = 1;
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 2 + "x" + 2)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p + 2) + "x" + q)).Text == pen)
                        {
                            //StatusBlock.Text = pen + " Won!";
                            //winner[r-1, s-1] = 1;
                            Won(r, s, p, q , pen);
                        }
                    }
                }
                else //3x2
                {
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q - 1))).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q + 1))).Text == pen)
                        {
                            //StatusBlock.Text = pen + " Won!";
                            //winner[r-1, s-1] = 1;
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 2 + "x" + 2)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p - 2) + "x" + q)).Text == pen)
                        {
                            //StatusBlock.Text = pen + " Won!";
                            //winner[r-1, s-1] = 1;
                            Won(r, s, p, q , pen);
                        }
                    }
                }
            }
            /*else if(sum % 4 == 0 && p == q) //2x2
            {
                if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 1 + "x" + 1)).Text == pen) //p-1 and q-1 are changed to 1 and 1
                {
                    if(((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 3 + "x" + 3)).Text == pen) { //p+1 and q+1 are changed to 3 and 3
                        //StatusBlock.Text = pen + " Won!";
                        //winner[r-1, s-1] = 1;
                        Won(r, s, p, q , pen);
                    }
                }
                else if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 1 + "x" + 3)).Text == pen)
                {
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 3 + "x" + 1)).Text == pen)
                    {
                        //StatusBlock.Text = pen + " Won!";
                        //winner[r-1, s-1] = 1;
                        Won(r, s, p, q , pen);
                    }
                }
                else if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 1 + "x" + 2)).Text == pen)
                {
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 3 + "x" + 2)).Text == pen)
                    {
                        //StatusBlock.Text = pen + " Won!";
                        //winner[r-1, s-1] = 1;
                        Won(r, s, p, q , pen);
                    }
                }
                else if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 2 + "x" + 1)).Text == pen)
                {
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 2 + "x" + 3)).Text == pen)
                    {
                        //StatusBlock.Text = pen + " Won!";
                        //winner[r-1, s-1] = 1;
                        Won(r, s, p, q , pen);
                    }
                }
            }*/
            /*if ( diff == 0 )
            {

            }
            else if ( diff == 1 || diff == -1 )
            {
                if ( q == 2 )
                {

                }
                else if (p == 2)
                {

                }
            }
            else
            {

            }*/
            if (pen == "X")
            {
                IndieCountX[r - 1, s - 1]++;
                pen = "O";
                StatusBlock.Text = pen + "'s turn";
            }
            else
            {
                IndieCountY[r - 1, s - 1]++;
                pen = "X";
                StatusBlock.Text = pen + "'s turn";
            }
            if (winner[r - 1, s - 1] == 0)
            {
                if (IndieCountX[r - 1, s - 1] + IndieCountY[r - 1, s - 1] == 9) //Was IndieCountX[r - 1, s- 1] > 4 || IndieCountY[r - 1, s- 1] > 4 
                {
                    winner[r - 1, s - 1] = 3;
                    WinnerBox.Text = "Tied in " + r + "," + s;
                    ((Windows.UI.Xaml.Controls.Image)this.FindName("Grid_" + r + "x" + s)).Opacity = 0;
                    ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("FinalWinBlock_" + r + "x" + s)).Text = "!";
                    for (int i = 1; i <= 3; i++)
                    {
                        for (int j = 1; j <= 3; j++)
                        {
                            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + i + "x" + j)).Opacity = 0;
                        }
                    }
                    Vacancy--;
                    ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("WinnerBox_" + r + "x" + s)).Text = winner[r - 1, s - 1].ToString();
                    //for (int i = 1; i <= 3; i++)
                    //{
                    //    for (int j = 1; j <= 3; j++)
                    //    {
                    //        //((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + i + "x" + j)).Text = "T";
                    //        winner[r - 1, s - 1] = 3;
                            
                    //    }
                    //}
                }
            }
            if (Victory == 0 && Vacancy == 0)
            {
                StatusBlock.Text = "The match tied!";
            }
        }

        public void Transfer(int r, int s, int p, int q)
        {
            if (winner[p - 1, q - 1] == 1 || winner[p - 1, q - 1] == 2 || winner[p - 1, q - 1] == 3)
            { 
                Wait(r, s, p, q);
                //StatusBlock.Text = "Already won!";
            }
            else
            {
                ((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + p + "x" + q)).IsTapEnabled = true;
                Canvas.SetZIndex(((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + p + "x" + q)), 0);
                ((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + p + "x" + q)).Opacity = 0.15;
                ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + q)).IsTapEnabled = false;
                Activate(p, q);
            }
        }

        public void Wait(int r, int s, int p, int q)
        {
            NullifyAll();
            /*for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; i <= 3; j++)
                {
                    ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + i + "x" + j)).IsTapEnabled = false;
                    //((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + p + "x" + q)).IsTapEnabled = false;
                }
            }*/
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if (winner[i - 1, j - 1] == 0) //Removed i != r && j != s
                    {
                        ((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + i + "x" + j)).IsTapEnabled = true;
                        Canvas.SetZIndex(((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + i + "x" + j)), 10);
                         ((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + i + "x" + j)).Opacity = 0.15;
                    }
                }
            }
        }

        public void Activate(int p, int q)
        {
            NullifyAll();
            for (int i = 1; i <= 3; i++)
                for (int j = 1; j <= 3; j++)
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + p + "x" + q + "_" + i + "x" + j)).Text == "" && winner[p-1, q-1] == 0)
                        ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + p + "x" + q + "_" + i + "x" + j)).IsTapEnabled = true;
        }

        public void Won(int r, int s, int p, int q, string pen)
        {
            //((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + p + "x" + q)).Opacity = 0;
            //VictoryFlag.Text = Victory.ToString();
            Vacancy--;
            ((Windows.UI.Xaml.Controls.Image)this.FindName("Grid_" + r + "x" + s)).Opacity = 0;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + i + "x" + j)).Opacity = 0;
                }   
            }
            //((Windows.UI.Xaml.Controls.TextBlock)this.FindName("FinalWinBlock_" + r + "x" + s)).Text = "";
            if (pen == "X")
            {
                ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("FinalWinBlock_" + r + "x" + s)).Text = "X";
                WinnerBox.Text = "X won in " + r + ", " + s;
                winner[r - 1, s - 1] = 1;
                countX++;
            }
            else if (pen == "O")
            {
                ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("FinalWinBlock_" + r + "x" + s)).Text = "O";
                WinnerBox.Text = "O won in " + r + ", " + s;
                winner[r - 1, s - 1] = 2;
                countY++;
            }
            //if (winner[r - 1, s - 1] == 0)
            //{
            //    if (IndieCountX[r - 1, s - 1] + IndieCountY[r - 1, s - 1] == 9) //Was IndieCountX[r - 1, s- 1] > 4 || IndieCountY[r - 1, s- 1] > 4 
            //    {
            //        winner[r - 1, s - 1] = 3;
            //        MoveBox.Text = "Tie at " + r + "," + s + " and " + p + ", " + q;
            //    }
            //}
            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("WinnerBox_" + r + "x" + s)).Text = winner[r - 1, s - 1].ToString();
            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 1; j <= 3; j++)
            //    {
            //        ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("WinnerBox_" + i + "x" + j)).Text = winner[r - 1, s - 1].ToString();
            //    }
            //}
            //if (winner[r - 1, s - 1] == 3) //Sub-match draw
            //{
            //    //Implement this in Played()
            //}
            if (true) //Checking the main grid for the grand winner //Was winner[r - 1, s - 1] == 1 || winner[r - 1, s - 1] == 2
            {
                if ((r + s) % 4 == 0)
                {
                    if (r == 1) //1x3
                    {
                        if (winner[r - 1, s - 1] == winner[0, 1])
                        {
                            if (winner[r - 1, s - 1] == winner[0, 0])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won in the first row
                            }
                        }
                        if (winner[r - 1, s - 1] == winner[1, 2])
                        {
                            if (winner[r - 1, s - 1] == winner[2, 2])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won in the third column
                            }
                        }
                        if (winner[r - 1, s - 1] == winner[1, 1])
                        {
                            if (winner[r - 1, s - 1] == winner[2, 0])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won along the minor diagonal
                            }
                        }
                    }
                    else if (r == 3) //3x1
                    {
                        if (winner[r - 1, s - 1] == winner[1, 0])
                        {
                            if (winner[r - 1, s - 1] == winner[0, 0])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won in the first column
                            }
                        }
                        if (winner[r - 1, s - 1] == winner[2, 1])
                        {
                            if (winner[r - 1, s - 1] == winner[2, 2])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won in the third row
                            }
                        }
                        if (winner[r - 1, s - 1] == winner[1, 1])
                        {
                            if (winner[r - 1, s - 1] == winner[0, 2])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won along the minor diagonal
                            }
                        }
                    }
                    else if (r == 2) //2x2
                    {
                        if (winner[r - 1, s - 1] == winner[0, 1])
                        {
                            if (winner[r - 1, s - 1] == winner[2, 1])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won in the second column
                            }
                        }
                        if (winner[r - 1, s - 1] == winner[1, 2])
                        {
                            if (winner[r - 1, s - 1] == winner[1, 0])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won in the second row
                            }
                        }
                        if (winner[r - 1, s - 1] == winner[0, 2])
                        {
                            if (winner[r - 1, s - 1] == winner[2, 0])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won in the minor diagonal
                            }
                        }
                        if (winner[r - 1, s - 1] == winner[0, 0])
                        {
                            if (winner[r - 1, s - 1] == winner[2, 2])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won in the major diagonal
                            }
                        }
                    }
                }
                else if ((r + s) % 4 == 2)
                {
                    if (r == 1) //1x1
                    {
                        if (winner[r - 1, s - 1] == winner[1, 0])
                        {
                            if (winner[r - 1, s - 1] == winner[2, 0])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won in the first column
                            }
                        }
                        if (winner[r - 1, s - 1] == winner[0, 1])
                        {
                            if (winner[r - 1, s - 1] == winner[0, 2])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won in the first row
                            }
                        }
                        if (winner[r - 1, s - 1] == winner[1, 1])
                        {
                            if (winner[r - 1, s - 1] == winner[2, 2])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won along the major diagonal
                            }
                        }
                    }
                    else if (r == 3) //3x3
                    {
                        if (winner[r - 1, s - 1] == winner[1, 2])
                        {
                            if (winner[r - 1, s - 1] == winner[0, 2])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won in the third column
                            }
                        }
                        if (winner[r - 1, s - 1] == winner[2, 1])
                        {
                            if (winner[r - 1, s - 1] == winner[2, 0])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won in the third row
                            }
                        }
                        if (winner[r - 1, s - 1] == winner[1, 1])
                        {
                            if (winner[r - 1, s - 1] == winner[0, 0])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won along the major diagonal
                            }
                        }
                    }
                }
                else if (r == 2 && r != s)
                {
                    if (s == 1) //2x1
                    {
                        if (winner[r - 1, s - 1] == winner[1, 1])
                        {
                            if (winner[r - 1, s - 1] == winner[1, 2])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won in the second row
                            }
                        }
                        if (winner[r - 1, s - 1] == winner[0, 0])
                        {
                            if (winner[r - 1, s - 1] == winner[2, 0])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won in the first column
                            }
                        }
                    }
                    else //2x3
                    {
                        if (winner[r - 1, s - 1] == winner[0, 2])
                        {
                            if (winner[r - 1, s - 1] == winner[2, 2])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won in the second row
                            }
                        }
                        if (winner[r - 1, s - 1] == winner[1, 1])
                        {
                            if (winner[r - 1, s - 1] == winner[1, 0])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won in the third column
                            }
                        }
                    }
                }
                else if (s == 2 && r != s)
                {
                    if (r == 1) //1x2
                    {
                        if (winner[r - 1, s - 1] == winner[1, 1])
                        {
                            if (winner[r - 1, s - 1] == winner[2, 1])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won in the first row
                            }
                        }
                        if (winner[r - 1, s - 1] == winner[0, 0])
                        {
                            if (winner[r - 1, s - 1] == winner[0, 2])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won in the second column
                            }
                        }
                    }
                    else //3x2
                    {
                        if (winner[r - 1, s - 1] == winner[1, 1])
                        {
                            if (winner[r - 1, s - 1] == winner[0, 1])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won in the second column
                            }
                        }
                        if (winner[r - 1, s - 1] == winner[2, 0])
                        {
                            if (winner[r - 1, s - 1] == winner[2, 2])
                            {
                                BigWin(winner[r - 1, s - 1]); //Won in the third row
                            }
                        }
                    }
                }
            }
            //else if ( true ) //Checking the main grid for Oes
            //{
                
            //}
            /*for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if (i != r && j != s)
                    {
                        ((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + i + "x" + j)).IsTapEnabled = true;
                        Canvas.SetZIndex(((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + i + "x" + j)), 10);
                        //((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + i + "x" + j)).Opacity = 0.15;
                    }
                }
            }*/
            /*if (Victory == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (true)
                        {
                            
                        }
                    }
                }
            }*/
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        if (winner[i, j] != 0)
            //        {
            //            Vacancy--;
            //        }
            //    }
            //}
            //WinnerBox.Text = "Win at " + r + ", " + s;
            if (Victory == 0 && Vacancy == 0)
            {
                ((Windows.UI.Xaml.Controls.Image)this.FindName("MainGrid")).Opacity = 0;
                StatusBlock.Text = "The match tied!";
                ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("Victorious")).Text = "!";
                for (int i = 1; i <= 3; i++)
                {
                    for (int j = 1; j <= 3; j++)
                    {
                        ((Windows.UI.Xaml.Controls.Image)this.FindName("Grid_" + i + "x" + j)).Opacity = 0;
                        ((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + i + "x" + j)).Visibility = Visibility.Collapsed;
                        //NullOpacity();
                        ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("FinalWinBlock_" + i + "x" + j)).Opacity = 0;
                        for (int k = 1; k <= 3; k++)
                        {
                            for (int l = 1; l <= 3; l++)
                            {
                                ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + i + "x" + j + "_" + k + "x" + l)).Opacity = 0;
                            }
                        }
                    }
                }
            }
        }

        public void BigWin(int GrandWinner)
        {
            //for (int i = 0; i < length; i++)
            //{
            //    for (int j = 0; j < length; j++)
            //    {
                    
            //    }
            //}
            ((Windows.UI.Xaml.Controls.Image)this.FindName("MainGrid")).Opacity = 0;
            //NullOpacity();
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    ((Windows.UI.Xaml.Controls.Image)this.FindName("Grid_" + i + "x" + j)).Opacity = 0;
                    ((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + i + "x" + j)).Visibility = Visibility.Collapsed;
                    //NullOpacity();
                    ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("FinalWinBlock_"  + i + "x" + j)).Opacity = 0;
                    for (int k = 1; k <= 3; k++)
                    {
                        for (int l = 1; l <= 3; l++)
                        {
                            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + i + "x" + j + "_" + k + "x" + l)).Opacity = 0;
                        }
                    }
                }   
            }
            Victory = 1;
            //WinnerBox.Text = "Game over!";
            if (GrandWinner == 1)
            {
                WinnerBox.Text = "X wins the game!";
                ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("Victorious")).Text = "X";
            }
            else if (GrandWinner == 2)
            {
                WinnerBox.Text = "O wins the game!";
                ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("Victorious")).Text = "O";
            }
        }

        public void NullOpacity()
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    ((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + i + "x" + j)).Opacity = 0;
                }
            }
        }

        private void Back_1x1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            NullOpacity();
            Canvas.SetZIndex(Back_1x1, 0);
            Back_1x1.Opacity = 0.15;
            Activate(1, 1);
        }

        private void Back_1x2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            NullOpacity();
            Canvas.SetZIndex(Back_1x2, 0);
            Back_1x2.Opacity = 0.15;
            Activate(1, 2);
        }

        private void Back_1x3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            NullOpacity();
            Canvas.SetZIndex(Back_1x3, 0);
            Back_1x3.Opacity = 0.15;
            Activate(1, 3);
        }

        private void Back_2x1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            NullOpacity();
            Canvas.SetZIndex(Back_2x1, 0);
            Back_2x1.Opacity = 0.15;
            Activate(2, 1);
        }

        private void Back_2x2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            NullOpacity();
            Canvas.SetZIndex(Back_2x2, 0);
            Back_2x2.Opacity = 0.15;
            Activate(2, 2);
        }

        private void Back_2x3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            NullOpacity();
            Canvas.SetZIndex(Back_2x3, 0);
            Back_2x3.Opacity = 0.15;
            Activate(2, 3);
        }

        private void Back_3x1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            NullOpacity();
            Canvas.SetZIndex(Back_3x1, 0);
            Back_3x1.Opacity = 0.15;
            Activate(3, 1);
        }

        private void Back_3x2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            NullOpacity();
            Canvas.SetZIndex(Back_3x2, 0);
            Back_3x2.Opacity = 0.15;
            Activate(3, 2);
            //var info = ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource).DataContext;
            //TestTextBox.Text = info.ToString();
            //ButtonX.Content = info.ToString();
        }

        private void Back_3x3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //ButtonX.Content = "Works!";
            //SetZIndex();
            //Back_3x3.
            NullOpacity();
            Canvas.SetZIndex(Back_3x3, 0);
            //ButtonY.Content = (Canvas.GetZIndex(Back_3x3)).ToString();
            Back_3x3.Opacity = 0.15;
            Activate(3, 3);
        }

        /*public void Played(int p, int q, int r, int s)
        {
            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + p + "x" + q + "_" + r + "x" + s)).Text = pen;
        }*/

        private void TextBlock_1x1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //14 16
            var info = ((TextBlock)sender).Name;
            string r = info.Substring(10, 1);
            string s = info.Substring(12, 1);
            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + "1x1")).Text = pen;
            ((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + r + "x" + s)).Opacity = 0;
            Played(Int32.Parse(r), Int32.Parse(s), 1, 1);
            Transfer(Int32.Parse(r), Int32.Parse(s), 1, 1);
            //((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + r + "x" + s)).IsTapEnabled = true;
            //Canvas.SetZIndex(((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + r + "x" + s)), 0);
            //((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + r + "x" + s)).Opacity = 0.15;
            //Activate(Int32.Parse(r), Int32.Parse(s));
        }

        private void TextBlock_1x2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var info = ((TextBlock)sender).Name;
            string r = info.Substring(10, 1);
            string s = info.Substring(12, 1);
            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + "1x2")).Text = pen;
            //Transfer(Int32.Parse(r), Int32.Parse(s));
            ((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + r + "x" + s)).Opacity = 0;
            Played(Int32.Parse(r), Int32.Parse(s), 1, 2);
            Transfer(Int32.Parse(r), Int32.Parse(s), 1, 2);
        }

        private void TextBlock_1x3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var info = ((TextBlock)sender).Name;
            string r = info.Substring(10, 1);
            string s = info.Substring(12, 1);
            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + "1x3")).Text = pen;
            //((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_1x3_" + r + "x" + s)).Text = pen;
            ((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + r + "x" + s)).Opacity = 0;
            Played(Int32.Parse(r), Int32.Parse(s), 1, 3);
            Transfer(Int32.Parse(r), Int32.Parse(s), 1, 3);
        }

        private void TextBlock_2x1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var info = ((TextBlock)sender).Name;
            string r = info.Substring(10, 1);
            string s = info.Substring(12, 1);
            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + "2x1")).Text = pen;
            ((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + r + "x" + s)).Opacity = 0;
            Played(Int32.Parse(r), Int32.Parse(s), 2, 1);
            Transfer(Int32.Parse(r), Int32.Parse(s), 2, 1);
        }

        private void TextBlock_2x2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var info = ((TextBlock)sender).Name;
            string r = info.Substring(10, 1);
            string s = info.Substring(12, 1);
            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_2x2")).Text = pen;
            ((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + r + "x" + s)).Opacity = 0;
            Played(Int32.Parse(r), Int32.Parse(s), 2, 2);
            Transfer(Int32.Parse(r), Int32.Parse(s), 2, 2);
        }

        private void TextBlock_2x3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var info = ((TextBlock)sender).Name;
            string r = info.Substring(10, 1);
            string s = info.Substring(12, 1);
            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + "2x3")).Text = pen;
            ((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + r + "x" + s)).Opacity = 0;
            Played(Int32.Parse(r), Int32.Parse(s), 2, 3);
            Transfer(Int32.Parse(r), Int32.Parse(s), 2, 3);
        }

        private void TextBlock_3x1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var info = ((TextBlock)sender).Name;
            string r = info.Substring(10, 1);
            string s = info.Substring(12, 1);
            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + "3x1")).Text = pen;
            ((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + r + "x" + s)).Opacity = 0;
            Played(Int32.Parse(r), Int32.Parse(s), 3, 1);
            Transfer(Int32.Parse(r), Int32.Parse(s), 3, 1);
        }

        private void TextBlock_3x2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var info = ((TextBlock)sender).Name;
            string r = info.Substring(10, 1);
            string s = info.Substring(12, 1);
            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + "3x2")).Text = pen;
            ((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + r + "x" + s)).Opacity = 0;
            Played(Int32.Parse(r), Int32.Parse(s), 3, 2);
            Transfer(Int32.Parse(r), Int32.Parse(s), 3, 2);
        }

        private void TextBlock_3x3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var info = ((TextBlock)sender).Name;
            string r = info.Substring(10, 1);
            string s = info.Substring(12, 1);
            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + "3x3")).Text = pen;
            ((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + r + "x" + s)).Opacity = 0;
            Played(Int32.Parse(r), Int32.Parse(s), 3, 3);
            Transfer(Int32.Parse(r), Int32.Parse(s), 3, 3);
        }
    }
}