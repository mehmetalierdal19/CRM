
namespace CRM
{
    partial class Alislar
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
            this.cbTeslimat = new System.Windows.Forms.ComboBox();
            this.cbTahsilat = new System.Windows.Forms.ComboBox();
            this.cbOdemeTipi = new System.Windows.Forms.ComboBox();
            this.cbParaBirimi = new System.Windows.Forms.ComboBox();
            this.tBLKATEGORILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbCRMDataSet13 = new CRM.dbCRMDataSet13();
            this.cbTedarikci = new System.Windows.Forms.ComboBox();
            this.tBLTEDARIKCIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbTBLTEDARIKCIDataSet = new CRM.dbTBLTEDARIKCIDataSet();
            this.dtAlisTarih = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.txtKDV = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.tBLKATEGORILERTableAdapter = new CRM.dbCRMDataSet13TableAdapters.TBLKATEGORILERTableAdapter();
            this.tBLTEDARIKCITableAdapter = new CRM.dbTBLTEDARIKCIDataSetTableAdapters.TBLTEDARIKCITableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.txtUrunArama = new System.Windows.Forms.TextBox();
            this.txtAlisArama = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUrunKodu = new System.Windows.Forms.TextBox();
            this.txtUrunKategori = new System.Windows.Forms.TextBox();
            this.txtBirim = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tBLKATEGORILERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLTEDARIKCIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTBLTEDARIKCIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(380, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tedarikçi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(750, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alış Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Kategrorisi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(434, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün Kodu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(817, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birim Fiyatı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(1184, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Miktar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(108, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Birim:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(450, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "KDV(%):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(802, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Toplam Tutar:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(1152, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Para Birimi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(62, 246);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Ödeme Tipi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(838, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "Teslimat:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(457, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = "Tahsilat:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(1185, 246);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 18);
            this.label14.TabIndex = 13;
            this.label14.Text = "Alış ID:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(79, 303);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 18);
            this.label15.TabIndex = 14;
            this.label15.Text = "Açıklama:";
            // 
            // cbTeslimat
            // 
            this.cbTeslimat.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTeslimat.FormattingEnabled = true;
            this.cbTeslimat.Items.AddRange(new object[] {
            "Yapıldı",
            "Yapılmadı"});
            this.cbTeslimat.Location = new System.Drawing.Point(930, 238);
            this.cbTeslimat.Name = "cbTeslimat";
            this.cbTeslimat.Size = new System.Drawing.Size(192, 26);
            this.cbTeslimat.TabIndex = 15;
            // 
            // cbTahsilat
            // 
            this.cbTahsilat.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTahsilat.FormattingEnabled = true;
            this.cbTahsilat.Items.AddRange(new object[] {
            "Yapıldı",
            "Yapılmadı",
            "Kısmi Ödeme"});
            this.cbTahsilat.Location = new System.Drawing.Point(546, 238);
            this.cbTahsilat.Name = "cbTahsilat";
            this.cbTahsilat.Size = new System.Drawing.Size(192, 26);
            this.cbTahsilat.TabIndex = 16;
            // 
            // cbOdemeTipi
            // 
            this.cbOdemeTipi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOdemeTipi.FormattingEnabled = true;
            this.cbOdemeTipi.Items.AddRange(new object[] {
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
            this.cbOdemeTipi.Location = new System.Drawing.Point(182, 238);
            this.cbOdemeTipi.Name = "cbOdemeTipi";
            this.cbOdemeTipi.Size = new System.Drawing.Size(192, 26);
            this.cbOdemeTipi.TabIndex = 17;
            // 
            // cbParaBirimi
            // 
            this.cbParaBirimi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbParaBirimi.FormattingEnabled = true;
            this.cbParaBirimi.Items.AddRange(new object[] {
            "TL",
            "EURO",
            "USD"});
            this.cbParaBirimi.Location = new System.Drawing.Point(1251, 163);
            this.cbParaBirimi.Name = "cbParaBirimi";
            this.cbParaBirimi.Size = new System.Drawing.Size(192, 26);
            this.cbParaBirimi.TabIndex = 18;
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
            // cbTedarikci
            // 
            this.cbTedarikci.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tBLTEDARIKCIBindingSource, "ID", true));
            this.cbTedarikci.DataSource = this.tBLTEDARIKCIBindingSource;
            this.cbTedarikci.DisplayMember = "TedarikciAd";
            this.cbTedarikci.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTedarikci.FormattingEnabled = true;
            this.cbTedarikci.Location = new System.Drawing.Point(476, 16);
            this.cbTedarikci.Name = "cbTedarikci";
            this.cbTedarikci.Size = new System.Drawing.Size(192, 26);
            this.cbTedarikci.TabIndex = 22;
            this.cbTedarikci.ValueMember = "ID";
            // 
            // tBLTEDARIKCIBindingSource
            // 
            this.tBLTEDARIKCIBindingSource.DataMember = "TBLTEDARIKCI";
            this.tBLTEDARIKCIBindingSource.DataSource = this.dbTBLTEDARIKCIDataSet;
            // 
            // dbTBLTEDARIKCIDataSet
            // 
            this.dbTBLTEDARIKCIDataSet.DataSetName = "dbTBLTEDARIKCIDataSet";
            this.dbTBLTEDARIKCIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtAlisTarih
            // 
            this.dtAlisTarih.Location = new System.Drawing.Point(854, 20);
            this.dtAlisTarih.Name = "dtAlisTarih";
            this.dtAlisTarih.Size = new System.Drawing.Size(200, 22);
            this.dtAlisTarih.TabIndex = 23;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Location = new System.Drawing.Point(1251, 238);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(192, 26);
            this.txtID.TabIndex = 24;
            // 
            // txtToplam
            // 
            this.txtToplam.Enabled = false;
            this.txtToplam.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplam.Location = new System.Drawing.Point(930, 163);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Size = new System.Drawing.Size(192, 26);
            this.txtToplam.TabIndex = 25;
            // 
            // txtKDV
            // 
            this.txtKDV.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKDV.Location = new System.Drawing.Point(546, 163);
            this.txtKDV.Name = "txtKDV";
            this.txtKDV.Size = new System.Drawing.Size(192, 26);
            this.txtKDV.TabIndex = 26;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Location = new System.Drawing.Point(1251, 95);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(192, 26);
            this.txtMiktar.TabIndex = 27;
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBirimFiyat.Location = new System.Drawing.Point(930, 90);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(192, 26);
            this.txtBirimFiyat.TabIndex = 28;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(182, 299);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(1261, 89);
            this.txtAciklama.TabIndex = 29;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(572, 419);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(122, 42);
            this.btnEkle.TabIndex = 30;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(744, 419);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(122, 42);
            this.btnSil.TabIndex = 31;
            this.btnSil.Text = "İptal Et";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(927, 419);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(122, 42);
            this.btnGuncelle.TabIndex = 32;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tBLKATEGORILERTableAdapter
            // 
            this.tBLKATEGORILERTableAdapter.ClearBeforeFill = true;
            // 
            // tBLTEDARIKCITableAdapter
            // 
            this.tBLTEDARIKCITableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(919, 498);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(524, 265);
            this.dataGridView2.TabIndex = 34;
            this.dataGridView2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_CellMouseClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(29, 498);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(884, 265);
            this.dataGridView3.TabIndex = 35;
            this.dataGridView3.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView3_CellMouseClick);
            // 
            // txtUrunArama
            // 
            this.txtUrunArama.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunArama.Location = new System.Drawing.Point(1285, 461);
            this.txtUrunArama.Name = "txtUrunArama";
            this.txtUrunArama.Size = new System.Drawing.Size(158, 26);
            this.txtUrunArama.TabIndex = 36;
            this.txtUrunArama.TextChanged += new System.EventHandler(this.txtUrunArama_TextChanged);
            // 
            // txtAlisArama
            // 
            this.txtAlisArama.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlisArama.Location = new System.Drawing.Point(29, 461);
            this.txtAlisArama.Name = "txtAlisArama";
            this.txtAlisArama.Size = new System.Drawing.Size(156, 26);
            this.txtAlisArama.TabIndex = 37;
            this.txtAlisArama.TextChanged += new System.EventHandler(this.txtAlisArama_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(191, 470);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(143, 17);
            this.label16.TabIndex = 38;
            this.label16.Text = "*Ürün Kodu Giriniz";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(1063, 470);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(208, 17);
            this.label17.TabIndex = 39;
            this.label17.Text = "*Ürün Kodu veya Adı Giriniz";
            // 
            // txtUrunKodu
            // 
            this.txtUrunKodu.Enabled = false;
            this.txtUrunKodu.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrunKodu.Location = new System.Drawing.Point(546, 90);
            this.txtUrunKodu.Name = "txtUrunKodu";
            this.txtUrunKodu.Size = new System.Drawing.Size(192, 26);
            this.txtUrunKodu.TabIndex = 40;
            // 
            // txtUrunKategori
            // 
            this.txtUrunKategori.Enabled = false;
            this.txtUrunKategori.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrunKategori.Location = new System.Drawing.Point(182, 90);
            this.txtUrunKategori.Name = "txtUrunKategori";
            this.txtUrunKategori.Size = new System.Drawing.Size(192, 26);
            this.txtUrunKategori.TabIndex = 41;
            // 
            // txtBirim
            // 
            this.txtBirim.Enabled = false;
            this.txtBirim.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirim.Location = new System.Drawing.Point(182, 168);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(192, 26);
            this.txtBirim.TabIndex = 42;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(26, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(170, 17);
            this.label18.TabIndex = 43;
            this.label18.Text = "* Lütfen Bir Ürün Seçininz";
            // 
            // Alislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1457, 768);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtBirim);
            this.Controls.Add(this.txtUrunKategori);
            this.Controls.Add(this.txtUrunKodu);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtAlisArama);
            this.Controls.Add(this.txtUrunArama);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtBirimFiyat);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtKDV);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dtAlisTarih);
            this.Controls.Add(this.cbTedarikci);
            this.Controls.Add(this.cbParaBirimi);
            this.Controls.Add(this.cbOdemeTipi);
            this.Controls.Add(this.cbTahsilat);
            this.Controls.Add(this.cbTeslimat);
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
            this.Name = "Alislar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Alışları";
            this.Load += new System.EventHandler(this.Alislar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLKATEGORILERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLTEDARIKCIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbTBLTEDARIKCIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
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
        private System.Windows.Forms.ComboBox cbTeslimat;
        private System.Windows.Forms.ComboBox cbTahsilat;
        private System.Windows.Forms.ComboBox cbOdemeTipi;
        private System.Windows.Forms.ComboBox cbParaBirimi;
        private System.Windows.Forms.ComboBox cbTedarikci;
        private System.Windows.Forms.DateTimePicker dtAlisTarih;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.TextBox txtKDV;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private dbCRMDataSet13 dbCRMDataSet13;
        private System.Windows.Forms.BindingSource tBLKATEGORILERBindingSource;
        private dbCRMDataSet13TableAdapters.TBLKATEGORILERTableAdapter tBLKATEGORILERTableAdapter;
        private dbTBLTEDARIKCIDataSet dbTBLTEDARIKCIDataSet;
        private System.Windows.Forms.BindingSource tBLTEDARIKCIBindingSource;
        private dbTBLTEDARIKCIDataSetTableAdapters.TBLTEDARIKCITableAdapter tBLTEDARIKCITableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox txtUrunArama;
        private System.Windows.Forms.TextBox txtAlisArama;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUrunKodu;
        private System.Windows.Forms.TextBox txtUrunKategori;
        private System.Windows.Forms.TextBox txtBirim;
        private System.Windows.Forms.Label label18;
    }
}