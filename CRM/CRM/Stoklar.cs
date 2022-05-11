using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRM
{
    public partial class Stoklar : Form
    {
        baglanti bgl = new baglanti();
        public Stoklar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ürünler urn = new Ürünler();
            urn.ShowDialog();
        }

        private void Stoklar_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }
        private void kayitGetir()
        {
            SqlCommand komut = new SqlCommand("Select * from TBLSTOKLAR", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void txtStokArama_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBLSTOKLAR where UrunKodu Like '%" + txtStokArama.Text + "%'", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if(txtStokArama.Text == "")
            {
                kayitGetir();
            }
        }
    }
}
