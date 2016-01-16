namespace MerapiGolfLogistik
{
    partial class PilihBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PilihBarang));
            this.queryTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.barangList = new System.Windows.Forms.DataGridView();
            this.idbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokBarangTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satuanLabel = new System.Windows.Forms.Label();
            this.jumlahTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hargaSatuanTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.namaBarangTb = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalHargaLabel = new System.Windows.Forms.Label();
            this.tambahBarangBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.barangList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBarangTotalBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // queryTb
            // 
            this.queryTb.Location = new System.Drawing.Point(117, 12);
            this.queryTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queryTb.Name = "queryTb";
            this.queryTb.Size = new System.Drawing.Size(319, 26);
            this.queryTb.TabIndex = 0;
            this.queryTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.queryTb_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cari Barang";
            // 
            // searchBtn
            // 
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.Location = new System.Drawing.Point(442, 8);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(99, 34);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Cari (F2)";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // barangList
            // 
            this.barangList.AutoGenerateColumns = false;
            this.barangList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.barangList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbarangDataGridViewTextBoxColumn,
            this.namabarangDataGridViewTextBoxColumn,
            this.stokDataGridViewTextBoxColumn,
            this.stok});
            this.barangList.DataSource = this.stokBarangTotalBindingSource;
            this.barangList.Location = new System.Drawing.Point(16, 58);
            this.barangList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barangList.Name = "barangList";
            this.barangList.RowTemplate.Height = 28;
            this.barangList.Size = new System.Drawing.Size(525, 372);
            this.barangList.TabIndex = 3;
            this.barangList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.barangList_CellDoubleClick);
            // 
            // idbarangDataGridViewTextBoxColumn
            // 
            this.idbarangDataGridViewTextBoxColumn.DataPropertyName = "id_barang";
            this.idbarangDataGridViewTextBoxColumn.HeaderText = "id_barang";
            this.idbarangDataGridViewTextBoxColumn.Name = "idbarangDataGridViewTextBoxColumn";
            this.idbarangDataGridViewTextBoxColumn.ReadOnly = true;
            this.idbarangDataGridViewTextBoxColumn.Visible = false;
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
            this.stokDataGridViewTextBoxColumn.HeaderText = "Stok";
            this.stokDataGridViewTextBoxColumn.Name = "stokDataGridViewTextBoxColumn";
            this.stokDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stok
            // 
            this.stok.DataPropertyName = "satuan";
            this.stok.HeaderText = "Satuan";
            this.stok.Name = "stok";
            // 
            // stokBarangTotalBindingSource
            // 
            this.stokBarangTotalBindingSource.DataSource = typeof(MerapiGolfLogistik.StokBarangTotal);
            // 
            // satuanLabel
            // 
            this.satuanLabel.AutoSize = true;
            this.satuanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satuanLabel.Location = new System.Drawing.Point(448, 32);
            this.satuanLabel.Name = "satuanLabel";
            this.satuanLabel.Size = new System.Drawing.Size(77, 20);
            this.satuanLabel.TabIndex = 7;
            this.satuanLabel.Text = "[Satuan]";
            // 
            // jumlahTb
            // 
            this.jumlahTb.Location = new System.Drawing.Point(382, 30);
            this.jumlahTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jumlahTb.Name = "jumlahTb";
            this.jumlahTb.Size = new System.Drawing.Size(52, 26);
            this.jumlahTb.TabIndex = 6;
            this.jumlahTb.TextChanged += new System.EventHandler(this.jumlahTb_TextChanged);
            this.jumlahTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.jumlahTb_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Harga Satuan:";
            // 
            // hargaSatuanTb
            // 
            this.hargaSatuanTb.Location = new System.Drawing.Point(382, 64);
            this.hargaSatuanTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hargaSatuanTb.Name = "hargaSatuanTb";
            this.hargaSatuanTb.Size = new System.Drawing.Size(144, 26);
            this.hargaSatuanTb.TabIndex = 8;
            this.hargaSatuanTb.TextChanged += new System.EventHandler(this.hargaSatuanTb_TextChanged);
            this.hargaSatuanTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hargaSatuanTb_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(206, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Jumlah:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(206, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Harga:";
            // 
            // namaBarangTb
            // 
            this.namaBarangTb.AutoSize = true;
            this.namaBarangTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaBarangTb.Location = new System.Drawing.Point(6, 32);
            this.namaBarangTb.Name = "namaBarangTb";
            this.namaBarangTb.Size = new System.Drawing.Size(177, 20);
            this.namaBarangTb.TabIndex = 5;
            this.namaBarangTb.Text = "[Pilih Barang Dahulu]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalHargaLabel);
            this.groupBox1.Controls.Add(this.namaBarangTb);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.hargaSatuanTb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.jumlahTb);
            this.groupBox1.Controls.Add(this.satuanLabel);
            this.groupBox1.Location = new System.Drawing.Point(16, 448);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(533, 141);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barang Terpilih";
            this.groupBox1.Visible = false;
            // 
            // totalHargaLabel
            // 
            this.totalHargaLabel.AutoSize = true;
            this.totalHargaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHargaLabel.Location = new System.Drawing.Point(378, 101);
            this.totalHargaLabel.Name = "totalHargaLabel";
            this.totalHargaLabel.Size = new System.Drawing.Size(52, 20);
            this.totalHargaLabel.TabIndex = 12;
            this.totalHargaLabel.Text = "Rp 0;";
            // 
            // tambahBarangBtn
            // 
            this.tambahBarangBtn.Image = ((System.Drawing.Image)(resources.GetObject("tambahBarangBtn.Image")));
            this.tambahBarangBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tambahBarangBtn.Location = new System.Drawing.Point(354, 599);
            this.tambahBarangBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tambahBarangBtn.Name = "tambahBarangBtn";
            this.tambahBarangBtn.Size = new System.Drawing.Size(187, 40);
            this.tambahBarangBtn.TabIndex = 14;
            this.tambahBarangBtn.Text = "Tambah Barang (F5)";
            this.tambahBarangBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tambahBarangBtn.UseVisualStyleBackColor = true;
            this.tambahBarangBtn.Visible = false;
            this.tambahBarangBtn.Click += new System.EventHandler(this.tambahBarangBtn_Click);
            // 
            // PilihBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 648);
            this.Controls.Add(this.tambahBarangBtn);
            this.Controls.Add(this.barangList);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.queryTb);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PilihBarang";
            this.Text = "Pilih Barang - Merapi Golf Inventory";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PilihSupplier_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barangList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stokBarangTotalBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox queryTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView barangList;
        private System.Windows.Forms.BindingSource stokBarangTotalBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stok;
        private System.Windows.Forms.Label satuanLabel;
        private System.Windows.Forms.TextBox jumlahTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hargaSatuanTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label namaBarangTb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tambahBarangBtn;
        private System.Windows.Forms.Label totalHargaLabel;
    }
}