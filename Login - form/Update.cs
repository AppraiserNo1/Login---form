using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Login___form
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }
    
        String connectionString = @"Data Source=desktop-20dl7b0;Initial Catalog=BookshopDB;Integrated Security=True";

        private void load_data()
        {       

            UpdatedataGridView.Columns.Clear();
            using (SqlConnection con1 = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from Customers", con1))
                {
                    using (SqlDataAdapter dad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dtd = new DataTable())
                        {
                            dad.Fill(dtd);
                            UpdatedataGridView.DataSource = dtd;
                        }
                    }
                }
            }
            UpdatedataGridView.AllowUserToAddRows = false;

        }
        
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
          

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
           
              
                conn.Open();
                string updateSql = "UPDATE Customers SET Username='" + txtusernameup.Text+ "',Password='"+ txtpasswordup.Text+ "',Name='"+ txtnameup.Text+"',Surname='"+txtsurnameup.Text+ "' WHERE Customer_id = '" + int.Parse(txtuserid.Text) +"'";
                using (SqlCommand cmd = new SqlCommand(updateSql, conn))
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Update Data Succesfully");
                    load_data();
                }   
               
            }

        }

        private void button_gback_Click(object sender, EventArgs e)
        {
            user_form gback = new user_form();
            gback.Show();
            this.Hide();
        }


        private void UpdatedataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
            

        }
        private void Update_Load(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
