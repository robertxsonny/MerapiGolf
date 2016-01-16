namespace MerapiGolfLogistik
{
    partial class PengembalianBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PengembalianBarang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectedNotaTb = new System.Windows.Forms.Label();
            this.pilihNotaBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.noNotaTb = new System.Windows.Forms.TextBox();
            this.keteranganLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.keteranganTb = new System.Windows.Forms.TextBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.tambahBarangBtn = new System.Windows.Forms.Button();
            this.itemView = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.deleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pengembalianItemExtendedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pengambilanItemExtendedBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.totalPengambilanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pengambilanItemExtendedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pengembalianItemExtendedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengambilanItemExtendedBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPengambilanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengambilanItemExtendedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectedNotaTb);
            this.groupBox1.Controls.Add(this.pilihNotaBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.noNotaTb);
            this.groupBox1.Controls.Add(this.keteranganLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.keteranganTb);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(470, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // selectedNotaTb
            // 
            this.selectedNotaTb.AutoSize = true;
            this.selectedNotaTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedNotaTb.Location = new System.Drawing.Point(316, 14);
            this.selectedNotaTb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedNotaTb.Name = "selectedNotaTb";
            this.selectedNotaTb.Size = new System.Drawing.Size(140, 13);
            this.selectedNotaTb.TabIndex = 14;
            this.selectedNotaTb.Text = "[Belum ada nota dipilih]";
            // 
            // pilihNotaBtn
            // 
            this.pilihNotaBtn.Image = ((System.Drawing.Image)(resources.GetObject("pilihNotaBtn.Image")));
            this.pilihNotaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pilihNotaBtn.Location = new System.Drawing.Point(316, 39);
            this.pilihNotaBtn.Margin = new System.Windows.Forms.Padding(2);
            this.pilihNotaBtn.Name = "pilihNotaBtn";
            this.pilihNotaBtn.Size = new System.Drawing.Size(137, 25);
            this.pilihNotaBtn.TabIndex = 13;
            this.pilihNotaBtn.Text = "Pilih Nota (F1)";
            this.pilihNotaBtn.UseVisualStyleBackColor = true;
            this.pilihNotaBtn.Click += new System.EventHandler(this.pilihNotaBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "No. Nota\r\nPengambilan";
            // 
            // noNotaTb
            // 
            this.noNotaTb.Enabled = false;
            this.noNotaTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noNotaTb.Location = new System.Drawing.Point(64, 14);
            this.noNotaTb.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.noNotaTb.Name = "noNotaTb";
            this.noNotaTb.Size = new System.Drawing.Size(150, 38);
            this.noNotaTb.TabIndex = 11;
            this.noNotaTb.Text = "B-001";
            // 
            // keteranganLabel
            // 
            this.keteranganLabel.AutoSize = true;
            this.keteranganLabel.Location = new System.Drawing.Point(5, 63);
            this.keteranganLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.keteranganLabel.Name = "keteranganLabel";
            this.keteranganLabel.Size = new System.Drawing.Size(62, 13);
            this.keteranganLabel.TabIndex = 9;
            this.keteranganLabel.Text = "Keterangan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Nota";
            // 
            // keteranganTb
            // 
            this.keteranganTb.Location = new System.Drawing.Point(71, 63);
            this.keteranganTb.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.keteranganTb.Name = "keteranganTb";
            this.keteranganTb.Size = new System.Drawing.Size(143, 20);
            this.keteranganTb.TabIndex = 10;
            // 
            // resetBtn
            // 
            this.resetBtn.Image = ((System.Drawing.Image)(resources.GetObject("resetBtn.Image")));
            this.resetBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resetBtn.Location = new System.Drawing.Point(344, 116);
            this.resetBtn.Margin = new System.Windows.Forms.Padding(2);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(91, 58);
            this.resetBtn.TabIndex = 13;
            this.resetBtn.Text = "Ulangi (F5)";
            this.resetBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.Image = ((System.Drawing.Image)(resources.GetObject("printBtn.Image")));
            this.printBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.printBtn.Location = new System.Drawing.Point(249, 116);
            this.printBtn.Margin = new System.Windows.Forms.Padding(2);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(91, 58);
            this.printBtn.TabIndex = 12;
            this.printBtn.Text = "Cetak (F4)";
            this.printBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // simpanBtn
            // 
            this.simpanBtn.Image = ((System.Drawing.Image)(resources.GetObject("simpanBtn.Image")));
            this.simpanBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.simpanBtn.Location = new System.Drawing.Point(154, 116);
            this.simpanBtn.Margin = new System.Windows.Forms.Padding(2);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(91, 58);
            this.simpanBtn.TabIndex = 11;
            this.simpanBtn.Text = "Simpan (F3)";
            this.simpanBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.simpanBtn.UseVisualStyleBackColor = true;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // tambahBarangBtn
            // 
            this.tambahBarangBtn.Image = ((System.Drawing.Image)(resources.GetObject("tambahBarangBtn.Image")));
            this.tambahBarangBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tambahBarangBtn.Location = new System.Drawing.Point(59, 116);
            this.tambahBarangBtn.Margin = new System.Windows.Forms.Padding(2);
            this.tambahBarangBtn.Name = "tambahBarangBtn";
            this.tambahBarangBtn.Size = new System.Drawing.Size(91, 58);
            this.tambahBarangBtn.TabIndex = 10;
            this.tambahBarangBtn.Text = "Tambah Barang (F2)";
            this.tambahBarangBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tambahBarangBtn.UseVisualStyleBackColor = true;
            this.tambahBarangBtn.Click += new System.EventHandler(this.tambahBarangBtn_Click);
            // 
            // itemView
            // 
            this.itemView.AutoGenerateColumns = false;
            this.itemView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deleteCol,
            this.id,
            this.namabarangDataGridViewTextBoxColumn,
            this.jumlah,
            this.satuanDataGridViewTextBoxColumn});
            this.itemView.DataSource = this.pengembalianItemExtendedBindingSource;
            this.itemView.Location = new System.Drawing.Point(11, 179);
            this.itemView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.itemView.Name = "itemView";
            this.itemView.RowTemplate.Height = 24;
            this.itemView.Size = new System.Drawing.Size(470, 167);
            this.itemView.TabIndex = 14;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 355);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(494, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(75, 16);
            this.progressBar.Visible = false;
            // 
            // deleteCol
            // 
            this.deleteCol.HeaderText = "";
            this.deleteCol.Name = "deleteCol";
            this.deleteCol.ReadOnly = true;
            this.deleteCol.Text = "X";
            this.deleteCol.UseColumnTextForButtonValue = true;
            this.deleteCol.Width = 50;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // jumlah
            // 
            this.jumlah.DataPropertyName = "jumlah";
            this.jumlah.HeaderText = "Jumlah";
            this.jumlah.Name = "jumlah";
            this.jumlah.ReadOnly = true;
            // 
            // namabarangDataGridViewTextBoxColumn
            // 
            this.namabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang";
            this.namabarangDataGridViewTextBoxColumn.Name = "namabarangDataGridViewTextBoxColumn";
            // 
            // satuanDataGridViewTextBoxColumn
            // 
            this.satuanDataGridViewTextBoxColumn.DataPropertyName = "satuan";
            this.satuanDataGridViewTextBoxColumn.HeaderText = "Satuan";
            this.satuanDataGridViewTextBoxColumn.Name = "satuanDataGridViewTextBoxColumn";
            // 
            // pengembalianItemExtendedBindingSource
            // 
            this.pengembalianItemExtendedBindingSource.DataSource = typeof(MerapiGolfLogistik.Models.PengembalianItemExtended);
            // 
            // pengambilanItemExtendedBindingSource1
            // 
            this.pengambilanItemExtendedBindingSource1.DataSource = typeof(MerapiGolfLogistik.Models.PengambilanItemExtended);
            // 
            // totalPengambilanBindingSource
            // 
            this.totalPengambilanBindingSource.DataSource = typeof(MerapiGolfLogistik.TotalPengambilan);
            // 
            // pengambilanItemExtendedBindingSource
            // 
            this.pengambilanItemExtendedBindingSource.DataSource = typeof(MerapiGolfLogistik.Models.PengambilanItemExtended);
            // 
            // PengembalianBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 377);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.itemView);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.simpanBtn);
            this.Controls.Add(this.tambahBarangBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "PengembalianBarang";
            this.Text = "Pengembalian Barang - Merapi Golf Inventory";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PengembalianBarang_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pengembalianItemExtendedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengambilanItemExtendedBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalPengambilanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengambilanItemExtendedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox noNotaTb;
        private System.Windows.Forms.Label keteranganLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keteranganTb;
        private System.Windows.Forms.Label selectedNotaTb;
        private System.Windows.Forms.Button pilihNotaBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.Button tambahBarangBtn;
        private System.Windows.Forms.DataGridView itemView;
        private System.Windows.Forms.BindingSource totalPengambilanBindingSource;
        private System.Windows.Forms.BindingSource pengambilanItemExtendedBindingSource1;
        private System.Windows.Forms.BindingSource pengambilanItemExtendedBindingSource;
        private System.Windows.Forms.BindingSource pengembalianItemExtendedBindingSource;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteCol;
    }
}