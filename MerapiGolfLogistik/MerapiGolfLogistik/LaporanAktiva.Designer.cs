namespace MerapiGolfLogistik
{
    partial class LaporanAktiva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaporanAktiva));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dariTanggalTb = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.sampaiTanggalTb = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.aktivaTb = new System.Windows.Forms.Label();
            this.pilihAktivaBtn = new System.Windows.Forms.Button();
            this.hapusFilterBtn = new System.Windows.Forms.Button();
            this.reportView = new System.Windows.Forms.DataGridView();
            this.cetakLaporanBtn = new System.Windows.Forms.Button();
            this.nama_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_per_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaaktivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahdiambilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargapembelianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokawalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokakhirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoawalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoakhirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laporanAktivaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reportView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanAktivaModelBindingSource)).BeginInit();
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
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pilih Aktiva";
            // 
            // aktivaTb
            // 
            this.aktivaTb.AutoSize = true;
            this.aktivaTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aktivaTb.Location = new System.Drawing.Point(124, 48);
            this.aktivaTb.Name = "aktivaTb";
            this.aktivaTb.Size = new System.Drawing.Size(207, 20);
            this.aktivaTb.TabIndex = 6;
            this.aktivaTb.Text = "[Belum ada aktiva dipilih]";
            // 
            // pilihAktivaBtn
            // 
            this.pilihAktivaBtn.Image = ((System.Drawing.Image)(resources.GetObject("pilihAktivaBtn.Image")));
            this.pilihAktivaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pilihAktivaBtn.Location = new System.Drawing.Point(252, 84);
            this.pilihAktivaBtn.Name = "pilihAktivaBtn";
            this.pilihAktivaBtn.Size = new System.Drawing.Size(176, 42);
            this.pilihAktivaBtn.TabIndex = 7;
            this.pilihAktivaBtn.Text = "Pilih Aktiva (F1)";
            this.pilihAktivaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pilihAktivaBtn.UseVisualStyleBackColor = true;
            this.pilihAktivaBtn.Click += new System.EventHandler(this.pilihKategoriBtn_Click);
            // 
            // hapusFilterBtn
            // 
            this.hapusFilterBtn.Image = ((System.Drawing.Image)(resources.GetObject("hapusFilterBtn.Image")));
            this.hapusFilterBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hapusFilterBtn.Location = new System.Drawing.Point(433, 84);
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
            this.namaaktivaDataGridViewTextBoxColumn,
            this.nama_barang,
            this.jumlahdiambilDataGridViewTextBoxColumn,
            this.hargapembelianDataGridViewTextBoxColumn,
            this.harga_per_unit,
            this.stokawalDataGridViewTextBoxColumn,
            this.stokakhirDataGridViewTextBoxColumn,
            this.saldoawalDataGridViewTextBoxColumn,
            this.saldoakhirDataGridViewTextBoxColumn});
            this.reportView.DataSource = this.laporanAktivaModelBindingSource;
            this.reportView.Location = new System.Drawing.Point(16, 132);
            this.reportView.Name = "reportView";
            this.reportView.RowTemplate.Height = 28;
            this.reportView.Size = new System.Drawing.Size(933, 395);
            this.reportView.TabIndex = 9;
            // 
            // cetakLaporanBtn
            // 
            this.cetakLaporanBtn.Image = ((System.Drawing.Image)(resources.GetObject("cetakLaporanBtn.Image")));
            this.cetakLaporanBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cetakLaporanBtn.Location = new System.Drawing.Point(597, 84);
            this.cetakLaporanBtn.Name = "cetakLaporanBtn";
            this.cetakLaporanBtn.Size = new System.Drawing.Size(144, 42);
            this.cetakLaporanBtn.TabIndex = 10;
            this.cetakLaporanBtn.Text = "Cetak Laporan";
            this.cetakLaporanBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cetakLaporanBtn.UseVisualStyleBackColor = true;
            this.cetakLaporanBtn.Click += new System.EventHandler(this.cetakLaporanBtn_Click);
            // 
            // nama_barang
            // 
            this.nama_barang.DataPropertyName = "nama_barang";
            this.nama_barang.HeaderText = "Nama Barang";
            this.nama_barang.Name = "nama_barang";
            this.nama_barang.ReadOnly = true;
            // 
            // harga_per_unit
            // 
            this.harga_per_unit.DataPropertyName = "harga_per_unit";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.harga_per_unit.DefaultCellStyle = dataGridViewCellStyle2;
            this.harga_per_unit.HeaderText = "Harga per Unit";
            this.harga_per_unit.Name = "harga_per_unit";
            this.harga_per_unit.ReadOnly = true;
            // 
            // namaaktivaDataGridViewTextBoxColumn
            // 
            this.namaaktivaDataGridViewTextBoxColumn.DataPropertyName = "nama_aktiva";
            this.namaaktivaDataGridViewTextBoxColumn.HeaderText = "Nama Aktiva";
            this.namaaktivaDataGridViewTextBoxColumn.Name = "namaaktivaDataGridViewTextBoxColumn";
            this.namaaktivaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jumlahdiambilDataGridViewTextBoxColumn
            // 
            this.jumlahdiambilDataGridViewTextBoxColumn.DataPropertyName = "jumlah_diambil";
            this.jumlahdiambilDataGridViewTextBoxColumn.HeaderText = "Jumlah";
            this.jumlahdiambilDataGridViewTextBoxColumn.Name = "jumlahdiambilDataGridViewTextBoxColumn";
            this.jumlahdiambilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hargapembelianDataGridViewTextBoxColumn
            // 
            this.hargapembelianDataGridViewTextBoxColumn.DataPropertyName = "harga_pembelian";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.hargapembelianDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.hargapembelianDataGridViewTextBoxColumn.HeaderText = "Total Harga";
            this.hargapembelianDataGridViewTextBoxColumn.Name = "hargapembelianDataGridViewTextBoxColumn";
            this.hargapembelianDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokawalDataGridViewTextBoxColumn
            // 
            this.stokawalDataGridViewTextBoxColumn.DataPropertyName = "stokawal";
            this.stokawalDataGridViewTextBoxColumn.HeaderText = "Stok Awal";
            this.stokawalDataGridViewTextBoxColumn.Name = "stokawalDataGridViewTextBoxColumn";
            this.stokawalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stokakhirDataGridViewTextBoxColumn
            // 
            this.stokakhirDataGridViewTextBoxColumn.DataPropertyName = "stokakhir";
            this.stokakhirDataGridViewTextBoxColumn.HeaderText = "Stok Akhir";
            this.stokakhirDataGridViewTextBoxColumn.Name = "stokakhirDataGridViewTextBoxColumn";
            this.stokakhirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saldoawalDataGridViewTextBoxColumn
            // 
            this.saldoawalDataGridViewTextBoxColumn.DataPropertyName = "saldoawal";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.saldoawalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.saldoawalDataGridViewTextBoxColumn.HeaderText = "Saldo Awal";
            this.saldoawalDataGridViewTextBoxColumn.Name = "saldoawalDataGridViewTextBoxColumn";
            this.saldoawalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saldoakhirDataGridViewTextBoxColumn
            // 
            this.saldoakhirDataGridViewTextBoxColumn.DataPropertyName = "saldoakhir";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.saldoakhirDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.saldoakhirDataGridViewTextBoxColumn.HeaderText = "Saldo Akhir";
            this.saldoakhirDataGridViewTextBoxColumn.Name = "saldoakhirDataGridViewTextBoxColumn";
            this.saldoakhirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // laporanAktivaModelBindingSource
            // 
            this.laporanAktivaModelBindingSource.DataSource = typeof(MerapiGolfLogistik.Models.LaporanAktivaModel);
            // 
            // LaporanAktiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 540);
            this.Controls.Add(this.cetakLaporanBtn);
            this.Controls.Add(this.reportView);
            this.Controls.Add(this.hapusFilterBtn);
            this.Controls.Add(this.pilihAktivaBtn);
            this.Controls.Add(this.aktivaTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sampaiTanggalTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dariTanggalTb);
            this.Controls.Add(this.label1);
            this.Name = "LaporanAktiva";
            this.Text = "Laporan Pengeluaran per Aktiva - Merapi Golf Inventory";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LaporanGudang_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.reportView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laporanAktivaModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dariTanggalTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker sampaiTanggalTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label aktivaTb;
        private System.Windows.Forms.Button pilihAktivaBtn;
        private System.Windows.Forms.Button hapusFilterBtn;
        private System.Windows.Forms.DataGridView reportView;
        private System.Windows.Forms.Button cetakLaporanBtn;
        private System.Windows.Forms.BindingSource laporanAktivaModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaaktivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahdiambilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargapembelianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_per_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokawalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokakhirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoawalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoakhirDataGridViewTextBoxColumn;
    }
}