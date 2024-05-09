namespace UygulamaSinavi2
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxKAdi = new System.Windows.Forms.TextBox();
            this.textBoxAdiSoyadi = new System.Windows.Forms.TextBox();
            this.textBoxEPosta = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uyeDb559DataSet = new UygulamaSinavi2.UyeDb559DataSet();
            this.uyelers559BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uyelers559TableAdapter = new UygulamaSinavi2.UyeDb559DataSetTableAdapters.Uyelers559TableAdapter();
            this.kAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ePostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeDb559DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelers559BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı Soyadı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "EPosta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre:";
            // 
            // textBoxKAdi
            // 
            this.textBoxKAdi.Location = new System.Drawing.Point(112, 31);
            this.textBoxKAdi.Name = "textBoxKAdi";
            this.textBoxKAdi.Size = new System.Drawing.Size(100, 20);
            this.textBoxKAdi.TabIndex = 4;
            // 
            // textBoxAdiSoyadi
            // 
            this.textBoxAdiSoyadi.Location = new System.Drawing.Point(112, 67);
            this.textBoxAdiSoyadi.Name = "textBoxAdiSoyadi";
            this.textBoxAdiSoyadi.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdiSoyadi.TabIndex = 5;
            // 
            // textBoxEPosta
            // 
            this.textBoxEPosta.Location = new System.Drawing.Point(112, 109);
            this.textBoxEPosta.Name = "textBoxEPosta";
            this.textBoxEPosta.Size = new System.Drawing.Size(100, 20);
            this.textBoxEPosta.TabIndex = 6;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(112, 152);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.PasswordChar = '*';
            this.textBoxSifre.Size = new System.Drawing.Size(100, 20);
            this.textBoxSifre.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kAdiDataGridViewTextBoxColumn,
            this.adiSoyadiDataGridViewTextBoxColumn,
            this.ePostaDataGridViewTextBoxColumn,
            this.sifreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uyelers559BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(235, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(517, 267);
            this.dataGridView1.TabIndex = 9;
            // 
            // uyeDb559DataSet
            // 
            this.uyeDb559DataSet.DataSetName = "UyeDb559DataSet";
            this.uyeDb559DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uyelers559BindingSource
            // 
            this.uyelers559BindingSource.DataMember = "Uyelers559";
            this.uyelers559BindingSource.DataSource = this.uyeDb559DataSet;
            // 
            // uyelers559TableAdapter
            // 
            this.uyelers559TableAdapter.ClearBeforeFill = true;
            // 
            // kAdiDataGridViewTextBoxColumn
            // 
            this.kAdiDataGridViewTextBoxColumn.DataPropertyName = "KAdi";
            this.kAdiDataGridViewTextBoxColumn.HeaderText = "KAdi";
            this.kAdiDataGridViewTextBoxColumn.Name = "kAdiDataGridViewTextBoxColumn";
            // 
            // adiSoyadiDataGridViewTextBoxColumn
            // 
            this.adiSoyadiDataGridViewTextBoxColumn.DataPropertyName = "AdiSoyadi";
            this.adiSoyadiDataGridViewTextBoxColumn.HeaderText = "AdiSoyadi";
            this.adiSoyadiDataGridViewTextBoxColumn.Name = "adiSoyadiDataGridViewTextBoxColumn";
            // 
            // ePostaDataGridViewTextBoxColumn
            // 
            this.ePostaDataGridViewTextBoxColumn.DataPropertyName = "EPosta";
            this.ePostaDataGridViewTextBoxColumn.HeaderText = "EPosta";
            this.ePostaDataGridViewTextBoxColumn.Name = "ePostaDataGridViewTextBoxColumn";
            // 
            // sifreDataGridViewTextBoxColumn
            // 
            this.sifreDataGridViewTextBoxColumn.DataPropertyName = "Sifre";
            this.sifreDataGridViewTextBoxColumn.HeaderText = "Sifre";
            this.sifreDataGridViewTextBoxColumn.Name = "sifreDataGridViewTextBoxColumn";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(126, 207);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(75, 23);
            this.btnListele.TabIndex = 10;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxEPosta);
            this.Controls.Add(this.textBoxAdiSoyadi);
            this.Controls.Add(this.textBoxKAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeDb559DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyelers559BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxKAdi;
        private System.Windows.Forms.TextBox textBoxAdiSoyadi;
        private System.Windows.Forms.TextBox textBoxEPosta;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private UyeDb559DataSet uyeDb559DataSet;
        private System.Windows.Forms.BindingSource uyelers559BindingSource;
        private UyeDb559DataSetTableAdapters.Uyelers559TableAdapter uyelers559TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ePostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnListele;
    }
}

