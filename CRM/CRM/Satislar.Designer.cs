
namespace CRM
{
    partial class Satislar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSatisTutar = new System.Windows.Forms.TextBox();
            this.txtIndirim = new System.Windows.Forms.TextBox();
            this.txtKDV = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.cbParaBirim = new System.Windows.Forms.ComboBox();
            this.cbTeslimat = new System.Windows.Forms.ComboBox();
            this.cbOdemeTip = new System.Windows.Forms.ComboBox();
            this.tBLURUNLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbURUNLERDataSet14 = new CRM.dbURUNLERDataSet14();
            this.tBLKATEGORILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbCRMDataSet13 = new CRM.dbCRMDataSet13();
            this.cbMusteri = new System.Windows.Forms.ComboBox();
            this.tBLMUSTERILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbMUSTERILERDataSet = new CRM.dbMUSTERILERDataSet();
            this.dtSatisTarih = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tBLMUSTERILERTableAdapter = new CRM.dbMUSTERILERDataSetTableAdapters.TBLMUSTERILERTableAdapter();
            this.tBLKATEGORILERTableAdapter = new CRM.dbCRMDataSet13TableAdapters.TBLKATEGORILERTableAdapter();
            this.tBLURUNLERTableAdapter = new CRM.dbURUNLERDataSet14TableAdapters.TBLURUNLERTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtSatisArama = new System.Windows.Forms.TextBox();
            this.txtUrunArama = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.txtBirim = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbURUNLERDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKATEGORILERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERILERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMUSTERILERDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(491, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(108, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Kategorisi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(483, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Kodu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(817, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birim Fiyatı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(818, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "İndirim(%):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1164, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Miktar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(184, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Birim:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(499, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "KDV(%):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(155, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Açıklama:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(820, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Para Birimi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(793, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Satış Tarihi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(1127, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "Ödeme Tipi:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(161, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = "Teslimat:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(1153, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 18);
            this.label14.TabIndex = 13;
            this.label14.Text = "Satış ID:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(478, 203);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 18);
            this.label15.TabIndex = 14;
            this.label15.Text = "Satış Tutarı:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(257, 259);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(1159, 87);
            this.txtAciklama.TabIndex = 15;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Location = new System.Drawing.Point(1231, 195);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(185, 26);
            this.txtID.TabIndex = 16;
            // 
            // txtSatisTutar
            // 
            this.txtSatisTutar.Enabled = false;
            this.txtSatisTutar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisTutar.Location = new System.Drawing.Point(581, 195);
            this.txtSatisTutar.Name = "txtSatisTutar";
            this.txtSatisTutar.Size = new System.Drawing.Size(185, 26);
            this.txtSatisTutar.TabIndex = 17;
            // 
            // txtIndirim
            // 
            this.txtIndirim.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIndirim.Location = new System.Drawing.Point(919, 147);
            this.txtIndirim.Name = "txtIndirim";
            this.txtIndirim.Size = new System.Drawing.Size(185, 26);
            this.txtIndirim.TabIndex = 18;
            // 
            // txtKDV
            // 
            this.txtKDV.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKDV.Location = new System.Drawing.Point(581, 141);
            this.txtKDV.Name = "txtKDV";
            this.txtKDV.Size = new System.Drawing.Size(185, 26);
            this.txtKDV.TabIndex = 19;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Location = new System.Drawing.Point(1231, 87);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(185, 26);
            this.txtMiktar.TabIndex = 20;
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirimFiyat.Location = new System.Drawing.Point(919, 83);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(185, 26);
            this.txtBirimFiyat.TabIndex = 21;
            // 
            // cbParaBirim
            // 
            this.cbParaBirim.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbParaBirim.FormattingEnabled = true;
            this.cbParaBirim.Items.AddRange(new object[] {
            "TL",
            "USD",
            "EURO"});
            this.cbParaBirim.Location = new System.Drawing.Point(919, 196);
            this.cbParaBirim.Name = "cbParaBirim";
            this.cbParaBirim.Size = new System.Drawing.Size(185, 26);
            this.cbParaBirim.TabIndex = 22;
            // 
            // cbTeslimat
            // 
            this.cbTeslimat.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTeslimat.FormattingEnabled = true;
            this.cbTeslimat.Items.AddRange(new object[] {
            "Yapıldı",
            "Yapılmadı"});
            this.cbTeslimat.Location = new System.Drawing.Point(257, 199);
            this.cbTeslimat.Name = "cbTeslimat";
            this.cbTeslimat.Size = new System.Drawing.Size(185, 26);
            this.cbTeslimat.TabIndex = 23;
            // 
            // cbOdemeTip
            // 
            this.cbOdemeTip.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOdemeTip.FormattingEnabled = true;
            this.cbOdemeTip.Items.AddRange(new object[] {
            "kapıda ödeme ",
            "kredi kartı",
            "havale/eft",
            "garanti kapsamında",
            "online ödeme",
            "sodexo",
            "multinet",
            "ticket",
            "yemek kartı",
            "diğer"});
            this.cbOdemeTip.Location = new System.Drawing.Point(1231, 151);
            this.cbOdemeTip.Name = "cbOdemeTip";
            this.cbOdemeTip.Size = new System.Drawing.Size(185, 26);
            this.cbOdemeTip.TabIndex = 24;
            // 
            // tBLURUNLERBindingSource
            // 
            this.tBLURUNLERBindingSource.DataMember = "TBLURUNLER";
            this.tBLURUNLERBindingSource.DataSource = this.dbURUNLERDataSet14;
            // 
            // dbURUNLERDataSet14
            // 
            this.dbURUNLERDataSet14.DataSetName = "dbURUNLERDataSet14";
            this.dbURUNLERDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLKATEGORILERBindingSource
            // 
            this.tBLKATEGORILERBindingSource.DataMember = "TBLKATEGORILER";
            this.tBLKATEGORILERBindingSource.DataSource = this.dbCRMDataSet13;
            // 
            // dbCRMDataSet13
            // 
            this.dbCRMDataSet13.DataSetName = "dbCRMDataSet13";
            this.dbCRMDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbMusteri
            // 
            this.cbMusteri.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tBLMUSTERILERBindingSource, "id", true));
            this.cbMusteri.DataSource = this.tBLMUSTERILERBindingSource;
            this.cbMusteri.DisplayMember = "MUSTERIAD";
            this.cbMusteri.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMusteri.FormattingEnabled = true;
            this.cbMusteri.Location = new System.Drawing.Point(581, 12);
            this.cbMusteri.Name = "cbMusteri";
            this.cbMusteri.Size = new System.Drawing.Size(185, 26);
            this.cbMusteri.TabIndex = 28;
            this.cbMusteri.ValueMember = "id";
            // 
            // tBLMUSTERILERBindingSource
            // 
            this.tBLMUSTERILERBindingSource.DataMember = "TBLMUSTERILER";
            this.tBLMUSTERILERBindingSource.DataSource = this.dbMUSTERILERDataSet;
            // 
            // dbMUSTERILERDataSet
            // 
            this.dbMUSTERILERDataSet.DataSetName = "dbMUSTERILERDataSet";
            this.dbMUSTERILERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtSatisTarih
            // 
            this.dtSatisTarih.CalendarFont = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtSatisTarih.Location = new System.Drawing.Point(904, 12);
            this.dtSatisTarih.Name = "dtSatisTarih";
            this.dtSatisTarih.Size = new System.Drawing.Size(200, 22);
            this.dtSatisTarih.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(625, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 42);
            this.button1.TabIndex = 30;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(764, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 42);
            this.button2.TabIndex = 31;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(902, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 42);
            this.button3.TabIndex = 32;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tBLMUSTERILERTableAdapter
            // 
            this.tBLMUSTERILERTableAdapter.ClearBeforeFill = true;
            // 
            // tBLKATEGORILERTableAdapter
            // 
            this.tBLKATEGORILERTableAdapter.ClearBeforeFill = true;
            // 
            // tBLURUNLERTableAdapter
            // 
            this.tBLURUNLERTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 432);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 341);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1030, 432);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(492, 341);
            this.dataGridView2.TabIndex = 34;
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            // 
            // txtSatisArama
            // 
            this.txtSatisArama.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisArama.Location = new System.Drawing.Point(12, 394);
            this.txtSatisArama.Name = "txtSatisArama";
            this.txtSatisArama.Size = new System.Drawing.Size(141, 26);
            this.txtSatisArama.TabIndex = 35;
            this.txtSatisArama.TextChanged += new System.EventHandler(this.txtSatisArama_TextChanged);
            // 
            // txtUrunArama
            // 
            this.txtUrunArama.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunArama.Location = new System.Drawing.Point(1369, 394);
            this.txtUrunArama.Name = "txtUrunArama";
            this.txtUrunArama.Size = new System.Drawing.Size(153, 26);
            this.txtUrunArama.TabIndex = 36;
            this.txtUrunArama.TextChanged += new System.EventHandler(this.txtUrunArama_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(161, 403);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 17);
            this.label16.TabIndex = 37;
            this.label16.Text = "*Ürün Kodu Giriniz";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1164, 403);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(185, 17);
            this.label17.TabIndex = 38;
            this.label17.Text = "*Ürün Kodu Veya Adı Giriniz";
            // 
            // txtKategori
            // 
            this.txtKategori.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKategori.Location = new System.Drawing.Point(257, 87);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(185, 26);
            this.txtKategori.TabIndex = 39;
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunKodu.Location = new System.Drawing.Point(581, 87);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(185, 26);
            this.txtUrunKodu.TabIndex = 40;
            // 
            // txtBirim
            // 
            this.txtBirim.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirim.Location = new System.Drawing.Point(257, 141);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(185, 26);
            this.txtBirim.TabIndex = 41;
            // 
            // Satislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1534, 785);
            this.Controls.Add(this.txtBirim);
            this.Controls.Add(this.txtUrunKodu);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtUrunArama);
            this.Controls.Add(this.txtSatisArama);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtSatisTarih);
            this.Controls.Add(this.cbMusteri);
            this.Controls.Add(this.cbOdemeTip);
            this.Controls.Add(this.cbTeslimat);
            this.Controls.Add(this.cbParaBirim);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtKDV);
            this.Controls.Add(this.txtIndirim);
            this.Controls.Add(this.txtSatisTutar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Satislar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satislar";
            this.Load += new System.EventHandler(this.Satislar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbURUNLERDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKATEGORILERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERILERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMUSTERILERDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSatisTutar;
        private System.Windows.Forms.TextBox txtIndirim;
        private System.Windows.Forms.TextBox txtKDV;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.ComboBox cbParaBirim;
        private System.Windows.Forms.ComboBox cbTeslimat;
        private System.Windows.Forms.ComboBox cbOdemeTip;
        private System.Windows.Forms.ComboBox cbMusteri;
        private System.Windows.Forms.DateTimePicker dtSatisTarih;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private dbMUSTERILERDataSet dbMUSTERILERDataSet;
        private System.Windows.Forms.BindingSource tBLMUSTERILERBindingSource;
        private dbMUSTERILERDataSetTableAdapters.TBLMUSTERILERTableAdapter tBLMUSTERILERTableAdapter;
        private dbCRMDataSet13 dbCRMDataSet13;
        private System.Windows.Forms.BindingSource tBLKATEGORILERBindingSource;
        private dbCRMDataSet13TableAdapters.TBLKATEGORILERTableAdapter tBLKATEGORILERTableAdapter;
        private dbURUNLERDataSet14 dbURUNLERDataSet14;
        private System.Windows.Forms.BindingSource tBLURUNLERBindingSource;
        private dbURUNLERDataSet14TableAdapters.TBLURUNLERTableAdapter tBLURUNLERTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtSatisArama;
        private System.Windows.Forms.TextBox txtUrunArama;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.TextBox txtBirim;
    }
}