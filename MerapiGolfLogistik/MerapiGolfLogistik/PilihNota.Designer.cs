namespace MerapiGolfLogistik
{
    partial class PilihNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PilihNota));
            this.searchNota = new System.Windows.Forms.Button();
            this.notaQuery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notaList = new System.Windows.Forms.DataGridView();
            this.nonotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namakaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaPengambilanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.notaList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaPengambilanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchNota
            // 
            this.searchNota.Image = ((System.Drawing.Image)(resources.GetObject("searchNota.Image")));
            this.searchNota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchNota.Location = new System.Drawing.Point(415, 12);
            this.searchNota.Margin = new System.Windows.Forms.Padding(2);
            this.searchNota.Name = "searchNota";
            this.searchNota.Size = new System.Drawing.Size(72, 25);
            this.searchNota.TabIndex = 5;
            this.searchNota.Text = "Cari (F2)";
            this.searchNota.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchNota.UseVisualStyleBackColor = true;
            this.searchNota.Click += new System.EventHandler(this.searchNota_Click);
            // 
            // notaQuery
            // 
            this.notaQuery.Location = new System.Drawing.Point(121, 15);
            this.notaQuery.Margin = new System.Windows.Forms.Padding(2);
            this.notaQuery.Name = "notaQuery";
            this.notaQuery.Size = new System.Drawing.Size(290, 20);
            this.notaQuery.TabIndex = 4;
            this.notaQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.notaQuery_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cari Nota Pembelian:";
            // 
            // notaList
            // 
            this.notaList.AllowUserToAddRows = false;
            this.notaList.AllowUserToDeleteRows = false;
            this.notaList.AllowUserToOrderColumns = true;
            this.notaList.AutoGenerateColumns = false;
            this.notaList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notaList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nonotaDataGridViewTextBoxColumn,
            this.namakaryawanDataGridViewTextBoxColumn,
            this.tanggalDataGridViewTextBoxColumn,
            this.keteranganDataGridViewTextBoxColumn});
            this.notaList.DataSource = this.notaPengambilanBindingSource;
            this.notaList.Location = new System.Drawing.Point(14, 50);
            this.notaList.Margin = new System.Windows.Forms.Padding(2);
            this.notaList.Name = "notaList";
            this.notaList.ReadOnly = true;
            this.notaList.RowTemplate.Height = 28;
            this.notaList.Size = new System.Drawing.Size(473, 251);
            this.notaList.TabIndex = 6;
            this.notaList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.notaList_CellDoubleClick);
            // 
            // nonotaDataGridViewTextBoxColumn
            // 
            this.nonotaDataGridViewTextBoxColumn.DataPropertyName = "no_nota";
            this.nonotaDataGridViewTextBoxColumn.HeaderText = "No. Nota";
            this.nonotaDataGridViewTextBoxColumn.Name = "nonotaDataGridViewTextBoxColumn";
            this.nonotaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namakaryawanDataGridViewTextBoxColumn
            // 
            this.namakaryawanDataGridViewTextBoxColumn.DataPropertyName = "nama_karyawan";
            this.namakaryawanDataGridViewTextBoxColumn.HeaderText = "Pengambil";
            this.namakaryawanDataGridViewTextBoxColumn.Name = "namakaryawanDataGridViewTextBoxColumn";
            this.namakaryawanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tanggalDataGridViewTextBoxColumn
            // 
            this.tanggalDataGridViewTextBoxColumn.DataPropertyName = "tanggal";
            this.tanggalDataGridViewTextBoxColumn.HeaderText = "Tanggal";
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
            // notaPengambilanBindingSource
            // 
            this.notaPengambilanBindingSource.DataSource = typeof(MerapiGolfLogistik.NotaPengambilan);
            // 
            // PilihNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 312);
            this.Controls.Add(this.notaList);
            this.Controls.Add(this.searchNota);
            this.Controls.Add(this.notaQuery);
            this.Controls.Add(this.label1);
            this.Name = "PilihNota";
            this.Text = "Pilih Nota - Merapi Golf Inventory";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PilihNota_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.notaList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notaPengambilanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchNota;
        private System.Windows.Forms.TextBox notaQuery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView notaList;
        private System.Windows.Forms.DataGridViewTextBoxColumn nonotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namakaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource notaPengambilanBindingSource;
    }
}