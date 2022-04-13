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
    public partial class Gorusmeler : Form
    {
        baglanti bgl = new baglanti();
        public Gorusmeler()
        {
            InitializeComponent();
        }

        private void Gorusmeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tBLPERSONELDATASET.TBLPERSONEL' table. You can move, or remove it, as needed.
            this.tBLPERSONELTableAdapter.Fill(this.tBLPERSONELDATASET.TBLPERSONEL);
            // TODO: This line of code loads data into the 'dbMUSTERILERDataSet.TBLMUSTERILER' table. You can move, or remove it, as needed.
            this.tBLMUSTERILERTableAdapter.Fill(this.dbMUSTERILERDataSet.TBLMUSTERILER);

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert Into TBLGORUSME (Musteri, Sorumlu, Aciklama, Tarih) values (@MUSTERI, @SORUMLU, @ACIKLAMA, @TARIH)", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@MUSTERI", SqlDbType.NVarChar).Value = cbMusteri.Text;
            komut.Parameters.AddWithValue("@SORUMLU", SqlDbType.NVarChar).Value = cbSorumlu.Text;
            komut.Parameters.AddWithValue("@ACIKLAMA", SqlDbType.NVarChar).Value = txtAciklama.Text;
            komut.Parameters.AddWithValue("@TARIH", SqlDbType.Time).Value = dtTarih.Value;
            komut.ExecuteNonQuery();
        }
    }
}
