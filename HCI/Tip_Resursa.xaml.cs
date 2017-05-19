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
    /// Interaction logic for Tip_Resursa.xaml
    /// </summary>
    public partial class Tip_Resursa : Window
    {
        public Tip_Resursa()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void TbtnIkonica_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TsaveBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TcloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
