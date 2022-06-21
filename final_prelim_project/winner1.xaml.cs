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
    /// Interaction logic for winner1.xaml
    /// </summary>
    public partial class winner1 : Window
    {
        public winner1()
        {
            InitializeComponent();
            playerwinnerTextblock2.Text = (name.pass_string2 + " Wins");
        }

        private void home_butz(object sender, RoutedEventArgs e)
        {
            MainWindow lol = new MainWindow();
            lol.Show();
            this.Close();
        }
    }
}
