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

namespace HCI
{
    /// <summary>
    /// Interaction logic for Dodaj_etiketu.xaml
    /// </summary>
    public partial class Dodaj_etiketu : Window
    {
        public Dodaj_etiketu()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void EsaveBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EcloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
