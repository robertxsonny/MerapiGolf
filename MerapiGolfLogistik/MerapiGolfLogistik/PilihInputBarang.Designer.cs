namespace MerapiGolfLogistik
{
    partial class PilihInputBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PilihInputBarang));
            this.label1 = new System.Windows.Forms.Label();
            this.tambahBarangBtn = new System.Windows.Forms.Button();
            this.tambahStokBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.namaUserTb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Silakan pilih jenis input barang yang Anda inginkan.";
            // 
            // tambahBarangBtn
            // 
            this.tambahBarangBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambahBarangBtn.Image = ((System.Drawing.Image)(resources.GetObject("tambahBarangBtn.Image")));
            this.tambahBarangBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tambahBarangBtn.Location = new System.Drawing.Point(16, 94);
            this.tambahBarangBtn.Name = "tambahBarangBtn";
            this.tambahBarangBtn.Size = new System.Drawing.Size(425, 57);
            this.tambahBarangBtn.TabIndex = 1;
            this.tambahBarangBtn.Text = "Tambah Jenis Barang Baru";
            this.tambahBarangBtn.UseVisualStyleBackColor = true;
            this.tambahBarangBtn.Click += new System.EventHandler(this.tambahBarangBtn_Click);
            // 
            // tambahStokBtn
            // 
            this.tambahStokBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambahStokBtn.Image = ((System.Drawing.Image)(resources.GetObject("tambahStokBtn.Image")));
            this.tambahStokBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tambahStokBtn.Location = new System.Drawing.Point(16, 157);
            this.tambahStokBtn.Name = "tambahStokBtn";
            this.tambahStokBtn.Size = new System.Drawing.Size(425, 54);
            this.tambahStokBtn.TabIndex = 2;
            this.tambahStokBtn.Text = "Tambah Stok Barang";
            this.tambahStokBtn.UseVisualStyleBackColor = true;
            this.tambahStokBtn.Click += new System.EventHandler(this.tambahStokBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Anda masuk sebagai:";
            // 
            // namaUserTb
            // 
            this.namaUserTb.AutoSize = true;
            this.namaUserTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaUserTb.Location = new System.Drawing.Point(162, 11);
            this.namaUserTb.Name = "namaUserTb";
            this.namaUserTb.Size = new System.Drawing.Size(98, 20);
            this.namaUserTb.TabIndex = 4;
            this.namaUserTb.Text = "[namauser]";
            // 
            // PilihInputBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 228);
            this.Controls.Add(this.namaUserTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tambahStokBtn);
            this.Controls.Add(this.tambahBarangBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe WP", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PilihInputBarang";
            this.Text = "Pilih Jenis Input Barang";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PilihInputBarang_FormClosed);
            this.Load += new System.EventHandler(this.PilihInputBarang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tambahBarangBtn;
        private System.Windows.Forms.Button tambahStokBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label namaUserTb;
    }
}