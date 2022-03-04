
namespace CRM
{
    partial class Aktiviteler
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
            this.lblAktiviteID = new System.Windows.Forms.Label();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.lblAktiviteTipi = new System.Windows.Forms.Label();
            this.lblAktiviteAd = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblLokasyon = new System.Windows.Forms.Label();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.lblBitis = new System.Windows.Forms.Label();
            this.lblOncelik = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtAktiviteAd = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.cbMusteri = new System.Windows.Forms.ComboBox();
            this.tBLMUSTERILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbCRMDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbCRMDataSet = new CRM.dbCRMDataSet();
            this.cbAktiviteTipi = new System.Windows.Forms.ComboBox();
            this.cbLokasyon = new System.Windows.Forms.ComboBox();
            this.dtBaslangicTarih = new System.Windows.Forms.DateTimePicker();
            this.dtBitisTarih = new System.Windows.Forms.DateTimePicker();
            this.cbOncelik = new System.Windows.Forms.ComboBox();
            this.dtBaslangicSaat = new System.Windows.Forms.DateTimePicker();
            this.dtBitisSaat = new System.Windows.Forms.DateTimePicker();
            this.btnAktiviteEkle = new System.Windows.Forms.Button();
            this.btnAktiviteGuncelle = new System.Windows.Forms.Button();
            this.btnAktiviteSil = new System.Windows.Forms.Button();
            this.dbCRMDataSet7 = new CRM.dbCRMDataSet7();
            this.dbCRMDataSet7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLMARKALARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLMARKALARTableAdapter = new CRM.dbCRMDataSet7TableAdapters.TBLMARKALARTableAdapter();
            this.tBLMUSTERILERTableAdapter = new CRM.dbCRMDataSetTableAdapters.TBLMUSTERILERTableAdapter();
            this.lblSorumlu = new System.Windows.Forms.Label();
            this.cbSorumlu = new System.Windows.Forms.ComboBox();
            this.tBLPERSONELDATASET = new CRM.TBLPERSONELDATASET();
            this.tBLPERSONELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLPERSONELTableAdapter = new CRM.TBLPERSONELDATASETTableAdapters.TBLPERSONELTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERILERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMARKALARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERSONELDATASET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERSONELBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAktiviteID
            // 
            this.lblAktiviteID.AutoSize = true;
            this.lblAktiviteID.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAktiviteID.Location = new System.Drawing.Point(596, 20);
            this.lblAktiviteID.Name = "lblAktiviteID";
            this.lblAktiviteID.Size = new System.Drawing.Size(129, 25);
            this.lblAktiviteID.TabIndex = 0;
            this.lblAktiviteID.Text = "Aktivite ID:";
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteri.Location = new System.Drawing.Point(1009, 24);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(123, 25);
            this.lblMusteri.TabIndex = 1;
            this.lblMusteri.Text = "Müşteriler:";
            // 
            // lblAktiviteTipi
            // 
            this.lblAktiviteTipi.AutoSize = true;
            this.lblAktiviteTipi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAktiviteTipi.Location = new System.Drawing.Point(583, 98);
            this.lblAktiviteTipi.Name = "lblAktiviteTipi";
            this.lblAktiviteTipi.Size = new System.Drawing.Size(142, 25);
            this.lblAktiviteTipi.TabIndex = 2;
            this.lblAktiviteTipi.Text = "Aktivite Tipi:";
            // 
            // lblAktiviteAd
            // 
            this.lblAktiviteAd.AutoSize = true;
            this.lblAktiviteAd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAktiviteAd.Location = new System.Drawing.Point(983, 98);
            this.lblAktiviteAd.Name = "lblAktiviteAd";
            this.lblAktiviteAd.Size = new System.Drawing.Size(149, 25);
            this.lblAktiviteAd.TabIndex = 3;
            this.lblAktiviteAd.Text = "Aktivite İsmi:";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.Location = new System.Drawing.Point(613, 173);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(112, 25);
            this.lblAciklama.TabIndex = 4;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // lblLokasyon
            // 
            this.lblLokasyon.AutoSize = true;
            this.lblLokasyon.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLokasyon.Location = new System.Drawing.Point(610, 361);
            this.lblLokasyon.Name = "lblLokasyon";
            this.lblLokasyon.Size = new System.Drawing.Size(115, 25);
            this.lblLokasyon.TabIndex = 5;
            this.lblLokasyon.Text = "Lokasyon:";
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslangic.Location = new System.Drawing.Point(546, 439);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(179, 25);
            this.lblBaslangic.TabIndex = 6;
            this.lblBaslangic.Text = "Başlangıç Tarihi:";
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitis.Location = new System.Drawing.Point(597, 509);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(128, 25);
            this.lblBitis.TabIndex = 7;
            this.lblBitis.Text = "Bitiş Tarihi:";
            // 
            // lblOncelik
            // 
            this.lblOncelik.AutoSize = true;
            this.lblOncelik.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOncelik.Location = new System.Drawing.Point(629, 576);
            this.lblOncelik.Name = "lblOncelik";
            this.lblOncelik.Size = new System.Drawing.Size(96, 25);
            this.lblOncelik.TabIndex = 8;
            this.lblOncelik.Text = "Öncelik:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Location = new System.Drawing.Point(748, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(202, 28);
            this.txtID.TabIndex = 9;
            // 
            // txtAktiviteAd
            // 
            this.txtAktiviteAd.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAktiviteAd.Location = new System.Drawing.Point(1151, 95);
            this.txtAktiviteAd.Name = "txtAktiviteAd";
            this.txtAktiviteAd.Size = new System.Drawing.Size(221, 28);
            this.txtAktiviteAd.TabIndex = 12;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(748, 174);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(619, 154);
            this.txtAciklama.TabIndex = 13;
            // 
            // cbMusteri
            // 
            this.cbMusteri.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tBLMUSTERILERBindingSource, "id", true));
            this.cbMusteri.DataSource = this.tBLMUSTERILERBindingSource;
            this.cbMusteri.DisplayMember = "MUSTERIAD";
            this.cbMusteri.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMusteri.FormattingEnabled = true;
            this.cbMusteri.Location = new System.Drawing.Point(1151, 21);
            this.cbMusteri.Name = "cbMusteri";
            this.cbMusteri.Size = new System.Drawing.Size(221, 28);
            this.cbMusteri.TabIndex = 18;
            this.cbMusteri.ValueMember = "id";
            // 
            // tBLMUSTERILERBindingSource
            // 
            this.tBLMUSTERILERBindingSource.DataMember = "TBLMUSTERILER";
            this.tBLMUSTERILERBindingSource.DataSource = this.dbCRMDataSetBindingSource;
            // 
            // dbCRMDataSetBindingSource
            // 
            this.dbCRMDataSetBindingSource.DataSource = this.dbCRMDataSet;
            this.dbCRMDataSetBindingSource.Position = 0;
            // 
            // dbCRMDataSet
            // 
            this.dbCRMDataSet.DataSetName = "dbCRMDataSet";
            this.dbCRMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbAktiviteTipi
            // 
            this.cbAktiviteTipi.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbAktiviteTipi.FormattingEnabled = true;
            this.cbAktiviteTipi.Items.AddRange(new object[] {
            "Toplantı",
            "E-posta",
            "Ziyaret",
            "Yemek",
            "Telefon",
            "Diğer"});
            this.cbAktiviteTipi.Location = new System.Drawing.Point(748, 99);
            this.cbAktiviteTipi.Name = "cbAktiviteTipi";
            this.cbAktiviteTipi.Size = new System.Drawing.Size(202, 28);
            this.cbAktiviteTipi.TabIndex = 19;
            // 
            // cbLokasyon
            // 
            this.cbLokasyon.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbLokasyon.FormattingEnabled = true;
            this.cbLokasyon.Items.AddRange(new object[] {
            "Seçiniz...",
            "Genel Merkez"});
            this.cbLokasyon.Location = new System.Drawing.Point(748, 362);
            this.cbLokasyon.Name = "cbLokasyon";
            this.cbLokasyon.Size = new System.Drawing.Size(294, 28);
            this.cbLokasyon.TabIndex = 20;
            // 
            // dtBaslangicTarih
            // 
            this.dtBaslangicTarih.CustomFormat = "";
            this.dtBaslangicTarih.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangicTarih.Location = new System.Drawing.Point(748, 439);
            this.dtBaslangicTarih.Name = "dtBaslangicTarih";
            this.dtBaslangicTarih.Size = new System.Drawing.Size(294, 28);
            this.dtBaslangicTarih.TabIndex = 21;
            // 
            // dtBitisTarih
            // 
            this.dtBitisTarih.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitisTarih.Location = new System.Drawing.Point(748, 506);
            this.dtBitisTarih.Name = "dtBitisTarih";
            this.dtBitisTarih.Size = new System.Drawing.Size(294, 28);
            this.dtBitisTarih.TabIndex = 22;
            // 
            // cbOncelik
            // 
            this.cbOncelik.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOncelik.FormattingEnabled = true;
            this.cbOncelik.Items.AddRange(new object[] {
            "Düşük",
            "Orta",
            "Yüksek"});
            this.cbOncelik.Location = new System.Drawing.Point(748, 573);
            this.cbOncelik.Name = "cbOncelik";
            this.cbOncelik.Size = new System.Drawing.Size(294, 28);
            this.cbOncelik.TabIndex = 23;
            // 
            // dtBaslangicSaat
            // 
            this.dtBaslangicSaat.CustomFormat = "";
            this.dtBaslangicSaat.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslangicSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtBaslangicSaat.Location = new System.Drawing.Point(1081, 436);
            this.dtBaslangicSaat.Name = "dtBaslangicSaat";
            this.dtBaslangicSaat.ShowUpDown = true;
            this.dtBaslangicSaat.Size = new System.Drawing.Size(200, 28);
            this.dtBaslangicSaat.TabIndex = 24;
            // 
            // dtBitisSaat
            // 
            this.dtBitisSaat.CustomFormat = "";
            this.dtBitisSaat.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitisSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtBitisSaat.Location = new System.Drawing.Point(1081, 506);
            this.dtBitisSaat.Name = "dtBitisSaat";
            this.dtBitisSaat.ShowUpDown = true;
            this.dtBitisSaat.Size = new System.Drawing.Size(200, 28);
            this.dtBitisSaat.TabIndex = 25;
            // 
            // btnAktiviteEkle
            // 
            this.btnAktiviteEkle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAktiviteEkle.Location = new System.Drawing.Point(612, 647);
            this.btnAktiviteEkle.Name = "btnAktiviteEkle";
            this.btnAktiviteEkle.Size = new System.Drawing.Size(113, 37);
            this.btnAktiviteEkle.TabIndex = 26;
            this.btnAktiviteEkle.Text = "Ekle";
            this.btnAktiviteEkle.UseVisualStyleBackColor = true;
            this.btnAktiviteEkle.Click += new System.EventHandler(this.btnAktiviteEkle_Click);
            // 
            // btnAktiviteGuncelle
            // 
            this.btnAktiviteGuncelle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAktiviteGuncelle.Location = new System.Drawing.Point(915, 647);
            this.btnAktiviteGuncelle.Name = "btnAktiviteGuncelle";
            this.btnAktiviteGuncelle.Size = new System.Drawing.Size(127, 37);
            this.btnAktiviteGuncelle.TabIndex = 27;
            this.btnAktiviteGuncelle.Text = "Güncelle";
            this.btnAktiviteGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnAktiviteSil
            // 
            this.btnAktiviteSil.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAktiviteSil.Location = new System.Drawing.Point(765, 647);
            this.btnAktiviteSil.Name = "btnAktiviteSil";
            this.btnAktiviteSil.Size = new System.Drawing.Size(113, 37);
            this.btnAktiviteSil.TabIndex = 28;
            this.btnAktiviteSil.Text = "Sil";
            this.btnAktiviteSil.UseVisualStyleBackColor = true;
            this.btnAktiviteSil.Click += new System.EventHandler(this.btnAktiviteSil_Click);
            // 
            // dbCRMDataSet7
            // 
            this.dbCRMDataSet7.DataSetName = "dbCRMDataSet7";
            this.dbCRMDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbCRMDataSet7BindingSource
            // 
            this.dbCRMDataSet7BindingSource.DataSource = this.dbCRMDataSet7;
            this.dbCRMDataSet7BindingSource.Position = 0;
            // 
            // tBLMARKALARBindingSource
            // 
            this.tBLMARKALARBindingSource.DataMember = "TBLMARKALAR";
            this.tBLMARKALARBindingSource.DataSource = this.dbCRMDataSet7BindingSource;
            // 
            // tBLMARKALARTableAdapter
            // 
            this.tBLMARKALARTableAdapter.ClearBeforeFill = true;
            // 
            // tBLMUSTERILERTableAdapter
            // 
            this.tBLMUSTERILERTableAdapter.ClearBeforeFill = true;
            // 
            // lblSorumlu
            // 
            this.lblSorumlu.AutoSize = true;
            this.lblSorumlu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSorumlu.Location = new System.Drawing.Point(1076, 576);
            this.lblSorumlu.Name = "lblSorumlu";
            this.lblSorumlu.Size = new System.Drawing.Size(107, 25);
            this.lblSorumlu.TabIndex = 29;
            this.lblSorumlu.Text = "Sorumlu:";
            // 
            // cbSorumlu
            // 
            this.cbSorumlu.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tBLPERSONELBindingSource, "ID", true));
            this.cbSorumlu.DataSource = this.tBLPERSONELBindingSource;
            this.cbSorumlu.DisplayMember = "PersonelAd";
            this.cbSorumlu.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSorumlu.FormattingEnabled = true;
            this.cbSorumlu.Location = new System.Drawing.Point(1192, 573);
            this.cbSorumlu.Name = "cbSorumlu";
            this.cbSorumlu.Size = new System.Drawing.Size(222, 28);
            this.cbSorumlu.TabIndex = 30;
            this.cbSorumlu.ValueMember = "ID";
            // 
            // tBLPERSONELDATASET
            // 
            this.tBLPERSONELDATASET.DataSetName = "TBLPERSONELDATASET";
            this.tBLPERSONELDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLPERSONELBindingSource
            // 
            this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
            this.tBLPERSONELBindingSource.DataSource = this.tBLPERSONELDATASET;
            // 
            // tBLPERSONELTableAdapter
            // 
            this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
            // 
            // Aktiviteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 717);
            this.Controls.Add(this.cbSorumlu);
            this.Controls.Add(this.lblSorumlu);
            this.Controls.Add(this.btnAktiviteSil);
            this.Controls.Add(this.btnAktiviteGuncelle);
            this.Controls.Add(this.btnAktiviteEkle);
            this.Controls.Add(this.dtBitisSaat);
            this.Controls.Add(this.dtBaslangicSaat);
            this.Controls.Add(this.cbOncelik);
            this.Controls.Add(this.dtBitisTarih);
            this.Controls.Add(this.dtBaslangicTarih);
            this.Controls.Add(this.cbLokasyon);
            this.Controls.Add(this.cbAktiviteTipi);
            this.Controls.Add(this.cbMusteri);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtAktiviteAd);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblOncelik);
            this.Controls.Add(this.lblBitis);
            this.Controls.Add(this.lblBaslangic);
            this.Controls.Add(this.lblLokasyon);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblAktiviteAd);
            this.Controls.Add(this.lblAktiviteTipi);
            this.Controls.Add(this.lblMusteri);
            this.Controls.Add(this.lblAktiviteID);
            this.Name = "Aktiviteler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aktiviteler";
            this.Load += new System.EventHandler(this.Aktiviteler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERILERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMARKALARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERSONELDATASET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERSONELBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAktiviteID;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.Label lblAktiviteTipi;
        private System.Windows.Forms.Label lblAktiviteAd;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblLokasyon;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.Label lblOncelik;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtAktiviteAd;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox cbMusteri;
        private System.Windows.Forms.ComboBox cbAktiviteTipi;
        private System.Windows.Forms.ComboBox cbLokasyon;
        private System.Windows.Forms.DateTimePicker dtBaslangicTarih;
        private System.Windows.Forms.DateTimePicker dtBitisTarih;
        private System.Windows.Forms.ComboBox cbOncelik;
        private System.Windows.Forms.DateTimePicker dtBaslangicSaat;
        private System.Windows.Forms.DateTimePicker dtBitisSaat;
        private System.Windows.Forms.Button btnAktiviteEkle;
        private System.Windows.Forms.Button btnAktiviteGuncelle;
        private System.Windows.Forms.Button btnAktiviteSil;
        private System.Windows.Forms.BindingSource dbCRMDataSet7BindingSource;
        private dbCRMDataSet7 dbCRMDataSet7;
        private System.Windows.Forms.BindingSource tBLMARKALARBindingSource;
        private dbCRMDataSet7TableAdapters.TBLMARKALARTableAdapter tBLMARKALARTableAdapter;
        private System.Windows.Forms.BindingSource dbCRMDataSetBindingSource;
        private dbCRMDataSet dbCRMDataSet;
        private System.Windows.Forms.BindingSource tBLMUSTERILERBindingSource;
        private dbCRMDataSetTableAdapters.TBLMUSTERILERTableAdapter tBLMUSTERILERTableAdapter;
        private System.Windows.Forms.Label lblSorumlu;
        private System.Windows.Forms.ComboBox cbSorumlu;
        private TBLPERSONELDATASET tBLPERSONELDATASET;
        private System.Windows.Forms.BindingSource tBLPERSONELBindingSource;
        private TBLPERSONELDATASETTableAdapters.TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
    }
}