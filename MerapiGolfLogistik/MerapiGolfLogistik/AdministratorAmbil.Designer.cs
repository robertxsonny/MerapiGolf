namespace MerapiGolfLogistik
{
    partial class AdministratorAmbil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministratorAmbil));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pengambilanBarangBtn = new System.Windows.Forms.Button();
            this.pengembalianBarangBtn = new System.Windows.Forms.Button();
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
            // pengambilanBarangBtn
            // 
            this.pengambilanBarangBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengambilanBarangBtn.Image = ((System.Drawing.Image)(resources.GetObject("pengambilanBarangBtn.Image")));
            this.pengambilanBarangBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pengambilanBarangBtn.Location = new System.Drawing.Point(12, 57);
            this.pengambilanBarangBtn.Name = "pengambilanBarangBtn";
            this.pengambilanBarangBtn.Size = new System.Drawing.Size(457, 54);
            this.pengambilanBarangBtn.TabIndex = 6;
            this.pengambilanBarangBtn.Text = "Pengambilan Barang (F1)";
            this.pengambilanBarangBtn.UseVisualStyleBackColor = true;
            this.pengambilanBarangBtn.Click += new System.EventHandler(this.pengambilanBarangBtn_Click);
            // 
            // pengembalianBarangBtn
            // 
            this.pengembalianBarangBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengembalianBarangBtn.Image = ((System.Drawing.Image)(resources.GetObject("pengembalianBarangBtn.Image")));
            this.pengembalianBarangBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pengembalianBarangBtn.Location = new System.Drawing.Point(12, 117);
            this.pengembalianBarangBtn.Name = "pengembalianBarangBtn";
            this.pengembalianBarangBtn.Size = new System.Drawing.Size(457, 54);
            this.pengembalianBarangBtn.TabIndex = 8;
            this.pengembalianBarangBtn.Text = "Pengembalian Barang (F2)";
            this.pengembalianBarangBtn.UseVisualStyleBackColor = true;
            this.pengembalianBarangBtn.Click += new System.EventHandler(this.pengembalianBarangBtn_Click);
            // 
            // AdministratorAmbil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 185);
            this.Controls.Add(this.pengembalianBarangBtn);
            this.Controls.Add(this.pengambilanBarangBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministratorAmbil";
            this.Text = "Administrator - Merapi Golf Inventory";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Administrator_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button pengambilanBarangBtn;
        private System.Windows.Forms.Button pengembalianBarangBtn;
    }
}