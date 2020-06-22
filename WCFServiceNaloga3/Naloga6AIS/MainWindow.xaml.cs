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

namespace Naloga6AIS
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

        private void PrijavaBTN_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(VnosImenaPolje.Text) && VnosGesloPolje.Password.Length>0)
            {
                FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
                
                if (client.Uporabnik(VnosImenaPolje.Text, VnosGesloPolje.Password.ToString()))
                {
                    Admin admin = new Admin();
                    admin.Show();
                    Close();
                }
                else
                {
                    NavadniUporabnik navadni = new NavadniUporabnik();
                    navadni.Show();
                    Close();
                }
                
            }
            else
            {
                MessageBox.Show("Polja nesmejo biti prazna!");
            }
        }

        private void RegistracijaBTN_Click(object sender, RoutedEventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.Show();
        }
    }
}
