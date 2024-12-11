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

namespace generatorHasla
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int counter = 0;
            int numOfChar = 0;
            string password = "";
            string letters = "abcdefghijklmnopqrstuvwxyz";
            string bigLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "1234567890";
            string characters = "!@#$%^&*()_+";
            if(int.TryParse(numberOfCharacters.Text, out numOfChar))
            {
                if (litery.IsChecked == true)
                {
                    int random = Random.Shared.Next();
                    password += bigLetters[random];
                    counter++;
                }
                if (cyfry.IsChecked == true)
                {
                    int random = Random.Shared.Next();
                    password += numbers[random];
                    counter++;
                }
                if (znaki.IsChecked == true)
                {
                    int random = Random.Shared.Next();
                    password += characters[random];
                    counter++;
                }
                for (int i = counter; i < numOfChar; i++) 
                {
                    int random = Random.Shared.Next();
                    password += letters[random];
                }
                MessageBox.Show(password, "");
            }
            else
            {
                MessageBox.Show("Przestań trolować", "Dom ci wybuchne", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            }
        }
    }
}
