namespace MerapiGolfLogistik
{
    partial class PilihAktiva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PilihAktiva));
            this.label1 = new System.Windows.Forms.Label();
            this.catQuery = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.aktivaView = new System.Windows.Forms.DataGridView();
            this.aktivaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaaktivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganaktivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.aktivaView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktivaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cari Aktiva:";
            // 
            // catQuery
            // 
            this.catQuery.Location = new System.Drawing.Point(108, 7);
            this.catQuery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.catQuery.Name = "catQuery";
            this.catQuery.Size = new System.Drawing.Size(287, 22);
            this.catQuery.TabIndex = 1;
            this.catQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.catQuery_KeyDown);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(400, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cari (F2)";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aktivaView
            // 
            this.aktivaView.AllowUserToAddRows = false;
            this.aktivaView.AllowUserToDeleteRows = false;
            this.aktivaView.AllowUserToOrderColumns = true;
            this.aktivaView.AutoGenerateColumns = false;
            this.aktivaView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aktivaView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.namaaktivaDataGridViewTextBoxColumn,
            this.keteranganaktivaDataGridViewTextBoxColumn});
            this.aktivaView.DataSource = this.aktivaBindingSource;
            this.aktivaView.Location = new System.Drawing.Point(14, 43);
            this.aktivaView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aktivaView.Name = "aktivaView";
            this.aktivaView.ReadOnly = true;
            this.aktivaView.RowTemplate.Height = 28;
            this.aktivaView.Size = new System.Drawing.Size(482, 309);
            this.aktivaView.TabIndex = 3;
            this.aktivaView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.categoriesView_CellMouseDoubleClick);
            // 
            // aktivaBindingSource
            // 
            this.aktivaBindingSource.DataSource = typeof(MerapiGolfLogistik.Aktiva);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
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
            // PilihAktiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 362);
            this.Controls.Add(this.aktivaView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.catQuery);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PilihAktiva";
            this.Text = "Pilih Aktiva - Merapi Golf Inventory";
            this.Load += new System.EventHandler(this.PilihKategori_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PilihKategori_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.aktivaView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aktivaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox catQuery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView aktivaView;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaaktivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganaktivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource aktivaBindingSource;
    }
}