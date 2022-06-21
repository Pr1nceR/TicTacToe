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
    /// Interaction logic for helptrue.xaml
    /// </summary>
    public partial class helptrue : Window
    {
        public helptrue()
        {
            InitializeComponent();
        }

        private void tun(object sender, RoutedEventArgs e)
        {
            help1window h1 = new help1window();
            h1.Show();
            this.Hide();
        }

        private void bacck(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
        }
    }
}
