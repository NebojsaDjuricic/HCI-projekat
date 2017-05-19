using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for Osnovni_podaci.xaml
    /// </summary>
    public partial class Osnovni_podaci : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Osnovni_podaci()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void tipR_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnTipR_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnIkonicaR_Click(object sender, RoutedEventArgs e)
        {

        }

        private void obnovljivR_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void vazanR_Checked(object sender, RoutedEventArgs e)
        {

        }
 
        private void eksplMoguca_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cenaR_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void btnEtiketaR_Click(object sender, RoutedEventArgs e)
        {

        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
