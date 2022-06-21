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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace final_prelim_project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void start_click(object sender, RoutedEventArgs e)
        {
            name player = new name();
            player.Show();
            this.Hide();      
        }

        private void help_click(object sender, RoutedEventArgs e)
        {
            helptrue rule = new helptrue();
            rule.Show();
            this.Hide();
        }

        private void about_click(object sender, RoutedEventArgs e)
        {
            about how = new about();
            how.Show();
            this.Hide();
        }

        private void exit_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
