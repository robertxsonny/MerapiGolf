namespace MerapiGolfLogistik
{
    partial class Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.tambahBarangBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tambahStokBtn = new System.Windows.Forms.Button();
            this.pengambilanBarangBtn = new System.Windows.Forms.Button();
            this.laporanGudangBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tambahBarangBtn
            // 
            this.tambahBarangBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambahBarangBtn.Image = ((System.Drawing.Image)(resources.GetObject("tambahBarangBtn.Image")));
            this.tambahBarangBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tambahBarangBtn.Location = new System.Drawing.Point(12, 70);
            this.tambahBarangBtn.Name = "tambahBarangBtn";
            this.tambahBarangBtn.Size = new System.Drawing.Size(425, 57);
            this.tambahBarangBtn.TabIndex = 2;
            this.tambahBarangBtn.Text = "Tambah Jenis Barang Baru (F1)";
            this.tambahBarangBtn.UseVisualStyleBackColor = true;
            this.tambahBarangBtn.Click += new System.EventHandler(this.tambahBarangBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selamat datang, Administrator!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pilih langkah yang akan Anda lakukan:";
            // 
            // tambahStokBtn
            // 
            this.tambahStokBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambahStokBtn.Image = ((System.Drawing.Image)(resources.GetObject("tambahStokBtn.Image")));
            this.tambahStokBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tambahStokBtn.Location = new System.Drawing.Point(12, 133);
            this.tambahStokBtn.Name = "tambahStokBtn";
            this.tambahStokBtn.Size = new System.Drawing.Size(425, 54);
            this.tambahStokBtn.TabIndex = 5;
            this.tambahStokBtn.Text = "Tambah Stok Barang (F2)";
            this.tambahStokBtn.UseVisualStyleBackColor = true;
            this.tambahStokBtn.Click += new System.EventHandler(this.tambahStokBtn_Click);
            // 
            // pengambilanBarangBtn
            // 
            this.pengambilanBarangBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengambilanBarangBtn.Image = ((System.Drawing.Image)(resources.GetObject("pengambilanBarangBtn.Image")));
            this.pengambilanBarangBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pengambilanBarangBtn.Location = new System.Drawing.Point(12, 193);
            this.pengambilanBarangBtn.Name = "pengambilanBarangBtn";
            this.pengambilanBarangBtn.Size = new System.Drawing.Size(425, 54);
            this.pengambilanBarangBtn.TabIndex = 6;
            this.pengambilanBarangBtn.Text = "Pengambilan Barang (F3)";
            this.pengambilanBarangBtn.UseVisualStyleBackColor = true;
            this.pengambilanBarangBtn.Click += new System.EventHandler(this.pengambilanBarangBtn_Click);
            // 
            // laporanGudangBtn
            // 
            this.laporanGudangBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laporanGudangBtn.Image = ((System.Drawing.Image)(resources.GetObject("laporanGudangBtn.Image")));
            this.laporanGudangBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.laporanGudangBtn.Location = new System.Drawing.Point(12, 253);
            this.laporanGudangBtn.Name = "laporanGudangBtn";
            this.laporanGudangBtn.Size = new System.Drawing.Size(425, 54);
            this.laporanGudangBtn.TabIndex = 7;
            this.laporanGudangBtn.Text = "Laporan Gudang (F4)";
            this.laporanGudangBtn.UseVisualStyleBackColor = true;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 317);
            this.Controls.Add(this.laporanGudangBtn);
            this.Controls.Add(this.pengambilanBarangBtn);
            this.Controls.Add(this.tambahStokBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tambahBarangBtn);
            this.Name = "Administrator";
            this.Text = "Administrator - Merapi Golf Inventory";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Administrator_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tambahBarangBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tambahStokBtn;
        private System.Windows.Forms.Button pengambilanBarangBtn;
        private System.Windows.Forms.Button laporanGudangBtn;
    }
}