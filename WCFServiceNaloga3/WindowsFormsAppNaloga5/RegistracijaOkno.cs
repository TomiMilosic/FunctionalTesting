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
    public partial class RegistracijaOkno : Form
    {
        public RegistracijaOkno()
        {
            InitializeComponent();
        }

        private void RegistracijaBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ImePoljeReg.Text) && !string.IsNullOrEmpty(GesloPoljeReg.Text))
            {
                FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();

                if (AdminDa.Checked)
                {
                    client.DodajUporabnika(ImePoljeReg.Text, GesloPoljeReg.Text,"Da");
                    MessageBox.Show("Admin dodan!");
                }
                else
                {
                    client.DodajUporabnika(ImePoljeReg.Text, GesloPoljeReg.Text,"Ne");
                    MessageBox.Show("Uporabnik dodan!");
                }
            }
            else
            {
                MessageBox.Show("Polja nesmejo biti prazna!");
            }
        }
    }
}
