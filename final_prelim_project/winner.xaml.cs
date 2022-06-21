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
    /// Interaction logic for winner.xaml
    /// </summary>
    public partial class winner : Window
    {
        public winner()
        {
            InitializeComponent();
            playerwinnerTextblock.Text = (name.pass_string + " Wins");
        }

        private void home_buts(object sender, RoutedEventArgs e)
        {
            MainWindow lol = new MainWindow();
            lol.Show();
            this.Close();
        }
    }
}
