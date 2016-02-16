namespace MerapiGolfLogistik
{
    partial class AdministratorReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorReport));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.laporanGudangBtn = new System.Windows.Forms.Button();
            this.laporanPerAktivaBtn = new System.Windows.Forms.Button();
            this.reportMovementBtn = new System.Windows.Forms.Button();
            this.laporanPerKategoriBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // laporanGudangBtn
            // 
            this.laporanGudangBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laporanGudangBtn.Image = ((System.Drawing.Image)(resources.GetObject("laporanGudangBtn.Image")));
            this.laporanGudangBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.laporanGudangBtn.Location = new System.Drawing.Point(16, 70);
            this.laporanGudangBtn.Name = "laporanGudangBtn";
            this.laporanGudangBtn.Size = new System.Drawing.Size(457, 54);
            this.laporanGudangBtn.TabIndex = 7;
            this.laporanGudangBtn.Text = "Laporan Pemakaian Barang Gudang (F1)";
            this.laporanGudangBtn.UseVisualStyleBackColor = true;
            this.laporanGudangBtn.Click += new System.EventHandler(this.laporanGudangBtn_Click);
            // 
            // laporanPerAktivaBtn
            // 
            this.laporanPerAktivaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laporanPerAktivaBtn.Image = ((System.Drawing.Image)(resources.GetObject("laporanPerAktivaBtn.Image")));
            this.laporanPerAktivaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.laporanPerAktivaBtn.Location = new System.Drawing.Point(16, 190);
            this.laporanPerAktivaBtn.Name = "laporanPerAktivaBtn";
            this.laporanPerAktivaBtn.Size = new System.Drawing.Size(457, 54);
            this.laporanPerAktivaBtn.TabIndex = 9;
            this.laporanPerAktivaBtn.Text = "Laporan Pengeluaran per Aktiva (F3)";
            this.laporanPerAktivaBtn.UseVisualStyleBackColor = true;
            this.laporanPerAktivaBtn.Click += new System.EventHandler(this.laporanPerAktivaBtn_Click);
            // 
            // reportMovementBtn
            // 
            this.reportMovementBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportMovementBtn.Image = ((System.Drawing.Image)(resources.GetObject("reportMovementBtn.Image")));
            this.reportMovementBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportMovementBtn.Location = new System.Drawing.Point(16, 250);
            this.reportMovementBtn.Name = "reportMovementBtn";
            this.reportMovementBtn.Size = new System.Drawing.Size(457, 54);
            this.reportMovementBtn.TabIndex = 10;
            this.reportMovementBtn.Text = "Laporan Pergerakan Barang (F4)";
            this.reportMovementBtn.UseVisualStyleBackColor = true;
            this.reportMovementBtn.Click += new System.EventHandler(this.reportMovementBtn_Click);
            // 
            // laporanPerKategoriBtn
            // 
            this.laporanPerKategoriBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laporanPerKategoriBtn.Image = ((System.Drawing.Image)(resources.GetObject("laporanPerKategoriBtn.Image")));
            this.laporanPerKategoriBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.laporanPerKategoriBtn.Location = new System.Drawing.Point(16, 130);
            this.laporanPerKategoriBtn.Name = "laporanPerKategoriBtn";
            this.laporanPerKategoriBtn.Size = new System.Drawing.Size(457, 54);
            this.laporanPerKategoriBtn.TabIndex = 11;
            this.laporanPerKategoriBtn.Text = "Laporan Barang per Kategori (F2)";
            this.laporanPerKategoriBtn.UseVisualStyleBackColor = true;
            this.laporanPerKategoriBtn.Click += new System.EventHandler(this.laporanPerKategoriBtn_Click);
            // 
            // AdministratorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 321);
            this.Controls.Add(this.laporanPerKategoriBtn);
            this.Controls.Add(this.reportMovementBtn);
            this.Controls.Add(this.laporanPerAktivaBtn);
            this.Controls.Add(this.laporanGudangBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministratorReport";
            this.Text = "Administrator - Merapi Golf Inventory";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Administrator_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button laporanGudangBtn;
        private System.Windows.Forms.Button laporanPerAktivaBtn;
        private System.Windows.Forms.Button reportMovementBtn;
        private System.Windows.Forms.Button laporanPerKategoriBtn;
    }
}