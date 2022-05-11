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
    public partial class Personeller : Form
    {
        baglanti bgl = new baglanti();
        public Personeller()
        {
            InitializeComponent();
        }
        private void personelliste()
        {
            SqlCommand komut = new SqlCommand("Select * from TBLPERSONEL", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void temizle()
        {
            txtPersonelAd.Text = "";
            txtPersonelid.Text = "";
            txtAdres.Text = "";
            txtEposta.Text = "";
            txtPozisyon.Text = "";
            mtxtTelNo.Text = "";
        } 
        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            // Personel Ekleme
            SqlCommand komut = new SqlCommand("Insert Into TBLPERSONEL (PersonelAd, Pozisyon, PersonelTelNo, PersonelAdres, PersonelEposta) values (@AD, @POZİSYON, @TEL, @ADRES, @EPOSTA)", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@AD", SqlDbType.NVarChar).Value = txtPersonelAd.Text;
            komut.Parameters.AddWithValue("@POZİSYON", SqlDbType.NVarChar).Value = txtPozisyon.Text;
            komut.Parameters.AddWithValue("@TEL", SqlDbType.NVarChar).Value = mtxtTelNo.Text;
            komut.Parameters.AddWithValue("@ADRES", SqlDbType.NVarChar).Value = txtAdres.Text;
            komut.Parameters.AddWithValue("@EPOSTA", SqlDbType.NVarChar).Value = txtEposta.Text;
            komut.ExecuteNonQuery();
            personelliste();
            temizle();
        }

        private void Personeller_Load(object sender, EventArgs e)
        {
            personelliste();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtPersonelid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtPersonelAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtPozisyon.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            mtxtTelNo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtAdres.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtEposta.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBLPERSONEL where ID=@id", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(txtPersonelid.Text);
            komut.ExecuteNonQuery();
            personelliste();
            temizle();
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBLPERSONEL set PersonelAd=@AD, Pozisyon=@POZISYON, PersonelTelNo=@TEL, PersonelAdres=@ADRES, PersonelEposta=@EPOSTA where ID=@id", bgl.sqlbaglanti());
            komut.Parameters.AddWithValue("@AD", SqlDbType.NVarChar).Value = txtPersonelAd.Text;
            komut.Parameters.AddWithValue("@POZISYON", SqlDbType.NVarChar).Value = txtPozisyon.Text;
            komut.Parameters.AddWithValue("@TEL", SqlDbType.NVarChar).Value = mtxtTelNo.Text;
            komut.Parameters.AddWithValue("@ADRES", SqlDbType.NVarChar).Value = txtAdres.Text;
            komut.Parameters.AddWithValue("@EPOSTA", SqlDbType.NVarChar).Value = txtEposta.Text;
            komut.Parameters.AddWithValue("@id", SqlDbType.Int).Value = Convert.ToInt32(txtPersonelid.Text);
            komut.ExecuteNonQuery();
            personelliste();
            temizle();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBLPERSONEL where PersonelAd Like '%" + textBox1.Text + "%'", bgl.sqlbaglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if(textBox1.Text == "")
            {
                personelliste();
            }
        }
    }
}
