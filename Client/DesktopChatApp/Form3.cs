using Microsoft.AspNetCore.SignalR.Client;
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

namespace DesktopChatApp
{
    public partial class Form3 : Form
    {
        private readonly string _name;
        private readonly HubConnection _connection;
        string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Form3(string name)
        {
            InitializeComponent();
            _name = name;

            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT username FROM login_tbl WHERE username != @user";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", name);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                // Assuming the ComboBox is named comboBox1
                comboBox1.Items.Add(dr["username"].ToString());
            }
            dr.Close();
            con.Close();

            _connection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7034/chathub?username={_name}")
                .WithAutomaticReconnect()
                .Build();
            _connection.On<string, string, string>("ReceiveMessage", (user, receiver, message) =>
            {
                this.Invoke(() =>
                {
                    if (receiver == _name || user == _name)
                    {
                        listBox1.Items.Add($"{user} : {message}");
                    }
                });
            });
        }

        private async void Form3_Load(object sender, EventArgs e)
        {
            await _connection.StartAsync();
            label1.Text = $"Welcome, {_name}.";
            listBox1.Items.Add("Connected to chat server!");

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text)) {
                string receiver = comboBox1.SelectedItem.ToString();
                await _connection.InvokeAsync("SendMessage", _name, receiver, textBox1.Text);
                textBox1.Clear();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            label3.Text = $"Chat with : {comboBox1.SelectedItem.ToString()}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
