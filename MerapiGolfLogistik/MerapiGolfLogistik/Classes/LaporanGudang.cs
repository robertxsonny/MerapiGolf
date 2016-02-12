using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerapiGolfLogistik.Classes
{
    public class LaporanGudang
    {
        public List<LaporanGudangItem> Items { get; set; }

        public string Periode { get; set; }
        
        public static LaporanGudang GenerateLaporanGudang(DateTime from, DateTime to)
        {
            using (MerapiGolfLogistikEntities dbContent = new MerapiGolfLogistikEntities())
            {
                LaporanGudang laporan = new LaporanGudang();
                laporan.Periode = from.ToString("dd MMMM yyyy", new CultureInfo("id-ID")) + " - " + to.ToString("dd MMMM yyyy", new CultureInfo("id-ID"));
                laporan.Items = new List<LaporanGudangItem>();
                List<Barang> barangList = dbContent.mg_barang.ToList();
                foreach (Barang barang in barangList)
                {
                    List<TotalPembelian> pembelianlist = dbContent.mg_total_pembelian.Where(p => p.id_barang == barang.id && p.tanggal <= to).ToList();
                    foreach (TotalPembelian pembelian in pembelianlist)
                    {
                        List<TotalPengambilan> pengambilanlist = dbContent.mg_total_pengambilan.Where(p => p.id_pembelian_barang == pembelian.id && p.tanggal <= to).ToList();
                        List<TotalPengembalian> pengembalianlist = dbContent.mg_total_pengembalian.Where(p => p.id_pembelian_barang == pembelian.id && p.tanggal <= to).ToList();
                        LaporanGudangItem item = new LaporanGudangItem();
                        item.NamaBarang = pembelian.nama_barang;
                        item.Kategori = pembelian.nama_kategori;
                        item.KategoriId = pembelian.id_kategori;
                        item.SubsiKategori = pembelian.subsikategori;
                        item.HargaSatuan = (pembelian.harga_satuan.HasValue ? pembelian.harga_satuan.Value : 0);
                        item.Subsi = pembelian.subsi;
                        item.Stok = (pembelian.tanggal < from ? (pembelian.banyak_barang.HasValue ? pembelian.banyak_barang.Value : 0) : 0);
                        item.StokMasuk = (pembelian.tanggal >= from ? (pembelian.banyak_barang.HasValue ? pembelian.banyak_barang.Value : 0) : 0);
                        item.StokKeluar = 0;

                        List<DateTime> tanggalTransaksi = new List<DateTime>();
                        if (pembelian.tanggal.HasValue && pembelian.tanggal.Value > from)
                            tanggalTransaksi.Add(pembelian.tanggal.Value);
                        foreach (TotalPengambilan pengambilan in pengambilanlist)
                        {
                            if (pengambilan.tanggal < from)
                                item.Stok -= (pengambilan.banyak_barang.HasValue ? pengambilan.banyak_barang.Value : 0);
                            else
                            {
                                item.StokKeluar += (pengambilan.banyak_barang.HasValue ? pengambilan.banyak_barang.Value : 0);
                                if (pengambilan.tanggal.HasValue)
                                    tanggalTransaksi.Add(pengambilan.tanggal.Value);
                            } 
                        }
                        foreach (TotalPengembalian pengembalian in pengembalianlist)
                        {
                            if (pengembalian.tanggal < from)
                                item.Stok += (pengembalian.banyak_dikembalikan.HasValue ? pengembalian.banyak_dikembalikan.Value : 0);
                            else
                            {
                                item.StokMasuk += (pengembalian.banyak_dikembalikan.HasValue ? pengembalian.banyak_dikembalikan.Value : 0);
                                if (pengembalian.tanggal.HasValue)
                                    tanggalTransaksi.Add(pengembalian.tanggal.Value);
                            }
                        }
                        if ((item.StokMasuk > 0 || item.StokKeluar > 0) && tanggalTransaksi.Count > 0)
                        {
                            DateTime minDate = tanggalTransaksi.Min();
                            DateTime maxDate = tanggalTransaksi.Max();
                            item.TanggalKeluar = minDate.ToString("dd/MM/yyyy") + (minDate == maxDate ? "" : "-" + maxDate.ToString("dd/MM/yyyy"));
                            laporan.Items.Add(item);
                        }
                    }
                }
                laporan.Items = laporan.Items.OrderBy(i => i.Kategori).ToList();
                return laporan;
            }
        }
    }

    public class LaporanGudangItem
    {
        public string Subsi { get; set; }

        public string NamaBarang { get; set; }
        public string SubsiKategori { get; set; }
        public Guid KategoriId { get; set; }
        public string Kategori { get; set; }

        public string TanggalKeluar { get; set; }

        public double Stok { get; set; }

        public double StokMasuk { get; set; }

        public double StokKeluar { get; set; }

        public double HargaSatuan { get; set; }

        public double Saldo { get { return Stok + StokMasuk - StokKeluar; } }

        public double HargaStok { get { return Stok * HargaSatuan; } }

        public double HargaMasuk { get { return StokMasuk * HargaSatuan; } }

        public double HargaKeluar { get { return StokKeluar * HargaSatuan; } }

        public double HargaSaldo { get { return Saldo * HargaSatuan; } }

    }
}
