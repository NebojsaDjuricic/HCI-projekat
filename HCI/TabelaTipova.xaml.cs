using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for TabelaTipova.xaml
    /// </summary>
    public partial class TabelaTipova : Window
    {
        public static List<Tip> tipovi3;
        public TabelaTipova()
        {
            tipovi3 = new List<Tip>();
            InitializeComponent();
            this.DataContext = this;
        }

        private void dataGridTipovi_Loaded(object sender, RoutedEventArgs e)
        {
            
            if (File.Exists("tipovi.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines(@"tipovi.txt");
                foreach (String l in lines)
                {
                    String[] podeljeni = l.Split('|');
                    Tip t = new Tip(podeljeni[0], podeljeni[1], podeljeni[2], podeljeni[3]);
                    tipovi3.Add(t);
                }
            }
            var grid = sender as DataGrid;
            grid.ItemsSource = tipovi3;
            

            /*
            var items = new List<Tip>();

            foreach (Tip t in MainWindow.tipovi4)
            {
                items.Add(t);
            }


            var grid = sender as DataGrid;
            grid.ItemsSource = items;
            */
        }

        private void dataGridTipovi_MouseEnter(object sender, MouseEventArgs e)
        {
            tipovi3.Clear();

            if (File.Exists("tipovi.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines(@"tipovi.txt");
                foreach (String l in lines)
                {
                    String[] podeljeni = l.Split('|');
                    Tip t = new Tip(podeljeni[0], podeljeni[1], podeljeni[2], podeljeni[3]);
                    tipovi3.Add(t);
                }
            }

            dataGridTipovi.ItemsSource = null;
            dataGridTipovi.ItemsSource = tipovi3;
        }

        private void TTbtnIzmena_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridTipovi.SelectedIndex != -1)
            {
                var x = new Tip_Resursa(tipovi3.ElementAt(dataGridTipovi.SelectedIndex).OznakaTipa, tipovi3.ElementAt(dataGridTipovi.SelectedIndex).ImeTipa, tipovi3.ElementAt(dataGridTipovi.SelectedIndex).IkonicaTipa, tipovi3.ElementAt(dataGridTipovi.SelectedIndex).OpisTipa);
                x.Show();
            }
        }

        private void TTbtnObrisi_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridTipovi.SelectedItem != null)
            {
                tipovi3.RemoveAt(dataGridTipovi.SelectedIndex);

                String podaciTipovi = "";
                foreach (Tip t in tipovi3)
                {
                    podaciTipovi += t.OznakaTipa + "|" + t.ImeTipa + "|" + t.OpisTipa + "|" + t.IkonicaTipa + Environment.NewLine;
                }

                System.IO.File.WriteAllText("tipovi.txt", podaciTipovi);

                dataGridTipovi.ItemsSource = null;
                dataGridTipovi.ItemsSource = tipovi3;
            }
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            HelpProvider.ShowHelp("PomocTabelaEtiketaiTipova", this);
        }

        private void TTpomocBtn_Click(object sender, RoutedEventArgs e)
        {
            HelpProvider.ShowHelp("PomocTabelaEtiketaiTipova", this);
        }


        /*
       private void pretragaTextBox_TextChanged(object sender, TextChangedEventArgs e)
       {
           foreach (Tip t in MainWindow.tipovi4)
               if (t.OznakaTipa.Contains(pretragaTextBoxTip.Text))
                   dataGridTipovi.SelectedItem = t;
       }

       private void sortiranje_TextChanged(object sender, TextChangedEventArgs e)
       {
           var items = new List<Tip>();
           if (sortComboTip.SelectedIndex == 0)
           {
               foreach (Tip t in MainWindow.tipovi4)
               {
                   if (t.OznakaTipa.Contains(sortiranje.Text))
                   {
                       items.Add(t);
                   }

               }
           }
           else if (sortComboTip.SelectedIndex == 1)
           {
               foreach (Tip t in MainWindow.tipovi4)
               {
                   if (t.ImeTipa.Contains(sortiranje.Text))
                   {
                       items.Add(t);
                   }

               }
           }
           else if (sortComboTip.SelectedIndex == 2)
           {
               foreach (Tip t in MainWindow.tipovi4)
               {
                   if (t.OpisTipa.Contains(sortiranje.Text))
                   {
                       items.Add(t);
                   }

               }
           }

           dataGridTipovi.ItemsSource = null;
           dataGridTipovi.ItemsSource = items;
       }

       */

    }
}
