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
    public partial class Vmestna : Form
    {
        public Vmestna()
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

            var seznamAvtoVSalonu = client.VrniAvteVSalonu().ToList();

            foreach (var item in seznamAvtoVSalonu)
            {
                listView = new ListViewItem(item.id.ToString());
                listView.SubItems.Add(item.avto.ToString());
                listView.SubItems.Add(item.avtosaloni.ToString());
                VmestnaList.Items.Add(listView);
            }
        }

        private void DodajVmestna_Click(object sender, EventArgs e)
        {
            FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
            int maxavti = client.VrniAvte().Count();
            int maxAvtosaloni = client.VrniAvtoSalone().Count();
            if (!string.IsNullOrEmpty(FKAvtoPolje.Text) && !string.IsNullOrEmpty(FKAvtoSalonPolje.Text))
            {
                int nekaj, nekaj2;
                nekaj = Convert.ToInt32(FKAvtoPolje.Text);
                nekaj2 = Convert.ToInt32(FKAvtoSalonPolje.Text);
                if (nekaj>0 && nekaj2>0 && nekaj<=maxavti && nekaj2 <= maxAvtosaloni)
                {

                    client.DodajAvtoVavtoSalon(Convert.ToInt32(FKAvtoPolje.Text),Convert.ToInt32(FKAvtoSalonPolje.Text));
                    MessageBox.Show("Uspesno dodano!");
                    Close();
                    Vmestna vmestna = new Vmestna();
                    vmestna.ShowDialog();
                }
                else
                {
                    MessageBox.Show("To tak ne bo slo, pubec dragi!");
                }

            }
            else
            {
                MessageBox.Show("Polja nesmejo biti prazna!");
            }
        }

        private void OdstraniVmestna_Click(object sender, EventArgs e)
        {
            ListViewItem listView = new ListViewItem(VmestnaList.SelectedItems[0].SubItems[0].Text);
            FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
            DialogResult dialogResult = MessageBox.Show("Izbrisi?","Brisanje_Vmestne",MessageBoxButtons.YesNo);
            if (dialogResult==DialogResult.Yes)
            {
                client.OdstraniAvtoVavtosalonu(Convert.ToInt32(VmestnaList.SelectedItems[0].Text));
                MessageBox.Show("Izbrisano!"); 
            }
            

           

            Close();
            Vmestna admin2 = new Vmestna();
            admin2.Show();
        }

        private void VmestnaList_Click(object sender, EventArgs e)
        {
            FKAvtoPolje.Text = VmestnaList.SelectedItems[0].SubItems[1].Text;
            FKAvtoSalonPolje.Text = VmestnaList.SelectedItems[0].SubItems[0].Text;
            
        }

        private void Prikaz_Avtov_Click(object sender, EventArgs e)
        {
            FKAvtoPolje.Text = Prikaz_Avtov.SelectedItems[0].Text;
        }

        private void Prikaz_AvtoSalonov_Click(object sender, EventArgs e)
        {
            FKAvtoSalonPolje.Text = Prikaz_AvtoSalonov.SelectedItems[0].Text;
        }

        private void UrediVmestna_Click(object sender, EventArgs e)
        {
            FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
            client.poosodobiAvtoVSalonu(Convert.ToInt32(VmestnaList.SelectedItems[0].Text),Convert.ToInt32(FKAvtoPolje.Text), Convert.ToInt32(FKAvtoSalonPolje.Text));
            MessageBox.Show("Uspesno!");
            Close();
            Vmestna neke = new Vmestna();
            neke.Show();
        }
    }
}
