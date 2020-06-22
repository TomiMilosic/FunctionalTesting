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
    public partial class NavadniUporabnik : Form
    {
        public NavadniUporabnik()
        {
            InitializeComponent();
            FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
            ListViewItem listView = new ListViewItem();

            var Uporabnikov = client.VrniVseUporabnike();

            foreach (var item in Uporabnikov)
            {
                listView = new ListViewItem(item.id.ToString());
                listView.SubItems.Add(item.uporabniskoIme);
                listView.SubItems.Add(item.geslo);
                listView.SubItems.Add(item.admin.ToString());
                Prikaz_Uporabnikov.Items.Add(listView);
            }
        }

        private void Prikaz_Uporabnikov_Click(object sender, EventArgs e)
        {


        }
    }
}
