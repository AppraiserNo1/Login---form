using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login___form
{
    public partial class Menuform : Form
    {
        public Menuform()
        {
            InitializeComponent();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Form1 back = new Form1();
            back.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_product_Click(object sender, EventArgs e)
        {
            product_form pdf = new product_form();
            pdf.Show();
            this.Hide();
        }

        private void button_user_Click(object sender, EventArgs e)
        {
             user_form uf = new user_form();
             uf.Show();
             this.Hide();
        }

        private void button_customer_Click(object sender, EventArgs e)
        {
              customer_form ctmf = new customer_form();
              ctmf.Show();
              this.Hide();
        }
    }
}
