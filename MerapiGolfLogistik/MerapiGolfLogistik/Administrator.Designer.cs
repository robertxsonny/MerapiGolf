﻿namespace MerapiGolfLogistik
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
            this.pengembalianBarangBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tambahBarangBtn
            // 
            this.tambahBarangBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambahBarangBtn.Image = ((System.Drawing.Image)(resources.GetObject("tambahBarangBtn.Image")));
            this.tambahBarangBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tambahBarangBtn.Location = new System.Drawing.Point(8, 45);
            this.tambahBarangBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tambahBarangBtn.Name = "tambahBarangBtn";
            this.tambahBarangBtn.Size = new System.Drawing.Size(283, 37);
            this.tambahBarangBtn.TabIndex = 2;
            this.tambahBarangBtn.Text = "Tambah Jenis Barang Baru (F1)";
            this.tambahBarangBtn.UseVisualStyleBackColor = true;
            this.tambahBarangBtn.Click += new System.EventHandler(this.tambahBarangBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selamat datang, Administrator!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pilih langkah yang akan Anda lakukan:";
            // 
            // tambahStokBtn
            // 
            this.tambahStokBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambahStokBtn.Image = ((System.Drawing.Image)(resources.GetObject("tambahStokBtn.Image")));
            this.tambahStokBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tambahStokBtn.Location = new System.Drawing.Point(8, 86);
            this.tambahStokBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tambahStokBtn.Name = "tambahStokBtn";
            this.tambahStokBtn.Size = new System.Drawing.Size(283, 35);
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
            this.pengambilanBarangBtn.Location = new System.Drawing.Point(8, 125);
            this.pengambilanBarangBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pengambilanBarangBtn.Name = "pengambilanBarangBtn";
            this.pengambilanBarangBtn.Size = new System.Drawing.Size(283, 35);
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
            this.laporanGudangBtn.Location = new System.Drawing.Point(5, 203);
            this.laporanGudangBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.laporanGudangBtn.Name = "laporanGudangBtn";
            this.laporanGudangBtn.Size = new System.Drawing.Size(283, 35);
            this.laporanGudangBtn.TabIndex = 7;
            this.laporanGudangBtn.Text = "Laporan Gudang (F5)";
            this.laporanGudangBtn.UseVisualStyleBackColor = true;
            // 
            // pengembalianBarangBtn
            // 
            this.pengembalianBarangBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengembalianBarangBtn.Image = ((System.Drawing.Image)(resources.GetObject("pengembalianBarangBtn.Image")));
            this.pengembalianBarangBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pengembalianBarangBtn.Location = new System.Drawing.Point(8, 164);
            this.pengembalianBarangBtn.Margin = new System.Windows.Forms.Padding(2);
            this.pengembalianBarangBtn.Name = "pengembalianBarangBtn";
            this.pengembalianBarangBtn.Size = new System.Drawing.Size(283, 35);
            this.pengembalianBarangBtn.TabIndex = 8;
            this.pengembalianBarangBtn.Text = "Pengembalian Barang (F4)";
            this.pengembalianBarangBtn.UseVisualStyleBackColor = true;
            this.pengembalianBarangBtn.Click += new System.EventHandler(this.pengembalianBarangBtn_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 251);
            this.Controls.Add(this.pengembalianBarangBtn);
            this.Controls.Add(this.laporanGudangBtn);
            this.Controls.Add(this.pengambilanBarangBtn);
            this.Controls.Add(this.tambahStokBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tambahBarangBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button pengembalianBarangBtn;
    }
}