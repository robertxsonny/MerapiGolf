namespace MerapiGolfLogistik
{
    partial class Gudang
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
            this.testBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(107, 127);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(180, 79);
            this.testBtn.TabIndex = 0;
            this.testBtn.Text = "Test return to login form";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // Gudang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 356);
            this.Controls.Add(this.testBtn);
            this.Name = "Gudang";
            this.Text = "Gudang";
            this.Load += new System.EventHandler(this.Gudang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button testBtn;
    }
}