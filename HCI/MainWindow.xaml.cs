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

namespace HCI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var x = new Osnovni_podaci();
            x.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            var x = new Tip_Resursa();
            x.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            var x = new Dodaj_etiketu();
            x.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            var x = new TabelaResursa();
            x.Show();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            var x = new TabelaTipova();
            x.Show();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            var x = new TabelaEtiketa();
            x.Show();
        }
    }
}
