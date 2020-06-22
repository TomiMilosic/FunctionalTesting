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
    public partial class UrediAvto : Form
    {
        private Admin admin;
        public UrediAvto()
        {
            InitializeComponent();

            FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
            var seznamAvtov = client.VrniAvte();
            ListViewItem listView = new ListViewItem();
            foreach (var item in seznamAvtov)
            {
                listView = new ListViewItem(item.id.ToString());
                listView.SubItems.Add(item.znamka);
                listView.SubItems.Add(item.model);
                listView.SubItems.Add(item.cena.ToString());
                Prikaz_Avtov.Items.Add(listView);
            }



        }

       

        private void ShraniSpremembe_Click(object sender, EventArgs e)
        {
            FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();


             if (!string.IsNullOrEmpty(UrediZnamkoPolje.Text) && !string.IsNullOrEmpty(UrediModelPolje.Text) && !string.IsNullOrEmpty(UrediCenoPolje.Text))
             {
                 int nekaj = Convert.ToInt32(UrediCenoPolje.Text);
                 if (nekaj>0)
                 {


                     client.poosodobiAvto(Convert.ToInt32(Prikaz_Avtov.SelectedItems[0].Text), UrediCenoPolje.Text,UrediModelPolje.Text,Convert.ToInt32(UrediCenoPolje.Text));
                     MessageBox.Show("Uspesno poosodobljeno!");
                    Close();
                    UrediAvto uredi = new UrediAvto();
                    uredi.Show();
                    
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

        private void UrediAvto_Load(object sender, EventArgs e)
        {

        }

        private void Prikaz_Avtov_Click(object sender, EventArgs e)
        {
            UrediZnamkoPolje.Text = Prikaz_Avtov.SelectedItems[0].SubItems[1].Text;//Znamka
            UrediModelPolje.Text = Prikaz_Avtov.SelectedItems[0].SubItems[2].Text;//model 
            UrediCenoPolje.Text = Prikaz_Avtov.SelectedItems[0].SubItems[3].Text;//cena 
        }
    }
}
