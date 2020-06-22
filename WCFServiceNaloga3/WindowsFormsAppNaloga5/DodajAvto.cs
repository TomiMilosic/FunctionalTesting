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
    public partial class DodajAvto : Form
    {
        public DodajAvto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstWebService.ServiceClient client = new FirstWebService.ServiceClient();
            
            bool flag = false;
            
            if (!string.IsNullOrEmpty(ZnamkaAvtaPolje.Text) && !string.IsNullOrEmpty(ModelAvtaPolje.Text) && !string.IsNullOrEmpty(CenaAvtaPolje.Text))
            {
                
                int nekaj = Convert.ToInt32(CenaAvtaPolje.Text);
                if (nekaj>0)
                {
                    flag = true;
                }
                if (flag)
                {
                    if (flag)
                    {
                        
                        
                        client.DodajAvto(ZnamkaAvtaPolje.Text, ModelAvtaPolje.Text, nekaj);
                        MessageBox.Show("Avto uspesno dodan!");
                        Admin admin = new Admin();
                        admin.Show();
                        
                       
                        
                    }
                    else
                    {
                        MessageBox.Show("Cena mora biti cela pozitivna stevilka!");
                    }
                }
                else
                {
                    MessageBox.Show("Cena mora biti cela pozitivna stevilka!");
                }
            }
            else
            {
                MessageBox.Show("Polja ne smejo biti prazna!");
            }
        }
    }
}
