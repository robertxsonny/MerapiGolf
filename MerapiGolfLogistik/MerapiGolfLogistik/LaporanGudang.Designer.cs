namespace MerapiGolfLogistik
{
    partial class LaporanGudang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaporanGudang));
            this.label1 = new System.Windows.Forms.Label();
            this.dariTanggalTb = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.sampaiTanggalTb = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.kategoriTb = new System.Windows.Forms.Label();
            this.pilihKategoriBtn = new System.Windows.Forms.Button();
            this.hapusFilterBtn = new System.Windows.Forms.Button();
            this.reportView = new System.Windows.Forms.DataGridView();
            this.subsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalKeluarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaMasukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaKeluarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaSaldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laporanGudangItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laporanBarangExtendedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cetakLaporanBtn = new System.Windows.Forms.Button();
            this.laporanGudangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reportView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanGudangItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanBarangExtendedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanGudangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dari Tanggal";
            // 
            // dariTanggalTb
            // 
            this.dariTanggalTb.Location = new System.Drawing.Point(129, 5);
            this.dariTanggalTb.Name = "dariTanggalTb";
            this.dariTanggalTb.Size = new System.Drawing.Size(331, 26);
            this.dariTanggalTb.TabIndex = 1;
            this.dariTanggalTb.ValueChanged += new System.EventHandler(this.dariTanggalTb_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sampai Tanggal";
            // 
            // sampaiTanggalTb
            // 
            this.sampaiTanggalTb.Location = new System.Drawing.Point(618, 5);
            this.sampaiTanggalTb.Name = "sampaiTanggalTb";
            this.sampaiTanggalTb.Size = new System.Drawing.Size(331, 26);
            this.sampaiTanggalTb.TabIndex = 4;
            this.sampaiTanggalTb.ValueChanged += new System.EventHandler(this.sampaiTanggalTb_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pilih Kategori";
            // 
            // kategoriTb
            // 
            this.kategoriTb.AutoSize = true;
            this.kategoriTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoriTb.Location = new System.Drawing.Point(124, 48);
            this.kategoriTb.Name = "kategoriTb";
            this.kategoriTb.Size = new System.Drawing.Size(225, 20);
            this.kategoriTb.TabIndex = 6;
            this.kategoriTb.Text = "[Belum ada kategori dipilih]";
            // 
            // pilihKategoriBtn
            // 
            this.pilihKategoriBtn.Image = ((System.Drawing.Image)(resources.GetObject("pilihKategoriBtn.Image")));
            this.pilihKategoriBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pilihKategoriBtn.Location = new System.Drawing.Point(245, 84);
            this.pilihKategoriBtn.Name = "pilihKategoriBtn";
            this.pilihKategoriBtn.Size = new System.Drawing.Size(176, 42);
            this.pilihKategoriBtn.TabIndex = 7;
            this.pilihKategoriBtn.Text = "Pilih Kategori (F1)";
            this.pilihKategoriBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pilihKategoriBtn.UseVisualStyleBackColor = true;
            this.pilihKategoriBtn.Click += new System.EventHandler(this.pilihKategoriBtn_Click);
            // 
            // hapusFilterBtn
            // 
            this.hapusFilterBtn.Image = ((System.Drawing.Image)(resources.GetObject("hapusFilterBtn.Image")));
            this.hapusFilterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hapusFilterBtn.Location = new System.Drawing.Point(426, 84);
            this.hapusFilterBtn.Name = "hapusFilterBtn";
            this.hapusFilterBtn.Size = new System.Drawing.Size(148, 42);
            this.hapusFilterBtn.TabIndex = 8;
            this.hapusFilterBtn.Text = "Hapus Filter";
            this.hapusFilterBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hapusFilterBtn.UseVisualStyleBackColor = true;
            this.hapusFilterBtn.Click += new System.EventHandler(this.hapusFilterBtn_Click);
            // 
            // reportView
            // 
            this.reportView.AutoGenerateColumns = false;
            this.reportView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subsiDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.kategoriDataGridViewTextBoxColumn,
            this.tanggalKeluarDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn4,
            this.stokDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.hargaMasukDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.hargaKeluarDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn5,
            this.hargaSaldoDataGridViewTextBoxColumn});
            this.reportView.DataSource = this.laporanGudangItemBindingSource;
            this.reportView.Location = new System.Drawing.Point(16, 132);
            this.reportView.Name = "reportView";
            this.reportView.RowTemplate.Height = 28;
            this.reportView.Size = new System.Drawing.Size(933, 395);
            this.reportView.TabIndex = 9;
            // 
            // subsiDataGridViewTextBoxColumn
            // 
            this.subsiDataGridViewTextBoxColumn.DataPropertyName = "Subsi";
            this.subsiDataGridViewTextBoxColumn.HeaderText = "Subsi";
            this.subsiDataGridViewTextBoxColumn.Name = "subsiDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NamaBarang";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nama Barang";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // kategoriDataGridViewTextBoxColumn
            // 
            this.kategoriDataGridViewTextBoxColumn.DataPropertyName = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.HeaderText = "Kategori";
            this.kategoriDataGridViewTextBoxColumn.Name = "kategoriDataGridViewTextBoxColumn";
            // 
            // tanggalKeluarDataGridViewTextBoxColumn
            // 
            this.tanggalKeluarDataGridViewTextBoxColumn.DataPropertyName = "TanggalKeluar";
            this.tanggalKeluarDataGridViewTextBoxColumn.HeaderText = "Tanggal Keluar";
            this.tanggalKeluarDataGridViewTextBoxColumn.Name = "tanggalKeluarDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "HargaSatuan";
            this.dataGridViewTextBoxColumn4.HeaderText = "Harga Satuan";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "Stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StokMasuk";
            this.dataGridViewTextBoxColumn2.HeaderText = "Stok Masuk";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // hargaMasukDataGridViewTextBoxColumn
            // 
            this.hargaMasukDataGridViewTextBoxColumn.DataPropertyName = "HargaMasuk";
            this.hargaMasukDataGridViewTextBoxColumn.HeaderText = "Harga Masuk";
            this.hargaMasukDataGridViewTextBoxColumn.Name = "hargaMasukDataGridViewTextBoxColumn";
            this.hargaMasukDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StokKeluar";
            this.dataGridViewTextBoxColumn3.HeaderText = "Stok Keluar";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // hargaKeluarDataGridViewTextBoxColumn
            // 
            this.hargaKeluarDataGridViewTextBoxColumn.DataPropertyName = "HargaKeluar";
            this.hargaKeluarDataGridViewTextBoxColumn.HeaderText = "Harga Keluar";
            this.hargaKeluarDataGridViewTextBoxColumn.Name = "hargaKeluarDataGridViewTextBoxColumn";
            this.hargaKeluarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Saldo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Saldo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // hargaSaldoDataGridViewTextBoxColumn
            // 
            this.hargaSaldoDataGridViewTextBoxColumn.DataPropertyName = "HargaSaldo";
            this.hargaSaldoDataGridViewTextBoxColumn.HeaderText = "Harga Saldo";
            this.hargaSaldoDataGridViewTextBoxColumn.Name = "hargaSaldoDataGridViewTextBoxColumn";
            this.hargaSaldoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // laporanGudangItemBindingSource
            // 
            this.laporanGudangItemBindingSource.DataSource = typeof(MerapiGolfLogistik.Classes.LaporanGudangItem);
            // 
            // cetakLaporanBtn
            // 
            this.cetakLaporanBtn.Image = ((System.Drawing.Image)(resources.GetObject("cetakLaporanBtn.Image")));
            this.cetakLaporanBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cetakLaporanBtn.Location = new System.Drawing.Point(590, 84);
            this.cetakLaporanBtn.Name = "cetakLaporanBtn";
            this.cetakLaporanBtn.Size = new System.Drawing.Size(144, 42);
            this.cetakLaporanBtn.TabIndex = 10;
            this.cetakLaporanBtn.Text = "Cetak Laporan";
            this.cetakLaporanBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cetakLaporanBtn.UseVisualStyleBackColor = true;
            this.cetakLaporanBtn.Click += new System.EventHandler(this.cetakLaporanBtn_Click);
            // 
            // laporanGudangBindingSource
            // 
            this.laporanGudangBindingSource.DataSource = typeof(MerapiGolfLogistik.Classes.LaporanGudang);
            // 
            // LaporanGudang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 540);
            this.Controls.Add(this.cetakLaporanBtn);
            this.Controls.Add(this.reportView);
            this.Controls.Add(this.hapusFilterBtn);
            this.Controls.Add(this.pilihKategoriBtn);
            this.Controls.Add(this.kategoriTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sampaiTanggalTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dariTanggalTb);
            this.Controls.Add(this.label1);
            this.Name = "LaporanGudang";
            this.Text = "Laporan Gudang - Merapi Golf Inventory";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LaporanGudang_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.reportView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanGudangItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanBarangExtendedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanGudangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dariTanggalTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker sampaiTanggalTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label kategoriTb;
        private System.Windows.Forms.Button pilihKategoriBtn;
        private System.Windows.Forms.Button hapusFilterBtn;
        private System.Windows.Forms.DataGridView reportView;
        private System.Windows.Forms.Button cetakLaporanBtn;
        private System.Windows.Forms.BindingSource laporanBarangExtendedBindingSource;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn idkategoriDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn namakategoriDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn satuanDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn stokAwalDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn stokmasukDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn stokkeluarDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn stoksaldoDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn hargaSatuanDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn saldoAwalDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn jumlahhrgbeliDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn jumlahhrgpakaiDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalKeluarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaMasukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaKeluarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaSaldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource laporanGudangItemBindingSource;
        private System.Windows.Forms.BindingSource laporanGudangBindingSource;
    }
}