using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aplikasi_Pemesanan_Tiket_Konser
{
    public partial class Form1 : Form
    {
        string database = "server=localhost;database=tiket;uid=root;pwd=''";
        public MySqlConnection koneksi;
        public MySqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            koneksi = new MySqlConnection(database);
            koneksi.Open();
            cmd = new MySqlCommand("SELECT user,pass FROM login", koneksi);
            var reader = cmd.ExecuteReader();
            try
            {
                if (!string.IsNullOrWhiteSpace(username.Text) && !string.IsNullOrWhiteSpace(pass.Text))
                {
                    while (reader.Read())
                    {
                        if (reader["user"].ToString() == username.Text && reader["pass"].ToString() == pass.Text)
                        {

                            Form2 t = new Form2();
                            t.Show();
                            t.Focus();
                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("user dan pass salah");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("isi username dan password");
                }
            }
            catch (Exception anu)
            {
                label5.Text = anu.Message;
                Form2 t = new Form2();
                t.Show();
                this.Hide();
            }
        }
    


private void button2_Click(object sender, EventArgs e)
        {
            username.Text = "";
            pass.Text = "";
        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
