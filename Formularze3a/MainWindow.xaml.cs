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

namespace Formularze3a
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
            string liczba = bok_textbox.Text;//nie chcemy string
            //int bok = int.Parse(bok_textbox.Text);

            int bok;
            int obwod;
            if(int.TryParse(bok_textbox.Text, out bok))
            {
                MessageBox.Show(bok.ToString());
                string figura = figura_combobox.Text;
                if(figura == "Kwadrat")
                {
                    obwod = bok * 4;
                    MessageBox.Show("Obwód kwadratu wynosi " + obwod.ToString());
                }
                else if(figura == "Trójkąt")
                {
                    obwod = bok * 3;
                    MessageBox.Show("Obwód trójkąta wynosi " + obwod.ToString());
                }



            }
            else
            {
                MessageBox.Show("To nie jest liczba");
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            float wynik = 0;
            float waluta;
            if(float.TryParse(waluta_textbox.Text, out waluta))
            {
                if (euro_radio.IsChecked == true)
                {
                    wynik = (float)(waluta * 0.26); 
                }
                else if(dolar_radio.IsChecked == true)
                {
                    wynik = (float)(waluta * 0.24);
                }
                else if(frank_radio.IsChecked == true)
                {
                    wynik = (float)(waluta * 0.22);
                }

                MessageBox.Show(wynik.ToString());
            }
            else
            {
                MessageBox.Show("Waluta musi być liczbą");
            }
            
        }
    }
}
