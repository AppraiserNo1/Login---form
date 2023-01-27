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
    public partial class customer_form : Form
    {
        public customer_form()
        {
            InitializeComponent();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Menuform gback = new Menuform();
            gback.Show();
            this.Hide();
        }
    }
}
