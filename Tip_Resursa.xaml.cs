using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Interaction logic for Tip_Resursa.xaml
    /// </summary>
    public partial class Tip_Resursa : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        static public List<Tip> tipovi = new List<Tip>();
        String ime;
        String staroIme;
        bool odakle;
        bool pojedinacno;

        public Tip_Resursa()
        {
            odakle = false;
            pojedinacno = false;
            InitializeComponent();
            this.DataContext = this;

            ikonicaTipa = "Close-Icon.png";
        }

        public String ikonicaTipa
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
                OnPropertyChanged("ikonicaTipa");
            }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public Tip_Resursa(bool b)
        {
            odakle = true;
            pojedinacno = true;
            InitializeComponent();
            this.DataContext = this;

            ikonicaTipa = "Close-Icon.png";
        }

        public Tip_Resursa(String oz, String ime, String iko, String opis)
        {
            odakle = true;
            InitializeComponent();
            Toznaka.Text = oz;
            Time.Text = ime;
            ikonicaTipa = iko;
            Topis.Text = opis;
            staroIme = oz;
            this.DataContext = this;
        }


        private void TbtnIkonica_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.DefaultExt = ".png";
            dlg.Filter = "PNG Files (*.png)|*.png|JPEG Files (*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            Nullable<bool> result = dlg.ShowDialog();
            Console.WriteLine(dlg.FileName);

            ikonicaTipa = dlg.FileName;
        }

        private void TsaveBtn_Click(object sender, RoutedEventArgs e)
        {
            bool sadrzi = false;

            if(odakle)
            {
                ObservableCollection<Tip> tipovi2 = new ObservableCollection<Tip>();
                if(File.Exists("tipovi.txt"))
                {
                    string[] lines = System.IO.File.ReadAllLines(@"tipovi.txt");

                    foreach (String l in lines)
                    {
                        String[] podeljeni = l.Split('|');
                        Tip t = new Tip(podeljeni[0], podeljeni[1], podeljeni[2], podeljeni[3]);
                        tipovi2.Add(t);
                    }
                }

                if(pojedinacno)
                {
                    foreach(Tip tip in tipovi2)
                    {
                        if(tip.OznakaTipa == Toznaka.Text)
                        {
                            sadrzi = true;
                        }
                    }

                    if(sadrzi)
                    {
                        MessageBox.Show("Tip sa ovom oznakom vec postoji!", "Upozorenje", MessageBoxButton.OK);
                    } else
                    {
                        Tip t = new Tip(Toznaka.Text, Time.Text, Topis.Text, ikonicaTipa);
                        tipovi2.Add(t);
                    }

                } else
                {
                    foreach(Tip tip in tipovi2)
                    {
                        if(tip.OznakaTipa == staroIme)
                        {
                            tip.OznakaTipa = Toznaka.Text;
                            tip.ImeTipa = Time.Text;
                            tip.IkonicaTipa = ikonicaTipa;
                            tip.OpisTipa = Topis.Text;
                            break;
                        }
                    }
                }

                if(!sadrzi)
                {
                    String podaci = "";

                    foreach(Tip t in tipovi2)
                    {
                        podaci += t.OznakaTipa + "|" + t.ImeTipa + "|" + t.OpisTipa + "|" + t.IkonicaTipa + Environment.NewLine;
                    }

                    System.IO.File.WriteAllText("tipovi.txt", podaci);
                    this.Close();
                }

            } else
            {
                bool ima = false;
                Tip t = new Tip(Toznaka.Text, Time.Text, Topis.Text, ikonicaTipa);

                foreach(Tip tip in Osnovni_podaci.tipovi)
                {
                    if(tip.OznakaTipa == Toznaka.Text)
                    {
                        ima = true;
                    }
                }

                if(ima)
                {
                    MessageBox.Show("Tip sa ovom oznakom vec postoji!", "Upozorenje", MessageBoxButton.OK);
                } else
                {
                    Osnovni_podaci.tipovi.Add(t);
                    this.Close();
                }
            }




        }

        private void TcloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
