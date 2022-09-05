using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Pemesanan_Tiket_Konser
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tiketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tiket i = new Tiket() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            i.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(i);
            i.Show();
        }

        private void laporanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            laporan p = new laporan() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            p.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(p);
            p.Show();
        }
    }
}
