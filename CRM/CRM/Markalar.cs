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
    public partial class Markalar : Form
    {
        baglanti bgl = new baglanti();
        public Markalar()
        {
            InitializeComponent();
        }

        private void Markalar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbCRMDataSet3.TBLMARKALAR' table. You can move, or remove it, as needed.
            this.tBLMARKALARTableAdapter.Fill(this.dbCRMDataSet3.TBLMARKALAR);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert INTO TBLMARKALAR (MarkaAd) VALUES (@MARKAAD)", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@MARKAAD", SqlDbType.NVarChar).Value = txtMarkaAd.Text;
            komut.ExecuteNonQuery();
            this.tBLMARKALARTableAdapter.Fill(this.dbCRMDataSet3.TBLMARKALAR);
        }
    }
}
