namespace MerapiGolfLogistik
{
    partial class PembelianBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PembelianBarang));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.keteranganLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.totalPembelianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tambahBarangBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargasatuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banyakbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalhargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPembelianBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(107, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 53);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "B-001";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.keteranganLabel);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 154);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // keteranganLabel
            // 
            this.keteranganLabel.AutoSize = true;
            this.keteranganLabel.Location = new System.Drawing.Point(6, 116);
            this.keteranganLabel.Name = "keteranganLabel";
            this.keteranganLabel.Size = new System.Drawing.Size(92, 20);
            this.keteranganLabel.TabIndex = 6;
            this.keteranganLabel.Text = "Keterangan";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(223, 26);
            this.textBox2.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(616, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Daftar Baru";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(449, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "[Belum ada supplier dipilih]";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(453, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pilih Supplier (F1)";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "No. Nota";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namabarangDataGridViewTextBoxColumn,
            this.hargasatuanDataGridViewTextBoxColumn,
            this.banyakbarangDataGridViewTextBoxColumn,
            this.harga_satuan,
            this.totalhargaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.totalPembelianBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(777, 337);
            this.dataGridView1.TabIndex = 4;
            // 
            // totalPembelianBindingSource
            // 
            this.totalPembelianBindingSource.DataSource = typeof(MerapiGolfLogistik.TotalPembelian);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 614);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(801, 30);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(60, 25);
            this.statusLabel.Text = "Ready";
            // 
            // tambahBarangBtn
            // 
            this.tambahBarangBtn.Image = ((System.Drawing.Image)(resources.GetObject("tambahBarangBtn.Image")));
            this.tambahBarangBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tambahBarangBtn.Location = new System.Drawing.Point(110, 166);
            this.tambahBarangBtn.Name = "tambahBarangBtn";
            this.tambahBarangBtn.Size = new System.Drawing.Size(136, 89);
            this.tambahBarangBtn.TabIndex = 6;
            this.tambahBarangBtn.Text = "Tambah Barang (F2)";
            this.tambahBarangBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tambahBarangBtn.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(252, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 89);
            this.button3.TabIndex = 7;
            this.button3.Text = "Simpan (F3)";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(394, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 89);
            this.button4.TabIndex = 8;
            this.button4.Text = "Cetak (F4)";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(536, 166);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 89);
            this.button5.TabIndex = 9;
            this.button5.Text = "Ulangi (F5)";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // namabarangDataGridViewTextBoxColumn
            // 
            this.namabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang";
            this.namabarangDataGridViewTextBoxColumn.Name = "namabarangDataGridViewTextBoxColumn";
            // 
            // hargasatuanDataGridViewTextBoxColumn
            // 
            this.hargasatuanDataGridViewTextBoxColumn.DataPropertyName = "harga_satuan";
            this.hargasatuanDataGridViewTextBoxColumn.HeaderText = "Harga Satuan";
            this.hargasatuanDataGridViewTextBoxColumn.Name = "hargasatuanDataGridViewTextBoxColumn";
            // 
            // banyakbarangDataGridViewTextBoxColumn
            // 
            this.banyakbarangDataGridViewTextBoxColumn.DataPropertyName = "banyak_barang";
            this.banyakbarangDataGridViewTextBoxColumn.HeaderText = "Banyak";
            this.banyakbarangDataGridViewTextBoxColumn.Name = "banyakbarangDataGridViewTextBoxColumn";
            // 
            // harga_satuan
            // 
            this.harga_satuan.DataPropertyName = "satuan";
            this.harga_satuan.HeaderText = "Satuan";
            this.harga_satuan.Name = "harga_satuan";
            // 
            // totalhargaDataGridViewTextBoxColumn
            // 
            this.totalhargaDataGridViewTextBoxColumn.DataPropertyName = "total_harga";
            this.totalhargaDataGridViewTextBoxColumn.HeaderText = "Total Harga";
            this.totalhargaDataGridViewTextBoxColumn.Name = "totalhargaDataGridViewTextBoxColumn";
            // 
            // PembelianBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 644);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tambahBarangBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "PembelianBarang";
            this.Text = "Pembelian Barang - Merapi Golf Inventory";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPembelianBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label keteranganLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button tambahBarangBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource totalPembelianBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargasatuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn banyakbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_satuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalhargaDataGridViewTextBoxColumn;
    }
}