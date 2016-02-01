namespace MerapiGolfLogistik
{
    partial class TambahAktiva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahAktiva));
            this.label1 = new System.Windows.Forms.Label();
            this.namaTb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.keteranganTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.aktivaList = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.namaaktivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganaktivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aktivaList)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aktivaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Aktiva*";
            // 
            // namaTb
            // 
            this.namaTb.Location = new System.Drawing.Point(160, 35);
            this.namaTb.Name = "namaTb";
            this.namaTb.Size = new System.Drawing.Size(478, 26);
            this.namaTb.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.keteranganTb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.namaTb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 177);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambah Aktiva";
            // 
            // saveBtn
            // 
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Location = new System.Drawing.Point(509, 125);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(129, 34);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Simpan (F5)";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // keteranganTb
            // 
            this.keteranganTb.Location = new System.Drawing.Point(160, 80);
            this.keteranganTb.Name = "keteranganTb";
            this.keteranganTb.Size = new System.Drawing.Size(478, 26);
            this.keteranganTb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Keterangan";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.aktivaList);
            this.groupBox3.Location = new System.Drawing.Point(12, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(659, 303);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Daftar Aktiva";
            // 
            // aktivaList
            // 
            this.aktivaList.AutoGenerateColumns = false;
            this.aktivaList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aktivaList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.deleteColumn,
            this.namaaktivaDataGridViewTextBoxColumn,
            this.keteranganaktivaDataGridViewTextBoxColumn});
            this.aktivaList.DataSource = this.aktivaBindingSource;
            this.aktivaList.Location = new System.Drawing.Point(8, 28);
            this.aktivaList.Name = "aktivaList";
            this.aktivaList.RowTemplate.Height = 28;
            this.aktivaList.Size = new System.Drawing.Size(645, 263);
            this.aktivaList.TabIndex = 4;
            this.aktivaList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplierList_CellContentClick);
            this.aktivaList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplierList_CellContentDoubleClick);
            this.aktivaList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.aktivaList_KeyDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 510);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(683, 30);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(60, 25);
            this.statusLabel.Text = "Ready";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 24);
            this.progressBar.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // deleteColumn
            // 
            this.deleteColumn.HeaderText = "";
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.ReadOnly = true;
            this.deleteColumn.Text = "X";
            this.deleteColumn.UseColumnTextForButtonValue = true;
            this.deleteColumn.Width = 50;
            // 
            // namaaktivaDataGridViewTextBoxColumn
            // 
            this.namaaktivaDataGridViewTextBoxColumn.DataPropertyName = "nama_aktiva";
            this.namaaktivaDataGridViewTextBoxColumn.HeaderText = "Nama Aktiva";
            this.namaaktivaDataGridViewTextBoxColumn.Name = "namaaktivaDataGridViewTextBoxColumn";
            this.namaaktivaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keteranganaktivaDataGridViewTextBoxColumn
            // 
            this.keteranganaktivaDataGridViewTextBoxColumn.DataPropertyName = "keterangan_aktiva";
            this.keteranganaktivaDataGridViewTextBoxColumn.HeaderText = "Keterangan";
            this.keteranganaktivaDataGridViewTextBoxColumn.Name = "keteranganaktivaDataGridViewTextBoxColumn";
            this.keteranganaktivaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aktivaBindingSource
            // 
            this.aktivaBindingSource.DataSource = typeof(MerapiGolfLogistik.Aktiva);
            // 
            // TambahAktiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 540);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TambahAktiva";
            this.Text = "Tambah/Ubah Aktiva - Merapi Golf Inventory";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TambahSupplier_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aktivaList)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aktivaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namaTb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox keteranganTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView aktivaList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.BindingSource aktivaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaaktivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganaktivaDataGridViewTextBoxColumn;
    }
}