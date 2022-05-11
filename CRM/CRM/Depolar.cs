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
    public partial class Depolar : Form
    {
        baglanti bgl = new baglanti();
        public Depolar()
        {
            InitializeComponent();
        }

        private void Depolar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbCRMDataSet4.TBLDEPOLAR' table. You can move, or remove it, as needed.
            this.tBLDEPOLARTableAdapter.Fill(this.dbCRMDataSet4.TBLDEPOLAR);

        }
        private void temizle()
        {
            textBox1.Text = "";
            txtDepoAd.Text = "";
        }

        private void btnDepoEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBLDEPOLAR (DepoAd) VALUES (@DEPOAD) ", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@DEPOAD", SqlDbType.NVarChar).Value = txtDepoAd.Text;
            komut.ExecuteNonQuery();
            this.tBLDEPOLARTableAdapter.Fill(this.dbCRMDataSet4.TBLDEPOLAR);
            temizle();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtDepoAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBLDEPOLAR where DepoID=@id", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(textBox1.Text);
            komut.ExecuteNonQuery();
            this.tBLDEPOLARTableAdapter.Fill(this.dbCRMDataSet4.TBLDEPOLAR);
            temizle();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBLDEPOLAR where DepoAd like '%" + txtArama.Text + "%'", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if(txtArama.Text == "")
            {
                this.tBLDEPOLARTableAdapter.Fill(this.dbCRMDataSet4.TBLDEPOLAR);
            }
        }
    }
}
