using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace DesktopChatApp
{
    public partial class Form2 : Form
    {

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form2()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string passwordHash = ComputeSha256Hash(textBox2.Text);

            SqlConnection con = new SqlConnection(cs);
            string query = "INSERT INTO login_tbl VALUES(@username,@passhash)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);
            cmd.Parameters.AddWithValue("@passhash", passwordHash);

            con.Open();
            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Registration successful!");
                Close();
            }
            else
            {
                MessageBox.Show("Registration failed!");
            }
        }

        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                errorProvider1.Icon = Properties.Resources.cross_mark;
                errorProvider1.SetError(this.textBox1, "Please fill the username.");
            }
            else
            {
                errorProvider1.Icon = Properties.Resources.check_mark;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox2.Text) || textBox2.Text.Length < 6)
            {
                textBox2.Focus();
                errorProvider2.Icon = Properties.Resources.cross_mark;
                errorProvider2.SetError(this.textBox2, "Password must be atleast 6 length long.");
            }
            else
            {
                errorProvider2.Icon = Properties.Resources.check_mark;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text) || (textBox2.Text != textBox3.Text))
            {
                textBox3.Focus();
                errorProvider3.Icon = Properties.Resources.cross_mark;
                errorProvider3.SetError(this.textBox3, "Password doesn't match.");
            }
            else
            {
                errorProvider3.Icon = Properties.Resources.check_mark;
            }
        }
    }
}
