namespace MerapiGolfLogistik
{
    partial class PilihSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PilihSupplier));
            this.queryTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.supplierList = new System.Windows.Forms.DataGridView();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namasupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatsupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teleponsupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailsupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.supplierList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // queryTb
            // 
            this.queryTb.Location = new System.Drawing.Point(117, 12);
            this.queryTb.Name = "queryTb";
            this.queryTb.Size = new System.Drawing.Size(334, 26);
            this.queryTb.TabIndex = 0;
            this.queryTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.queryTb_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cari Supplier";
            // 
            // searchBtn
            // 
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.Location = new System.Drawing.Point(473, 8);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(99, 34);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Cari (F2)";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // supplierList
            // 
            this.supplierList.AutoGenerateColumns = false;
            this.supplierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.namasupplierDataGridViewTextBoxColumn,
            this.alamatsupplierDataGridViewTextBoxColumn,
            this.teleponsupplierDataGridViewTextBoxColumn,
            this.emailsupplierDataGridViewTextBoxColumn});
            this.supplierList.DataSource = this.supplierBindingSource;
            this.supplierList.Location = new System.Drawing.Point(16, 57);
            this.supplierList.Name = "supplierList";
            this.supplierList.RowTemplate.Height = 28;
            this.supplierList.Size = new System.Drawing.Size(556, 373);
            this.supplierList.TabIndex = 3;
            this.supplierList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplierList_CellDoubleClick);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(MerapiGolfLogistik.Supplier);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // namasupplierDataGridViewTextBoxColumn
            // 
            this.namasupplierDataGridViewTextBoxColumn.DataPropertyName = "nama_supplier";
            this.namasupplierDataGridViewTextBoxColumn.HeaderText = "Nama Supplier";
            this.namasupplierDataGridViewTextBoxColumn.Name = "namasupplierDataGridViewTextBoxColumn";
            this.namasupplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alamatsupplierDataGridViewTextBoxColumn
            // 
            this.alamatsupplierDataGridViewTextBoxColumn.DataPropertyName = "alamat_supplier";
            this.alamatsupplierDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatsupplierDataGridViewTextBoxColumn.Name = "alamatsupplierDataGridViewTextBoxColumn";
            this.alamatsupplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teleponsupplierDataGridViewTextBoxColumn
            // 
            this.teleponsupplierDataGridViewTextBoxColumn.DataPropertyName = "telepon_supplier";
            this.teleponsupplierDataGridViewTextBoxColumn.HeaderText = "No. Telepon";
            this.teleponsupplierDataGridViewTextBoxColumn.Name = "teleponsupplierDataGridViewTextBoxColumn";
            this.teleponsupplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailsupplierDataGridViewTextBoxColumn
            // 
            this.emailsupplierDataGridViewTextBoxColumn.DataPropertyName = "email_supplier";
            this.emailsupplierDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailsupplierDataGridViewTextBoxColumn.Name = "emailsupplierDataGridViewTextBoxColumn";
            this.emailsupplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PilihSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 442);
            this.Controls.Add(this.supplierList);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.queryTb);
            this.Name = "PilihSupplier";
            this.Text = "Pilih Supplier - Merapi Golf Inventory";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PilihSupplier_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.supplierList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox queryTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView supplierList;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namasupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatsupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teleponsupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailsupplierDataGridViewTextBoxColumn;
    }
}