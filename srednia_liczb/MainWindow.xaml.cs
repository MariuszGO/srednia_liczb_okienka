using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using String = System.String;

namespace srednia_liczb
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
            double wartosc1, wartosc2, wartosc3, wynik;
            string x;
            srednia.Content = "Podałeś niepoprawną wartość!!! ";

            if (Double.TryParse(Convert.ToString(liczba1.Text), out wartosc1) && Double.TryParse(Convert.ToString(liczba2.Text), out wartosc2) && Double.TryParse(Convert.ToString(liczba3.Text), out wartosc3))
            {


                wartosc1 = Convert.ToDouble(liczba1.Text);
                wartosc2 = Convert.ToDouble(liczba2.Text);
                wartosc3 = Convert.ToDouble(liczba3.Text);
                wynik = (wartosc1 + wartosc2 + wartosc3) / 3;
                x = Convert.ToString(String.Format("{0:0.000}", wynik));


                srednia.Content = "Średnia liczb: " + x;
            }
        }
    }
}