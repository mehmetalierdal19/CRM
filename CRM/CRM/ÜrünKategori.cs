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
    public partial class ÜrünKategori : Form
    {
        baglanti bgl = new baglanti();
        public ÜrünKategori()
        {
            InitializeComponent();
        }

        private void ÜrünKategori_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbCRMDataSet2.TBLKATEGORILER' table. You can move, or remove it, as needed.
            this.tBLKATEGORILERTableAdapter.Fill(this.dbCRMDataSet2.TBLKATEGORILER);

        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("Insert INTO TBLKATEGORILER (KategoriAD, UrunSayisi) VALUES (@KATEGORIAD, @URUNSAYISI)", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@KATEGORIAD", SqlDbType.NVarChar).Value = txtKategoriAd.Text;
            komut.Parameters.AddWithValue("@URUNSAYISI", SqlDbType.Int).Value = Convert.ToInt32(txtUrunSayisi.Text);
            komut.ExecuteNonQuery();
            this.tBLKATEGORILERTableAdapter.Fill(this.dbCRMDataSet2.TBLKATEGORILER);
        }
    }
}
