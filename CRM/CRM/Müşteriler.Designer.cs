
namespace CRM
{
    partial class Müşteriler
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
            this.tBLMUSTERILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbCRMDataSet = new CRM.dbCRMDataSet();
            this.tBLMUSTERILERTableAdapter = new CRM.dbCRMDataSetTableAdapters.TBLMUSTERILERTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblYetkiliName = new System.Windows.Forms.Label();
            this.lblYetkiliEposta = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtYetkiliName = new System.Windows.Forms.TextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblAdres = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtVergiNo = new System.Windows.Forms.TextBox();
            this.txtVergiD = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.cbMusteriAsama = new System.Windows.Forms.ComboBox();
            this.lblid = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mUSTERIADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriYetkiliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yetkiliEpostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yetkiliTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yetkiliAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yetkiliPozisyonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vergiDairesiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vergiNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.müsteriAsamasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLMUSTERILERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbMUSTERILERDataSet = new CRM.dbMUSTERILERDataSet();
            this.tBLPERSONELDATASET = new CRM.TBLPERSONELDATASET();
            this.tBLPERSONELDATASETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLPERSONELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLPERSONELTableAdapter = new CRM.TBLPERSONELDATASETTableAdapters.TBLPERSONELTableAdapter();
            this.tBLMUSTERILERTableAdapter1 = new CRM.dbMUSTERILERDataSetTableAdapters.TBLMUSTERILERTableAdapter();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERILERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERILERBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMUSTERILERDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERSONELDATASET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERSONELDATASETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERSONELBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tBLMUSTERILERBindingSource
            // 
            this.tBLMUSTERILERBindingSource.DataMember = "TBLMUSTERILER";
            this.tBLMUSTERILERBindingSource.DataSource = this.dbCRMDataSet;
            // 
            // dbCRMDataSet
            // 
            this.dbCRMDataSet.DataSetName = "dbCRMDataSet";
            this.dbCRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLMUSTERILERTableAdapter
            // 
            this.tBLMUSTERILERTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(786, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAd
            // 
            this.lblAd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(705, 139);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(136, 30);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Müşteri Ad:";
            // 
            // lblYetkiliName
            // 
            this.lblYetkiliName.AutoSize = true;
            this.lblYetkiliName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetkiliName.Location = new System.Drawing.Point(655, 200);
            this.lblYetkiliName.Name = "lblYetkiliName";
            this.lblYetkiliName.Size = new System.Drawing.Size(186, 25);
            this.lblYetkiliName.TabIndex = 3;
            this.lblYetkiliName.Text = "Yetkili Ad-Soyad:";
            // 
            // lblYetkiliEposta
            // 
            this.lblYetkiliEposta.AutoSize = true;
            this.lblYetkiliEposta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetkiliEposta.Location = new System.Drawing.Point(1132, 144);
            this.lblYetkiliEposta.Name = "lblYetkiliEposta";
            this.lblYetkiliEposta.Size = new System.Drawing.Size(165, 25);
            this.lblYetkiliEposta.TabIndex = 4;
            this.lblYetkiliEposta.Text = "Yetkili E-posta:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTel.Location = new System.Drawing.Point(577, 269);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(264, 25);
            this.lblTel.TabIndex = 5;
            this.lblTel.Text = "Yetkili Telefon Numarası:";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(850, 141);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(232, 26);
            this.txtAd.TabIndex = 6;
            // 
            // txtYetkiliName
            // 
            this.txtYetkiliName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYetkiliName.Location = new System.Drawing.Point(850, 201);
            this.txtYetkiliName.Name = "txtYetkiliName";
            this.txtYetkiliName.Size = new System.Drawing.Size(232, 26);
            this.txtYetkiliName.TabIndex = 7;
            // 
            // txtEposta
            // 
            this.txtEposta.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEposta.Location = new System.Drawing.Point(1314, 141);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(220, 26);
            this.txtEposta.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1016, 534);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(1229, 534);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 38);
            this.button3.TabIndex = 11;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(1151, 200);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(146, 25);
            this.lblAdres.TabIndex = 12;
            this.lblAdres.Text = "Yetkili Adres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(513, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Yetkilinin Şirketteki Pozisyonu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1156, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Vergi Dairesi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(1137, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "VergiNo/TC No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(664, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Müşteri Aşaması:";
            // 
            // txtAdres
            // 
            this.txtAdres.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdres.Location = new System.Drawing.Point(1314, 197);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(220, 26);
            this.txtAdres.TabIndex = 17;
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVergiNo.Location = new System.Drawing.Point(1314, 331);
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Size = new System.Drawing.Size(220, 26);
            this.txtVergiNo.TabIndex = 18;
            // 
            // txtVergiD
            // 
            this.txtVergiD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtVergiD.Location = new System.Drawing.Point(1314, 263);
            this.txtVergiD.Name = "txtVergiD";
            this.txtVergiD.Size = new System.Drawing.Size(220, 26);
            this.txtVergiD.TabIndex = 19;
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPosition.Location = new System.Drawing.Point(850, 335);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(232, 26);
            this.txtPosition.TabIndex = 20;
            // 
            // cbMusteriAsama
            // 
            this.cbMusteriAsama.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMusteriAsama.FormattingEnabled = true;
            this.cbMusteriAsama.Items.AddRange(new object[] {
            "Potansiyel",
            "Kampanya",
            "Sıcak",
            "Takip",
            "Portföy",
            "Kaybedildi"});
            this.cbMusteriAsama.Location = new System.Drawing.Point(850, 423);
            this.cbMusteriAsama.Name = "cbMusteriAsama";
            this.cbMusteriAsama.Size = new System.Drawing.Size(232, 26);
            this.cbMusteriAsama.TabIndex = 21;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblid.Location = new System.Drawing.Point(1204, 424);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(111, 25);
            this.lblid.TabIndex = 22;
            this.lblid.Text = "MuseriID:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Location = new System.Drawing.Point(1314, 421);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(220, 26);
            this.txtID.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.mUSTERIADDataGridViewTextBoxColumn,
            this.musteriYetkiliDataGridViewTextBoxColumn,
            this.yetkiliEpostaDataGridViewTextBoxColumn,
            this.yetkiliTelDataGridViewTextBoxColumn,
            this.yetkiliAdresDataGridViewTextBoxColumn,
            this.yetkiliPozisyonDataGridViewTextBoxColumn,
            this.vergiDairesiDataGridViewTextBoxColumn,
            this.vergiNoDataGridViewTextBoxColumn,
            this.müsteriAsamasiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLMUSTERILERBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(495, 656);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // mUSTERIADDataGridViewTextBoxColumn
            // 
            this.mUSTERIADDataGridViewTextBoxColumn.DataPropertyName = "MUSTERIAD";
            this.mUSTERIADDataGridViewTextBoxColumn.HeaderText = "MUSTERIAD";
            this.mUSTERIADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mUSTERIADDataGridViewTextBoxColumn.Name = "mUSTERIADDataGridViewTextBoxColumn";
            this.mUSTERIADDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriYetkiliDataGridViewTextBoxColumn
            // 
            this.musteriYetkiliDataGridViewTextBoxColumn.DataPropertyName = "MusteriYetkili";
            this.musteriYetkiliDataGridViewTextBoxColumn.HeaderText = "MusteriYetkili";
            this.musteriYetkiliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriYetkiliDataGridViewTextBoxColumn.Name = "musteriYetkiliDataGridViewTextBoxColumn";
            this.musteriYetkiliDataGridViewTextBoxColumn.Width = 125;
            // 
            // yetkiliEpostaDataGridViewTextBoxColumn
            // 
            this.yetkiliEpostaDataGridViewTextBoxColumn.DataPropertyName = "YetkiliEposta";
            this.yetkiliEpostaDataGridViewTextBoxColumn.HeaderText = "YetkiliEposta";
            this.yetkiliEpostaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yetkiliEpostaDataGridViewTextBoxColumn.Name = "yetkiliEpostaDataGridViewTextBoxColumn";
            this.yetkiliEpostaDataGridViewTextBoxColumn.Width = 125;
            // 
            // yetkiliTelDataGridViewTextBoxColumn
            // 
            this.yetkiliTelDataGridViewTextBoxColumn.DataPropertyName = "YetkiliTel";
            this.yetkiliTelDataGridViewTextBoxColumn.HeaderText = "YetkiliTel";
            this.yetkiliTelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yetkiliTelDataGridViewTextBoxColumn.Name = "yetkiliTelDataGridViewTextBoxColumn";
            this.yetkiliTelDataGridViewTextBoxColumn.Width = 125;
            // 
            // yetkiliAdresDataGridViewTextBoxColumn
            // 
            this.yetkiliAdresDataGridViewTextBoxColumn.DataPropertyName = "YetkiliAdres";
            this.yetkiliAdresDataGridViewTextBoxColumn.HeaderText = "YetkiliAdres";
            this.yetkiliAdresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yetkiliAdresDataGridViewTextBoxColumn.Name = "yetkiliAdresDataGridViewTextBoxColumn";
            this.yetkiliAdresDataGridViewTextBoxColumn.Width = 125;
            // 
            // yetkiliPozisyonDataGridViewTextBoxColumn
            // 
            this.yetkiliPozisyonDataGridViewTextBoxColumn.DataPropertyName = "YetkiliPozisyon";
            this.yetkiliPozisyonDataGridViewTextBoxColumn.HeaderText = "YetkiliPozisyon";
            this.yetkiliPozisyonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yetkiliPozisyonDataGridViewTextBoxColumn.Name = "yetkiliPozisyonDataGridViewTextBoxColumn";
            this.yetkiliPozisyonDataGridViewTextBoxColumn.Width = 125;
            // 
            // vergiDairesiDataGridViewTextBoxColumn
            // 
            this.vergiDairesiDataGridViewTextBoxColumn.DataPropertyName = "VergiDairesi";
            this.vergiDairesiDataGridViewTextBoxColumn.HeaderText = "VergiDairesi";
            this.vergiDairesiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vergiDairesiDataGridViewTextBoxColumn.Name = "vergiDairesiDataGridViewTextBoxColumn";
            this.vergiDairesiDataGridViewTextBoxColumn.Width = 125;
            // 
            // vergiNoDataGridViewTextBoxColumn
            // 
            this.vergiNoDataGridViewTextBoxColumn.DataPropertyName = "VergiNo";
            this.vergiNoDataGridViewTextBoxColumn.HeaderText = "VergiNo";
            this.vergiNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vergiNoDataGridViewTextBoxColumn.Name = "vergiNoDataGridViewTextBoxColumn";
            this.vergiNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // müsteriAsamasiDataGridViewTextBoxColumn
            // 
            this.müsteriAsamasiDataGridViewTextBoxColumn.DataPropertyName = "MüsteriAsamasi";
            this.müsteriAsamasiDataGridViewTextBoxColumn.HeaderText = "MüsteriAsamasi";
            this.müsteriAsamasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.müsteriAsamasiDataGridViewTextBoxColumn.Name = "müsteriAsamasiDataGridViewTextBoxColumn";
            this.müsteriAsamasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tBLMUSTERILERBindingSource1
            // 
            this.tBLMUSTERILERBindingSource1.DataMember = "TBLMUSTERILER";
            this.tBLMUSTERILERBindingSource1.DataSource = this.dbMUSTERILERDataSet;
            // 
            // dbMUSTERILERDataSet
            // 
            this.dbMUSTERILERDataSet.DataSetName = "dbMUSTERILERDataSet";
            this.dbMUSTERILERDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLPERSONELDATASET
            // 
            this.tBLPERSONELDATASET.DataSetName = "TBLPERSONELDATASET";
            this.tBLPERSONELDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLPERSONELDATASETBindingSource
            // 
            this.tBLPERSONELDATASETBindingSource.DataSource = this.tBLPERSONELDATASET;
            this.tBLPERSONELDATASETBindingSource.Position = 0;
            // 
            // tBLPERSONELBindingSource
            // 
            this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
            this.tBLPERSONELBindingSource.DataSource = this.tBLPERSONELDATASETBindingSource;
            // 
            // tBLPERSONELTableAdapter
            // 
            this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
            // 
            // tBLMUSTERILERTableAdapter1
            // 
            this.tBLMUSTERILERTableAdapter1.ClearBeforeFill = true;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTel.Location = new System.Drawing.Point(850, 272);
            this.txtTel.Mask = "(999) 000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(232, 26);
            this.txtTel.TabIndex = 25;
            // 
            // Müşteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1572, 680);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.cbMusteriAsama);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtVergiD);
            this.Controls.Add(this.txtVergiNo);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.txtYetkiliName);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblYetkiliEposta);
            this.Controls.Add(this.lblYetkiliName);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Müşteriler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.Müşteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERILERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERILERBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMUSTERILERDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERSONELDATASET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERSONELDATASETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERSONELBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private dbCRMDataSet dbCRMDataSet;
        private System.Windows.Forms.BindingSource tBLMUSTERILERBindingSource;
        private dbCRMDataSetTableAdapters.TBLMUSTERILERTableAdapter tBLMUSTERILERTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblYetkiliName;
        private System.Windows.Forms.Label lblYetkiliEposta;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtYetkiliName;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtVergiNo;
        private System.Windows.Forms.TextBox txtVergiD;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.ComboBox cbMusteriAsama;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tBLPERSONELDATASETBindingSource;
        private TBLPERSONELDATASET tBLPERSONELDATASET;
        private System.Windows.Forms.BindingSource tBLPERSONELBindingSource;
        private TBLPERSONELDATASETTableAdapters.TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
        private dbMUSTERILERDataSet dbMUSTERILERDataSet;
        private System.Windows.Forms.BindingSource tBLMUSTERILERBindingSource1;
        private dbMUSTERILERDataSetTableAdapters.TBLMUSTERILERTableAdapter tBLMUSTERILERTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mUSTERIADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriYetkiliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yetkiliEpostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yetkiliTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yetkiliAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yetkiliPozisyonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vergiDairesiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vergiNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn müsteriAsamasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox txtTel;
    }
}