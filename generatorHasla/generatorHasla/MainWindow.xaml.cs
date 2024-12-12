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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace generowaniehasla
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Haslo = " ";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void generuj_Click(object sender, RoutedEventArgs e)
        {
            int dlugosc = 0;
            Random random = new Random();
            Haslo = "";
            if(int.TryParse(liczbaznakow.Text, out dlugosc))
            {
                if(malewielkie.IsChecked == true)
                {
                    string duze = "QWERTYUIOPASDFGHJKLZXCVBNM";
                    int indeks = random.Next(duze.Length);
                        Haslo = Haslo + duze[indeks];
                }
                if(cyfry.IsChecked == true)
                {
                    int cyfra = random.Next(10);
                    Haslo = Haslo + cyfra.ToString();
                }
                if(specjalne.IsChecked == true)
                {
                    string znaki = "!@#$%^&*()_";
                    int indeks = random.Next(znaki.Length);
                    Haslo = Haslo + znaki[indeks];
                }
                while (Haslo.Length < dlugosc)
                {
                    string maleLitery = "qwertyuiopasdfghjklzxcvbnm";
                    int indeks = random.Next(maleLitery.Length);
                    Haslo = Haslo + maleLitery[indeks];
                }
                MessageBox.Show("haslo: " + Haslo);
            }
            else
            {
                MessageBox.Show("dlugosc musi byc liczba");
            }
        }

        private void zatwierdzbaton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Dane pracownika: "+imiebox.Text+" "+naziwkso.Text+" "+stanowisko.Text+" Hasło: "+Haslo);
        }
    }
}
