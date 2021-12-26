
namespace CRM
{
    partial class AlışveSatışlar
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSatis = new System.Windows.Forms.Button();
            this.dbCRMDataSet1 = new CRM.dbCRMDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbCRMDataSet11 = new CRM.dbCRMDataSet11();
            this.tBLISLEMLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLISLEMLERTableAdapter = new CRM.dbCRMDataSet11TableAdapters.TBLISLEMLERTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRUNIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mIKTARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLISFIYATIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sATISFIYATIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıSLEMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.cbUrunAd = new System.Windows.Forms.ComboBox();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblAlisFiyati = new System.Windows.Forms.Label();
            this.lblSatisFiyati = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.dbCRMDataSet12 = new CRM.dbCRMDataSet12();
            this.tBLURUNLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLURUNLERTableAdapter = new CRM.dbCRMDataSet12TableAdapters.TBLURUNLERTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uRUNIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mIKTARDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLISFIYATIDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sATISFIYATIDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıSLEMDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblUrunAd2 = new System.Windows.Forms.Label();
            this.lblMiktar2 = new System.Windows.Forms.Label();
            this.lblAlisFiyati2 = new System.Windows.Forms.Label();
            this.lblSatisFiyat2 = new System.Windows.Forms.Label();
            this.btnAlis = new System.Windows.Forms.Button();
            this.cbÜrünAd2 = new System.Windows.Forms.ComboBox();
            this.txtMiktar2 = new System.Windows.Forms.TextBox();
            this.txtAlisFiyat2 = new System.Windows.Forms.TextBox();
            this.txtSatisFiyati2 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLISLEMLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1280, 642);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSatisFiyati);
            this.tabPage1.Controls.Add(this.txtAlisFiyati);
            this.tabPage1.Controls.Add(this.txtMiktar);
            this.tabPage1.Controls.Add(this.lblSatisFiyati);
            this.tabPage1.Controls.Add(this.lblAlisFiyati);
            this.tabPage1.Controls.Add(this.lblMiktar);
            this.tabPage1.Controls.Add(this.cbUrunAd);
            this.tabPage1.Controls.Add(this.lblUrunAd);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnSatis);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1272, 613);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Satış İşlemi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtSatisFiyati2);
            this.tabPage2.Controls.Add(this.txtAlisFiyat2);
            this.tabPage2.Controls.Add(this.txtMiktar2);
            this.tabPage2.Controls.Add(this.cbÜrünAd2);
            this.tabPage2.Controls.Add(this.btnAlis);
            this.tabPage2.Controls.Add(this.lblSatisFiyat2);
            this.tabPage2.Controls.Add(this.lblAlisFiyati2);
            this.tabPage2.Controls.Add(this.lblMiktar2);
            this.tabPage2.Controls.Add(this.lblUrunAd2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1272, 613);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alış İşlemi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSatis
            // 
            this.btnSatis.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatis.Location = new System.Drawing.Point(187, 468);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(117, 42);
            this.btnSatis.TabIndex = 1;
            this.btnSatis.Text = "Satış Yap";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // dbCRMDataSet1
            // 
            this.dbCRMDataSet1.DataSetName = "dbCRMDataSet";
            this.dbCRMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.uRUNIDDataGridViewTextBoxColumn,
            this.mIKTARDataGridViewTextBoxColumn,
            this.aLISFIYATIDataGridViewTextBoxColumn,
            this.sATISFIYATIDataGridViewTextBoxColumn,
            this.ıSLEMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLISLEMLERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(556, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(691, 390);
            this.dataGridView1.TabIndex = 2;
            // 
            // dbCRMDataSet11
            // 
            this.dbCRMDataSet11.DataSetName = "dbCRMDataSet11";
            this.dbCRMDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLISLEMLERBindingSource
            // 
            this.tBLISLEMLERBindingSource.DataMember = "TBLISLEMLER";
            this.tBLISLEMLERBindingSource.DataSource = this.dbCRMDataSet11;
            // 
            // tBLISLEMLERTableAdapter
            // 
            this.tBLISLEMLERTableAdapter.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 125;
            // 
            // uRUNIDDataGridViewTextBoxColumn
            // 
            this.uRUNIDDataGridViewTextBoxColumn.DataPropertyName = "URUNID";
            this.uRUNIDDataGridViewTextBoxColumn.HeaderText = "URUNID";
            this.uRUNIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.uRUNIDDataGridViewTextBoxColumn.Name = "uRUNIDDataGridViewTextBoxColumn";
            this.uRUNIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // mIKTARDataGridViewTextBoxColumn
            // 
            this.mIKTARDataGridViewTextBoxColumn.DataPropertyName = "MIKTAR";
            this.mIKTARDataGridViewTextBoxColumn.HeaderText = "MIKTAR";
            this.mIKTARDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mIKTARDataGridViewTextBoxColumn.Name = "mIKTARDataGridViewTextBoxColumn";
            this.mIKTARDataGridViewTextBoxColumn.Width = 125;
            // 
            // aLISFIYATIDataGridViewTextBoxColumn
            // 
            this.aLISFIYATIDataGridViewTextBoxColumn.DataPropertyName = "ALISFIYATI";
            this.aLISFIYATIDataGridViewTextBoxColumn.HeaderText = "ALISFIYATI";
            this.aLISFIYATIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aLISFIYATIDataGridViewTextBoxColumn.Name = "aLISFIYATIDataGridViewTextBoxColumn";
            this.aLISFIYATIDataGridViewTextBoxColumn.Width = 125;
            // 
            // sATISFIYATIDataGridViewTextBoxColumn
            // 
            this.sATISFIYATIDataGridViewTextBoxColumn.DataPropertyName = "SATISFIYATI";
            this.sATISFIYATIDataGridViewTextBoxColumn.HeaderText = "SATISFIYATI";
            this.sATISFIYATIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sATISFIYATIDataGridViewTextBoxColumn.Name = "sATISFIYATIDataGridViewTextBoxColumn";
            this.sATISFIYATIDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıSLEMDataGridViewTextBoxColumn
            // 
            this.ıSLEMDataGridViewTextBoxColumn.DataPropertyName = "ISLEM";
            this.ıSLEMDataGridViewTextBoxColumn.HeaderText = "ISLEM";
            this.ıSLEMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıSLEMDataGridViewTextBoxColumn.Name = "ıSLEMDataGridViewTextBoxColumn";
            this.ıSLEMDataGridViewTextBoxColumn.Width = 125;
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAd.Location = new System.Drawing.Point(42, 120);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(94, 25);
            this.lblUrunAd.TabIndex = 3;
            this.lblUrunAd.Text = "Ürün Adı:";
            // 
            // cbUrunAd
            // 
            this.cbUrunAd.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tBLURUNLERBindingSource, "id", true));
            this.cbUrunAd.DataSource = this.tBLURUNLERBindingSource;
            this.cbUrunAd.DisplayMember = "UrunAd";
            this.cbUrunAd.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbUrunAd.FormattingEnabled = true;
            this.cbUrunAd.Location = new System.Drawing.Point(212, 120);
            this.cbUrunAd.Name = "cbUrunAd";
            this.cbUrunAd.Size = new System.Drawing.Size(220, 28);
            this.cbUrunAd.TabIndex = 4;
            this.cbUrunAd.ValueMember = "id";
            this.cbUrunAd.SelectedIndexChanged += new System.EventHandler(this.cbUrunAd_SelectedIndexChanged);
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.Location = new System.Drawing.Point(42, 190);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(85, 25);
            this.lblMiktar.TabIndex = 5;
            this.lblMiktar.Text = "Miktar:";
            // 
            // lblAlisFiyati
            // 
            this.lblAlisFiyati.AutoSize = true;
            this.lblAlisFiyati.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlisFiyati.Location = new System.Drawing.Point(42, 268);
            this.lblAlisFiyati.Name = "lblAlisFiyati";
            this.lblAlisFiyati.Size = new System.Drawing.Size(120, 25);
            this.lblAlisFiyati.TabIndex = 6;
            this.lblAlisFiyati.Text = "Alış Fiyatı:";
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.AutoSize = true;
            this.lblSatisFiyati.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisFiyati.Location = new System.Drawing.Point(42, 353);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(134, 25);
            this.lblSatisFiyati.TabIndex = 7;
            this.lblSatisFiyati.Text = "Satış Fiyatı:";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar.Location = new System.Drawing.Point(212, 187);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(220, 28);
            this.txtMiktar.TabIndex = 8;
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlisFiyati.Location = new System.Drawing.Point(212, 265);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(220, 28);
            this.txtAlisFiyati.TabIndex = 9;
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisFiyati.Location = new System.Drawing.Point(212, 350);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(220, 28);
            this.txtSatisFiyati.TabIndex = 10;
            this.txtSatisFiyati.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dbCRMDataSet12
            // 
            this.dbCRMDataSet12.DataSetName = "dbCRMDataSet12";
            this.dbCRMDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLURUNLERBindingSource
            // 
            this.tBLURUNLERBindingSource.DataMember = "TBLURUNLER";
            this.tBLURUNLERBindingSource.DataSource = this.dbCRMDataSet12;
            // 
            // tBLURUNLERTableAdapter
            // 
            this.tBLURUNLERTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn1,
            this.uRUNIDDataGridViewTextBoxColumn1,
            this.mIKTARDataGridViewTextBoxColumn1,
            this.aLISFIYATIDataGridViewTextBoxColumn1,
            this.sATISFIYATIDataGridViewTextBoxColumn1,
            this.ıSLEMDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.tBLISLEMLERBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(559, 116);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(691, 390);
            this.dataGridView2.TabIndex = 0;
            // 
            // ıDDataGridViewTextBoxColumn1
            // 
            this.ıDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ıDDataGridViewTextBoxColumn1.Name = "ıDDataGridViewTextBoxColumn1";
            this.ıDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // uRUNIDDataGridViewTextBoxColumn1
            // 
            this.uRUNIDDataGridViewTextBoxColumn1.DataPropertyName = "URUNID";
            this.uRUNIDDataGridViewTextBoxColumn1.HeaderText = "URUNID";
            this.uRUNIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.uRUNIDDataGridViewTextBoxColumn1.Name = "uRUNIDDataGridViewTextBoxColumn1";
            this.uRUNIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // mIKTARDataGridViewTextBoxColumn1
            // 
            this.mIKTARDataGridViewTextBoxColumn1.DataPropertyName = "MIKTAR";
            this.mIKTARDataGridViewTextBoxColumn1.HeaderText = "MIKTAR";
            this.mIKTARDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.mIKTARDataGridViewTextBoxColumn1.Name = "mIKTARDataGridViewTextBoxColumn1";
            this.mIKTARDataGridViewTextBoxColumn1.Width = 125;
            // 
            // aLISFIYATIDataGridViewTextBoxColumn1
            // 
            this.aLISFIYATIDataGridViewTextBoxColumn1.DataPropertyName = "ALISFIYATI";
            this.aLISFIYATIDataGridViewTextBoxColumn1.HeaderText = "ALISFIYATI";
            this.aLISFIYATIDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.aLISFIYATIDataGridViewTextBoxColumn1.Name = "aLISFIYATIDataGridViewTextBoxColumn1";
            this.aLISFIYATIDataGridViewTextBoxColumn1.Width = 125;
            // 
            // sATISFIYATIDataGridViewTextBoxColumn1
            // 
            this.sATISFIYATIDataGridViewTextBoxColumn1.DataPropertyName = "SATISFIYATI";
            this.sATISFIYATIDataGridViewTextBoxColumn1.HeaderText = "SATISFIYATI";
            this.sATISFIYATIDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.sATISFIYATIDataGridViewTextBoxColumn1.Name = "sATISFIYATIDataGridViewTextBoxColumn1";
            this.sATISFIYATIDataGridViewTextBoxColumn1.Width = 125;
            // 
            // ıSLEMDataGridViewTextBoxColumn1
            // 
            this.ıSLEMDataGridViewTextBoxColumn1.DataPropertyName = "ISLEM";
            this.ıSLEMDataGridViewTextBoxColumn1.HeaderText = "ISLEM";
            this.ıSLEMDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ıSLEMDataGridViewTextBoxColumn1.Name = "ıSLEMDataGridViewTextBoxColumn1";
            this.ıSLEMDataGridViewTextBoxColumn1.Width = 125;
            // 
            // lblUrunAd2
            // 
            this.lblUrunAd2.AutoSize = true;
            this.lblUrunAd2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAd2.Location = new System.Drawing.Point(46, 115);
            this.lblUrunAd2.Name = "lblUrunAd2";
            this.lblUrunAd2.Size = new System.Drawing.Size(110, 25);
            this.lblUrunAd2.TabIndex = 1;
            this.lblUrunAd2.Text = "Ürün Adı:";
            this.lblUrunAd2.Click += new System.EventHandler(this.lblUrunAd2_Click);
            // 
            // lblMiktar2
            // 
            this.lblMiktar2.AutoSize = true;
            this.lblMiktar2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar2.Location = new System.Drawing.Point(46, 202);
            this.lblMiktar2.Name = "lblMiktar2";
            this.lblMiktar2.Size = new System.Drawing.Size(85, 25);
            this.lblMiktar2.TabIndex = 2;
            this.lblMiktar2.Text = "Miktar:";
            // 
            // lblAlisFiyati2
            // 
            this.lblAlisFiyati2.AutoSize = true;
            this.lblAlisFiyati2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlisFiyati2.Location = new System.Drawing.Point(46, 274);
            this.lblAlisFiyati2.Name = "lblAlisFiyati2";
            this.lblAlisFiyati2.Size = new System.Drawing.Size(111, 25);
            this.lblAlisFiyati2.TabIndex = 3;
            this.lblAlisFiyati2.Text = "Alış Fiyatı";
            // 
            // lblSatisFiyat2
            // 
            this.lblSatisFiyat2.AutoSize = true;
            this.lblSatisFiyat2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisFiyat2.Location = new System.Drawing.Point(46, 348);
            this.lblSatisFiyat2.Name = "lblSatisFiyat2";
            this.lblSatisFiyat2.Size = new System.Drawing.Size(134, 25);
            this.lblSatisFiyat2.TabIndex = 4;
            this.lblSatisFiyat2.Text = "Satış Fiyatı:";
            // 
            // btnAlis
            // 
            this.btnAlis.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlis.Location = new System.Drawing.Point(178, 464);
            this.btnAlis.Name = "btnAlis";
            this.btnAlis.Size = new System.Drawing.Size(117, 42);
            this.btnAlis.TabIndex = 5;
            this.btnAlis.Text = "Alış Yap";
            this.btnAlis.UseVisualStyleBackColor = true;
            this.btnAlis.Click += new System.EventHandler(this.btnAlis_Click);
            // 
            // cbÜrünAd2
            // 
            this.cbÜrünAd2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tBLURUNLERBindingSource, "id", true));
            this.cbÜrünAd2.DataSource = this.tBLURUNLERBindingSource;
            this.cbÜrünAd2.DisplayMember = "UrunAd";
            this.cbÜrünAd2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbÜrünAd2.FormattingEnabled = true;
            this.cbÜrünAd2.Location = new System.Drawing.Point(222, 116);
            this.cbÜrünAd2.Name = "cbÜrünAd2";
            this.cbÜrünAd2.Size = new System.Drawing.Size(210, 28);
            this.cbÜrünAd2.TabIndex = 6;
            this.cbÜrünAd2.ValueMember = "id";
            this.cbÜrünAd2.SelectedIndexChanged += new System.EventHandler(this.cbÜrünAd2_SelectedIndexChanged);
            // 
            // txtMiktar2
            // 
            this.txtMiktar2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMiktar2.Location = new System.Drawing.Point(222, 199);
            this.txtMiktar2.Name = "txtMiktar2";
            this.txtMiktar2.Size = new System.Drawing.Size(210, 28);
            this.txtMiktar2.TabIndex = 7;
            // 
            // txtAlisFiyat2
            // 
            this.txtAlisFiyat2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlisFiyat2.Location = new System.Drawing.Point(222, 275);
            this.txtAlisFiyat2.Name = "txtAlisFiyat2";
            this.txtAlisFiyat2.Size = new System.Drawing.Size(210, 28);
            this.txtAlisFiyat2.TabIndex = 8;
            // 
            // txtSatisFiyati2
            // 
            this.txtSatisFiyati2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisFiyati2.Location = new System.Drawing.Point(222, 345);
            this.txtSatisFiyati2.Name = "txtSatisFiyati2";
            this.txtSatisFiyati2.Size = new System.Drawing.Size(210, 28);
            this.txtSatisFiyati2.TabIndex = 9;
            // 
            // AlışveSatışlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 642);
            this.Controls.Add(this.tabControl1);
            this.Name = "AlışveSatışlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlışveSatışlar";
            this.Load += new System.EventHandler(this.AlışveSatışlar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLISLEMLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLURUNLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSatis;
        private dbCRMDataSet dbCRMDataSet1;
        private dbCRMDataSet11 dbCRMDataSet11;
        private System.Windows.Forms.BindingSource tBLISLEMLERBindingSource;
        private dbCRMDataSet11TableAdapters.TBLISLEMLERTableAdapter tBLISLEMLERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uRUNIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIKTARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLISFIYATIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sATISFIYATIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıSLEMDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label lblSatisFiyati;
        private System.Windows.Forms.Label lblAlisFiyati;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.ComboBox cbUrunAd;
        private System.Windows.Forms.Label lblUrunAd;
        private dbCRMDataSet12 dbCRMDataSet12;
        private System.Windows.Forms.BindingSource tBLURUNLERBindingSource;
        private dbCRMDataSet12TableAdapters.TBLURUNLERTableAdapter tBLURUNLERTableAdapter;
        private System.Windows.Forms.Label lblUrunAd2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uRUNIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mIKTARDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLISFIYATIDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sATISFIYATIDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıSLEMDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnAlis;
        private System.Windows.Forms.Label lblSatisFiyat2;
        private System.Windows.Forms.Label lblAlisFiyati2;
        private System.Windows.Forms.TextBox txtSatisFiyati2;
        private System.Windows.Forms.TextBox txtAlisFiyat2;
        private System.Windows.Forms.TextBox txtMiktar2;
        private System.Windows.Forms.ComboBox cbÜrünAd2;
        private System.Windows.Forms.Label lblMiktar2;
    }
}