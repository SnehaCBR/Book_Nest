using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace Book_Shop_Management_Project
{
    public partial class Forgot_Password : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-32FVHP9\\SQLEXPRESS;Initial Catalog=\"Book store management\";Integrated Security=True");
        public Forgot_Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select username,password,Role from Login where username = '" + txtUser.Text + "' ", con);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                txtGetPassword.Text = dr[1].ToString();
            }
            else
            {
                MessageBox.Show("Invalid Username!");
                txtGetPassword.Text = "";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGetPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
