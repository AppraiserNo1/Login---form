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
using System.Configuration; 


namespace Login___form
{
    public partial class user_form : Form
    {
        
        public user_form()
        {
            InitializeComponent();
        }

       String connectionString = @"Data Source=desktop-20dl7b0;Initial Catalog=BookshopDB;Integrated Security=True";
       
        public void BindData()
        {

            userdataGridView.Columns.Clear();
            using (SqlConnection con1 = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from Customers", con1))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            userdataGridView.DataSource = dt;
                        }   
                    }
                }
            }
            userdataGridView.AllowUserToAddRows = false;

            DataGridViewButtonColumn buttoncolumn = new DataGridViewButtonColumn();
            userdataGridView.Columns.Insert(6, buttoncolumn);
            buttoncolumn.HeaderText = "Delete Row";
            buttoncolumn.Width = 50;
            buttoncolumn.Text = "Delete";
            buttoncolumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn buttoncolumn1 = new DataGridViewButtonColumn();
            userdataGridView.Columns.Insert(7, buttoncolumn1);
            buttoncolumn1.HeaderText = "Edit Row";
            buttoncolumn1.Width = 50;
            buttoncolumn1.Text = "Edit";
            buttoncolumn1.UseColumnTextForButtonValue = true;

        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Menuform gback = new Menuform();
            gback.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 6)
            {
                DataGridViewRow row = userdataGridView.Rows[e.RowIndex];
                if (MessageBox.Show(String.Format("Do You Want Delete This Row ? ", row.Cells["UserID"].Value), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection con1 = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("Delete from Customers Where Customer_id =@UserID", con1))
                        {
                            cmd.Parameters.AddWithValue("UserID", row.Cells["UserID"].Value);
                            con1.Open();
                            cmd.ExecuteNonQuery();
                            con1.Close();


                        }
                    }
                    BindData();
                }
            }
            if (e.ColumnIndex == 7)
            {
  
                Update upform = new Update();
                upform.Show();
                this.Hide();
            }
        }

        private void user_form_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            update_form f2 = new update_form();
            f2.Show();
            this.Hide();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            SqlConnection conup = new SqlConnection(connectionString);
            conup.Open();
           // SqlCommand cmd = new SqlCommand("Update Tester SET Username='" + txtusernameup.Text + "' ,Password='" + txtpasswordup.Text + "' ,Name='" + txtpasswordup.Text + "' ,Surname='" + txtsurnameup.Text + "' ,Status='" + upcombobox.Text + "' Where UserID='" + int.Parse(txtuserid.Text) + "' ", conn);
            //cmd.Parameters.AddWithValue("@UserID", i);
            //cmd.Parameters.AddWithValue("@Username", txtusernameup.Text);
            // cmd.Parameters.AddWithValue("@Password", txtpasswordup.Text);
            // cmd.Parameters.AddWithValue("@Name", txtnameup.Text);
            // cmd.Parameters.AddWithValue("@Surname", txtsurnameup.Text);
            // cmd.Parameters.AddWithValue("@Status", upcombobox.Text);

           // cmd.ExecuteNonQuery();
            conup.Close();
            MessageBox.Show("Update Data Succesfully");
            BindData();
        }
    }
}
