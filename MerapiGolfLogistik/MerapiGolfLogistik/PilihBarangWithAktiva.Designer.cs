namespace MerapiGolfLogistik
{
    partial class PilihBarangWithAktiva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PilihBarangWithAktiva));
            this.queryTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.barangList = new System.Windows.Forms.DataGridView();
            this.stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuanLabel = new System.Windows.Forms.Label();
            this.jumlahTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.namaBarangTb = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tambahBarangBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.aktivaTb = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pilihAktivaBtn = new System.Windows.Forms.Button();
            this.idbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokBarangTotalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barangList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stokBarangTotalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // queryTb
            // 
            this.queryTb.Location = new System.Drawing.Point(104, 10);
            this.queryTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queryTb.Name = "queryTb";
            this.queryTb.Size = new System.Drawing.Size(284, 22);
            this.queryTb.TabIndex = 0;
            this.queryTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.queryTb_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cari Barang";
            // 
            // searchBtn
            // 
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.Location = new System.Drawing.Point(393, 6);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(88, 27);
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
            this.barangList.Location = new System.Drawing.Point(14, 46);
            this.barangList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barangList.Name = "barangList";
            this.barangList.RowTemplate.Height = 28;
            this.barangList.Size = new System.Drawing.Size(467, 298);
            this.barangList.TabIndex = 3;
            this.barangList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.barangList_CellDoubleClick);
            // 
            // stok
            // 
            this.stok.DataPropertyName = "satuan";
            this.stok.HeaderText = "Satuan";
            this.stok.Name = "stok";
            // 
            // satuanLabel
            // 
            this.satuanLabel.AutoSize = true;
            this.satuanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satuanLabel.Location = new System.Drawing.Point(398, 26);
            this.satuanLabel.Name = "satuanLabel";
            this.satuanLabel.Size = new System.Drawing.Size(69, 17);
            this.satuanLabel.TabIndex = 7;
            this.satuanLabel.Text = "[Satuan]";
            // 
            // jumlahTb
            // 
            this.jumlahTb.Location = new System.Drawing.Point(340, 24);
            this.jumlahTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jumlahTb.Name = "jumlahTb";
            this.jumlahTb.Size = new System.Drawing.Size(47, 22);
            this.jumlahTb.TabIndex = 6;
            this.jumlahTb.TextChanged += new System.EventHandler(this.jumlahTb_TextChanged);
            this.jumlahTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.jumlahTb_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(183, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Jumlah:";
            // 
            // namaBarangTb
            // 
            this.namaBarangTb.AutoSize = true;
            this.namaBarangTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaBarangTb.Location = new System.Drawing.Point(5, 26);
            this.namaBarangTb.Name = "namaBarangTb";
            this.namaBarangTb.Size = new System.Drawing.Size(162, 17);
            this.namaBarangTb.TabIndex = 5;
            this.namaBarangTb.Text = "[Pilih Barang Dahulu]";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.namaBarangTb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.jumlahTb);
            this.groupBox1.Controls.Add(this.satuanLabel);
            this.groupBox1.Location = new System.Drawing.Point(14, 358);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(474, 56);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barang Terpilih";
            this.groupBox1.Visible = false;
            // 
            // tambahBarangBtn
            // 
            this.tambahBarangBtn.Image = ((System.Drawing.Image)(resources.GetObject("tambahBarangBtn.Image")));
            this.tambahBarangBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tambahBarangBtn.Location = new System.Drawing.Point(332, 487);
            this.tambahBarangBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tambahBarangBtn.Name = "tambahBarangBtn";
            this.tambahBarangBtn.Size = new System.Drawing.Size(156, 32);
            this.tambahBarangBtn.TabIndex = 14;
            this.tambahBarangBtn.Text = "Tambah Barang (F5)";
            this.tambahBarangBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tambahBarangBtn.UseVisualStyleBackColor = true;
            this.tambahBarangBtn.Visible = false;
            this.tambahBarangBtn.Click += new System.EventHandler(this.tambahBarangBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.aktivaTb);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.pilihAktivaBtn);
            this.groupBox2.Location = new System.Drawing.Point(14, 419);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 63);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilih Aktiva";
            this.groupBox2.Visible = false;
            // 
            // aktivaTb
            // 
            this.aktivaTb.AutoSize = true;
            this.aktivaTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aktivaTb.Location = new System.Drawing.Point(5, 25);
            this.aktivaTb.Name = "aktivaTb";
            this.aktivaTb.Size = new System.Drawing.Size(154, 17);
            this.aktivaTb.TabIndex = 13;
            this.aktivaTb.Text = "[Pilih Aktiva Dahulu]";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(342, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Daftar Aktiva";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pilihAktivaBtn
            // 
            this.pilihAktivaBtn.Image = ((System.Drawing.Image)(resources.GetObject("pilihAktivaBtn.Image")));
            this.pilihAktivaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pilihAktivaBtn.Location = new System.Drawing.Point(206, 17);
            this.pilihAktivaBtn.Name = "pilihAktivaBtn";
            this.pilihAktivaBtn.Size = new System.Drawing.Size(130, 32);
            this.pilihAktivaBtn.TabIndex = 0;
            this.pilihAktivaBtn.Text = "Pilih Aktiva (F3)";
            this.pilihAktivaBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.pilihAktivaBtn.UseVisualStyleBackColor = true;
            this.pilihAktivaBtn.Click += new System.EventHandler(this.pilihAktivaBtn_Click);
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
            // stokBarangTotalBindingSource
            // 
            this.stokBarangTotalBindingSource.DataSource = typeof(MerapiGolfLogistik.StokBarangTotal);
            // 
            // PilihBarangWithAktiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 530);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tambahBarangBtn);
            this.Controls.Add(this.barangList);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.queryTb);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PilihBarangWithAktiva";
            this.Text = "Pilih Barang Diambil - Merapi Golf Inventory";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PilihSupplier_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.barangList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stokBarangTotalBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label namaBarangTb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tambahBarangBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button pilihAktivaBtn;
        private System.Windows.Forms.Label aktivaTb;
    }
}