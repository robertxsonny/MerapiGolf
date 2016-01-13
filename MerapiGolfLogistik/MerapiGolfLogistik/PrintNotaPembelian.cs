using MerapiGolfLogistik.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerapiGolfLogistik
{
    public partial class PrintNotaPembelian : Form
    {
        public PrintNotaPembelian()
        {
            InitializeComponent();
        }

        public PrintNotaPembelian(NotaPembelianDetail nota)
        {
            InitializeComponent();
            nomorNotaLabel.Text = nota.no_nota;
            supplierLabel.Text = nota.nama_supplier;
            userLabel.Text = nota.nama_karyawan;
            tanggalLabel.Text = (nota.tanggal.HasValue ? nota.tanggal.Value.ToString("dd MMMM yyyy", CultureInfo.GetCultureInfo("id-ID")) : "-");
            keteranganLabel.Text = nota.keterangan;

            foreach (TotalPembelian item in nota.items)
            {
                int i = nota.items.IndexOf(item);
                Label nameLabel = new Label();
                nameLabel.Name = "nameLabel_" + item.id.ToString();
                nameLabel.Text = item.nama_barang.ToUpper() + Environment.NewLine 
                    + (item.banyak_barang.HasValue ? item.banyak_barang.Value : 0) + " x " + item.harga_satuan;
                nameLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                itemLayoutPanel.Controls.Add(nameLabel, 0, i);

                Label priceLabel = new Label();
                priceLabel.Name = "priceLabel_" + item.id.ToString();
                string price = (item.total_harga.HasValue ? item.total_harga.Value : 0).ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
                priceLabel.Text = "Rp " + price.PadLeft(14);
                priceLabel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
                itemLayoutPanel.Controls.Add(priceLabel, 0, i);

                itemLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            string totalPrice = (nota.total.HasValue ? nota.total.Value : 0).ToString("N", CultureInfo.GetCultureInfo("id-ID").NumberFormat);
            totalValueLabel.Text = "Rp " + totalPrice.PadLeft(14);

            itemLayoutPanel.SetRow(totalLabel, nota.items.Count);
            itemLayoutPanel.SetRow(totalValueLabel, nota.items.Count);
        }

    }
}
