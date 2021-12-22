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
    public partial class Müşteriler : Form
    {
        public Müşteriler()
        {
            InitializeComponent();
        }

        private void Müşteriler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbCRMDataSet.TBLMUSTERILER' table. You can move, or remove it, as needed.
            this.tBLMUSTERILERTableAdapter.Fill(this.dbCRMDataSet.TBLMUSTERILER);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriEkle mstrekle = new MusteriEkle();
            mstrekle.ShowDialog();
        }
    }
}
