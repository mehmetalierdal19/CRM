using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CRM
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(@"Data Source =DESKTOP-7EGS3RS\SQLEXPRESS; Initial Catalog=dbCRM; Integrated Security=True");
            SqlCommand komut = new SqlCommand("Insert INTO TBLMUSTERILER (MUSTERIAD, MUSTERISOYAD, SEHIR, ILETISIMNO) VALUES (@AD, @SOYAD, @SEHIR, @ILETISIMNO)" ,baglan);
            baglan.Open();
            komut.Parameters.AddWithValue("@AD", SqlDbType.NVarChar).Value = txtMUSTERIAD.Text;
            komut.Parameters.AddWithValue("@SOYAD", SqlDbType.NVarChar).Value = txtSOYAD.Text;
            komut.Parameters.AddWithValue("@SEHIR", SqlDbType.NVarChar).Value = txtSEHIR.Text;
            komut.Parameters.AddWithValue("@ILETISIMNO", SqlDbType.NVarChar).Value = txtILETISIM.Text;
            komut.ExecuteNonQuery();
        }
    }
}
