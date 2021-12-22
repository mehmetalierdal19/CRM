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
    }
}
