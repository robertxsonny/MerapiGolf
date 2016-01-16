using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MerapiGolfLogistik.Models;

namespace MerapiGolfLogistik
{
    public partial class LaporanGudang : Form
    {
        private MerapiGolfLogistikEntities dbContent = new MerapiGolfLogistikEntities();
        private Guid selectedCategory = Guid.Empty;
        public LaporanGudang()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.ActiveControl = this.reportView;
            this.StartPosition = FormStartPosition.CenterScreen;
            RefreshView();
        }

        private void SelectCategory()
        {
            PilihKategori pilihform = new PilihKategori();
            var dlgmsg = pilihform.ShowDialog();
            if (dlgmsg == DialogResult.OK)
            {
                this.selectedCategory = pilihform.selectedId;
                var category = dbContent.mg_kategori.Where(p => p.id == this.selectedCategory).Single();
                kategoriTb.Text = category.nama_kategori;
                RefreshView();
            }
        }

        private void RefreshView()
        {
            dbContent = new MerapiGolfLogistikEntities();
            List<LaporanBarangExtended> result = new List<LaporanBarangExtended>();

            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now;
            DateTime.TryParse(dariTanggalTb.Text, out start);
            DateTime.TryParse(sampaiTanggalTb.Text, out end);

            var reports = dbContent.LaporanGudangFilter(start, end).ToList().OrderBy(p => p.nama_kategori).ToList();
            if (this.selectedCategory != Guid.Empty)
                reports = reports.Where(p => p.idkategori == this.selectedCategory).ToList();
            if (reports.Count > 0)
            {
                foreach (var report in reports)
                { 
                    LaporanBarangExtended laporan = new LaporanBarangExtended();
                    var barang = dbContent.mg_barang.Where(p => p.id == report.id).Single();
                    var allpembelian = dbContent.mg_pembelian_item.Where(p => p.barang_id == barang.id).ToList();
                    allpembelian.ForEach((p) =>
                    {
                        p.harga_satuan = p.harga_satuan * p.banyak_barang;
                    });
                    double saldoAwal = allpembelian.Sum(p => p.harga_satuan.Value);
                    double stokAwal = allpembelian.Sum(p => p.banyak_barang.Value);
                    laporan.saldoAwal = saldoAwal;
                    laporan.stokAwal = stokAwal;
                    laporan.id = report.id;
                    laporan.idkategori = report.idkategori;
                    laporan.jumlahhrgbeli = report.jumlahhrgbeli;
                    laporan.jumlahhrgpakai = report.jumlahhrgpakai;
                    laporan.nama_barang = report.nama_barang;
                    laporan.nama_kategori = report.nama_kategori;
                    laporan.saldo = report.saldo;
                    laporan.satuan = report.satuan;
                    laporan.stokkeluar = report.stokkeluar;
                    laporan.stokmasuk = report.stokmasuk;
                    laporan.stoksaldo = report.stoksaldo;
                    result.Add(laporan);
                }
                
            }
            reportView.DataSource = null;
            reportView.DataSource = result;
        }

        private void pilihKategoriBtn_Click(object sender, EventArgs e)
        {
            SelectCategory();
        }

        private void hapusFilterBtn_Click(object sender, EventArgs e)
        {
            this.selectedCategory = Guid.Empty;
            kategoriTb.Text = "[Belum ada kategori dipilih]";
            RefreshView();
        }

        private void LaporanGudang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                SelectCategory();
        }

        private void dariTanggalTb_ValueChanged(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void sampaiTanggalTb_ValueChanged(object sender, EventArgs e)
        {
            RefreshView();
        }
    }
}
