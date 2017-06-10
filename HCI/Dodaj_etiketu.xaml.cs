using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Dodaj_etiketu.xaml
    /// </summary>
    public partial class Dodaj_etiketu : Window
    {
        bool odakle;
        string staroIme;
        bool pojedinacno;

        public Dodaj_etiketu()
        {
            InitializeComponent();
            pojedinacno = false;
            odakle = false;
        }

        public Dodaj_etiketu(Boolean b)
        {
            InitializeComponent();
            odakle = true;
            pojedinacno = true;
        }

        public Dodaj_etiketu(String oz, String boja, String op)
        {
            staroIme = oz;
            InitializeComponent();
            Eoznaka.Text = oz;
            Eopis.Text = op;

            Color c = (Color)ColorConverter.ConvertFromString(boja);
            bojaEtikete.SelectedColor = c;

            odakle = true;
            pojedinacno = false;
        }

        private void EsaveBtn_Click(object sender, RoutedEventArgs e)
        {
            bool sadrzi = false;

            if (Eoznaka.Text.Equals(""))
            {
                MessageBox.Show("Etiketa mora imati oznaku!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {



                if (odakle)
                {
                    ObservableCollection<Etiketa> etikete2 = new ObservableCollection<Etiketa>();
                    if (File.Exists("etikete.txt"))
                    {
                        string[] lines = System.IO.File.ReadAllLines(@"etikete.txt");
                        foreach (String l in lines)
                        {
                            String[] podeljeni = l.Split('|');
                            Etiketa et = new Etiketa(podeljeni[0], podeljeni[1], podeljeni[2]);
                            etikete2.Add(et);
                        }
                    }

                    if (pojedinacno)
                    {
                        foreach (Etiketa eti in etikete2)
                        {
                            if (eti.OznakaEtikete == Eoznaka.Text)
                            {
                                sadrzi = true;
                            }
                        }

                        if (sadrzi)
                        {
                            MessageBox.Show("Etiketa sa ovom oznakom vec postoji!", "Upozorenje", MessageBoxButton.OK);
                        }
                        else
                        {
                            Etiketa et = new Etiketa(Eoznaka.Text, bojaEtikete.SelectedColor.ToString(), Eopis.Text);
                            etikete2.Add(et);
                        }

                    }
                    else
                    {
                        foreach (Etiketa eti in etikete2)
                        {
                            if (eti.OznakaEtikete == staroIme)
                            {
                                eti.OznakaEtikete = Eoznaka.Text;
                                eti.BojaEtikete = bojaEtikete.SelectedColor.ToString();
                                eti.OpisEtikete = Eopis.Text;
                                break;
                            }
                        }
                    }

                    if (!sadrzi)
                    {
                        String podaci = "";
                        foreach (Etiketa et in etikete2)
                        {
                            podaci += et.OznakaEtikete + "|" + et.BojaEtikete + "|" + et.OpisEtikete + Environment.NewLine;
                        }

                        System.IO.File.WriteAllText("etikete.txt", podaci);
                        this.Close();
                    }

                }
                else
                {
                    sadrzi = false;
                    Etiketa et = new Etiketa(Eoznaka.Text, bojaEtikete.SelectedColor.ToString(), Eopis.Text);
                    foreach (Etiketa eti in Osnovni_podaci.etikete2)
                    {
                        if (eti.OznakaEtikete == Eoznaka.Text)
                        {
                            sadrzi = true;
                        }
                    }

                    if (sadrzi)
                    {
                        MessageBox.Show("Etiketa sa ovom oznakom vec postoji!", "Upozorenje", MessageBoxButton.OK);
                    }
                    else
                    {
                        Osnovni_podaci.etikete2.Add(et);
                        this.Close();
                    }
                }
            }

        }

        private void EcloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            HelpProvider.ShowHelp("PomocEtiketa", this);
        }

        private void EpomocBtn_Click(object sender, RoutedEventArgs e)
        {
            HelpProvider.ShowHelp("PomocEtiketa", this);
        }
    }
}
