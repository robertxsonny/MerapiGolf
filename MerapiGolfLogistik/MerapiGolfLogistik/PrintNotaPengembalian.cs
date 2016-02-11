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
    public partial class PrintNotaPengembalian : Form
    {

        Bitmap memoryImage;
        private NotaPengembalianDetail nota;

        public PrintNotaPengembalian()
        {
            InitializeComponent();
        }

        public PrintNotaPengembalian(NotaPengembalianDetail nota)
        {
            InitializeComponent();
            this.nota = nota;
            nomorNotaLabel.Text = nota.no_nota;
            userLabel.Text = nota.nama_karyawan.ToUpper();
            tanggalLabel.Text = (nota.tanggal.HasValue ? nota.tanggal.Value.ToString("dd MMMM yyyy", CultureInfo.GetCultureInfo("id-ID")) : "-").ToUpper();
            keteranganLabel.Text = nota.keterangan.ToUpper();

            foreach (PengembalianPerBarang item in nota.items)
            {
                int i = nota.items.IndexOf(item);

                itemLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

                Label nameLabel = new Label();
                nameLabel.Name = "nameLabel_" + item.id_barang.ToString();
                nameLabel.Text = item.nama_barang.ToUpper();
                nameLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                nameLabel.AutoSize = true;
                itemLayoutPanel.Controls.Add(nameLabel, 0, i);

                Label qtyLabel = new Label();
                qtyLabel.Name = "qtyLabel_" + item.id_barang.ToString();
                qtyLabel.Text = (item.banyak_dikembalikan.HasValue ? item.banyak_dikembalikan.Value : 0).ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat) + " " + item.satuan.ToUpper();
                qtyLabel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                qtyLabel.AutoSize = true;
                itemLayoutPanel.Controls.Add(qtyLabel, 1, i);
            }

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            (sender as Timer).Stop();
            PrintDocument printDocument = new PrintDocument();
            PaperSize psize = new PaperSize("Custom size 1", 350, 450 + (this.nota.items.Count * 45));
            printDocument.DefaultPageSettings.PaperSize = psize;
            printDocument.PrintPage += PrintDocument_PrintPage;
            PrintPreviewDialog printPreview = new PrintPreviewDialog();
            printPreview.Document = printDocument;
            //CaptureScreen();
            //printDocument.Print();
            printPreview.ShowDialog();
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
            e.Graphics.DrawString("     BUKTI PENGEMBALIAN    ", subtitlefont, Brushes.Black, startX, startY + offset);
            offset += 20;
            e.Graphics.DrawString("Nomor         : " + this.nota.no_nota, contentfont, Brushes.Black, startX, startY + offset);
            offset += 20;
            e.Graphics.DrawString("Pengembali    : ", contentfont, Brushes.Black, startX, startY + offset);
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

            foreach (var item in this.nota.items)
            {
                offset += 20;
                e.Graphics.DrawString(item.nama_barang, contentfont, Brushes.Black, startX, startY + offset);
                offset += 20;
                e.Graphics.DrawString(item.banyak_dikembalikan.ToString() + " " + item.satuan, contentfont, Brushes.Black, startX + 170, startY + offset);
            }
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
