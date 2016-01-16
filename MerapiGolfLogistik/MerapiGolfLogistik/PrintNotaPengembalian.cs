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

       
        public PrintNotaPengembalian()
        {
            InitializeComponent();
        }

        public PrintNotaPengembalian(NotaPengembalianDetail nota)
        {
            InitializeComponent();
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
            printDocument.PrintPage += PrintDocument_PrintPage;
            PrintPreviewDialog printPreview = new PrintPreviewDialog();
            printPreview.Document = printDocument;
            CaptureScreen();
            printPreview.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
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
