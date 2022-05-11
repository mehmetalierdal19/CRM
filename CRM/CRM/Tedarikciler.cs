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
    public partial class Tedarikciler : Form
    {
        baglanti bgl = new baglanti();
        public Tedarikciler()
        {
            InitializeComponent();
        }
        private void Tedarikciler_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }
        private void kayitGetir()
        {
            SqlCommand komut = new SqlCommand("Select * from TBLTEDARIKCI", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void temizle()
        {
            txtID.Text = "";
            txtTedarikci.Text = "";
            txtYetkili.Text = "";
            txtEposta.Text = "";
            txtTel.Text = "";
            txtAdres.Text = "";
            txtDaire.Text = "";
            txtVergino.Text = "";
            cbPara.Text = "";
            txtAciklama.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert Into TBLTEDARIKCI (TedarikciAd, Yetkili, Eposta, Telefon, Adres, VergiDairesi, VergiNo, ParaBirimi, Aciklama) values (@TEDARIKCI, @YETKILI, @POSTA, @TEL, @ADRES, @DAİRE, @VNO, @PARA, @ACIKLAMA)", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@TEDARIKCI", SqlDbType.NVarChar).Value = txtTedarikci.Text;
            komut.Parameters.AddWithValue("@YETKILI", SqlDbType.NVarChar).Value = txtYetkili.Text;
            komut.Parameters.AddWithValue("@POSTA", SqlDbType.NVarChar).Value = txtEposta.Text;
            komut.Parameters.AddWithValue("@TEL", SqlDbType.NVarChar).Value = txtTel.Text;
            komut.Parameters.AddWithValue("@ADRES", SqlDbType.NVarChar).Value = txtAdres.Text;
            komut.Parameters.AddWithValue("@DAİRE", SqlDbType.NVarChar).Value = txtDaire.Text;
            komut.Parameters.AddWithValue("@VNO", SqlDbType.NVarChar).Value = txtVergino.Text;
            komut.Parameters.AddWithValue("@PARA", SqlDbType.NVarChar).Value = cbPara.Text;
            komut.Parameters.AddWithValue("@ACIKLAMA", SqlDbType.NVarChar).Value = txtAciklama.Text;
            komut.ExecuteNonQuery();
            kayitGetir();
            temizle();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTedarikci.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtYetkili.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEposta.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtDaire.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtVergino.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cbPara.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBLTEDARIKCI where ID=@id", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text);
            komut.ExecuteNonQuery();
            kayitGetir();
            temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBLTEDARIKCI set TedarikciAd=@AD, Yetkili=@YETKILI, Eposta=@EPOSTA, Telefon=@TEL, Adres=@ADRES, VergiDairesi=@DAIRE, VergiNo=@NO, ParaBirimi=@PARA, Aciklama=@ACIKLAMA where ID=@id", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@AD", SqlDbType.NVarChar).Value = txtTedarikci.Text;
            komut.Parameters.AddWithValue("@YETKILI", SqlDbType.NVarChar).Value = txtYetkili.Text;
            komut.Parameters.AddWithValue("@EPOSTA", SqlDbType.NVarChar).Value = txtEposta.Text;
            komut.Parameters.AddWithValue("@TEL", SqlDbType.NVarChar).Value = txtTel.Text;
            komut.Parameters.AddWithValue("@ADRES", SqlDbType.NVarChar).Value = txtAdres.Text;
            komut.Parameters.AddWithValue("@DAIRE", SqlDbType.NVarChar).Value = txtDaire.Text;
            komut.Parameters.AddWithValue("@NO", SqlDbType.NVarChar).Value = txtVergino.Text;
            komut.Parameters.AddWithValue("@PARA", SqlDbType.NVarChar).Value = cbPara.Text;
            komut.Parameters.AddWithValue("@ACIKLAMA", SqlDbType.NVarChar).Value = txtAciklama.Text;
            komut.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text);
            komut.ExecuteNonQuery();
            kayitGetir();
            temizle();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBLTEDARIKCI where TedarikciAd Like '%" + txtArama.Text + "%'", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if(txtArama.Text == "")
            {
                kayitGetir();
            }
        }
    }
}
