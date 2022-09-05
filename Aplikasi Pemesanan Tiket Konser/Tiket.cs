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
    public partial class Tiket : Form
    {
        string database = ("server = localhost;database=Tiket;uid=root;pwd=''");
        public MySqlConnection menyambung;
        public MySqlCommand cmd;
        public MySqlDataAdapter adp;
        public Tiket()
        {
            InitializeComponent();
        }
        public void Query(string query)
        {
            menyambung = new MySqlConnection(database);
            try
            {
                menyambung.Open();
                cmd = new MySqlCommand(query, menyambung);
                cmd.ExecuteNonQuery();
            }
            catch (Exception reszy)
            {
                MessageBox.Show(reszy.Message);
            }
            finally
            {
                menyambung.Close();
            }

        }


        private void Tiket_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a, b, c, td, snack, minum;
            int harga, snackh, minumh, jumlah;
            a = textBox1.Text;
            b = textBox2.Text;
            c = textBox3.Text;
            td = comboBox1.Text;
            snack = comboBox2.Text;
            minum = comboBox3.Text;

            if (td.Equals("Basic"))
            {
                textBox6.Text = "Tempat Duduk Basic";
                harga = 35000;
                if (snack.Equals("Pop Corn"))
                {
                    snackh = 10000;
                }
                else if (snack.Equals("Kentang Goreng"))
                {
                    snackh = 12000;
                }
                else if (snack.Equals("Nugget"))
                {
                    snackh = 15000;
                }
                else
                {
                    snackh = 0;
                }
                textBox5.Text = harga.ToString();
                label20.Text = a;
                label19.Text = b;
                label18.Text = c;
                if (minum.Equals("Air Mineral"))
                {
                    minumh = 5000;
                }
                else if (minum.Equals("Ice Tea"))
                {
                    minumh = 8000;
                }
                else if (minum.Equals("Ice Coffe"))
                {
                    minumh = 12000;
                }
                else if (minum.Equals("Milkshake"))
                {
                    minumh = 15000;
                }
                else if (minum.Equals("Juice"))
                {
                    minumh = 12000;
                }
                else
                {
                    minumh = 0;
                }
                jumlah = harga + snackh + minumh;
                textBox4.Text = snackh.ToString();
                textBox9.Text = minumh.ToString();
                textBox8.Text = jumlah.ToString();
            }
            else if (td.Equals("VIP"))
            {
                textBox6.Text = "Tempat Duduk VIP";
                harga = 60000;
                if (snack.Equals("Pop Corn"))
                {
                    snackh = 10000;
                }
                else if (snack.Equals("Kentang Goreng"))
                {
                    snackh = 12000;
                }
                else if (snack.Equals("Nugget"))
                {
                    snackh = 15000;
                }
                else
                {
                    snackh = 0;
                }
                textBox5.Text = harga.ToString();
                label20.Text = a;
                label19.Text = b;
                label18.Text = c;
                if (minum.Equals("Air Mineral"))
                {
                    minumh = 5000;
                }
                else if (minum.Equals("Ice Tea"))
                {
                    minumh = 8000;
                }
                else if (minum.Equals("Ice Coffe"))
                {
                    minumh = 12000;
                }
                else if (minum.Equals("Milkshake"))
                {
                    minumh = 15000;
                }
                else if (minum.Equals("Juice"))
                {
                    minumh = 12000;
                }
                else
                {
                    minumh = 0;
                }
                jumlah = harga + snackh + minumh;
                textBox4.Text = snackh.ToString();
                textBox9.Text = minumh.ToString();
                textBox8.Text = jumlah.ToString();
            }
            else if (td.Equals("Fancy"))
            {
                textBox6.Text = "Tempat Duduk Fancy";
                harga = 100000;
                if (snack.Equals("Pop Corn"))
                {
                    snackh = 10000;
                }
                else if (snack.Equals("Kentang Goreng"))
                {
                    snackh = 12000;
                }
                else if (snack.Equals("Nugget"))
                {
                    snackh = 15000;
                }
                else
                {
                    snackh = 0;
                }
                textBox5.Text = harga.ToString();
                label20.Text = a;
                label19.Text = b;
                label18.Text = c;
                if (minum.Equals("Air Mineral"))
                {
                    minumh = 5000;
                }
                else if (minum.Equals("Ice Tea"))
                {
                    minumh = 8000;
                }
                else if (minum.Equals("Ice Coffe"))
                {
                    minumh = 12000;
                }
                else if (minum.Equals("Milkshake"))
                {
                    minumh = 15000;
                }
                else if (minum.Equals("Juice"))
                {
                    minumh = 12000;
                }
                else
                {
                    minumh = 0;
                }
                jumlah = harga + snackh + minumh;
                textBox4.Text = snackh.ToString();
                textBox9.Text = minumh.ToString();
                textBox8.Text = jumlah.ToString();
            }

            Query("insert into data values('" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.comboBox1.Text + "','" + this.comboBox2.Text + "','" + this.comboBox3.Text + "')");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Petunjuk c = new Petunjuk();
            c.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
