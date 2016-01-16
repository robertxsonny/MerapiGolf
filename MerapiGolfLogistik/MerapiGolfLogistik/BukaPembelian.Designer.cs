namespace MerapiGolfLogistik
{
    partial class BukaPembelian
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
            this.label1 = new System.Windows.Forms.Label();
            this.filterCari = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dariTanggalTb = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.sampaiTanggalTb = new System.Windows.Forms.DateTimePicker();
            this.pembelianView = new System.Windows.Forms.DataGridView();
            this.semuaPembelianCb = new System.Windows.Forms.CheckBox();
            this.pembelianExtendedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isFinishedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pembelianView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembelianExtendedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter Pencarian";
            // 
            // filterCari
            // 
            this.filterCari.FormattingEnabled = true;
            this.filterCari.Items.AddRange(new object[] {
            "Semua Pembelian",
            "Pembelian Tanpa Harga"});
            this.filterCari.Location = new System.Drawing.Point(153, 10);
            this.filterCari.Name = "filterCari";
            this.filterCari.Size = new System.Drawing.Size(533, 28);
            this.filterCari.TabIndex = 1;
            this.filterCari.SelectedIndexChanged += new System.EventHandler(this.filterCari_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dari Tanggal";
            // 
            // dariTanggalTb
            // 
            this.dariTanggalTb.Location = new System.Drawing.Point(153, 53);
            this.dariTanggalTb.Name = "dariTanggalTb";
            this.dariTanggalTb.Size = new System.Drawing.Size(533, 26);
            this.dariTanggalTb.TabIndex = 3;
            this.dariTanggalTb.ValueChanged += new System.EventHandler(this.dariTanggalTb_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sampai Tanggal";
            // 
            // sampaiTanggalTb
            // 
            this.sampaiTanggalTb.Location = new System.Drawing.Point(153, 98);
            this.sampaiTanggalTb.Name = "sampaiTanggalTb";
            this.sampaiTanggalTb.Size = new System.Drawing.Size(533, 26);
            this.sampaiTanggalTb.TabIndex = 5;
            this.sampaiTanggalTb.ValueChanged += new System.EventHandler(this.sampaiTanggalTb_ValueChanged);
            // 
            // pembelianView
            // 
            this.pembelianView.AutoGenerateColumns = false;
            this.pembelianView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pembelianView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn,
            this.keteranganDataGridViewTextBoxColumn,
            this.isFinishedDataGridViewCheckBoxColumn});
            this.pembelianView.DataSource = this.pembelianExtendedBindingSource;
            this.pembelianView.Location = new System.Drawing.Point(21, 173);
            this.pembelianView.Name = "pembelianView";
            this.pembelianView.RowTemplate.Height = 28;
            this.pembelianView.Size = new System.Drawing.Size(665, 363);
            this.pembelianView.TabIndex = 6;
            this.pembelianView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pembelianView_CellContentDoubleClick);
            this.pembelianView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pembelianView_KeyDown);
            // 
            // semuaPembelianCb
            // 
            this.semuaPembelianCb.AutoSize = true;
            this.semuaPembelianCb.Location = new System.Drawing.Point(153, 138);
            this.semuaPembelianCb.Name = "semuaPembelianCb";
            this.semuaPembelianCb.Size = new System.Drawing.Size(343, 24);
            this.semuaPembelianCb.TabIndex = 7;
            this.semuaPembelianCb.Text = "Tampilkan Pembelian Tak Terbatas Tanggal";
            this.semuaPembelianCb.UseVisualStyleBackColor = true;
            this.semuaPembelianCb.CheckedChanged += new System.EventHandler(this.semuaPembelianCb_CheckedChanged);
            // 
            // pembelianExtendedBindingSource
            // 
            this.pembelianExtendedBindingSource.DataSource = typeof(MerapiGolfLogistik.Models.PembelianExtended);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "No. Nota";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.useridDataGridViewTextBoxColumn.HeaderText = "User";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "tanggal";
            this.tanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal Pembelian";
            this.tanggalDataGridViewTextBoxColumn.Name = "tanggalDataGridViewTextBoxColumn";
            this.tanggalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keteranganDataGridViewTextBoxColumn
            // 
            this.keteranganDataGridViewTextBoxColumn.DataPropertyName = "keterangan";
            this.keteranganDataGridViewTextBoxColumn.HeaderText = "Keterangan";
            this.keteranganDataGridViewTextBoxColumn.Name = "keteranganDataGridViewTextBoxColumn";
            this.keteranganDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isFinishedDataGridViewCheckBoxColumn
            // 
            this.isFinishedDataGridViewCheckBoxColumn.DataPropertyName = "IsFinished";
            this.isFinishedDataGridViewCheckBoxColumn.HeaderText = "Harga Sudah Dimasukkan";
            this.isFinishedDataGridViewCheckBoxColumn.Name = "isFinishedDataGridViewCheckBoxColumn";
            this.isFinishedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // BukaPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 548);
            this.Controls.Add(this.semuaPembelianCb);
            this.Controls.Add(this.pembelianView);
            this.Controls.Add(this.sampaiTanggalTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dariTanggalTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterCari);
            this.Controls.Add(this.label1);
            this.Name = "BukaPembelian";
            this.Text = "Buka Pembelian - Merapi Golf Inventory";
            this.Load += new System.EventHandler(this.BukaPembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pembelianView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembelianExtendedBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filterCari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dariTanggalTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker sampaiTanggalTb;
        private System.Windows.Forms.DataGridView pembelianView;
        private System.Windows.Forms.BindingSource pembelianExtendedBindingSource;
        private System.Windows.Forms.CheckBox semuaPembelianCb;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isFinishedDataGridViewCheckBoxColumn;
    }
}