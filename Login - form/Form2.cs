using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login___form
{
    public partial class update_form : Form
    {

        public update_form()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=desktop-20dl7b0;Initial Catalog=BookshopDB;Integrated Security=True;");
        double val = 0;

        private void update_form_Load(object sender, EventArgs e)
        {
            AutoIncrementID();
        }

        private void btnsave_Click(object sender, EventArgs e)  
        {
            
              
               con.Open(); 
                SqlCommand cmd = new SqlCommand("INSERT INTO Customers (Customer_id,Username,Password,Name,Surname,Address,Email) VALUES ('"+ cusidlabel.Text + "','" + tbuser.Text + "','" + tbpass.Text + "','" + tbname.Text + "','" + tbsname.Text + "','" + tbaddress.Text + "','" + tbemail.Text + "')",con);
                 cmd.ExecuteNonQuery();
                   con.Close();
                     MessageBox.Show("Add User Data Succesfully");
                        
                          tbuser.Text = "";
                          tbpass.Text = "";
                          tbname.Text = "";
                          tbname.Text = "";
                          tbsname.Text = "";
                          tbaddress.Text = "";
                          tbemail.Text = "";

            AutoIncrementID();

          
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            user_form back = new user_form();
            back.Show();
            this.Hide();
        }
        private void AutoIncrementID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(Customer_id) from [Customers]",con);
            int autoid = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            autoid++;
            cusidlabel.Text = val + autoid.ToString();

        }
    }
}
