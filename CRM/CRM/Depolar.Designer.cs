
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(411, 316);
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
            this.lblDepoAd.Location = new System.Drawing.Point(460, 233);
            this.lblDepoAd.Name = "lblDepoAd";
            this.lblDepoAd.Size = new System.Drawing.Size(132, 29);
            this.lblDepoAd.TabIndex = 1;
            this.lblDepoAd.Text = "Depo Adı:";
            // 
            // txtDepoAd
            // 
            this.txtDepoAd.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDepoAd.Location = new System.Drawing.Point(648, 236);
            this.txtDepoAd.Name = "txtDepoAd";
            this.txtDepoAd.Size = new System.Drawing.Size(225, 28);
            this.txtDepoAd.TabIndex = 2;
            // 
            // btnDepoEkle
            // 
            this.btnDepoEkle.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepoEkle.Location = new System.Drawing.Point(465, 377);
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
            this.button1.Location = new System.Drawing.Point(753, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Depolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1021, 450);
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
    }
}