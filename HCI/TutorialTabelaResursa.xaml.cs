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
    /// Interaction logic for TutorialTabelaResursa.xaml
    /// </summary>
    public partial class TutorialTabelaResursa : Window
    {
        public TutorialTabelaResursa()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var x = new TutorialTabelaResursa2();
            x.Show();
            this.Close();
        }
    }
}
