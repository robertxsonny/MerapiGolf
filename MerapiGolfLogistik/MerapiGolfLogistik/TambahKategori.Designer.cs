namespace MerapiGolfLogistik
{
    partial class TambahKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TambahKategori));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.categoryList = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.namakategoriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.namaTb = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryViewBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(12, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(659, 277);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Daftar Kategori";
            // 
            // categoryList
            // 
            this.categoryList.AutoGenerateColumns = false;
            this.categoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.deleteColumn,
            this.namakategoriDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.categoryList.DataSource = this.categoryViewBindingSource;
            this.categoryList.Location = new System.Drawing.Point(20, 195);
            this.categoryList.Name = "categoryList";
            this.categoryList.RowTemplate.Height = 28;
            this.categoryList.Size = new System.Drawing.Size(645, 319);
            this.categoryList.TabIndex = 4;
            this.categoryList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplierList_CellContentClick);
            this.categoryList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplierList_CellContentDoubleClick);
            this.categoryList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.categoryList_KeyDown);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
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
            // namakategoriDataGridViewTextBoxColumn
            // 
            this.namakategoriDataGridViewTextBoxColumn.DataPropertyName = "nama_kategori";
            this.namakategoriDataGridViewTextBoxColumn.HeaderText = "Nama Kategori";
            this.namakategoriDataGridViewTextBoxColumn.Name = "namakategoriDataGridViewTextBoxColumn";
            this.namakategoriDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Jumlah Barang di Kategori";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryViewBindingSource
            // 
            this.categoryViewBindingSource.DataSource = typeof(MerapiGolfLogistik.Models.CategoryView);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.progressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Kategori*";
            // 
            // namaTb
            // 
            this.namaTb.Location = new System.Drawing.Point(160, 71);
            this.namaTb.Name = "namaTb";
            this.namaTb.Size = new System.Drawing.Size(478, 26);
            this.namaTb.TabIndex = 1;
            // 
            // saveBtn
            // 
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Location = new System.Drawing.Point(509, 112);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(129, 34);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Simpan (F5)";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.namaTb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 155);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambah Kategori";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(478, 26);
            this.textBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kode Kategori";
            // 
            // TambahKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 558);
            this.Controls.Add(this.categoryList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TambahKategori";
            this.Text = "Tambah/Ubah Kategori - Merapi Golf Inventory";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TambahSupplier_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.categoryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryViewBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView categoryList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namaTb;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namakategoriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoryViewBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}