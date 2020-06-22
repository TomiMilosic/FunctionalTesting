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
    /// Interaction logic for NavadniUporabnik.xaml
    /// </summary>
    public partial class NavadniUporabnik : Window
    {
        public NavadniUporabnik()
        {
            FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
            InitializeComponent();
            Uporabnikilist.ItemsSource = client.VrniVseUporabnike();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(DodajImePolje.Text) && string.IsNullOrEmpty(DodajGesloPolje.Text))
            {
                    FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
                    client.DodajUporabnika(DodajImePolje.Text, DodajGesloPolje.Text, adminradio.IsChecked.Value.ToString());
                    MessageBox.Show("Uporabnik uspesno dodan!");
                    Close();
            }
            else
            {
                MessageBox.Show("Polja nesmejo biti prazna!");
            }
        }

        private void OdstraniUporabnikaBTN_Click(object sender, RoutedEventArgs e)
        {
            FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
            var neke = Uporabnikilist.SelectedItem as FirstWebService.UporabniskiRacun;
            client.OdstraniUporabnika(neke.id);
            MessageBox.Show("Uporabnik uspesno odstranjen!");
            Close();
            NavadniUporabnik navadni = new NavadniUporabnik();
            navadni.Show();
            

        }

        private void UrediUporabnikaBTN_Click(object sender, RoutedEventArgs e)
        {
            FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
            var neke = Uporabnikilist.SelectedItem as FirstWebService.UporabniskiRacun;
            client.posodobiUporabniskiRacun(neke.id,DodajImePolje.Text,DodajGesloPolje.Text);
            MessageBox.Show("Uporabnik poosodobljen!");
            Close();
            NavadniUporabnik navadni = new NavadniUporabnik();
            navadni.Show();
        }
    }
}
