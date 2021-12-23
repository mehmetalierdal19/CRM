using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void MÜŞTERİLER_Click(object sender, EventArgs e)
        {
            Müşteriler mstr = new Müşteriler();
            mstr.ShowDialog();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ürünler urunler = new Ürünler();
            urunler.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ÜrünKategori urnktgr = new ÜrünKategori();
            urnktgr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Markalar mrklr = new Markalar();
            mrklr.ShowDialog();
        }
    }
}
