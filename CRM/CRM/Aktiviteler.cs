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
            // TODO: This line of code loads data into the 'tBLPERSONELDATASET.TBLPERSONEL' table. You can move, or remove it, as needed.
            this.tBLPERSONELTableAdapter.Fill(this.tBLPERSONELDATASET.TBLPERSONEL);
            // TODO: This line of code loads data into the 'dbCRMDataSet.TBLMUSTERILER' table. You can move, or remove it, as needed.
            this.tBLMUSTERILERTableAdapter.Fill(this.dbCRMDataSet.TBLMUSTERILER);
            // TODO: This line of code loads data into the 'dbCRMDataSet7.TBLMARKALAR' table. You can move, or remove it, as needed.
            this.tBLMARKALARTableAdapter.Fill(this.dbCRMDataSet7.TBLMARKALAR);

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
        }

        private void btnAktiviteSil_Click(object sender, EventArgs e)
        {

        }
    }
}
