namespace MerapiGolfLogistik
{
    partial class LaporanKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaporanKategori));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dariTanggalTb = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.sampaiTanggalTb = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.kategoriTb = new System.Windows.Forms.Label();
            this.pilihKategoriBtn = new System.Windows.Forms.Button();
            this.hapusFilterBtn = new System.Windows.Forms.Button();
            this.reportView = new System.Windows.Forms.DataGridView();
            this.laporanKategoriModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cetakLaporanBtn = new System.Windows.Forms.Button();
            this.subsikategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namakategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subsibarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokmasukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokkeluarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sisastokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldomasukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldokeluarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sisasaldoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.reportView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanKategoriModelBindingSource)).BeginInit();
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
            this.subsikategoriDataGridViewTextBoxColumn,
            this.namakategoriDataGridViewTextBoxColumn,
            this.subsibarangDataGridViewTextBoxColumn,
            this.namabarangDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.stokmasukDataGridViewTextBoxColumn,
            this.stokkeluarDataGridViewTextBoxColumn,
            this.sisastokDataGridViewTextBoxColumn,
            this.saldoDataGridViewTextBoxColumn,
            this.saldomasukDataGridViewTextBoxColumn,
            this.saldokeluarDataGridViewTextBoxColumn,
            this.sisasaldoDataGridViewTextBoxColumn});
            this.reportView.DataSource = this.laporanKategoriModelBindingSource;
            this.reportView.Location = new System.Drawing.Point(16, 132);
            this.reportView.Name = "reportView";
            this.reportView.RowTemplate.Height = 28;
            this.reportView.Size = new System.Drawing.Size(933, 395);
            this.reportView.TabIndex = 9;
            // 
            // laporanKategoriModelBindingSource
            // 
            this.laporanKategoriModelBindingSource.DataSource = typeof(MerapiGolfLogistik.Models.LaporanKategoriModel);
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
            // subsikategoriDataGridViewTextBoxColumn
            // 
            this.subsikategoriDataGridViewTextBoxColumn.DataPropertyName = "subsi_kategori";
            this.subsikategoriDataGridViewTextBoxColumn.HeaderText = "Subsi Kategori";
            this.subsikategoriDataGridViewTextBoxColumn.Name = "subsikategoriDataGridViewTextBoxColumn";
            this.subsikategoriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namakategoriDataGridViewTextBoxColumn
            // 
            this.namakategoriDataGridViewTextBoxColumn.DataPropertyName = "nama_kategori";
            this.namakategoriDataGridViewTextBoxColumn.HeaderText = "Nama Kategori";
            this.namakategoriDataGridViewTextBoxColumn.Name = "namakategoriDataGridViewTextBoxColumn";
            this.namakategoriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subsibarangDataGridViewTextBoxColumn
            // 
            this.subsibarangDataGridViewTextBoxColumn.DataPropertyName = "subsi_barang";
            this.subsibarangDataGridViewTextBoxColumn.HeaderText = "Subsi Barang";
            this.subsibarangDataGridViewTextBoxColumn.Name = "subsibarangDataGridViewTextBoxColumn";
            this.subsibarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namabarangDataGridViewTextBoxColumn
            // 
            this.namabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang";
            this.namabarangDataGridViewTextBoxColumn.Name = "namabarangDataGridViewTextBoxColumn";
            this.namabarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokDataGridViewTextBoxColumn
            // 
            this.stokDataGridViewTextBoxColumn.DataPropertyName = "stok";
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok Awal";
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            this.stokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokmasukDataGridViewTextBoxColumn
            // 
            this.stokmasukDataGridViewTextBoxColumn.DataPropertyName = "stokmasuk";
            this.stokmasukDataGridViewTextBoxColumn.HeaderText = "Stok +";
            this.stokmasukDataGridViewTextBoxColumn.Name = "stokmasukDataGridViewTextBoxColumn";
            this.stokmasukDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokkeluarDataGridViewTextBoxColumn
            // 
            this.stokkeluarDataGridViewTextBoxColumn.DataPropertyName = "stokkeluar";
            this.stokkeluarDataGridViewTextBoxColumn.HeaderText = "Stok -";
            this.stokkeluarDataGridViewTextBoxColumn.Name = "stokkeluarDataGridViewTextBoxColumn";
            this.stokkeluarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sisastokDataGridViewTextBoxColumn
            // 
            this.sisastokDataGridViewTextBoxColumn.DataPropertyName = "sisastok";
            this.sisastokDataGridViewTextBoxColumn.HeaderText = "Stok Akhir";
            this.sisastokDataGridViewTextBoxColumn.Name = "sisastokDataGridViewTextBoxColumn";
            this.sisastokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            this.saldoDataGridViewTextBoxColumn.DataPropertyName = "saldo";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.saldoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.saldoDataGridViewTextBoxColumn.HeaderText = "Saldo Awal";
            this.saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            this.saldoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saldomasukDataGridViewTextBoxColumn
            // 
            this.saldomasukDataGridViewTextBoxColumn.DataPropertyName = "saldomasuk";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.saldomasukDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.saldomasukDataGridViewTextBoxColumn.HeaderText = "Saldo +";
            this.saldomasukDataGridViewTextBoxColumn.Name = "saldomasukDataGridViewTextBoxColumn";
            this.saldomasukDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saldokeluarDataGridViewTextBoxColumn
            // 
            this.saldokeluarDataGridViewTextBoxColumn.DataPropertyName = "saldokeluar";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.saldokeluarDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.saldokeluarDataGridViewTextBoxColumn.HeaderText = "Saldo -";
            this.saldokeluarDataGridViewTextBoxColumn.Name = "saldokeluarDataGridViewTextBoxColumn";
            this.saldokeluarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sisasaldoDataGridViewTextBoxColumn
            // 
            this.sisasaldoDataGridViewTextBoxColumn.DataPropertyName = "sisasaldo";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.sisasaldoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.sisasaldoDataGridViewTextBoxColumn.HeaderText = "Saldo Akhir";
            this.sisasaldoDataGridViewTextBoxColumn.Name = "sisasaldoDataGridViewTextBoxColumn";
            this.sisasaldoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LaporanKategori
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
            this.Name = "LaporanKategori";
            this.Text = "Laporan Barang per Kategori - Merapi Golf Inventory";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LaporanGudang_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.reportView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanKategoriModelBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource laporanKategoriModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn subsikategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namakategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subsibarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokmasukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokkeluarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sisastokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldomasukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldokeluarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sisasaldoDataGridViewTextBoxColumn;
    }
}