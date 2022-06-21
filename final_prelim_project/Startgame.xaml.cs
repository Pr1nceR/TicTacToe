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
using System.Windows.Shapes;

namespace final_prelim_project
{
    public partial class Startgame : Window
    {
        bool movePlayer = false; // False = player1, True = player2
        int count = 0;
        int playerA;
        int playerB;
        int rounds = 1;
        public static string playbox;
        char[,] table = new char[3, 3]; // Player1 = 'O', Player2 = 'X'
        name wow = new name();

        void DetermineWinner()
        {
            count++;
            for (int i = 0; i < 3; i++)
            {             
                // horizontal
                if (table[i, 0] == 'O' && table[i, 1] == 'O' && table[i, 2] == 'O')
                {
                    MessageBox.Show(name.pass_string + " Won");
                    playerA++;
                    scoreA.Text = Convert.ToString(playerA);
                    rounds++;
                    roundstry.Text = Convert.ToString(rounds);
                    reset_game();
                }
                else if (table[i, 0] == 'X' && table[i, 1] == 'X' && table[i, 2] == 'X')
                {
                    MessageBox.Show(name.pass_string2 + " Won");
                    playerB++;
                    scoreB.Text = Convert.ToString(playerB);
                    rounds++;
                    roundstry.Text = Convert.ToString(rounds);
                    reset_game();
                }
                // vertical 
                else if (table[0, i] == 'O' && table[1, i] == 'O' && table[2, i] == 'O')
                {
                    MessageBox.Show(name.pass_string + " Won");
                    playerA++;
                    scoreA.Text = Convert.ToString(playerA);
                    rounds++;
                    roundstry.Text = Convert.ToString(rounds);
                    reset_game();
                }
                else if (table[0, i] == 'X' && table[1, i] == 'X' && table[2, i] == 'X')
                {
                    MessageBox.Show(name.pass_string2 + " Won");
                    playerB++;
                    scoreB.Text = Convert.ToString(playerB);
                    rounds++;
                    roundstry.Text = Convert.ToString(rounds);
                    reset_game();
                }

            }
            // diagonal
            if (table[0, 0] == 'O' && table[1, 1] == 'O' && table[2, 2] == 'O')
            {
                MessageBox.Show(name.pass_string+" Won");
                playerA++;
                scoreA.Text = Convert.ToString(playerA);
                rounds++;
                roundstry.Text = Convert.ToString(rounds);
                reset_game();
            }
            else if (table[0, 0] == 'X' && table[1, 1] == 'X' && table[2, 2] == 'X')
            {
                MessageBox.Show(name.pass_string2 + " Won");
                playerB++;
                scoreB.Text = Convert.ToString(playerB);
                rounds++;
                roundstry.Text = Convert.ToString(rounds);
                reset_game();
            }
            else if (table[0, 2] == 'O' && table[1, 1] == 'O' && table[2, 0] == 'O')
            {
                MessageBox.Show(name.pass_string + " Won");
                playerA++;
                scoreA.Text = Convert.ToString(playerA);
                rounds++;
                roundstry.Text = Convert.ToString(rounds);
                reset_game();
            }
            else if (table[0, 2] == 'X' && table[1, 1] == 'X' && table[2, 0] == 'X')
            {
                MessageBox.Show(name.pass_string + " Won");
                playerA++;
                scoreA.Text = Convert.ToString(playerA);
                rounds++;
                roundstry.Text = Convert.ToString(rounds);
                reset_game();
            }
            else if (count == 9)
            {

                MessageBox.Show("No one wins the round! Draw!");
                reset_game();
            }

        }

        public Startgame()
        {
            InitializeComponent();
            player1textblock.Text = name.pass_string;
            player2textblock.Text = name.pass_string2;
        }
        name lol = new name();

        private void Index00Button_Click(object sender, RoutedEventArgs e)
        {

            if (movePlayer == false)
            {
                _index00Button.Content = new Image
                {
                    Source = new BitmapImage(new Uri( name.player1Piece, UriKind.Relative)),
                    VerticalAlignment = VerticalAlignment.Center,
                    Stretch = Stretch.Fill
                };
                movePlayer = true;
                table[0, 0] = 'O';
            }
            else
            {
                _index00Button.Content = new Image
                {
                    Source = new BitmapImage(new Uri( name.player2Piece, UriKind.Relative)),
                    VerticalAlignment = VerticalAlignment.Center,
                    Stretch = Stretch.Fill
                };
                movePlayer = false;
                table[0, 0] = 'X';
            }
            _index00Button.IsEnabled = false;
            DetermineWinner();
        }

        private void Index10Button_Click(object sender, RoutedEventArgs e)
        {
            if (movePlayer == false)
            {
                _index10Button.Content = new Image
                {
                    Source = new BitmapImage(new Uri( name.player1Piece, UriKind.Relative)),
                    VerticalAlignment = VerticalAlignment.Center,
                    Stretch = Stretch.Fill
                };
                movePlayer = true;
                table[1, 0] = 'O';
            }
            else
            {
                _index10Button.Content = new Image
                {
                    Source = new BitmapImage(new Uri( name.player2Piece, UriKind.Relative)),
                    VerticalAlignment = VerticalAlignment.Center,
                    Stretch = Stretch.Fill
                };
                movePlayer = false;
                table[1, 0] = 'X';
            }
            _index10Button.IsEnabled = false;
            DetermineWinner();
        }

        private void Index20Button_Click(object sender, RoutedEventArgs e)
        {
            if (movePlayer == false)
            {
                _index20Button.Content = new Image
                {
                    Source = new BitmapImage(new Uri( name.player1Piece, UriKind.Relative)),
                    VerticalAlignment = VerticalAlignment.Center,
                    Stretch = Stretch.Fill
                };
                movePlayer = true;
                table[2, 0] = 'O';
            }
            else
            {
                _index20Button.Content = new Image
                {
                    Source = new BitmapImage(new Uri("Resources/" + name.player2Piece, UriKind.Relative)),
                    VerticalAlignment = VerticalAlignment.Center,
                    Stretch = Stretch.Fill
                };
                movePlayer = false;
                table[2, 0] = 'X';
            }
            _index20Button.IsEnabled = false;
            DetermineWinner();
        }

        private void Index01Button_Click(object sender, RoutedEventArgs e)
        {
            if (movePlayer == false)
            {
                _index01Button.Content = new Image
                {
                    Source = new BitmapImage(new Uri( name.player1Piece, UriKind.Relative)),
                    VerticalAlignment = VerticalAlignment.Center,
                    Stretch = Stretch.Fill
                };
                movePlayer = true;
                table[0, 1] = 'O';
            }
            else
            {
                _index01Button.Content = new Image
                {
                    Source = new BitmapImage(new Uri( name.player2Piece, UriKind.Relative)),
                    VerticalAlignment = VerticalAlignment.Center,
                    Stretch = Stretch.Fill
                };
                movePlayer = false;
                table[0, 1] = 'X';
            }
            _index01Button.IsEnabled = false;
            DetermineWinner();
        }

        private void Index11Button_Click(object sender, RoutedEventArgs e)
        {
            if (movePlayer == false)
            {
                _index11Button.Content = new Image
                {
                    Source = new BitmapImage(new Uri( name.player1Piece, UriKind.Relative)),
                    VerticalAlignment = VerticalAlignment.Center,
                    Stretch = Stretch.Fill
                };
                movePlayer = true;
                table[1, 1] = 'O';
            }
            else
            {
                _index11Button.Content = new Image
                {
                    Source = new BitmapImage(new Uri( name.player2Piece, UriKind.Relative)),
                    VerticalAlignment = VerticalAlignment.Center,
                    Stretch = Stretch.Fill
                };
                movePlayer = false;
                table[1, 1] = 'X';
            }
            _index11Button.IsEnabled = false;
            DetermineWinner();
        }

        private void Index21Button_Click(object sender, RoutedEventArgs e)
        {
            if (movePlayer == false)
            {
                _index21Button.Content = new Image
                {
                    Source = new BitmapImage(new Uri(name.player1Piece, UriKind.Relative)),
                    VerticalAlignment = VerticalAlignment.Center,
                    Stretch = Stretch.Fill
                };
                movePlayer = true;
                table[2, 1] = 'O';
            }
            else
            {
                _index21Button.Content = new Image
                {
                    Source = new BitmapImage(new Uri( name.player2Piece, UriKind.Relative)),
                    VerticalAlignment = VerticalAlignment.Center,
                    Stretch = Stretch.Fill
                };
                movePlayer = false;
                table[2, 1] = 'X';
            }
            _index21Button.IsEnabled = false;
            DetermineWinner();
        }

        private void Index02Button_Click(object sender, RoutedEventArgs e)
        {
            if (movePlayer == false)
            {
                _index02Button.Content = new Image
                {
                    Source = new BitmapImage(new Uri(name.player1Piece, UriKind.Relative)),
                    VerticalAlignment = VerticalAlignment.Center,
                    Stretch = Stretch.Fill
                };
                movePlayer = true;
                table[0, 2] = 'O';
            }
            else
            {
                _index02Button.Content = new Image
                {
                    Source = new BitmapImage(new Uri(name.player2Piece, UriKind.Relative)),
                    VerticalAlignment = VerticalAlignment.Center,
                    Stretch = Stretch.Fill
                };
                movePlayer = false;
                table[0, 2] = 'X';
            }
            _index02Button.IsEnabled = false;
            DetermineWinner();
        }

        private void Index12Button_Click(object sender, RoutedEventArgs e)
        {
            if (movePlayer == false)
            {
                _index12Button.Content = new Image
                {
                    Source = new BitmapImage(new Uri( name.player1Piece, UriKind.Relative)),
                    VerticalAlignment = VerticalAlignment.Center,
                    Stretch = Stretch.Fill
                };
                movePlayer = true;
                table[1, 2] = 'O';
            }
            else
            {
                _index12Button.Content = new Image
                {
                    Source = new BitmapImage(new Uri(name.player2Piece, UriKind.Relative)),
                    VerticalAlignment = VerticalAlignment.Center,
                    Stretch = Stretch.Fill
                };
                movePlayer = false;
                table[1, 2] = 'X';
            }
            _index12Button.IsEnabled = false;
            DetermineWinner();
        }

        private void Index22Button_Click(object sender, RoutedEventArgs e)
        {
            if (movePlayer == false)
            {
                _index22Button.Content = new Image
                {
                    Source = new BitmapImage(new Uri( name.player1Piece, UriKind.Relative)),
                    VerticalAlignment = VerticalAlignment.Center,
                    Stretch = Stretch.Fill
                };
                movePlayer = true;
                table[2, 2] = 'O';
            }
            else
            {
                _index22Button.Content = new Image
                {
                    Source = new BitmapImage(new Uri(name.player2Piece, UriKind.Relative)),
                    VerticalAlignment = VerticalAlignment.Center,
                    Stretch = Stretch.Fill
                };
                movePlayer = false;
                table[2, 2] = 'X';
            }
            _index22Button.IsEnabled = false;
            DetermineWinner();
        }

        private void reset_game()
        {         
            movePlayer = false;
            table = new char[3, 3];
            count = 0;
            if (rounds == 6)
            {
                this.Close();
            }
            if (playerA == 3)
            {
                winner shox = new winner();              
                shox.Show();
                this.Close();
            }
            else if (playerB == 3)
            {
                winner1 shoxz = new winner1();
                shoxz.Show();
                this.Close();
            }
            _index00Button.Content = " ";
            _index10Button.Content = " ";
            _index20Button.Content = " ";
            _index01Button.Content = " ";
            _index11Button.Content = " ";
            _index21Button.Content = " ";
            _index02Button.Content = " ";
            _index12Button.Content = " ";
            _index22Button.Content = " ";

            _index00Button.IsEnabled = true;
            _index10Button.IsEnabled = true;
            _index20Button.IsEnabled = true;
            _index01Button.IsEnabled = true;
            _index11Button.IsEnabled = true;
            _index21Button.IsEnabled = true;
            _index02Button.IsEnabled = true;
            _index12Button.IsEnabled = true;
            _index22Button.IsEnabled = true;

        }

        private void back_mainclick(object sender, RoutedEventArgs e)
        {           
            MainWindow now = new MainWindow();
            now.Show();
            this.Hide();       
        }
    }

}
