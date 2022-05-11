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
    public partial class Aktiviteler : Form
    {
        baglanti bgl = new baglanti();

        public Aktiviteler()
        {
            InitializeComponent();
        }

        private void Aktiviteler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbMUSTERILERDataSet.TBLMUSTERILER' table. You can move, or remove it, as needed.
            this.tBLMUSTERILERTableAdapter1.Fill(this.dbMUSTERILERDataSet.TBLMUSTERILER);
            // TODO: This line of code loads data into the 'tBLPERSONELDATASET.TBLPERSONEL' table. You can move, or remove it, as needed.
            this.tBLPERSONELTableAdapter.Fill(this.tBLPERSONELDATASET.TBLPERSONEL);
            // TODO: This line of code loads data into the 'dbCRMDataSet.TBLMUSTERILER' table. You can move, or remove it, as needed.
            //this.tBLMUSTERILERTableAdapter.Fill(this.dbCRMDataSet.TBLMUSTERILER);
            // TODO: This line of code loads data into the 'dbCRMDataSet7.TBLMARKALAR' table. You can move, or remove it, as needed.
            this.tBLMARKALARTableAdapter.Fill(this.dbCRMDataSet7.TBLMARKALAR);
            aktivitelistele();

        }
        private void aktivitelistele()
        {
            SqlCommand komut = new SqlCommand("Select * from TBLAKTIVITELER", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void temizle()
        {
            txtAciklama.Text = "";
            txtAktiviteAd.Text = "";
            txtID.Text = "";
            cbAktiviteTipi.Text = "";
            cbLokasyon.Text = "";
            cbMusteri.Text = "";
            cbOncelik.Text = "";
            cbSorumlu.Text = "";
            dtBaslangicSaat.Value = DateTime.Now;
            dtBaslangicTarih.Value = DateTime.Now;
            dtBitisSaat.Value = DateTime.Now;
            dtBitisTarih.Value = DateTime.Now;
        }
        private void btnAktiviteEkle_Click(object sender, EventArgs e)
        {
            // Aktivite Ekleme
            SqlCommand komut = new SqlCommand("Insert Into TBLAKTIVITELER (Musteri, AktiviteTipi, AktiviteAdi, Aciklama, Lokasyon, BaslangicTarihi, BaslangicSaati, BitisTarihi, BitisSaat, Oncelik, Sorumlu) values (@MUSTERI, @AKTIVITETIPI, @AKTIVITEADI, @ACIKLAMA, @LOKASYON, @BASLANGIC, @BASLANGICSAAT, @BITIS, @BITISSAAT, @ONCELIK, @SORUMLU)", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@MUSTERI", SqlDbType.NVarChar).Value = cbMusteri.Text;
            komut.Parameters.AddWithValue("@AKTIVITETIPI", SqlDbType.NVarChar).Value = cbAktiviteTipi.Text;
            komut.Parameters.AddWithValue("@AKTIVITEADI", SqlDbType.NVarChar).Value = txtAktiviteAd.Text;
            komut.Parameters.AddWithValue("@ACIKLAMA", SqlDbType.NVarChar).Value = txtAciklama.Text;
            komut.Parameters.AddWithValue("@LOKASYON", SqlDbType.NVarChar).Value = cbLokasyon.Text;
            komut.Parameters.AddWithValue("@BASLANGIC", SqlDbType.Date).Value = dtBaslangicTarih.Value;
            komut.Parameters.AddWithValue("@BASLANGICSAAT", SqlDbType.Time).Value = dtBaslangicSaat.Value;
            komut.Parameters.AddWithValue("@BITIS", SqlDbType.Date).Value = dtBitisTarih.Value;
            komut.Parameters.AddWithValue("@BITISSAAT", SqlDbType.Time).Value = dtBitisSaat.Value;
            komut.Parameters.AddWithValue("@ONCELIK", SqlDbType.NVarChar).Value = cbOncelik.Text;
            komut.Parameters.AddWithValue("@SORUMLU", SqlDbType.NVarChar).Value = cbSorumlu.Text;
            komut.ExecuteNonQuery();
            aktivitelistele();
            temizle();
        }

        private void cbAktiviteTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMusteri.Text != "" && cbAktiviteTipi.Text != "")
            {
                txtAktiviteAd.Text = cbMusteri.Text + ": " + cbAktiviteTipi.Text;
            }
            else
            {
                txtAktiviteAd.Text = "";
            }
        }

        private void btnAktiviteSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBLAKTIVITELER where ID=@id", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text);
            komut.ExecuteNonQuery();
            aktivitelistele();
            temizle();
        }

        private void btnAktiviteGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBLAKTIVITELER set Musteri=@MUSTERI, AktiviteTipi=@AKTIVITETIPI, AktiviteAdi=@AKTIVITEADI, Aciklama=@ACIKLAMA, Lokasyon=@LOKASYON, BaslangicTarihi=@BASLANGIC, BaslangicSaati=@BASLANGICSAAT, BitisTarihi=@BITIS, BitisSaat=@BITISSAAT, Oncelik=@ONCELIK, Sorumlu=@SORUMLU where ID=@id", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@MUSTERI", SqlDbType.NVarChar).Value = cbMusteri.Text;
            komut.Parameters.AddWithValue("@AKTIVITETIPI", SqlDbType.NVarChar).Value = cbAktiviteTipi.Text;
            komut.Parameters.AddWithValue("@AKTIVITEADI", SqlDbType.NVarChar).Value = txtAktiviteAd.Text;
            komut.Parameters.AddWithValue("@ACIKLAMA", SqlDbType.NVarChar).Value = txtAciklama.Text;
            komut.Parameters.AddWithValue("@LOKASYON", SqlDbType.NVarChar).Value = cbLokasyon.Text;
            komut.Parameters.AddWithValue("@BASLANGIC", SqlDbType.Date).Value = dtBaslangicTarih.Value;
            komut.Parameters.AddWithValue("@BASLANGICSAAT", SqlDbType.Time).Value = dtBaslangicSaat.Value;
            komut.Parameters.AddWithValue("@BITIS", SqlDbType.Date).Value = dtBitisTarih.Value;
            komut.Parameters.AddWithValue("@BITISSAAT", SqlDbType.Time).Value = dtBitisSaat.Value;
            komut.Parameters.AddWithValue("@ONCELIK", SqlDbType.NVarChar).Value = cbOncelik.Text;
            komut.Parameters.AddWithValue("@SORUMLU", SqlDbType.NVarChar).Value = cbSorumlu.Text;
            komut.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(txtID.Text);
            komut.ExecuteNonQuery();
            aktivitelistele();
            temizle();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbMusteri.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            cbAktiviteTipi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtAktiviteAd.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cbLokasyon.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dtBaslangicTarih.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            dtBaslangicSaat.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[7].Value.ToString());
            dtBitisTarih.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[8].Value.ToString());
            dtBitisSaat.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[9].Value.ToString());
            cbOncelik.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            cbSorumlu.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBLAKTIVITELER where Musteri Like '%" + txtArama.Text + "%'", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if(txtArama.Text == "")
            {
                aktivitelistele();
            }

        }
    }
}
