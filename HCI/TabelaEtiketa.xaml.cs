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
    /// Interaction logic for TabelaEtiketa.xaml
    /// </summary>
    public partial class TabelaEtiketa : Window
    {
        public static List<Etiketa> etikete3;
        public TabelaEtiketa()
        {
            etikete3 = new List<Etiketa>();
            InitializeComponent();
            this.DataContext = this;
        }

        private void dataGridEtikete_Loaded(object sender, RoutedEventArgs e)
        {
            
            if (File.Exists("etikete.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines(@"etikete.txt");
                foreach (String l in lines)
                {
                    String[] podeljeni = l.Split('|');

                    Etiketa et = new Etiketa(podeljeni[0], podeljeni[1], podeljeni[2]);
                    etikete3.Add(et);
                }
            }
            var grid = sender as DataGrid;
            grid.ItemsSource = etikete3;

            
/*
            var items = new List<Etiketa>();

            foreach (Etiketa et in MainWindow.etikete4)
            {
                items.Add(et);
            }

            var grid = sender as DataGrid;
            grid.ItemsSource = items;
*/
        }

        private void dataGridEtikete_MouseEnter(object sender, MouseEventArgs e)
        {
            etikete3.Clear();

            if (File.Exists("etikete.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines(@"etikete.txt");
                foreach (String l in lines)
                {
                    String[] podeljeni = l.Split('|');

                    Etiketa et = new Etiketa(podeljeni[0], podeljeni[1], podeljeni[2]);
                    etikete3.Add(et);
                }
            }
            dataGridEtikete.ItemsSource = null;
            dataGridEtikete.ItemsSource = etikete3;
        }

        private void TEbtnIzmena_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridEtikete.SelectedIndex != -1)
            {
                var x = new Dodaj_etiketu(etikete3.ElementAt(dataGridEtikete.SelectedIndex).OznakaEtikete, etikete3.ElementAt(dataGridEtikete.SelectedIndex).BojaEtikete, etikete3.ElementAt(dataGridEtikete.SelectedIndex).OpisEtikete);
                x.Show();
            }
        }

        private void TEbtnObrisi_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridEtikete.SelectedItem != null)
            {
                etikete3.RemoveAt(dataGridEtikete.SelectedIndex);

                String podaciEtikete = "";

                foreach (Etiketa et in etikete3)
                {
                    podaciEtikete += et.OznakaEtikete + "|" + et.BojaEtikete + "|" + et.OpisEtikete + Environment.NewLine;
                }
                System.IO.File.WriteAllText("etikete.txt", podaciEtikete);

                dataGridEtikete.ItemsSource = null;
                dataGridEtikete.ItemsSource = etikete3;
            }
        }

        private void TEpomocBtn_Click(object sender, RoutedEventArgs e)
        {
            HelpProvider.ShowHelp("PomocTabelaEtiketaiTipova", this);
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            HelpProvider.ShowHelp("PomocTabelaEtiketaiTipova", this);
        }
        /*
private void sortiranjeEtiketa_TextChanged(object sender, TextChangedEventArgs e)
{
  var items = new List<Etiketa>();
  if (sortComboEtiketa.SelectedIndex == 0)
  {
      foreach (Etiketa et in MainWindow.etikete4)
      {
          if (et.OznakaEtikete.Contains(sortiranjeEtiketa.Text))
          {
              items.Add(et);
          }

      }
  }
  else if (sortComboEtiketa.SelectedIndex == 0)
  {
      foreach (Etiketa et in MainWindow.etikete4)
      {
          if (et.BojaEtikete.Contains(sortiranjeEtiketa.Text))
          {
              items.Add(et);
          }

      }
  }
  else if (sortComboEtiketa.SelectedIndex == 0)
  {
      foreach (Etiketa et in MainWindow.etikete4)
      {
          if (et.OpisEtikete.Contains(sortiranjeEtiketa.Text))
          {
              items.Add(et);
          }

      }
  }

  dataGridEtikete.ItemsSource = null;
  dataGridEtikete.ItemsSource = items;
}

private void pretragaTextBoxEtiketa_TextChanged(object sender, TextChangedEventArgs e)
{
  foreach (Etiketa eti in MainWindow.etikete4)
      if (eti.OznakaEtikete.Contains(pretragaTextBoxEtiketa.Text))
          dataGridEtikete.SelectedItem = eti;
}

*/
    }
}
