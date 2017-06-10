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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HCI
{
    [Serializable]
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public static ObservableCollection<Resurs> resursi2;
        public static ObservableCollection<Resurs> resursi3;
        public static ObservableCollection<Resurs> resursi4;
        public static ObservableCollection<Resurs> resursi5;
        public static ObservableCollection<Resurs> resursi6;
        public static ObservableCollection<Etiketa> prikazEt;
        public static ObservableCollection<Tip> tipovi4;
        public static ObservableCollection<Etiketa> etikete4;
        public static List<int> brojeviResursa;
        Point startPoint = new Point();
        List<Point> tacke = new List<Point>();
        double canvasX, canvasY;
        double oblikX, oblikY;
        public static int indeks = -1;
        String ikonica;

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            resursi2 = new ObservableCollection<Resurs>();
            resursi3 = new ObservableCollection<Resurs>();
            resursi4 = new ObservableCollection<Resurs>();
            resursi5 = new ObservableCollection<Resurs>();
            resursi6 = new ObservableCollection<Resurs>();

            prikazEt = new ObservableCollection<Etiketa>();
            brojeviResursa = new List<int>();
            ikonica = "i";
            

            if (File.Exists("resursi.txt"))
            {
                string[] lines = System.IO.File.ReadAllLines(@"resursi.txt");

                foreach(String l in lines)
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
                            
                        } catch
                        {
                            x = false;
                        }
                    }

                    Resurs r = new Resurs(podeljeni[0], podeljeni[1], podeljeni[2], t, podeljeni[7], podeljeni[8], podeljeni[9], podeljeni[10], podeljeni[11], podeljeni[12], podeljeni[13], podeljeni[14], etikete);
                    resursi2.Add(r);
                   // tipovi4.Add(t);
                  //  etikete4.Add(et);

                }
            }
        }

        public ObservableCollection<Resurs> resLista
        {
            get { return resursi2; }
            set
            {
                resursi2 = value;
                OnPropertyChanged(resLista);

                for (int i = 0; i < brojeviResursa.Count; i++)
                {
                    Console.Write(brojeviResursa[i] + " ");
                    if (brojeviResursa[i] == 1)
                    {
                        Ellipse eli = (Ellipse)canvas.Children[i];
                        Resurs resurs = resursi2[1];
                        //eli.Stroke = (SolidColorBrush)new BrushConverter().ConvertFromString("Red"); ;
                        ImageBrush myBrush = new ImageBrush();
                        myBrush.ImageSource = new BitmapImage(new Uri(resurs.IkonicaResursa));
                        eli.Fill = myBrush;
                        
                        eli.ToolTip = resurs.OznakaResursa;
                    }
                }
            }
        }

        public String ikonica2
        {
            get { return ikonica; }
            set
            {
                ikonica = value;
                OnPropertyChanged(ikonica2);
            }
        }
        protected void OnPropertyChanged(String ikonica)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
               // Console.WriteLine("aaa" + ikonica);
                handler(this, new PropertyChangedEventArgs("ikonica"));
            }
        }

        public ObservableCollection<Etiketa> resEtik
        {
            get
            {
                return prikazEt;
            }
            set
            {
                prikazEt = value;
                OnPropertyChanged(resEtik);
            }
        }

        protected void OnPropertyChanged(ObservableCollection<Etiketa> prikazEt)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                Console.WriteLine("doke vise?????");
                handler(this, new PropertyChangedEventArgs("prikazEt"));
            }
        }

        public ObservableCollection<Resurs> resIk
        {
            get { return resursi3; }
            set
            {
                resursi3 = value;
                OnPropertyChanged(resIk);
            }
        }

        public ObservableCollection<Resurs> resOzn
        {
            get { return resursi4; }
            set
            {
                resursi4 = value;
                OnPropertyChanged(resOzn);
            }
        }
        public ObservableCollection<Resurs> resIme
        {
            get { return resursi5; }
            set
            {
                resursi5 = value;
                OnPropertyChanged(resIme);
            }
        }

        public ObservableCollection<Resurs> resOpis
        {
            get { return resursi6; }
            set
            {
                resursi6 = value;
                OnPropertyChanged(resOpis);
            }
        }



        protected void OnPropertyChanged(ObservableCollection<Resurs> resursi2)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs("resursi2"));
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var x = new Osnovni_podaci();
            x.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            var x = new Tip_Resursa(true);
            x.Show();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            var x = new Dodaj_etiketu(true);
            x.Show();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            var x = new TabelaResursa();
            x.Show();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            var x = new TabelaTipova();
            x.Show();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            var x = new TabelaEtiketa();
            x.Show();
        }

        private void MWizmeni_Click(object sender, RoutedEventArgs e)
        {
            if(listaResursa.SelectedIndex != -1)
            {
                indeks = listaResursa.SelectedIndex;
                var r = new Osnovni_podaci(resursi2.ElementAt(listaResursa.SelectedIndex));
                r.Show();
            }
        }

        private void MWobrisi_Click(object sender, RoutedEventArgs e)
        {
            if(listaResursa.SelectedIndex != -1)
            {


                Console.WriteLine("brojeviResursa:  ");
                foreach (int a in brojeviResursa)
                {
                    Console.WriteLine(a);
                }

                foreach (Ellipse eli in canvas.Children)
                {
                    String tool = eli.ToolTip.ToString();
                    if (tool == resursi2.ElementAt(listaResursa.SelectedIndex).OznakaResursa)
                    {
                        String[] podeljeno = ((String)eli.Tag).Split(',');
                        double x = Double.Parse(podeljeno[0]);
                        double y = Double.Parse(podeljeno[1]);
                        int i = int.Parse(podeljeno[2]);
                        brojeviResursa.Remove(i);
                        int koja = 0;
                        foreach (Point po in tacke)
                        {
                            if (po.X == x && po.Y == y)
                            {
                                break;
                            }
                            koja++;
                        }
                        tacke.RemoveAt(koja);
                        canvas.Children.Remove(eli);
                        
                        break;
                    }
                }



                foreach (Ellipse eli in canvas.Children)
                {
                    String[] podeljeno = ((String)eli.Tag).Split(',');
                    double x = Double.Parse(podeljeno[0]);
                    double y = Double.Parse(podeljeno[1]);
                    int i = int.Parse(podeljeno[2]);
                    if (i > listaResursa.SelectedIndex)
                    {
                        i--;
                    }
                    eli.Tag = (x + "," + y + "," + i);
                }
                for (int j = 0; j < brojeviResursa.Count; j++)
                {
                    if (brojeviResursa[j] > listaResursa.SelectedIndex)
                    {
                        brojeviResursa[j]--;
                    }
                }


                resursi2.RemoveAt(listaResursa.SelectedIndex);

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
        }

        private void listaResursa_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(null);
        }

        private void listaResursa_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePos = e.GetPosition(null);
            Vector diff = startPoint - mousePos;

            if(e.LeftButton == MouseButtonState.Pressed)
            {
                ListView listView = sender as ListView;
                ListViewItem listViewItem = FindAncestor<ListViewItem>((DependencyObject)e.OriginalSource);

                try
                {
                    Resurs resurs = (Resurs)listView.ItemContainerGenerator.ItemFromContainer(listViewItem);

                    DataObject dragData = new DataObject("myFormat", resurs);
                    DragDrop.DoDragDrop(listViewItem, dragData, DragDropEffects.Link);
                } catch
                {

                }
                
            }
        }

        private static T FindAncestor<T>(DependencyObject current) where T : DependencyObject
        {
            do
            {
                if (current is T)
                {
                    return (T)current;
                }
                current = VisualTreeHelper.GetParent(current);
            }
            while (current != null);
            return null;
        }


        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            HelpProvider.ShowHelp("HelpMain", this);
        }

        private void DockPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent("myFormat") || sender == e.Source)
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void DockPanel_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("myFormat"))
            {
                bool preklapanje = false;
                Point p = e.GetPosition(this);
                foreach (Point po in tacke)
                {
                    if (Math.Sqrt(Math.Pow((p.X - po.X), 2) + Math.Pow((p.Y - po.Y), 2)) < 30)
                    {
                        preklapanje = true;
                    }
                }
                if (!preklapanje)
                {
                    Resurs resurs = e.Data.GetData("myFormat") as Resurs;
                    Ellipse eli = new Ellipse();

                    eli.Width = 30;
                    eli.Height = 30;
                    eli.StrokeThickness = 3;

                    //eli.Stroke = (SolidColorBrush)new BrushConverter().ConvertFromString("Red");


                    ImageBrush myBrush = new ImageBrush();
                    myBrush.ImageSource = new BitmapImage(new Uri(resurs.IkonicaResursa));
                    eli.Fill = myBrush;
                    eli.ToolTip = resurs.OznakaResursa;


                    ContextMenu contextMenu1;

                    contextMenu1 = new ContextMenu();

                    MenuItem menuItem1;

                    menuItem1 = new MenuItem();

                    MenuItem menuItem2;

                    menuItem2 = new MenuItem();

                    contextMenu1.Items.Add(menuItem2);
                    menuItem2.Header = "Izmeni";
                    //add menu item in context menu

                    contextMenu1.Items.Add(menuItem1);

                    menuItem1.Header = "Ukloni";
                    int indeks2 = 0;
                    indeks2 = listaResursa.SelectedIndex;


                    eli.ContextMenu = contextMenu1;


                    Canvas.SetTop(eli, p.Y - 25);
                    Canvas.SetLeft(eli, p.X - 5);

                    bool radi = true;
                    for (int i = 0; i < brojeviResursa.Count(); i++)
                    {
                        if (brojeviResursa[i] == indeks2)
                        {
                            radi = false;
                        }
                    }
                    if (radi)
                    {

                        eli.Tag = (p.X + "," + p.Y + "," + indeks2);
                        canvas.Children.Add(eli);
                        tacke.Add(p);
                        brojeviResursa.Add(indeks2);
                        menuItem1.Click += delegate
                        {
                            canvas.Children.Remove(eli); 
                            String[] podeljeno = ((String)eli.Tag).Split(',');
                            double x = Double.Parse(podeljeno[0]);
                            double y = Double.Parse(podeljeno[1]);
                            int i = int.Parse(podeljeno[2]);
                            brojeviResursa.Remove(i);
                            int koja = 0;
                            foreach (Point po in tacke)
                            {
                                if (po.X == x && po.Y == y)
                                {
                                    break;
                                }
                                koja++;
                            }
                            tacke.RemoveAt(koja);
                        };
                        menuItem2.Click += delegate
                        {
                            String[] podeljeno = ((String)eli.Tag).Split(',');
                            double x = Double.Parse(podeljeno[0]);
                            double y = Double.Parse(podeljeno[1]);
                            int i = int.Parse(podeljeno[2]);
                            indeks = i;
                            var r = new Osnovni_podaci(resursi2.ElementAt(i));
                            r.Show();

                        };

                    }
                    else
                    {
                        MessageBox.Show("Resurs se vec nalazi na mapi!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Pozicija je zauzeta!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                try
                {

                    //Ellipse elipsa = sender as Ellipse;
                    Ellipse elip = FindAncestor<Ellipse>((DependencyObject)e.OriginalSource);
                    //Console.WriteLine("Ovde smo");
                    String[] podeljeno = ((String)elip.Tag).Split(',');
                    int index = int.Parse(podeljeno[2]);
                    prikazEt.Clear();
                    resursi3.Clear();
                    resursi4.Clear();
                    resursi5.Clear();
                    resursi6.Clear();
                    if (index != -1)
                    {
                        resursi3.Add(resursi2.ElementAt(index));
                        resursi4.Add(resursi2.ElementAt(index));
                        resursi5.Add(resursi2.ElementAt(index));
                        resursi6.Add(resursi2.ElementAt(index));
                        foreach (Etiketa et in resursi2.ElementAt(index).EtiketaResursa)
                        {
                            prikazEt.Add(et);
                        }

                    }

                    // Find the data behind the ListViewItem
                    canvasX = e.GetPosition(canvas).X;
                    canvasY = e.GetPosition(canvas).Y;
                    oblikX = Canvas.GetLeft(elip);
                    oblikY = Canvas.GetLeft(elip);
                    // Initialize the drag & drop operation
                    DataObject dragData = new DataObject("myFormat1", elip);
                    DragDrop.DoDragDrop(elip, dragData, DragDropEffects.Link);
                }
                catch
                {

                }
            }
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            if (indeks != -1)
            {
                for (int i = 0; i < brojeviResursa.Count; i++)
                {
                    Console.Write(brojeviResursa[i] + " ");
                    if (brojeviResursa[i] == indeks)
                    {
                        Ellipse eli = (Ellipse)canvas.Children[i];
                        Resurs resurs = resursi2[indeks];
                        eli.Fill = null;
                        //eli.Stroke = (SolidColorBrush)new BrushConverter().ConvertFromString("Green"); ;
                        ImageBrush myBrush = new ImageBrush();
                        myBrush.ImageSource = new BitmapImage(new Uri(resurs.IkonicaResursa));
                        eli.Fill = myBrush;
                        Console.WriteLine("zasto?" + resurs.IkonicaResursa);
                        eli.ToolTip = resurs.OznakaResursa;

                    }
                }
            }
            indeks = -1;
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            var x = new TutorialResurs();
            x.Show();
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            var x = new TutorialTip();
            x.Show();
        }

        private void MenuItem_Click_9(object sender, RoutedEventArgs e)
        {
            var x = new TutorialEtiketa();
            x.Show();
        }

        private void MenuItem_Click_10(object sender, RoutedEventArgs e)
        {
            var x = new TutorialTabelaResursa();
            x.Show();
        }

        private void MenuItem_Click_11(object sender, RoutedEventArgs e)
        {
            var x = new TutorialTabelaTipova();
            x.Show();
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            HelpProvider.ShowHelp("HelpMain", this);
        }

        private void canvas_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("myFormat1"))
            {

                bool preklapanje = false;
                Point p = e.GetPosition(this);
                foreach (Point po in tacke)
                {
                    if (Math.Sqrt(Math.Pow((p.X - po.X), 2) + Math.Pow((p.Y - po.Y), 2)) < 30)
                    {
                        preklapanje = true;

                    }
                }
                if (!preklapanje)
                {

                    tacke.Add(p);
                    Ellipse eli = e.Data.GetData("myFormat1") as Ellipse;

                    String[] podeljeno = ((String)eli.Tag).Split(',');
                    double x = Double.Parse(podeljeno[0]);
                    double y = Double.Parse(podeljeno[1]);
                    int i = int.Parse(podeljeno[2]);
                    int koja = 0;
                    foreach (Point po in tacke)
                    {
                        if (po.X == x && po.Y == y)
                        {
                            break;
                        }
                        koja++;
                    }
                    tacke.RemoveAt(koja);
                    eli.Tag = (p.X + "," + p.Y + "," + i);
                    Canvas.SetTop(eli, p.Y - 25);
                    Canvas.SetLeft(eli, p.X - 5);
                }
                else
                    MessageBox.Show("Pozicija je zauzeta!", "Upozorenje", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
        }

        private void listaResursa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            prikazEt.Clear();
            resursi3.Clear();
            resursi4.Clear();
            resursi5.Clear();
            resursi6.Clear();

            if (listaResursa.SelectedIndex != -1)
            {
                resursi3.Add(resursi2.ElementAt(listaResursa.SelectedIndex));
                resursi4.Add(resursi2.ElementAt(listaResursa.SelectedIndex));
                resursi5.Add(resursi2.ElementAt(listaResursa.SelectedIndex));
                resursi6.Add(resursi2.ElementAt(listaResursa.SelectedIndex));

                foreach (Etiketa et in resursi2.ElementAt(listaResursa.SelectedIndex).EtiketaResursa)
                {
                    prikazEt.Add(et);
                }
            }

        //    Console.WriteLine()       
        }
    }
}
