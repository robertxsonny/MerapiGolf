using MerapiGolfLogistik.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerapiGolfLogistik
{
    public partial class PrintNotaPembelian : Form
    {

        Bitmap memoryImage;

       
        public PrintNotaPembelian()
        {
            InitializeComponent();
        }

        public PrintNotaPembelian(NotaPembelianDetail nota)
        {
            InitializeComponent();
            nomorNotaLabel.Text = nota.no_nota;
            supplierLabel.Text = nota.nama_supplier.ToUpper();
            userLabel.Text = nota.nama_karyawan.ToUpper();
            tanggalLabel.Text = (nota.tanggal.HasValue ? nota.tanggal.Value.ToString("dd MMMM yyyy", CultureInfo.GetCultureInfo("id-ID")).ToUpper() : "-");
            keteranganLabel.Text = nota.keterangan.ToUpper();

            foreach (TotalPembelian item in nota.items)
            {
                int i = nota.items.IndexOf(item); 
                Label nameLabel = new Label();
                nameLabel.Name = "nameLabel_" + item.id.ToString();
                nameLabel.Text = item.nama_barang.ToUpper() + Environment.NewLine 
                    + " " + (item.banyak_barang.HasValue ? item.banyak_barang.Value : 0) + " x " + item.harga_satuan;
                nameLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                nameLabel.AutoSize = true;
                itemLayoutPanel.Controls.Add(nameLabel, 0, i);

                Label priceLabel = new Label();
                priceLabel.Name = "priceLabel_" + item.id.ToString();
                string price = (item.total_harga.HasValue ? item.total_harga.Value : 0).ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
                priceLabel.Text = "Rp " + price.PadLeft(13);
                priceLabel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                priceLabel.AutoSize = true;
                itemLayoutPanel.Controls.Add(priceLabel, 1, i);

                itemLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            string totalPrice = (nota.total.HasValue ? nota.total.Value : 0).ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
            totalValueLabel.Text = "Rp " + totalPrice.PadLeft(13);

            itemLayoutPanel.SetRow(totalLabel, nota.items.Count);
            itemLayoutPanel.SetRow(totalValueLabel, nota.items.Count);

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
                        
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            (sender as Timer).Stop();
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;
            //printDocument.ori
            //PrintPreviewDialog printPreview = new PrintPreviewDialog();
            //printPreview.Document = printDocument;
            CaptureScreen();
            //printPreview.ShowDialog();
            printDocument.Print();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);

            //Font titlefont = new Font("Courier New", 14);
            //Font subtitlefont = new Font("Courier New", 10);
            //Font sectiontitlefont = new Font("Courier New", 12);
            //Font contentfont = new Font("Courier New", 8);
           
            //int startX = 50;
            //int startY = 50;
            //int offset = 40;
            //e.Graphics.DrawString(label16.Text, titlefont, Brushes.Black, startX, startY + offset);
            //offset += 20;
            //e.Graphics.DrawString(label17.Text, subtitlefont, Brushes.Black, startX, startY + offset);
            //offset += 20;
            //e.Graphics.DrawString(label2.Text, titlefont, Brushes.Black, startX, startY + offset);
            //offset += 20;
            //e.Graphics.DrawString(label1.Text, sectiontitlefont, Brushes.Black, startX, startY + offset);
        }
        
        private void CaptureScreen()
        {
            Graphics myGraphics = mainLayoutPanel.CreateGraphics();
            Size s = mainLayoutPanel.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            Point location = PointToScreen(mainLayoutPanel.Location);
            memoryGraphics.CopyFromScreen(location.X, location.Y, 0, 0, s);
        }
    }
}
