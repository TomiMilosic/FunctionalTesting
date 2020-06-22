using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppNaloga5
{
    public partial class UrediAvtosalon : Form
    {
        public UrediAvtosalon()
        {
            InitializeComponent();

            FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
            var seznamAvtosalonov = client.VrniAvtoSalone();
            foreach (var item in seznamAvtosalonov)
            {
                ListViewItem listView = new ListViewItem(item.id.ToString());
                listView.SubItems.Add(item.naziv);
                listView.SubItems.Add(item.kraj);
                listView.SubItems.Add(item.letoUstanovitve.ToString());
                Prikaz_AvtoSalonov.Items.Add(listView);
            }
        }

        private void ShraniSpremembeSalon_Click(object sender, EventArgs e)
        {
            FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();

            if (!string.IsNullOrEmpty(UrediNazivPolje.Text) && !string.IsNullOrEmpty(UrediKrajPolje.Text) && !string.IsNullOrEmpty(UrediLetoPolje.Text))
            {
                int nekaj = Convert.ToInt32(UrediLetoPolje.Text);
                if (nekaj > 0)
                {


                    client.poosodobiAvtoSalon(Convert.ToInt32(Prikaz_AvtoSalonov.SelectedItems[0].Text), UrediNazivPolje.Text, UrediKrajPolje.Text, Convert.ToInt32(UrediLetoPolje.Text));
                    MessageBox.Show("Uspesno poosodobljeno!");
                    Close();
                    UrediAvtosalon uredi = new UrediAvtosalon();
                    uredi.Show();

                }
                else
                {
                    MessageBox.Show("Leto je pozitivno celo stevilo!");
                }
            }
            else
            {
                MessageBox.Show("Polja nesmejo biti prazna!");
            }
        }

        private void Prikaz_AvtoSalonov_Click(object sender, EventArgs e)
        {
            UrediNazivPolje.Text = Prikaz_AvtoSalonov.SelectedItems[0].SubItems[1].Text;//
            UrediKrajPolje.Text = Prikaz_AvtoSalonov.SelectedItems[0].SubItems[2].Text;//
            UrediLetoPolje.Text = Prikaz_AvtoSalonov.SelectedItems[0].SubItems[3].Text;// 
        
        }
    }
}
