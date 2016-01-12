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
            this.noNotaTb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.keteranganLabel = new System.Windows.Forms.Label();
            this.keteranganTb = new System.Windows.Forms.TextBox();
            this.buatSupplierBtn = new System.Windows.Forms.Button();
            this.selectedSupplierTb = new System.Windows.Forms.Label();
            this.pilihSupplierBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.itemList = new System.Windows.Forms.DataGridView();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tambahBarangBtn = new System.Windows.Forms.Button();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.totalHargaText = new System.Windows.Forms.Label();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargasatuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banyakbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalhargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPembelianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemList)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalPembelianBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // noNotaTb
            // 
            this.noNotaTb.Enabled = false;
            this.noNotaTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noNotaTb.Location = new System.Drawing.Point(107, 25);
            this.noNotaTb.Name = "noNotaTb";
            this.noNotaTb.Size = new System.Drawing.Size(223, 53);
            this.noNotaTb.TabIndex = 1;
            this.noNotaTb.Text = "B-001";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.keteranganLabel);
            this.groupBox1.Controls.Add(this.keteranganTb);
            this.groupBox1.Controls.Add(this.buatSupplierBtn);
            this.groupBox1.Controls.Add(this.selectedSupplierTb);
            this.groupBox1.Controls.Add(this.pilihSupplierBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.noNotaTb);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(906, 154);
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
            // keteranganTb
            // 
            this.keteranganTb.Location = new System.Drawing.Point(107, 113);
            this.keteranganTb.Name = "keteranganTb";
            this.keteranganTb.Size = new System.Drawing.Size(223, 26);
            this.keteranganTb.TabIndex = 8;
            // 
            // buatSupplierBtn
            // 
            this.buatSupplierBtn.Image = ((System.Drawing.Image)(resources.GetObject("buatSupplierBtn.Image")));
            this.buatSupplierBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buatSupplierBtn.Location = new System.Drawing.Point(758, 55);
            this.buatSupplierBtn.Name = "buatSupplierBtn";
            this.buatSupplierBtn.Size = new System.Drawing.Size(140, 39);
            this.buatSupplierBtn.TabIndex = 7;
            this.buatSupplierBtn.Text = "Daftar Baru";
            this.buatSupplierBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buatSupplierBtn.UseVisualStyleBackColor = true;
            this.buatSupplierBtn.Click += new System.EventHandler(this.buatSupplierBtn_Click);
            // 
            // selectedSupplierTb
            // 
            this.selectedSupplierTb.AutoSize = true;
            this.selectedSupplierTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedSupplierTb.Location = new System.Drawing.Point(591, 25);
            this.selectedSupplierTb.Name = "selectedSupplierTb";
            this.selectedSupplierTb.Size = new System.Drawing.Size(223, 20);
            this.selectedSupplierTb.TabIndex = 6;
            this.selectedSupplierTb.Text = "[Belum ada supplier dipilih]";
            // 
            // pilihSupplierBtn
            // 
            this.pilihSupplierBtn.Image = ((System.Drawing.Image)(resources.GetObject("pilihSupplierBtn.Image")));
            this.pilihSupplierBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pilihSupplierBtn.Location = new System.Drawing.Point(595, 55);
            this.pilihSupplierBtn.Name = "pilihSupplierBtn";
            this.pilihSupplierBtn.Size = new System.Drawing.Size(157, 39);
            this.pilihSupplierBtn.TabIndex = 4;
            this.pilihSupplierBtn.Text = "Pilih Supplier (F1)";
            this.pilihSupplierBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pilihSupplierBtn.UseVisualStyleBackColor = true;
            this.pilihSupplierBtn.Click += new System.EventHandler(this.pilihSupplierBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(518, 25);
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
            // itemList
            // 
            this.itemList.AutoGenerateColumns = false;
            this.itemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deleteColumn,
            this.Column1,
            this.namabarangDataGridViewTextBoxColumn,
            this.hargasatuanDataGridViewTextBoxColumn,
            this.banyakbarangDataGridViewTextBoxColumn,
            this.harga_satuan,
            this.totalhargaDataGridViewTextBoxColumn});
            this.itemList.DataSource = this.totalPembelianBindingSource;
            this.itemList.Location = new System.Drawing.Point(12, 261);
            this.itemList.Name = "itemList";
            this.itemList.RowTemplate.Height = 28;
            this.itemList.Size = new System.Drawing.Size(906, 337);
            this.itemList.TabIndex = 4;
            this.itemList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // deleteColumn
            // 
            this.deleteColumn.HeaderText = "";
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.Text = "X";
            this.deleteColumn.UseColumnTextForButtonValue = true;
            this.deleteColumn.Width = 50;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // harga_satuan
            // 
            this.harga_satuan.DataPropertyName = "satuan";
            this.harga_satuan.HeaderText = "Satuan";
            this.harga_satuan.Name = "harga_satuan";
            this.harga_satuan.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 670);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(930, 30);
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
            this.tambahBarangBtn.Location = new System.Drawing.Point(196, 166);
            this.tambahBarangBtn.Name = "tambahBarangBtn";
            this.tambahBarangBtn.Size = new System.Drawing.Size(136, 89);
            this.tambahBarangBtn.TabIndex = 6;
            this.tambahBarangBtn.Text = "Tambah Barang (F2)";
            this.tambahBarangBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tambahBarangBtn.UseVisualStyleBackColor = true;
            this.tambahBarangBtn.Click += new System.EventHandler(this.tambahBarangBtn_Click);
            // 
            // simpanBtn
            // 
            this.simpanBtn.Image = ((System.Drawing.Image)(resources.GetObject("simpanBtn.Image")));
            this.simpanBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.simpanBtn.Location = new System.Drawing.Point(338, 166);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(136, 89);
            this.simpanBtn.TabIndex = 7;
            this.simpanBtn.Text = "Simpan (F3)";
            this.simpanBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.simpanBtn.UseVisualStyleBackColor = true;
            // 
            // printBtn
            // 
            this.printBtn.Image = ((System.Drawing.Image)(resources.GetObject("printBtn.Image")));
            this.printBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.printBtn.Location = new System.Drawing.Point(480, 166);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(136, 89);
            this.printBtn.TabIndex = 8;
            this.printBtn.Text = "Cetak (F4)";
            this.printBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.printBtn.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Image = ((System.Drawing.Image)(resources.GetObject("resetBtn.Image")));
            this.resetBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resetBtn.Location = new System.Drawing.Point(622, 166);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(136, 89);
            this.resetBtn.TabIndex = 9;
            this.resetBtn.Text = "Ulangi (F5)";
            this.resetBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.resetBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 606);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total Harga";
            // 
            // totalHargaText
            // 
            this.totalHargaText.AutoSize = true;
            this.totalHargaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHargaText.Location = new System.Drawing.Point(651, 606);
            this.totalHargaText.Name = "totalHargaText";
            this.totalHargaText.Size = new System.Drawing.Size(126, 46);
            this.totalHargaText.TabIndex = 11;
            this.totalHargaText.Text = "label4";
            // 
            // namabarangDataGridViewTextBoxColumn
            // 
            this.namabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang";
            this.namabarangDataGridViewTextBoxColumn.Name = "namabarangDataGridViewTextBoxColumn";
            this.namabarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hargasatuanDataGridViewTextBoxColumn
            // 
            this.hargasatuanDataGridViewTextBoxColumn.DataPropertyName = "harga_satuan";
            this.hargasatuanDataGridViewTextBoxColumn.HeaderText = "Harga Satuan";
            this.hargasatuanDataGridViewTextBoxColumn.Name = "hargasatuanDataGridViewTextBoxColumn";
            this.hargasatuanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // banyakbarangDataGridViewTextBoxColumn
            // 
            this.banyakbarangDataGridViewTextBoxColumn.DataPropertyName = "banyak_barang";
            this.banyakbarangDataGridViewTextBoxColumn.HeaderText = "Banyak";
            this.banyakbarangDataGridViewTextBoxColumn.Name = "banyakbarangDataGridViewTextBoxColumn";
            this.banyakbarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalhargaDataGridViewTextBoxColumn
            // 
            this.totalhargaDataGridViewTextBoxColumn.DataPropertyName = "total_harga";
            this.totalhargaDataGridViewTextBoxColumn.HeaderText = "Total Harga";
            this.totalhargaDataGridViewTextBoxColumn.Name = "totalhargaDataGridViewTextBoxColumn";
            this.totalhargaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalPembelianBindingSource
            // 
            this.totalPembelianBindingSource.DataSource = typeof(MerapiGolfLogistik.TotalPembelian);
            // 
            // PembelianBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 700);
            this.Controls.Add(this.totalHargaText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.simpanBtn);
            this.Controls.Add(this.tambahBarangBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.groupBox1);
            this.Name = "PembelianBarang";
            this.Text = "Pembelian Barang - Merapi Golf Inventory";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PembelianBarang_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemList)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.totalPembelianBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox noNotaTb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label selectedSupplierTb;
        private System.Windows.Forms.Button pilihSupplierBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buatSupplierBtn;
        private System.Windows.Forms.DataGridView itemList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label keteranganLabel;
        private System.Windows.Forms.TextBox keteranganTb;
        private System.Windows.Forms.Button tambahBarangBtn;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.BindingSource totalPembelianBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargasatuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn banyakbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_satuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalhargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalHargaText;
    }
}