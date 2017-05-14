using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;

namespace SPE_Project
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Player P = new Player();
        public MainWindow()
        {
            InitializeComponent();
            lblStatus.Content = P.lblStatus;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            P.selectLied();
            P.startLied();
            lblStatus.Content = P.lblStatus;

        }

        

        private void button_Pause_Click(object sender, RoutedEventArgs e)
        {
            P.pauseLied();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start("wmplayer.exe");
        }
    }
}
