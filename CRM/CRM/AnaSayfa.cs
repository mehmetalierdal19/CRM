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

        private void button4_Click(object sender, EventArgs e)
        {
            Depolar dplr = new Depolar();
            dplr.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AlışveSatışlar avs = new AlışveSatışlar();
            avs.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Aktiviteler akt = new Aktiviteler();
            akt.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Personeller prs = new Personeller();
            prs.ShowDialog();
        }

        private void btnStoklar_Click(object sender, EventArgs e)
        {
            Stoklar stklr = new Stoklar();
            stklr.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Gorusmeler grs = new Gorusmeler();
            grs.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Tedarikciler tdr = new Tedarikciler();
            tdr.ShowDialog();
        }
    }
}
