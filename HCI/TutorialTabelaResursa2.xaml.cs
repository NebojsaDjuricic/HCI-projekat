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
    /// Interaction logic for TutoeialTabelaResursa2.xaml
    /// </summary>
    public partial class TutorialTabelaResursa2 : Window
    {
        public TutorialTabelaResursa2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var x = new TutorialTabelaResursa();
            x.Show();
            this.Close();
        }
    }
}
