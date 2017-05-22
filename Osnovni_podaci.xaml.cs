using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public static ObservableCollection<Tip> tipovi;
        public static ObservableCollection<Etiketa> etikete2;

        private string ikona = "Close-Icon.png";





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
            var x = new Tip_Resursa();
            x.Show();
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
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void btnEtiketaR_Click(object sender, RoutedEventArgs e)
        {
            var x = new Dodaj_etiketu();
            x.Show();
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
