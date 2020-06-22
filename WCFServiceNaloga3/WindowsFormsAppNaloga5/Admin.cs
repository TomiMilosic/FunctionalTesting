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
    public partial class Admin : Form
    {
        public Admin()
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
            var seznamAvtosalonov = client.VrniAvtoSalone();

            foreach (var item in seznamAvtosalonov)
            {
                listView = new ListViewItem(item.id.ToString());
                listView.SubItems.Add(item.naziv);
                listView.SubItems.Add(item.kraj);
                listView.SubItems.Add(item.letoUstanovitve.ToString());
                Prikaz_AvtoSalonov.Items.Add(listView);
            }
        }

        private void Prikaz_Avtov_SelectedIndexChanged(object sender, EventArgs e)
        {
            FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
            var seznamAvtov = client.VrniAvte();

            Console.WriteLine(sender+" "+e);


        }

        private void Prikaz_Avtov_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Console.WriteLine(sender+" "+e);
            FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();

            var seznamAvtov = client.VrniAvte();
            var seznamAvtosalonov = client.VrniAvtoSalone();
            foreach (var item in seznamAvtov)
            {
                ListViewItem listView = new ListViewItem(item.id.ToString());
                listView.SubItems.Add(item.znamka);
                listView.SubItems.Add(item.model);
                listView.SubItems.Add(item.cena.ToString());
                Prikaz_Avtov.Items.Add(listView);
            }


           
            foreach (var item in seznamAvtosalonov)
            {
                ListViewItem listView = new ListViewItem(item.id.ToString());
                listView.SubItems.Add(item.naziv);
                listView.SubItems.Add(item.kraj);
                listView.SubItems.Add(item.letoUstanovitve.ToString());
                Prikaz_AvtoSalonov.Items.Add(listView);
            }
            
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DodajAvtoBTN_Click(object sender, EventArgs e)
        {
            Close();
            DodajAvto dodajAvto = new DodajAvto();
            dodajAvto.Show();
        }

        private void OdstraniAvtoBTN_Click(object sender, EventArgs e)
        {


            ListViewItem listView = new ListViewItem(Prikaz_Avtov.SelectedItems[0].SubItems[0].Text);
            listView.SubItems.Add(Prikaz_Avtov.SelectedItems[0].SubItems[1].Text);
            listView.SubItems.Add(Prikaz_Avtov.FocusedItem.Index.ToString());
            Prikaz_Avtov.Items.Add(listView);
            FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
            client.IzbrisiAvto(Convert.ToInt32(Prikaz_Avtov.SelectedItems[0].SubItems[0].Text));
           
            var seznamAvtov = client.VrniAvte();
            foreach (var item in seznamAvtov)
            {
                listView = new ListViewItem(item.id.ToString());
                listView.SubItems.Add(item.znamka);
                listView.SubItems.Add(item.model);
                listView.SubItems.Add(item.cena.ToString());
                Prikaz_Avtov.Items.Add(listView);
            }

            Close();
            Admin admin2 = new Admin();
            admin2.Show();
            
            
            
        
        }

        private void DodajAvtoSalonBTN_Click(object sender, EventArgs e)
        {
            Close();
            DodajAvtosalon dodajAvtosalon = new DodajAvtosalon();
            dodajAvtosalon.Show();
            
        }

        private void OdstraniAvtosalonBTN_Click(object sender, EventArgs e)
        {
            ListViewItem listView = new ListViewItem(Prikaz_AvtoSalonov.SelectedItems[0].SubItems[0].Text);
            listView.SubItems.Add(Prikaz_AvtoSalonov.SelectedItems[0].SubItems[1].Text);
            listView.SubItems.Add(Prikaz_AvtoSalonov.FocusedItem.Index.ToString());
            Prikaz_AvtoSalonov.Items.Add(listView);
            FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
            client.IzbrisiAvtoSalon(Convert.ToInt32(Prikaz_AvtoSalonov.SelectedItems[0].SubItems[0].Text));

            


            var seznamAvtov = client.VrniAvtoSalone();
            foreach (var item in seznamAvtov)
            {
                listView = new ListViewItem(item.id.ToString());
                listView.SubItems.Add(item.naziv);
                listView.SubItems.Add(item.kraj);
                listView.SubItems.Add(item.letoUstanovitve.ToString());
                Prikaz_AvtoSalonov.Items.Add(listView);
            }

            Close();
            Admin admin2 = new Admin();
            admin2.Show();

        }

        private void UrediAvtoBTN_Click(object sender, EventArgs e)
        {
            Close();
            UrediAvto urediAvto = new UrediAvto();
            urediAvto.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UrediAvtosalon uredi = new UrediAvtosalon();
            uredi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vmestna vmestna = new Vmestna();
            vmestna.Show();
        }
    }
}
