using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
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
        public static ObservableCollection<Tip> tipovi2;
        public static ObservableCollection<Etiketa> etikete2;

        private string ikona = "Artboard.png";
        bool izmena;
        bool izmenaIkonica;
        string staraOznaka;
        
        public Osnovni_podaci()
        {
            InitializeComponent();
            this.DataContext = this;
            izmena = false;
            izmenaIkonica = true;
            tipovi2 = new ObservableCollection<Tip>();
            etikete2 = new ObservableCollection<Etiketa>();

            if(File.Exists("tipovi.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines(@"tipovi.txt");

                foreach(String l in lines)
                {
                    String[] podeljeni = l.Split('|');
                    Tip t = new Tip(podeljeni[0], podeljeni[1], podeljeni[2], podeljeni[3]);
                    tipovi2.Add(t);
                }
            }

            if(File.Exists("etikete.txt"))
            {
                string[] lines2 = System.IO.File.ReadAllLines(@"etikete.txt");

                foreach(String l in lines2)
                {
                    String[] podeljeni = l.Split('|');
                    Etiketa et = new Etiketa(podeljeni[0], podeljeni[1], podeljeni[2]);
                    etikete2.Add(et);
                }
            }

        }

        public Osnovni_podaci(Resurs res)
        {
            izmenaIkonica = false;
            InitializeComponent();
            this.DataContext = this;
            tipovi2 = new ObservableCollection<Tip>();
            etikete2 = new ObservableCollection<Etiketa>();

            if (File.Exists("tipovi.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines(@"tipovi.txt");

                foreach (String l in lines)
                {
                    String[] podeljeni = l.Split('|');
                    Tip t = new Tip(podeljeni[0], podeljeni[1], podeljeni[2], podeljeni[3]);
                    tipovi2.Add(t);
                }
            }

            if (File.Exists("etikete.txt"))
            {
                string[] lines2 = System.IO.File.ReadAllLines(@"etikete.txt");

                foreach (String l in lines2)
                {
                    String[] podeljeni = l.Split('|');
                    Etiketa et = new Etiketa(podeljeni[0], podeljeni[1], podeljeni[2]);
                    etikete2.Add(et);
                }
            }

            int br = 0;
            foreach(Tip tip in tipovi2)
            {
                if(tip.OznakaTipa == res.TipResursa.OznakaTipa)
                {
                    break;
                }

                br++;
            }

            Roznaka.Text = res.OznakaResursa;
            Roznaka.IsReadOnly = true;
            Rime.Text = res.ImeResursa;
            Ropis.Text = res.OpisResursa;
            Rtip.SelectedIndex = br;

            if(res.Frekvencija == "Redak")
            {
                frekvPojav.SelectedIndex = 0;
            } else if(res.Frekvencija == "Cest")
            {
                frekvPojav.SelectedIndex = 1;
            } else
            {
                frekvPojav.SelectedIndex = 2;
            }

            ikonicaRe = res.IkonicaResursa;

            if(res.Obnovljiv == "Obnovljiv")
            {
                obnovljivR.IsChecked = true;
            } else
            {
                neobnovljivR.IsChecked = true;
            }

            if(res.Vaznost == "Vazan")
            {
                vazanR.IsChecked = true;
            } else
            {
                nevazanR.IsChecked = true;
            }

            if(res.Eksploatacija == "Trenutno moguca")
            {
                eksplMoguca.IsChecked = true;
            } else
            {
                eksplNemoguca.IsChecked = true;
            }

            if(res.Jedinica == "Merica")
            {
                jedinicaMereR.SelectedIndex = 0;
            } else if(res.Jedinica == "Barel")
            {
                jedinicaMereR.SelectedIndex = 1;
            } else if(res.Jedinica == "Tona") {
                jedinicaMereR.SelectedIndex = 2;
            } else {
                jedinicaMereR.SelectedIndex = 3;
            }

            cenaR.Text = res.Cena;
            datumOtkr.Text = res.Datum;

            foreach(Etiketa etiketa in etikete2)
            {
                foreach(Etiketa e1 in res.EtiketaResursa)
                {
                    if (etiketa.OznakaEtikete == e1.OznakaEtikete)
                    {
                        listaEtiketa.SelectedItems.Add(etiketa);
                    }
                }
               
            }

            izmena = true;
            staraOznaka = res.OznakaResursa;

        }

        public ObservableCollection<Tip> tipoviR
        {
            get
            {
                return tipovi2;
            }

            set
            {
                tipovi2 = value;
                OnPropertyChanged(tipoviR);
            }
        }

        protected void OnPropertyChanged(ObservableCollection<Tip> tipovi2)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs("tipovi2"));
            }
        }

        public ObservableCollection<Etiketa> etiketeLista
        {
            get
            {
                return etikete2;
            }

            set
            {
                etikete2 = value;
                OnPropertyChanged(etiketeLista);
            }
        }

        protected void OnPropertyChanged(ObservableCollection<Etiketa> etikete2)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs("etikete2"));
            }
        }

        public string ikonicaRe
        {
            get
            {
                return ikona;
            }
            set
            {

                ikona = value;
                OnPropertyChanged("ikonicaRe");

            }
        }

        protected void OnPropertyChanged(string ikona)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(ikona));
            }
        }

        private void tipR_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(izmenaIkonica)
            {
                ikonicaRe = tipovi2.ElementAt(Rtip.SelectedIndex).getIkonicaTipa();
            }
            izmenaIkonica = true;
            
        }

        private void btnTipR_Click(object sender, RoutedEventArgs e)
        {
            var x = new Tip_Resursa();
            x.Show();
        }

        private void btnIkonicaR_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.DefaultExt = ".png";
            dlg.Filter = "PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            Nullable<bool> result = dlg.ShowDialog();
            ikonicaRe = dlg.FileName;
        }       

        private void btnEtiketaR_Click(object sender, RoutedEventArgs e)
        {
            var x = new Dodaj_etiketu();
            x.Show();
        }

        private void saveBtn_Click(object sender, RoutedEventArgs e)
        {
            int a;

            if(Roznaka.Text.Equals(""))
            {
                MessageBox.Show("Resurs mora imati oznaku!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
            } else if(Rime.Text.Equals(""))
            {
                MessageBox.Show("Resurs mora imati ime!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
            } else if(Rtip.SelectedIndex == -1)
            {
                MessageBox.Show("Resurs mora imati tip!" + Environment.NewLine + "Ukoliko u listi nema ponudjenih tipova resursa, kliknite na dugme \"Dodajte tip\" kako biste napravili novi tip.", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
            } else if(cenaR.Text.Equals(""))
            {
                MessageBox.Show("Resurs mora imati cenu!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
            } else if(!int.TryParse(cenaR.Text, out a))
            {
                MessageBox.Show("Cena mora biti celobrojna decimalna vrednost!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
            } else if(datumOtkr.Text.Equals(""))
            {
                MessageBox.Show("Morate uneti datum otkrivanja resursa!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
            } else
            {
                String podaciR = "";
                String podaciT = "";
                String podaciE = "";
                String frekvencija = "";
                String jedinicaM = "";

                foreach(Tip t in tipovi2)
                {
                    podaciT += t.OznakaTipa + "|" + t.ImeTipa + "|" + t.OpisTipa + "|" + t.IkonicaTipa + Environment.NewLine; 
                }
                System.IO.File.WriteAllText("tipovi.txt", podaciT);

                foreach (Etiketa et in etikete2)
                {
                    podaciE += et.OznakaEtikete + "|" + et.BojaEtikete + "|" + et.OpisEtikete + Environment.NewLine;
                }
                System.IO.File.WriteAllText("etikete.txt", podaciE);

                if(frekvPojav.SelectedIndex == 0)
                {
                    frekvencija = "Redak";
                } else if(frekvPojav.SelectedIndex == 1)
                {
                    frekvencija = "Cest";
                } else
                {
                    frekvencija = "Univerzalan";
                }

                if(jedinicaMereR.SelectedIndex == 0)
                {
                    jedinicaM = "Merica";
                } else if(jedinicaMereR.SelectedIndex == 1)
                {
                    jedinicaM = "Barel";
                } else if(jedinicaMereR.SelectedIndex == 2)
                {
                    jedinicaM = "Tona";
                } else
                {
                    jedinicaM = "Kilogram";
                }

                List<Etiketa> etikete = new List<Etiketa>();
                foreach(Etiketa e2 in listaEtiketa.SelectedItems)
                {
                    etikete.Add(e2);
                }

                Resurs r = new Resurs(Roznaka.Text, Rime.Text, Ropis.Text, tipovi2.ElementAt(Rtip.SelectedIndex), frekvencija, RimgIkonica.Source.ToString(), (bool)obnovljivR.IsChecked ? "Obnovljiv" : "Neobnovljiv", (bool)vazanR.IsChecked ? "Vazan" : "Nevazan", (bool)eksplMoguca.IsChecked ? "Trenutno moguca" : "Trenutno nemoguca", jedinicaM, cenaR.Text, datumOtkr.Text, etikete);

                Boolean upis = true;

                if(izmena)
                {
                    int ind = 0;

                    foreach(Resurs resurs in MainWindow.resursi2)
                    {
                        if(resurs.OznakaResursa == staraOznaka)
                        {
                            break;
                        }
                        ind++;
                    }

                    if(upis)
                    {
                        MainWindow.resursi2.RemoveAt(ind);
                        MainWindow.resursi2.Insert(ind, r);
                        MainWindow.indeks = ind;
                    } else
                    {
                        MessageBox.Show("Resurs sa ovom oznakom vec postoji!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }

                } else
                {
                    foreach(Resurs re in MainWindow.resursi2)
                    {
                        if(re.OznakaResursa == r.OznakaResursa)
                        {
                            upis = false;
                        }
                    }

                    if(upis)
                    {
                        MainWindow.resursi2.Add(r);
                    } else
                    {
                        MessageBox.Show("Resurs sa ovom oznakom vec postoji!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    
                }

                if(upis)
                {
                    foreach (Resurs res in MainWindow.resursi2)
                    {
                        podaciR += res.OznakaResursa + "|" + res.ImeResursa + "|" + res.OpisResursa + "|" + res.TipResursa.ImeTipa + "|"
                                    + res.TipResursa.OznakaTipa + "|" + res.TipResursa.OpisTipa + "|" + res.TipResursa.IkonicaTipa + "|"
                                    + res.Frekvencija + "|" + res.IkonicaResursa + "|" + res.Obnovljiv + "|" + res.Vaznost + "|"
                                    + res.Eksploatacija + "|" + res.Jedinica + "|" + res.Cena + "|" + res.Datum + "|";

                        foreach(Etiketa eti in res.EtiketaResursa)
                        {
                            podaciR += "/" + eti.OznakaEtikete + "/" + eti.BojaEtikete + "/" + eti.OpisEtikete;
                        }
                            podaciR += Environment.NewLine;
                    }
                    System.IO.File.WriteAllText("resursi.txt", podaciR);

                    Close();
                }      

            }

        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            HelpProvider.ShowHelp("PomocResurs", this);
        }

        private void pomocBtn_Click(object sender, RoutedEventArgs e)
        {
            HelpProvider.ShowHelp("PomocResurs", this);
        }
    }
}
