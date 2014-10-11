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
using Windows.UI.Popups;
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
                        }
                    }
                }
            }
        }

        string pen = "";
        int[,] winner = new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        int countX = 0;
        int countY = 0;
        int[,] IndieCountX = new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        int[,] IndieCountY = new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
        int Vacancy = 9;
        int Victory = 0;

        private void ButtonX_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    Canvas.SetZIndex(((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + i + "x" + j)), 10);
                }
            }
            ButtonY.IsEnabled = false;
            pen = "X";
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
            ButtonY.IsEnabled = false;
            StatusBlock.Text = pen + "'s turn";
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
                            ((global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + i + "x" + j + "_" + k + "x" + l)).IsTapEnabled = false;
                        }
                    }
                }
            }
        }

        public void Played( int r, int s, int p, int q )
        {
            int sum = p + q;
            if (sum % 4 == 0) //1x3 and 3x1
            {
                if (p == 1) //1x3
                {
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q - 1))).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q - 2))).Text == pen)
                        {
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p + 1) + "x" + q)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p + 2) + "x" + q)).Text == pen)
                        {
                            Won(r, s, p, q , pen);
                        }
                    }
                    if(((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 2 + "x" + 2)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p + 2) + "x" + (q - 2))).Text == pen)
                        {
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
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q + 1))).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q+2))).Text == pen)
                        {
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 2 + "x" + 2)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p - 2) + "x" + (q + 2))).Text == pen)
                        {
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
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 1 + "x" + 2)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 3 + "x" + 2)).Text == pen)
                        {
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 2 + "x" + 1)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 2 + "x" + 3)).Text == pen)
                        {
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 1 + "x" + 3)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 3 + "x" + 1)).Text == pen)
                        {
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
                        if(((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 3 + "x" + 3)).Text == pen) 
                        {
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q + 1))).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q + 2))).Text == pen)
                        {
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p + 1) + "x" + q)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p + 2) + "x" + q)).Text == pen)
                        {
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
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q - 1))).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q - 2))).Text == pen)
                        {
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p - 1) + "x" + (q - 1))).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p - 2) + "x" + (q - 2))).Text == pen)
                        {
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
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 2 + "x" + 2)).Text == pen)
                    {
                        if(((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q + 2))).Text == pen) 
                        {
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
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 2 + "x" + 2)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + p + "x" + (q - 2))).Text == pen)
                        {
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
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 2 + "x" + 2)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p + 2) + "x" + q)).Text == pen)
                        {
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
                            Won(r, s, p, q , pen);
                        }
                    }
                    if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + 2 + "x" + 2)).Text == pen)
                    {
                        if (((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + (p - 2) + "x" + q)).Text == pen)
                        {
                            Won(r, s, p, q , pen);
                        }
                    }
                }
            }

            if (Victory != 1)
            {
                if (pen == "X")
                {
                    IndieCountX[r - 1, s - 1]++;
                    pen = "O";
                    StatusBlock.Text = pen + "'s turn";
                }
                else if (pen == "O")
                {
                    IndieCountY[r - 1, s - 1]++;
                    pen = "X";
                    StatusBlock.Text = pen + "'s turn";
                }
            }

            if (winner[r - 1, s - 1] == 0)
            {
                if (IndieCountX[r - 1, s - 1] + IndieCountY[r - 1, s - 1] == 9)
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
                }
            }
        }

        public void Transfer(int r, int s, int p, int q)
        {
            if (winner[p - 1, q - 1] == 1 || winner[p - 1, q - 1] == 2 || winner[p - 1, q - 1] == 3)
            { 
                Wait(r, s, p, q);
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
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    if (winner[i - 1, j - 1] == 0)
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
            Vacancy--;
            ((Windows.UI.Xaml.Controls.Image)this.FindName("Grid_" + r + "x" + s)).Opacity = 0;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + i + "x" + j)).Opacity = 0;
                }   
            }

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
            //((Windows.UI.Xaml.Controls.TextBlock)this.FindName("WinnerBox_" + r + "x" + s)).Text = winner[r - 1, s - 1].ToString();

            if (true) //Checking the main grid for the grand winner
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
            
            if (Victory == 0 && Vacancy == 0)
            {
                ((Windows.UI.Xaml.Controls.Image)this.FindName("MainGrid")).Opacity = 0;
                WinnerBox.Text = "The match tied!";
                StatusBlock.Text = "";
                ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("Victorious")).Text = "!";
                ResetButton.IsEnabled = true;
                ResetButton.Opacity = 1;
                for (int i = 1; i <= 3; i++)
                {
                    for (int j = 1; j <= 3; j++)
                    {
                        ((Windows.UI.Xaml.Controls.Image)this.FindName("Grid_" + i + "x" + j)).Opacity = 0;
                        ((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + i + "x" + j)).Visibility = Visibility.Collapsed;
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
            ((Windows.UI.Xaml.Controls.Image)this.FindName("MainGrid")).Opacity = 0;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    ((Windows.UI.Xaml.Controls.Image)this.FindName("Grid_" + i + "x" + j)).Opacity = 0;
                    ((Windows.UI.Xaml.Shapes.Rectangle)this.FindName("Back_" + i + "x" + j)).Visibility = Visibility.Collapsed;
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
            if (GrandWinner == 1)
            {
                StatusBlock.Text = "";
                WinnerBox.Text = "X wins the game!";
                ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("Victorious")).Text = "X";
            }
            else if (GrandWinner == 2)
            {
                WinnerBox.Text = "O wins the game!";
                StatusBlock.Text = "";
                ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("Victorious")).Text = "O";
            }
            ResetButton.IsEnabled = true;
            ResetButton.Opacity = 1;
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
        }

        private void Back_3x3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            NullOpacity();
            Canvas.SetZIndex(Back_3x3, 0);
            Back_3x3.Opacity = 0.15;
            Activate(3, 3);
        }

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
        }

        private void TextBlock_1x2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var info = ((TextBlock)sender).Name;
            string r = info.Substring(10, 1);
            string s = info.Substring(12, 1);
            ((Windows.UI.Xaml.Controls.TextBlock)this.FindName("TextBlock_" + r + "x" + s + "_" + "1x2")).Text = pen;
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

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            //var CurrentFrame = Window.Current.Content as Frame;
            //CurrentFrame.Navigate(CurrentFrame.Content.GetType());
            //CurrentFrame.GoBack();
            Frame.Navigate(typeof(MainPage));
            Frame.GoBack(); 
        }

        private void CommandInvokedHandler(IUICommand command)
        {
            //throw new NotImplementedException();
            if (command.Label == "Yes")
            {
                Frame.GoBack();
            }
        }
        private async void backButton_Click(object sender, RoutedEventArgs e)
        {
            //Frame.GoBack();
            //Frame.Navigate(typeof(MenuPage));
            var Alert = new MessageDialog("Are you sure you want to quit this game?");
            //Frame.GoBack();
            Alert.Commands.Add(new UICommand("Yes", new UICommandInvokedHandler(this.CommandInvokedHandler)));
            Alert.Commands.Add(new UICommand("No", new UICommandInvokedHandler(this.CommandInvokedHandler)));
            Alert.DefaultCommandIndex = 0;
            await Alert.ShowAsync();
        }
    }
}