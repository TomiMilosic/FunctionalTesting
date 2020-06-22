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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ImePolje.Text) && !string.IsNullOrEmpty(GesloPolje.Text))
            {
                FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();

                if (client.Uporabnik(ImePolje.Text, GesloPolje.Text))
                {
                    Admin admin = new Admin();
                    admin.Show();
                    
                }
                else
                {
                    NavadniUporabnik navadniUporabnik = new NavadniUporabnik();
                    navadniUporabnik.Show();
                    
                }
            }
            else
            {
                MessageBox.Show("Nobeno polje nesme biti prazno!");
            }
        }

        private void Registracija_Click(object sender, EventArgs e)
        {
            RegistracijaOkno registracijaOkno = new RegistracijaOkno();
            registracijaOkno.Show();
        }
    }
}
