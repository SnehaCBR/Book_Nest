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

namespace Book_Shop_Management_Project
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-32FVHP9\\SQLEXPRESS;Initial Catalog=\"Book store management\";Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Register]\r\n           ([FirstName]\r\n           ,[LastName]\r\n           ,[Email_Id]\r\n           ,[Gender]\r\n           ,[Address]\r\n           ,[Mobile_No]\r\n           ,[username]\r\n           ,[password])\r\n     VALUES ('" + txtFname.Text+ "','"+txtLname.Text+ "','"+txtEmail.Text+ "','"+cbGender.SelectedItem.ToString()+ "','"+txtAddress.Text+ "','"+txtMobile_No.Text+"','" + txtUser.Text+ "','"+txtPass.Text+"')",con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registered Successfully!");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
