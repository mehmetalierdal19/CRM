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
        private void temizle()
        {
            txtID.Text = "";
            txtMarkaAd.Text = "";
        }

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert INTO TBLMARKALAR (MarkaAd) VALUES (@MARKAAD)", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@MARKAAD", SqlDbType.NVarChar).Value = txtMarkaAd.Text;
            komut.ExecuteNonQuery();
            this.tBLMARKALARTableAdapter.Fill(this.dbCRMDataSet3.TBLMARKALAR);
            temizle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBLMARKALAR where MarkaID=@id", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text);
            komut.ExecuteNonQuery();
            this.tBLMARKALARTableAdapter.Fill(this.dbCRMDataSet3.TBLMARKALAR);
            temizle();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtMarkaAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBLMARKALAR where MarkaAd Like '%" + txtArama.Text + "%'", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if(txtArama.Text == "")
            {
                this.tBLMARKALARTableAdapter.Fill(this.dbCRMDataSet3.TBLMARKALAR);
            }
        }
    }
}
