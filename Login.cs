using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Book_Shop_Management_Project
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-32FVHP9\\SQLEXPRESS;Initial Catalog=\"Book store management\";Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select * from Login where username = '" + txtUser.Text + "' and password = '" + txtPass.Text + "' and Role = '" + cbRole.SelectedItem + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count > 0 )
            {
                MessageBox.Show("Login Sucessfully!");
                if (cbRole.SelectedIndex == 0)
                {
                    UserLogin u = new UserLogin();
                    this.Hide();
                    u.Show();
                }
                else
                {

                    AdminLogin a = new AdminLogin();
                    this.Hide();
                    a.Show();
                }
            }
                
            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_Password sc = new Forgot_Password();
            this.Hide();
            sc.Show();
        }

        private void tbpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
