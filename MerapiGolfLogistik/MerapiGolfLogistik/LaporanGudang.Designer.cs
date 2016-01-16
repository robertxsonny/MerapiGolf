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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dariTanggalTb = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.sampaiTanggalTb = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.kategoriTb = new System.Windows.Forms.Label();
            this.pilihKategoriBtn = new System.Windows.Forms.Button();
            this.hapusFilterBtn = new System.Windows.Forms.Button();
            this.reportView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namakategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokAwalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokmasukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokkeluarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoksaldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaSatuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoAwalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahhrgbeliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahhrgpakaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laporanBarangExtendedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cetakLaporanBtn = new System.Windows.Forms.Button();
            this.cetakLaporanPerKategoriBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanBarangExtendedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dari Tanggal";
            // 
            // dariTanggalTb
            // 
            this.dariTanggalTb.Location = new System.Drawing.Point(86, 3);
            this.dariTanggalTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dariTanggalTb.Name = "dariTanggalTb";
            this.dariTanggalTb.Size = new System.Drawing.Size(222, 20);
            this.dariTanggalTb.TabIndex = 1;
            this.dariTanggalTb.ValueChanged += new System.EventHandler(this.dariTanggalTb_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sampai Tanggal";
            // 
            // sampaiTanggalTb
            // 
            this.sampaiTanggalTb.Location = new System.Drawing.Point(412, 3);
            this.sampaiTanggalTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sampaiTanggalTb.Name = "sampaiTanggalTb";
            this.sampaiTanggalTb.Size = new System.Drawing.Size(222, 20);
            this.sampaiTanggalTb.TabIndex = 4;
            this.sampaiTanggalTb.ValueChanged += new System.EventHandler(this.sampaiTanggalTb_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pilih Kategori";
            // 
            // kategoriTb
            // 
            this.kategoriTb.AutoSize = true;
            this.kategoriTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoriTb.Location = new System.Drawing.Point(83, 31);
            this.kategoriTb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.kategoriTb.Name = "kategoriTb";
            this.kategoriTb.Size = new System.Drawing.Size(161, 13);
            this.kategoriTb.TabIndex = 6;
            this.kategoriTb.Text = "[Belum ada kategori dipilih]";
            // 
            // pilihKategoriBtn
            // 
            this.pilihKategoriBtn.Image = ((System.Drawing.Image)(resources.GetObject("pilihKategoriBtn.Image")));
            this.pilihKategoriBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pilihKategoriBtn.Location = new System.Drawing.Point(86, 55);
            this.pilihKategoriBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pilihKategoriBtn.Name = "pilihKategoriBtn";
            this.pilihKategoriBtn.Size = new System.Drawing.Size(117, 27);
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
            this.hapusFilterBtn.Location = new System.Drawing.Point(207, 55);
            this.hapusFilterBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hapusFilterBtn.Name = "hapusFilterBtn";
            this.hapusFilterBtn.Size = new System.Drawing.Size(99, 27);
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
            this.idDataGridViewTextBoxColumn,
            this.idkategoriDataGridViewTextBoxColumn,
            this.namakategoriDataGridViewTextBoxColumn,
            this.namabarangDataGridViewTextBoxColumn,
            this.satuanDataGridViewTextBoxColumn,
            this.stokAwalDataGridViewTextBoxColumn,
            this.stokmasukDataGridViewTextBoxColumn,
            this.stokkeluarDataGridViewTextBoxColumn,
            this.stoksaldoDataGridViewTextBoxColumn,
            this.hargaSatuanDataGridViewTextBoxColumn,
            this.saldoAwalDataGridViewTextBoxColumn,
            this.jumlahhrgbeliDataGridViewTextBoxColumn,
            this.jumlahhrgpakaiDataGridViewTextBoxColumn,
            this.saldoDataGridViewTextBoxColumn});
            this.reportView.DataSource = this.laporanBarangExtendedBindingSource;
            this.reportView.Location = new System.Drawing.Point(11, 86);
            this.reportView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportView.Name = "reportView";
            this.reportView.RowTemplate.Height = 28;
            this.reportView.Size = new System.Drawing.Size(622, 257);
            this.reportView.TabIndex = 9;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idkategoriDataGridViewTextBoxColumn
            // 
            this.idkategoriDataGridViewTextBoxColumn.DataPropertyName = "idkategori";
            this.idkategoriDataGridViewTextBoxColumn.HeaderText = "idkategori";
            this.idkategoriDataGridViewTextBoxColumn.Name = "idkategoriDataGridViewTextBoxColumn";
            this.idkategoriDataGridViewTextBoxColumn.ReadOnly = true;
            this.idkategoriDataGridViewTextBoxColumn.Visible = false;
            // 
            // namakategoriDataGridViewTextBoxColumn
            // 
            this.namakategoriDataGridViewTextBoxColumn.DataPropertyName = "nama_kategori";
            this.namakategoriDataGridViewTextBoxColumn.HeaderText = "Nama Kategori";
            this.namakategoriDataGridViewTextBoxColumn.Name = "namakategoriDataGridViewTextBoxColumn";
            this.namakategoriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namabarangDataGridViewTextBoxColumn
            // 
            this.namabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang";
            this.namabarangDataGridViewTextBoxColumn.Name = "namabarangDataGridViewTextBoxColumn";
            this.namabarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // satuanDataGridViewTextBoxColumn
            // 
            this.satuanDataGridViewTextBoxColumn.DataPropertyName = "satuan";
            this.satuanDataGridViewTextBoxColumn.HeaderText = "Satuan";
            this.satuanDataGridViewTextBoxColumn.Name = "satuanDataGridViewTextBoxColumn";
            this.satuanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokAwalDataGridViewTextBoxColumn
            // 
            this.stokAwalDataGridViewTextBoxColumn.DataPropertyName = "stokAwal";
            this.stokAwalDataGridViewTextBoxColumn.HeaderText = "Stok Awal";
            this.stokAwalDataGridViewTextBoxColumn.Name = "stokAwalDataGridViewTextBoxColumn";
            this.stokAwalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokmasukDataGridViewTextBoxColumn
            // 
            this.stokmasukDataGridViewTextBoxColumn.DataPropertyName = "stokmasuk";
            this.stokmasukDataGridViewTextBoxColumn.HeaderText = "Stok Masuk";
            this.stokmasukDataGridViewTextBoxColumn.Name = "stokmasukDataGridViewTextBoxColumn";
            this.stokmasukDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokkeluarDataGridViewTextBoxColumn
            // 
            this.stokkeluarDataGridViewTextBoxColumn.DataPropertyName = "stokkeluar";
            this.stokkeluarDataGridViewTextBoxColumn.HeaderText = "Stok Keluar";
            this.stokkeluarDataGridViewTextBoxColumn.Name = "stokkeluarDataGridViewTextBoxColumn";
            this.stokkeluarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stoksaldoDataGridViewTextBoxColumn
            // 
            this.stoksaldoDataGridViewTextBoxColumn.DataPropertyName = "stoksaldo";
            this.stoksaldoDataGridViewTextBoxColumn.HeaderText = "Saldo Stok";
            this.stoksaldoDataGridViewTextBoxColumn.Name = "stoksaldoDataGridViewTextBoxColumn";
            this.stoksaldoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hargaSatuanDataGridViewTextBoxColumn
            // 
            this.hargaSatuanDataGridViewTextBoxColumn.DataPropertyName = "hargaSatuan";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = "0";
            this.hargaSatuanDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.hargaSatuanDataGridViewTextBoxColumn.HeaderText = "Harga Satuan";
            this.hargaSatuanDataGridViewTextBoxColumn.Name = "hargaSatuanDataGridViewTextBoxColumn";
            this.hargaSatuanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saldoAwalDataGridViewTextBoxColumn
            // 
            this.saldoAwalDataGridViewTextBoxColumn.DataPropertyName = "saldoAwal";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            this.saldoAwalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.saldoAwalDataGridViewTextBoxColumn.HeaderText = "Saldo Awal";
            this.saldoAwalDataGridViewTextBoxColumn.Name = "saldoAwalDataGridViewTextBoxColumn";
            this.saldoAwalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jumlahhrgbeliDataGridViewTextBoxColumn
            // 
            this.jumlahhrgbeliDataGridViewTextBoxColumn.DataPropertyName = "jumlahhrgbeli";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0";
            this.jumlahhrgbeliDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.jumlahhrgbeliDataGridViewTextBoxColumn.HeaderText = "Jumlah Harga Beli";
            this.jumlahhrgbeliDataGridViewTextBoxColumn.Name = "jumlahhrgbeliDataGridViewTextBoxColumn";
            this.jumlahhrgbeliDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jumlahhrgpakaiDataGridViewTextBoxColumn
            // 
            this.jumlahhrgpakaiDataGridViewTextBoxColumn.DataPropertyName = "jumlahhrgpakai";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = "0";
            this.jumlahhrgpakaiDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.jumlahhrgpakaiDataGridViewTextBoxColumn.HeaderText = "Jumlah Harga Pakai";
            this.jumlahhrgpakaiDataGridViewTextBoxColumn.Name = "jumlahhrgpakaiDataGridViewTextBoxColumn";
            this.jumlahhrgpakaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            this.saldoDataGridViewTextBoxColumn.DataPropertyName = "saldo";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = "0";
            this.saldoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.saldoDataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            this.saldoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // laporanBarangExtendedBindingSource
            // 
            this.laporanBarangExtendedBindingSource.DataSource = typeof(MerapiGolfLogistik.Models.LaporanBarangExtended);
            // 
            // cetakLaporanBtn
            // 
            this.cetakLaporanBtn.Image = ((System.Drawing.Image)(resources.GetObject("cetakLaporanBtn.Image")));
            this.cetakLaporanBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cetakLaporanBtn.Location = new System.Drawing.Point(316, 55);
            this.cetakLaporanBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cetakLaporanBtn.Name = "cetakLaporanBtn";
            this.cetakLaporanBtn.Size = new System.Drawing.Size(96, 27);
            this.cetakLaporanBtn.TabIndex = 10;
            this.cetakLaporanBtn.Text = "Cetak Laporan";
            this.cetakLaporanBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cetakLaporanBtn.UseVisualStyleBackColor = true;
            this.cetakLaporanBtn.Click += new System.EventHandler(this.cetakLaporanBtn_Click);
            // 
            // cetakLaporanPerKategoriBtn
            // 
            this.cetakLaporanPerKategoriBtn.Image = ((System.Drawing.Image)(resources.GetObject("cetakLaporanPerKategoriBtn.Image")));
            this.cetakLaporanPerKategoriBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cetakLaporanPerKategoriBtn.Location = new System.Drawing.Point(416, 55);
            this.cetakLaporanPerKategoriBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cetakLaporanPerKategoriBtn.Name = "cetakLaporanPerKategoriBtn";
            this.cetakLaporanPerKategoriBtn.Size = new System.Drawing.Size(160, 27);
            this.cetakLaporanPerKategoriBtn.TabIndex = 11;
            this.cetakLaporanPerKategoriBtn.Text = "Cetak Laporan per Kategori";
            this.cetakLaporanPerKategoriBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cetakLaporanPerKategoriBtn.UseVisualStyleBackColor = true;
            // 
            // LaporanGudang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 351);
            this.Controls.Add(this.cetakLaporanPerKategoriBtn);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LaporanGudang";
            this.Text = "Laporan Gudang - Merapi Golf Inventory";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LaporanGudang_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.reportView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanBarangExtendedBindingSource)).EndInit();
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
        private System.Windows.Forms.Button cetakLaporanPerKategoriBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namakategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokAwalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokmasukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokkeluarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoksaldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaSatuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoAwalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahhrgbeliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahhrgpakaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
    }
}