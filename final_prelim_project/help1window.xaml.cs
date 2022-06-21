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
    /// Interaction logic for help1window.xaml
    /// </summary>
    public partial class help1window : Window
    {
        public help1window()
        {
            InitializeComponent();
        }

        private void back(object sender, RoutedEventArgs e)
        {
            help he = new help();
            he.Show();
            this.Hide();
        }

        private void next(object sender, RoutedEventArgs e)
        {
            help2window he2 = new help2window();
            he2.Show();
            this.Hide();
        }
    }
}
