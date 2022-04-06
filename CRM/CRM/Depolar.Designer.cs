
namespace CRM
{
    partial class Depolar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.depoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depoAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLDEPOLARBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbCRMDataSet4 = new CRM.dbCRMDataSet4();
            this.tBLDEPOLARTableAdapter = new CRM.dbCRMDataSet4TableAdapters.TBLDEPOLARTableAdapter();
            this.lblDepoAd = new System.Windows.Forms.Label();
            this.txtDepoAd = new System.Windows.Forms.TextBox();
            this.btnDepoEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDEPOLARBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.depoIDDataGridViewTextBoxColumn,
            this.depoAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLDEPOLARBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(430, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(574, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // depoIDDataGridViewTextBoxColumn
            // 
            this.depoIDDataGridViewTextBoxColumn.DataPropertyName = "DepoID";
            this.depoIDDataGridViewTextBoxColumn.HeaderText = "DepoID";
            this.depoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.depoIDDataGridViewTextBoxColumn.Name = "depoIDDataGridViewTextBoxColumn";
            this.depoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.depoIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // depoAdDataGridViewTextBoxColumn
            // 
            this.depoAdDataGridViewTextBoxColumn.DataPropertyName = "DepoAd";
            this.depoAdDataGridViewTextBoxColumn.HeaderText = "DepoAd";
            this.depoAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.depoAdDataGridViewTextBoxColumn.Name = "depoAdDataGridViewTextBoxColumn";
            this.depoAdDataGridViewTextBoxColumn.Width = 125;
            // 
            // tBLDEPOLARBindingSource
            // 
            this.tBLDEPOLARBindingSource.DataMember = "TBLDEPOLAR";
            this.tBLDEPOLARBindingSource.DataSource = this.dbCRMDataSet4;
            // 
            // dbCRMDataSet4
            // 
            this.dbCRMDataSet4.DataSetName = "dbCRMDataSet4";
            this.dbCRMDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLDEPOLARTableAdapter
            // 
            this.tBLDEPOLARTableAdapter.ClearBeforeFill = true;
            // 
            // lblDepoAd
            // 
            this.lblDepoAd.AutoSize = true;
            this.lblDepoAd.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDepoAd.Location = new System.Drawing.Point(616, 386);
            this.lblDepoAd.Name = "lblDepoAd";
            this.lblDepoAd.Size = new System.Drawing.Size(132, 29);
            this.lblDepoAd.TabIndex = 1;
            this.lblDepoAd.Text = "Depo Adı:";
            // 
            // txtDepoAd
            // 
            this.txtDepoAd.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDepoAd.Location = new System.Drawing.Point(764, 389);
            this.txtDepoAd.Name = "txtDepoAd";
            this.txtDepoAd.Size = new System.Drawing.Size(225, 28);
            this.txtDepoAd.TabIndex = 2;
            // 
            // btnDepoEkle
            // 
            this.btnDepoEkle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepoEkle.Location = new System.Drawing.Point(430, 496);
            this.btnDepoEkle.Name = "btnDepoEkle";
            this.btnDepoEkle.Size = new System.Drawing.Size(120, 33);
            this.btnDepoEkle.TabIndex = 3;
            this.btnDepoEkle.Text = "Ekle";
            this.btnDepoEkle.UseVisualStyleBackColor = true;
            this.btnDepoEkle.Click += new System.EventHandler(this.btnDepoEkle_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(610, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(142, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Depo ID:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(283, 392);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 28);
            this.textBox1.TabIndex = 6;
            // 
            // Depolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1234, 624);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDepoEkle);
            this.Controls.Add(this.txtDepoAd);
            this.Controls.Add(this.lblDepoAd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Depolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depolar";
            this.Load += new System.EventHandler(this.Depolar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLDEPOLARBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCRMDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbCRMDataSet4 dbCRMDataSet4;
        private System.Windows.Forms.BindingSource tBLDEPOLARBindingSource;
        private dbCRMDataSet4TableAdapters.TBLDEPOLARTableAdapter tBLDEPOLARTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn depoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depoAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblDepoAd;
        private System.Windows.Forms.TextBox txtDepoAd;
        private System.Windows.Forms.Button btnDepoEkle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}