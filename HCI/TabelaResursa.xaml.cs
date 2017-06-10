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
    /// Interaction logic for TabelaResursa.xaml
    /// </summary>
    public partial class TabelaResursa : Window
    {
        public static List<Resurs> resursi6;

        public TabelaResursa()
        {
            resursi6 = new List<Resurs>();
            InitializeComponent();
            this.DataContext = this;
        }

        private void dataGridResursi_Loaded(object sender, RoutedEventArgs e)
        {
            var items = new List<Resurs>();

            foreach (Resurs r in MainWindow.resursi2)
            {
                items.Add(r);
            }

            var grid = sender as DataGrid;
            grid.ItemsSource = items;
        }

        private void pretragaTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            foreach (Resurs r in MainWindow.resursi2)
                if (r.OznakaResursa.Contains(pretragaTextBox.Text))
                    dataGridResursi.SelectedItem = r;
        }

        private void sortEtiketa_TextChanged(object sender, TextChangedEventArgs e)
        {
            var items = new List<Resurs>();
            if (sortCombo.SelectedIndex == 0)
            {
                foreach (Resurs r in MainWindow.resursi2)
                {
                    if (r.OznakaResursa.Contains(sortEtiketa.Text))
                    {
                        items.Add(r);
                    }

                }
            }
            else if (sortCombo.SelectedIndex == 1)
            {
                foreach (Resurs r in MainWindow.resursi2)
                {
                    if (r.ImeResursa.Contains(sortEtiketa.Text))
                    {
                        items.Add(r);
                    }

                }
            }
            else if (sortCombo.SelectedIndex == 2)
            {
                foreach (Resurs r in MainWindow.resursi2)
                {
                    if (r.OpisResursa.Contains(sortEtiketa.Text))
                    {
                        items.Add(r);
                    }

                }
            }
            else if (sortCombo.SelectedIndex == 3)
            {
                foreach (Resurs r in MainWindow.resursi2)
                {
                    if (r.Frekvencija.Contains(sortEtiketa.Text))
                    {
                        items.Add(r);
                    }

                }
            }
            else if (sortCombo.SelectedIndex == 4)
            {
                foreach (Resurs r in MainWindow.resursi2)
                {
                    if (r.Vaznost.Contains(sortEtiketa.Text))
                    {
                        items.Add(r);
                    }

                }
            }
            else if (sortCombo.SelectedIndex == 5)
            {
                foreach (Resurs r in MainWindow.resursi2)
                {
                    if (r.Eksploatacija.Contains(sortEtiketa.Text))
                    {
                        items.Add(r);
                    }

                }
            }
            else if (sortCombo.SelectedIndex == 6)
            {
                foreach (Resurs r in MainWindow.resursi2)
                {
                    if (r.Obnovljiv.Contains(sortEtiketa.Text))
                    {
                        items.Add(r);
                    }

                }
            }
            else if (sortCombo.SelectedIndex == 7)
            {
                foreach (Resurs r in MainWindow.resursi2)
                {
                    if (r.Jedinica.Contains(sortEtiketa.Text))
                    {
                        items.Add(r);
                    }

                }
            }
            else if (sortCombo.SelectedIndex == 8)
            {
                foreach (Resurs r in MainWindow.resursi2)
                {
                    if (r.Cena.Contains(sortEtiketa.Text))
                    {
                        items.Add(r);
                    }

                }
            }
            else if (sortCombo.SelectedIndex == 9)
            {
                foreach (Resurs r in MainWindow.resursi2)
                {
                    if (r.Datum.Contains(sortEtiketa.Text))
                    {
                        items.Add(r);
                    }

                }
            }
            else if (sortCombo.SelectedIndex == 10)
            {
                foreach (Resurs r in MainWindow.resursi2)
                {
                    if (r.TipResursa.ImeTipa.Contains(sortEtiketa.Text))
                    {
                        items.Add(r);
                    }

                }
            }

            dataGridResursi.ItemsSource = null;
            dataGridResursi.ItemsSource = items;
        }

        private void TRizmeniBtn_Click(object sender, RoutedEventArgs e)
        {

            Resurs r = (Resurs)dataGridResursi.SelectedItem;
            foreach (Resurs re in MainWindow.resursi2)
            {
                if (re.OznakaResursa == r.OznakaResursa)
                {
                    var wid = new Osnovni_podaci(re);
                    wid.Show();
                    wid.Closed += delegate
                    {
                        var items = new List<Resurs>();

                        foreach (Resurs res in MainWindow.resursi2)
                        {
                            items.Add(res);
                        }
                        dataGridResursi.ItemsSource = null;
                        dataGridResursi.ItemsSource = items;
                    };
                    break;
                }
            }
        }

        private void TRobrisiBtn_Click(object sender, RoutedEventArgs e)
        {
            Resurs r = (Resurs)dataGridResursi.SelectedItem;


            foreach (Resurs re in MainWindow.resursi2)
            {
                if (re.OznakaResursa == r.OznakaResursa)
                {
                    MainWindow.resursi2.Remove(re);
                    break;
                }
            }
            var items = new List<Resurs>();

            foreach (Resurs res in MainWindow.resursi2)
            {
                items.Add(res);
            }
            dataGridResursi.ItemsSource = null;
            dataGridResursi.ItemsSource = items;
            String podaciR = "";

            foreach (Resurs res in MainWindow.resursi2)
            {
                podaciR += res.OznakaResursa + "|" + res.ImeResursa + "|" + res.OpisResursa + "|" + res.TipResursa.ImeTipa + "|"
                            + res.TipResursa.OznakaTipa + "|" + res.TipResursa.OpisTipa + "|" + res.TipResursa.IkonicaTipa + "|"
                            + res.Frekvencija + "|" + res.IkonicaResursa + "|" + res.Obnovljiv + "|" + res.Vaznost + "|"
                            + res.Eksploatacija + "|" + res.Jedinica + "|" + res.Cena + "|" + res.Datum + "|";

                foreach (Etiketa eti in res.EtiketaResursa)
                {
                    podaciR += "/" + eti.OznakaEtikete + "/" + eti.BojaEtikete + "/" + eti.OpisEtikete;
                }
                podaciR += Environment.NewLine;
            }
            System.IO.File.WriteAllText("resursi.txt", podaciR);
        }
/*
        private void dataGridResursi_MouseEnter(object sender, MouseEventArgs e)
        {
           // resursi6.Clear();

            //if (File.Exists("resursi.txt"))
           // {
             //   string[] lines = System.IO.File.ReadAllLines(@"resursi.txt");
             /*   foreach (String l in lines)
                {
                    String[] podeljeni = l.Split('|');
                    Resurs r = new Tip(podeljeni[0], podeljeni[1], podeljeni[2], podeljeni[3]);
                    resursi6.Add(r);
                }

                foreach (String l in lines)
                {
                    String[] podeljeni = l.Split('|');
                    String[] podeljeni2 = podeljeni[15].Split('/');
                    Tip t = new Tip(podeljeni[3], podeljeni[4], podeljeni[5], podeljeni[6]);
                    //  Etiketa et = new Etiketa(podeljeni2[0], podeljeni2[1], podeljeni2[2]);
                    // Resurs r = new Resurs(podeljeni[0], podeljeni[1], podeljeni[2], t, podeljeni[7], podeljeni[8], podeljeni[9], podeljeni[10], podeljeni[11], podeljeni[12], podeljeni[13], podeljeni[14], et);
                    // resursi2.Add(r);
                    List<Etiketa> etikete = new List<Etiketa>();
                    Boolean x = true;
                    String str1 = "";
                    String str2 = "";
                    String str3 = "";
                    int i = 1;

                    while (x)
                    {
                        try
                        {
                            str1 = podeljeni2[i];
                            i++;
                            str2 = podeljeni2[i];
                            i++;
                            str3 = podeljeni2[i];
                            i++;

                            Etiketa Et = new Etiketa(str1, str2, str3);
                            etikete.Add(Et);

                        }
                        catch
                        {
                            x = false;
                        }
                    }

                    Resurs r = new Resurs(podeljeni[0], podeljeni[1], podeljeni[2], t, podeljeni[7], podeljeni[8], podeljeni[9], podeljeni[10], podeljeni[11], podeljeni[12], podeljeni[13], podeljeni[14], etikete);
                    resursi6.Add(r);
                    //tipovi4.Add(t);
                    //  etikete4.Add(et);

                }

            }

            dataGridResursi.ItemsSource = null;
            dataGridResursi.ItemsSource = resursi6;
        }
*/
        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            HelpProvider.ShowHelp("PomocTabelaResursa", this);
        }

        private void TRpomocBtn_Click(object sender, RoutedEventArgs e)
        {
            HelpProvider.ShowHelp("PomocTabelaResursa", this);
        }
    }
}
