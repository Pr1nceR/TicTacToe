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
    /// <summary>
    /// Interaction logic for name.xaml
    /// </summary>
    public partial class name : Window
    {
        public name()
        {
            InitializeComponent();
        }

        public static string player1Piece = string.Empty;
        public static string player2Piece = string.Empty;
        public static string pass_string;
        public static string pass_string2;


        private void check()
        {
            but1.IsEnabled = true;
            but2.IsEnabled = true;
            but3.IsEnabled = true;
            but4.IsEnabled = true;
            but5.IsEnabled = true;
            but6.IsEnabled = true;
        }

        private void check1()
        {
            but11.IsEnabled = true;
            but22.IsEnabled = true;
            but33.IsEnabled = true;
            but44.IsEnabled = true;
            but55.IsEnabled = true;
            but66.IsEnabled = true;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            player1Piece = "1d018d32dcf81371fccb76c17b2044d4.png";
            check();
            but1.IsEnabled = false;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            player1Piece = "40-512.png";
            check();
            but2.IsEnabled = false;
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            player1Piece = "a93ae072d2ddaee0dbf4bc327c72810f.png";
            check();
            but3.IsEnabled = false;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            player1Piece = "bunnies-clipart-face-5.png";
            check();
            but4.IsEnabled = false;
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            player1Piece = "clipart-elephant-face-3.png";
            check();
            but5.IsEnabled = false;
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            player1Piece = "ebbccaf76f41f7d83e45a42974cfcd87-dog-illustration-by-vexels.png";
            check();
            but6.IsEnabled = false;
        }



        private void Button11_Click(object sender, RoutedEventArgs e)
        {
            player2Piece = "1d018d32dcf81371fccb76c17b2044d4.png";
            check1();
            but11.IsEnabled = false;
        }

        private void Button22_Click(object sender, RoutedEventArgs e)
        {
            player2Piece = "40-512.png";
            check1();
            but22.IsEnabled = false;
        }

        private void Button33_Click(object sender, RoutedEventArgs e)
        {
            player2Piece = "a93ae072d2ddaee0dbf4bc327c72810f.png";
            check1();
            but33.IsEnabled = false;
        }

        private void Button44_Click(object sender, RoutedEventArgs e)
        {
            player2Piece = "bunnies-clipart-face-5.png";
            check1();
            but44.IsEnabled = false;
        }

        private void Button55_Click(object sender, RoutedEventArgs e)
        {
            player2Piece = "clipart-elephant-face-3.png";
            check1();
            but55.IsEnabled = false;
        }

        private void Button66_Click(object sender, RoutedEventArgs e)
        {
            player2Piece = "ebbccaf76f41f7d83e45a42974cfcd87-dog-illustration-by-vexels.png";
            check1();
            but66.IsEnabled = false;
        }

        private void play_click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            pass_string = player1TextBox.Text;
            pass_string2 = player2TextBox.Text;
            Startgame now = new Startgame();
            winner wow = new winner();
            winner1 aw = new winner1();
            now.Show();
        }
    }
}
