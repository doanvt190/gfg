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


namespace ASM2_DATA
{
    public partial class Login : Form
    {
        SqlConnection conn;
        public Login()
        {
            InitializeComponent();
            conn = new SqlConnection("server = ĐOÀN; database = LibraryManagement1; integrated security = true");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want to exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;
            string query = "select * from Accounts where username = @username and user_password = @password";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", SqlDbType.VarChar);
            cmd.Parameters["@username"].Value = username;
            cmd.Parameters.AddWithValue("@password", SqlDbType.VarChar);
            cmd.Parameters["@password"].Value = password;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string role = reader["user_role"].ToString();
                if (role.Equals("admin"))
                {
                    MessageBox.Show(this, "Login success", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    Form1 admin = new Form1(username);
                    admin.ShowDialog();
                    this.Dispose();
                }
                else if (role.Equals("borrower"))
                {
                    MessageBox.Show(this, "Login success", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    Form2 borrower = new Form2(username);
                    borrower.ShowDialog();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }
            }
            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

