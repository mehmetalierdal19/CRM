
namespace CRM
{
    partial class Gorusmeler
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
            this.cbMusteri = new System.Windows.Forms.ComboBox();
            this.tBLMUSTERILERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbMUSTERILERDataSet = new CRM.dbMUSTERILERDataSet();
            this.cbSorumlu = new System.Windows.Forms.ComboBox();
            this.tBLPERSONELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLPERSONELDATASETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBLPERSONELDATASET = new CRM.TBLPERSONELDATASET();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.tBLMUSTERILERTableAdapter = new CRM.dbMUSTERILERDataSetTableAdapters.TBLMUSTERILERTableAdapter();
            this.tBLPERSONELTableAdapter = new CRM.TBLPERSONELDATASETTableAdapters.TBLPERSONELTableAdapter();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERILERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMUSTERILERDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERSONELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERSONELDATASETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERSONELDATASET)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(465, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Açıklama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(20, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sorumlu:";
            // 
            // cbMusteri
            // 
            this.cbMusteri.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tBLMUSTERILERBindingSource, "id", true));
            this.cbMusteri.DataSource = this.tBLMUSTERILERBindingSource;
            this.cbMusteri.DisplayMember = "MUSTERIAD";
            this.cbMusteri.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMusteri.FormattingEnabled = true;
            this.cbMusteri.Location = new System.Drawing.Point(169, 74);
            this.cbMusteri.Name = "cbMusteri";
            this.cbMusteri.Size = new System.Drawing.Size(201, 28);
            this.cbMusteri.TabIndex = 3;
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
            // cbSorumlu
            // 
            this.cbSorumlu.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tBLPERSONELBindingSource, "ID", true));
            this.cbSorumlu.DataSource = this.tBLPERSONELBindingSource;
            this.cbSorumlu.DisplayMember = "PersonelAd";
            this.cbSorumlu.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSorumlu.FormattingEnabled = true;
            this.cbSorumlu.Location = new System.Drawing.Point(169, 154);
            this.cbSorumlu.Name = "cbSorumlu";
            this.cbSorumlu.Size = new System.Drawing.Size(201, 28);
            this.cbSorumlu.TabIndex = 4;
            this.cbSorumlu.ValueMember = "ID";
            // 
            // tBLPERSONELBindingSource
            // 
            this.tBLPERSONELBindingSource.DataMember = "TBLPERSONEL";
            this.tBLPERSONELBindingSource.DataSource = this.tBLPERSONELDATASETBindingSource;
            // 
            // tBLPERSONELDATASETBindingSource
            // 
            this.tBLPERSONELDATASETBindingSource.DataSource = this.tBLPERSONELDATASET;
            this.tBLPERSONELDATASETBindingSource.Position = 0;
            // 
            // tBLPERSONELDATASET
            // 
            this.tBLPERSONELDATASET.DataSetName = "TBLPERSONELDATASET";
            this.tBLPERSONELDATASET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(583, 74);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(583, 219);
            this.txtAciklama.TabIndex = 5;
            // 
            // tBLMUSTERILERTableAdapter
            // 
            this.tBLMUSTERILERTableAdapter.ClearBeforeFill = true;
            // 
            // tBLPERSONELTableAdapter
            // 
            this.tBLPERSONELTableAdapter.ClearBeforeFill = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(113, 249);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(140, 44);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(318, 249);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(140, 44);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // Gorusmeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1253, 714);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.cbSorumlu);
            this.Controls.Add(this.cbMusteri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Gorusmeler";
            this.Text = "Gorusmeler";
            this.Load += new System.EventHandler(this.Gorusmeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBLMUSTERILERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbMUSTERILERDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERSONELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERSONELDATASETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLPERSONELDATASET)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMusteri;
        private System.Windows.Forms.ComboBox cbSorumlu;
        private System.Windows.Forms.TextBox txtAciklama;
        private dbMUSTERILERDataSet dbMUSTERILERDataSet;
        private System.Windows.Forms.BindingSource tBLMUSTERILERBindingSource;
        private dbMUSTERILERDataSetTableAdapters.TBLMUSTERILERTableAdapter tBLMUSTERILERTableAdapter;
        private System.Windows.Forms.BindingSource tBLPERSONELDATASETBindingSource;
        private TBLPERSONELDATASET tBLPERSONELDATASET;
        private System.Windows.Forms.BindingSource tBLPERSONELBindingSource;
        private TBLPERSONELDATASETTableAdapters.TBLPERSONELTableAdapter tBLPERSONELTableAdapter;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
    }
}