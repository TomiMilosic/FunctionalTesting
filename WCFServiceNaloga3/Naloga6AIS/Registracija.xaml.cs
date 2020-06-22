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
using System.Windows.Shapes;

namespace Naloga6AIS
{
    /// <summary>
    /// Interaction logic for Registracija.xaml
    /// </summary>
    public partial class Registracija : Window
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(RegistracijaPolje.Text) && RegGeslo1Polje.Password.Length>0 && RegGeslo2Polje.Password.Length>0)
            {
                if (RegGeslo1Polje.Password==RegGeslo2Polje.Password)
                {
                    FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
                    client.DodajUporabnika(RegistracijaPolje.Text,RegGeslo1Polje.Password,adminradio.IsChecked.Value.ToString());
                    MessageBox.Show("Uporabnik uspesno dodan!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Gesli se ne ujemata!");
                }
            }
            else
            {
                MessageBox.Show("Polja nesmejo biti prazna!");
            }
        }
    }
}
