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
        private NotaPembelianDetail nota;
       
        public PrintNotaPembelian()
        {
            InitializeComponent();
        }

        public PrintNotaPembelian(NotaPembelianDetail nota)
        {
            InitializeComponent();
            this.nota = nota;
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
            PaperSize psize = new PaperSize("Custom size 1", 350, 450 + (this.nota.items.Count*40));
            printDocument.PrintPage += PrintDocument_PrintPage;
            printDocument.DefaultPageSettings.PaperSize = psize;
            //printDocument.ori
            //PrintPreviewDialog printPreview = new PrintPreviewDialog();
            //printPreview.Document = printDocument;
            //CaptureScreen();
            //printPreview.ShowDialog();
            printDocument.Print();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            //e.Graphics.DrawImage(memoryImage, 0, 0);

            Font titlefont = new Font("Courier New", 12, FontStyle.Bold);
            Font subtitlefont = new Font("Courier New", 10, FontStyle.Bold);
            Font sectiontitlefont = new Font("Courier New", 10, FontStyle.Bold);
            Font contentfont = new Font("Courier New", 8, FontStyle.Bold);

            int startX = 0;
            int startY = 0;
            int offset = 0;
            e.Graphics.DrawString("      MERAPI GOLF     ", titlefont, Brushes.Black, startX, startY + offset);
            offset += 20;
            e.Graphics.DrawString("JALAN GOLF NO. 1 KEPUH HARJO", subtitlefont, Brushes.Black, startX, startY + offset);
            offset += 20;
            e.Graphics.DrawString("  CANGKRINGAN, SLEMAN  ", titlefont, Brushes.Black, startX, startY + offset);
            offset += 20;
            e.Graphics.DrawString("----------------------------", sectiontitlefont, Brushes.Black, startX, startY + offset);
            offset += 20;
            e.Graphics.DrawString("      BUKTI PEMBELIAN      ", subtitlefont, Brushes.Black, startX, startY + offset);
            offset += 20;
            e.Graphics.DrawString("Nomor         : " + this.nota.no_nota, contentfont, Brushes.Black, startX, startY + offset);
            offset += 20;
            e.Graphics.DrawString("Supplier      : " + this.nota.nama_supplier, contentfont, Brushes.Black, startX, startY + offset);
            offset += 20;
            e.Graphics.DrawString("Pembeli       : ", contentfont, Brushes.Black, startX, startY + offset);
            e.Graphics.DrawString(this.nota.nama_karyawan, contentfont, Brushes.Black, new RectangleF(startX + 110, startY + offset, 150, 1000));
            offset += 20 * (1 + (this.nota.nama_karyawan.Length / 20));
            e.Graphics.DrawString("Tanggal       : " + this.nota.tanggal.Value.ToString("dd MMMM yyyy"), contentfont, Brushes.Black, startX, startY + offset);
            offset += 20;
            e.Graphics.DrawString("Keterangan    : ", contentfont, Brushes.Black, startX, startY + offset);
            e.Graphics.DrawString(this.nota.keterangan, contentfont, Brushes.Black, new RectangleF(startX + 110, startY + offset, 150, 1000));
            offset += 20 * (1 + (this.nota.keterangan.Length / 20));
            e.Graphics.DrawString("----------------------------", sectiontitlefont, Brushes.Black, startX, startY + offset);
            offset += 20;
            e.Graphics.DrawString("        DAFTAR BARANG        ", subtitlefont, Brushes.Black, startX, startY + offset);
            double subtotal = 0;
            foreach (var item in this.nota.items)
            {
                subtotal += item.total_harga.HasValue ? item.total_harga.Value : 0;
                offset += 20;
                e.Graphics.DrawString(item.nama_barang, contentfont, Brushes.Black, startX, startY + offset);
                e.Graphics.DrawString((item.total_harga.HasValue ? item.total_harga.Value : 0).ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat), contentfont, Brushes.Black, startX + 150, startY + offset);
                offset += 20;
                e.Graphics.DrawString(item.banyak_barang.ToString() + " " + item.satuan + " x " + (item.harga_satuan.HasValue ? item.harga_satuan.Value : 0).ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat), contentfont, Brushes.Black, startX + 20, startY + offset);
            }
            offset += 20;
            e.Graphics.DrawString("----------------------------", sectiontitlefont, Brushes.Black, startX, startY + offset);
            offset += 20;
            e.Graphics.DrawString("Total pembelian", contentfont, Brushes.Black, startX, startY + offset);
            e.Graphics.DrawString(subtotal.ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat), contentfont, Brushes.Black, startX + 150, startY + offset);
            offset += 20;
            e.Graphics.DrawString("----------------------------", sectiontitlefont, Brushes.Black, startX, startY + offset);
            offset += 20;
            e.Graphics.DrawString("        TERIMA KASIH        ", sectiontitlefont, Brushes.Black, startX, startY + offset);
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
