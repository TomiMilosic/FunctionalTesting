using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
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
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
            InitializeComponent();
            
            Avti.ItemsSource = client.VrniAvte();
            Avtosaloni.ItemsSource = client.VrniAvtoSalone();
            AvtVsalonu.ItemsSource = client.VrniAvteVSalonu();
        }

        private void Avti_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (Textbox3.Visibility==Visibility.Hidden && Napis3.Visibility==Visibility.Hidden)
            {
                Textbox3.Visibility = Visibility.Visible;
                Napis3.Visibility = Visibility.Visible;
            }     
            
            Napis1.Content = "Znamka:";
            Napis2.Content = "Model";
            Napis3.Content = "Cena";

            DodajStvarBTN.Content = "Dodaj avto";
            UrediStvarBTN.Content = "Uredi avto";
            OdstraniStvarBTN.Content = "Odstrani avto";
            var neke = Avti.SelectedItem as FirstWebService.Avto;
            Textbox1.Text = neke.znamka;
            Textbox2.Text = neke.model;
            Textbox3.Text = neke.cena.ToString();
        }


        private void Avtosaloni_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Textbox3.Visibility == Visibility.Hidden && Napis3.Visibility == Visibility.Hidden)
            {
                Textbox3.Visibility = Visibility.Visible;
                Napis3.Visibility = Visibility.Visible;
            }
            
            Napis1.Content = "Naziv";
            Napis2.Content = "Kraj";
            Napis3.Content = "Leto ustanove:";

            DodajStvarBTN.Content = "Dodaj avtosalon";
            UrediStvarBTN.Content = "Uredi avtosalon";
            OdstraniStvarBTN.Content = "Odstrani avtosalon";
            var neke = Avtosaloni.SelectedItem as FirstWebService.Avtosalon;
            Textbox1.Text = neke.naziv;
            Textbox2.Text = neke.kraj;
            Textbox3.Text = neke.letoUstanovitve.ToString();
        }

        private void AvtVsalonu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Textbox3.Visibility == Visibility.Hidden && Napis3.Visibility == Visibility.Hidden)
            {
                Textbox3.Visibility = Visibility.Visible;
                Napis3.Visibility = Visibility.Visible;
            }
            Napis1.Content = "Avto";
            Napis2.Content = "Avtosalon";
            Napis3.Visibility = Visibility.Hidden;
            Textbox3.Visibility = Visibility.Hidden;


            DodajStvarBTN.Content = "Dodaj";
            UrediStvarBTN.Content = "Uredi";
            OdstraniStvarBTN.Content = "Odstrani";

            var neke = AvtVsalonu.SelectedItem as FirstWebService.AvtoVAvtosalonu;
            Textbox1.Text = neke.avto.ToString();
            Textbox2.Text = neke.avtosaloni.ToString();
            

        }

        private void DodajStvarBTN_Click(object sender, RoutedEventArgs e)
        {
            if (Napis1.Content== "Znamka:" && Napis2.Content== "Model")
            {
                if (!string.IsNullOrEmpty(Textbox1.Text) && !string.IsNullOrEmpty(Textbox2.Text) &&!string.IsNullOrEmpty(Textbox3.Text))
                {
                    int nekaj = Convert.ToInt32(Textbox3.Text);
                    if (nekaj>0)
                    {
                        FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
                        client.DodajAvto(Textbox1.Text, Textbox2.Text, Convert.ToInt32(Textbox3.Text));
                        MessageBox.Show("Avto uspesno dodan!");
                        
                        Admin admin = new Admin();
                        admin.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Cena je pozitivno celo stevilo!");
                    }
                }
                else
                {
                    MessageBox.Show("Polja nesmejo biti prazna!");
                }
            }

            if (Napis1.Content== "Naziv" && Napis2.Content== "Kraj" )
            {
                if (!string.IsNullOrEmpty(Textbox1.Text) && !string.IsNullOrEmpty(Textbox2.Text) && !string.IsNullOrEmpty(Textbox3.Text))
                {
                    int nekej = Convert.ToInt32(Textbox3.Text);
                    if (nekej>1000)
                    {
                        FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
                        client.DodajAvtoSalon(Textbox1.Text, Textbox2.Text, Convert.ToInt32(Textbox3.Text));
                        MessageBox.Show("Avtosalon uspesno dodan");
                        Admin admin = new Admin();
                        admin.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Leto ustanovitve je cela pozitivna cela stevilka!");
                    }
                }
                else
                {
                    MessageBox.Show("Polja nemejo biti prazna");
                }


            }

            if (Napis1.Content=="Avto" && Napis2.Content=="Avtosalon")
            {
                if (!string.IsNullOrEmpty(Textbox1.Text) && !string.IsNullOrEmpty(Textbox2.Text))
                {
                    FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
                    //var avto = Avti.SelectedItem as FirstWebService.Avto;
                    //var avtosalon = Avtosaloni.SelectedItem as FirstWebService.Avtosalon;
                    client.DodajAvtoVavtoSalon(Convert.ToInt32(Textbox1.Text), Convert.ToInt32(Textbox2.Text));
                    
                    MessageBox.Show("Uspesno dodano!");
                    Admin admin = new Admin();
                    admin.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Polja nesmejo biti prazna!");
                }
            }
        }

        private void UrediStvarBTN_Click(object sender, RoutedEventArgs e)
        {
            FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
            if (Napis1.Content == "Znamka:")
            {
                if (!string.IsNullOrEmpty(Textbox1.Text) && !string.IsNullOrEmpty(Textbox2.Text) && !string.IsNullOrEmpty(Textbox3.Text))
                {
                    var avto = Avti.SelectedItem as FirstWebService.Avto;
                    client.poosodobiAvto(avto.id, Textbox1.Text, Textbox2.Text, Convert.ToInt32(Textbox3.Text));
                    MessageBox.Show("Avto urejen!");
                    
                    Admin admin = new Admin();
                    admin.Show();
                    Close();
                }
            }

            if (Napis2.Content == "Kraj")
            {
                if (!string.IsNullOrEmpty(Textbox1.Text) && !string.IsNullOrEmpty(Textbox2.Text) && !string.IsNullOrEmpty(Textbox3.Text))
                {
                    var avtosalon = Avtosaloni.SelectedItem as FirstWebService.Avtosalon;
                    client.poosodobiAvtoSalon(avtosalon.id,Textbox1.Text,Textbox2.Text,Convert.ToInt32(Textbox3.Text));
                    MessageBox.Show("Avtosalon urejen!");
                    
                    Admin admin = new Admin();
                    admin.Show();
                    Close();
                }
            }
            if (UrediStvarBTN.Content == "Uredi")
            {
                if (!string.IsNullOrEmpty(Textbox1.Text) && !string.IsNullOrEmpty(Textbox2.Text))
                {
                    var vmesna = AvtVsalonu.SelectedItem as FirstWebService.AvtoVAvtosalonu;
                    client.poosodobiAvtoVSalonu(vmesna.id,Convert.ToInt32(Textbox1.Text),Convert.ToInt32(Textbox2.Text));
                    MessageBox.Show("Urejeno!");
                    
                    Admin admin = new Admin();
                    admin.Show();
                    Close();
                }
            }
        }

        private void OdstraniStvarBTN_Click(object sender, RoutedEventArgs e)
        {
            FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
            if (Napis1.Content=="Znamka:")
            {
                var avto = Avti.SelectedItem as FirstWebService.Avto;
                client.IzbrisiAvto(avto.id);
                MessageBox.Show("Avto odstranjen!");
                
                Admin admin = new Admin();
                admin.Show();
                Close();
            }

            if (Napis2.Content=="Kraj")
            {
                var avtosalon = Avtosaloni.SelectedItem as FirstWebService.Avtosalon;
                client.IzbrisiAvtoSalon(avtosalon.id);
                MessageBox.Show("Avtosalon odstranjen!");
                
                Admin admin = new Admin();
                admin.Show();
                Close();
            }
            if (UrediStvarBTN.Content == "Uredi")
            {
                var vmesna = AvtVsalonu.SelectedItem as FirstWebService.AvtoVAvtosalonu;
                client.OdstraniAvtoVavtosalonu(vmesna.id);
                MessageBox.Show("Odstranjeno!");
                
                Admin admin = new Admin();
                admin.Show();
                Close();
            }
        }
    }
}
