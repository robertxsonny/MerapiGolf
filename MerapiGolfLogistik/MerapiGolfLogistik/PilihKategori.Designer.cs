namespace MerapiGolfLogistik
{
    partial class PilihKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PilihKategori));
            this.label1 = new System.Windows.Forms.Label();
            this.catQuery = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.categoriesView = new System.Windows.Forms.DataGridView();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Kategori:";
            // 
            // catQuery
            // 
            this.catQuery.Location = new System.Drawing.Point(122, 9);
            this.catQuery.Name = "catQuery";
            this.catQuery.Size = new System.Drawing.Size(355, 26);
            this.catQuery.TabIndex = 1;
            this.catQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.catQuery_KeyDown);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(483, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cari";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // categoriesView
            // 
            this.categoriesView.AllowUserToAddRows = false;
            this.categoriesView.AllowUserToDeleteRows = false;
            this.categoriesView.AllowUserToOrderColumns = true;
            this.categoriesView.AutoGenerateColumns = false;
            this.categoriesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.index,
            this.nama_kategori,
            this.stock});
            this.categoriesView.DataSource = this.categoryBindingSource;
            this.categoriesView.Location = new System.Drawing.Point(16, 54);
            this.categoriesView.Name = "categoriesView";
            this.categoriesView.ReadOnly = true;
            this.categoriesView.RowTemplate.Height = 28;
            this.categoriesView.Size = new System.Drawing.Size(542, 386);
            this.categoriesView.TabIndex = 3;
            this.categoriesView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.categoriesView_CellMouseDoubleClick);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(MerapiGolfLogistik.Models.CategoryView);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Kode";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // index
            // 
            this.index.DataPropertyName = "index";
            this.index.HeaderText = "Kode";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            // 
            // nama_kategori
            // 
            this.nama_kategori.DataPropertyName = "nama_kategori";
            this.nama_kategori.HeaderText = "Nama Kategori";
            this.nama_kategori.Name = "nama_kategori";
            this.nama_kategori.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "Jumlah Barang di Kategori Ini";
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // PilihKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 452);
            this.Controls.Add(this.categoriesView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.catQuery);
            this.Controls.Add(this.label1);
            this.Name = "PilihKategori";
            this.Text = "Pilih Kategori";
            this.Load += new System.EventHandler(this.PilihKategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox catQuery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView categoriesView;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
    }
}