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
    public partial class DodajAvtosalon : Form
    {
        public DodajAvtosalon()
        {
            InitializeComponent();
        }

        private void DodajAvtoSalonaBTN_Click(object sender, EventArgs e)
        {
            FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
            bool flag = false;
            if (!string.IsNullOrEmpty(NazivAvtoSalonaPolje.Text) && !string.IsNullOrEmpty(KrajAvtosalonaPolje.Text) && !string.IsNullOrEmpty(LetoUstanovitvePolje.Text) )
            {
                int Leto = Convert.ToInt32(LetoUstanovitvePolje.Text);
                if (Leto>1000)
                {
                    flag = true;
                }
                else
                {
                    MessageBox.Show("Leta morajo biti cela pozitivna stevila!");
                }

                if (flag)
                {
                    client.DodajAvtoSalon(NazivAvtoSalonaPolje.Text,KrajAvtosalonaPolje.Text,Leto);
                    MessageBox.Show("Avto salon je uspeno dodan!");
                    Close();
                    Admin admin1 = new Admin();
                    admin1.Show();
                }

            }else
            {
                MessageBox.Show("Polja nesmejo biti prazna!");
            }
        }
    }
}
