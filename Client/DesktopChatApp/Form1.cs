using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Security.Cryptography;

namespace DesktopChatApp
{
    public partial class Form1 : Form
    {
        public string LoggedInUsername { get;set; }

        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string passwordHash = ComputeSha256Hash(textBox2.Text);


            SqlConnection con = new SqlConnection(cs);

            string query = "SELECT * FROM login_tbl WHERE username = @user AND passhash = @passhash";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", textBox1.Text);
            cmd.Parameters.AddWithValue("@passhash", passwordHash);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                LoggedInUsername = textBox1.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {

                MessageBox.Show("Login Failed!");
            }

            con.Close();


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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
