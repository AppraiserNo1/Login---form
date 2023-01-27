using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace Login___form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=desktop-20dl7b0;Initial Catalog=BookshopDB;Integrated Security=True");

        private void Login_button_Click(object sender, EventArgs e)
        {
            String Username, Password;

            Username = txt_username.Text;
            Password = txt_password.Text;

            try
            {
                String Querry = "SELECT * FROM Customers WHERE Username = '"+txt_username.Text+"'AND Password = '"+txt_password.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(Querry, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                 
                    Username = txt_username.Text;
                    Password = txt_password.Text;

                    Menuform form2 = new Menuform();
                    form2.Show();
                    this.Hide(); 

                }   
                else
                {
                    MessageBox.Show("Login Failed!!", "Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();
                    txt_username.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }

        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();

            txt_username.Focus();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            DialogResult exit;
            exit = MessageBox.Show("Do you want to exit ?","Exit",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(exit == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
    