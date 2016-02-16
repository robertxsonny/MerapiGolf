using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MerapiGolfLogistik.Models;
using System.Windows.Forms;

namespace MerapiGolfLogistik.Classes
{
    public class FetchData : Form
    {
        private MerapiGolfLogistikEntities dbContent;
        public IEnumerable<MerapiGolfLogistik.Models.CategoryView> GetCategory(string query)
        {
            using (dbContent = new MerapiGolfLogistikEntities())
            {
                var result = new List<MerapiGolfLogistik.Models.CategoryView>();
                List<Kategori> categories = new List<Kategori>();
                if (String.IsNullOrWhiteSpace(query))
                    categories = dbContent.mg_kategori.ToList();
                else
                {
                    string queryLower = query.ToLower();
                    categories = dbContent.mg_kategori.Where(p => p.nama_kategori.ToLower().Contains(queryLower)).ToList();
                }
                int index = 1;
                categories = categories.OrderBy(p => p.inputdate).ToList();
                foreach (var Kategori in categories)
                {
                    MerapiGolfLogistik.Models.CategoryView cat = new Models.CategoryView();
                    cat.id = Kategori.id;
                    cat.index = index.ToString().PadLeft(7, '0');
                    cat.nama_kategori = Kategori.nama_kategori;
                    cat.subsi = Kategori.subsi;
                    cat.stock = Kategori.barang.Count;
                    result.Add(cat);
                    index++;
                }
                return result;
            }
        }

        public IEnumerable<ItemView> GetItems(string query)
        {
            using (dbContent = new MerapiGolfLogistikEntities())
            {
                var res = new List<ItemView>();
                List<Barang> items = new List<Barang>();
                if (String.IsNullOrWhiteSpace(query))
                    items = dbContent.mg_barang.ToList();
                else
                    items = dbContent.mg_barang.Where(p => p.nama_barang.Contains(query.ToLower())).ToList();

                if (items.Count != 0)
                {
                    foreach (var item in items)
                    {
                        ItemView itemview = new ItemView();
                        itemview.id = item.id;
                        itemview.id_kategori = item.id_kategori;
                        itemview.subsi = item.subsi;

                        var stoktotal = dbContent.mg_stok_barang_total.Where(p => p.id_barang == item.id).ToList();
                        if (stoktotal.Count > 0)
                        {
                            var stok = stoktotal.FirstOrDefault();
                            itemview.itemcount = stok.stok.HasValue ? stok.stok.Value : 0;
                        }

                        if (itemview.itemcount != 0)
                        {
                            if (item.pembelian_item.Count != 0)
                            {
                                var selectdates = item.pembelian_item.Select(p => p.pembelian.tanggal);
                                var datesort = selectdates.OrderByDescending(p => p);
                                itemview.lastcreateditemdate = datesort.First().HasValue ? datesort.First().Value.ToString("dd MMM yyyy") : "-";
                            }
                        }
                        else itemview.lastcreateditemdate = "Belum ada stok barang";
                        itemview.nama_barang = item.nama_barang;
                        itemview.satuan = item.satuan;
                        itemview.categoryname = item.kategori.nama_kategori;
                        res.Add(itemview);
                    }
                }

                return res;

            }
        }

        public IEnumerable<PembelianExtended> GetPreviousPembelian(bool isFinished,
            DateTime startDate, DateTime endDate, bool displayAll)
        {
            using (dbContent = new MerapiGolfLogistikEntities())
            {
                List<PembelianExtended> result = new List<PembelianExtended>();
                var allpembelians = dbContent.mg_pembelian.ToList();
                foreach (var item in allpembelians)
                {
                    PembelianExtended pembelian = new PembelianExtended();
                    pembelian.id = item.id;
                    pembelian.IsFinished = item.pembelian_item.Where(p => p.harga_satuan == 0 || p.banyak_barang == 0).ToList().
                        Count == 0;
                    pembelian.keterangan = item.keterangan;
                    pembelian.supplier_id = item.supplier_id;
                    pembelian.tanggal = item.tanggal;
                    pembelian.username = item.user.nama_karyawan;
                    result.Add(pembelian);
                }

                if (!isFinished)
                    result = result.Where(p => !p.IsFinished).ToList();

                if (!displayAll)
                {
                    result = result.Where(p => p.tanggal.HasValue).ToList();
                    result = result.Where(p => p.tanggal.Value.Subtract(startDate).TotalDays >= 0 &&
                    p.tanggal.Value.Subtract(endDate).TotalDays <= 0).ToList();
                }
                return result;
            }
        }

        public IEnumerable<LaporanAktivaModel> GetReportByAktiva(Guid aktivaId,
            DateTime from, DateTime to)
        {
            using (dbContent = new MerapiGolfLogistikEntities())
            {
                List<LaporanAktivaModel> result = new List<LaporanAktivaModel>();
                var pengambilan_items = dbContent.mg_pengambilan_item.Where(p => p.pengambilan.tanggal.HasValue).ToList();
                //for calculation
                var pembelian_items = dbContent.mg_pembelian_item.Where(p => p.pembelian.tanggal.HasValue).ToList();
                var pengambilan_all = dbContent.mg_pengambilan_item.Where(p => p.pengambilan.tanggal.HasValue).ToList();
                var pengembalian_items = dbContent.mg_pengembalian_item.Where(p => p.pengembalian.tanggal.HasValue).ToList();
                if (aktivaId != Guid.Empty)
                    pengambilan_items = pengambilan_items.Where(p => p.id_aktiva == aktivaId).ToList();
                pengambilan_items = pengambilan_items.Where(p => p.pengambilan.tanggal.Value.Subtract(from).TotalDays >= 0 &&
                p.pengambilan.tanggal.Value.Subtract(to).TotalDays <= 0).ToList();
                var pengambilan_per_aktiva = pengambilan_items.GroupBy(p => p.id_aktiva);
                //iterasi per grup aktiva
                foreach (var per_aktiva in pengambilan_per_aktiva)
                {
                    var list_pengambilan_per_aktiva = per_aktiva.ToList();
                    var pengambilan_per_barang = list_pengambilan_per_aktiva.GroupBy(p => p.pembelian_item.barang_id);
                    //iterasi per grup pengambilan per ID barang
                    foreach (var pengambilan_per_id in pengambilan_per_barang)
                    {
                        if (pengambilan_per_id.Count() > 0)
                        {
                            LaporanAktivaModel single = new LaporanAktivaModel();
                            var pengambilan_pertama = pengambilan_per_id.FirstOrDefault();
                            single.id_aktiva = per_aktiva.Key.Value;
                            single.nama_aktiva = pengambilan_pertama.aktiva.nama_aktiva;
                            single.nama_barang = pengambilan_pertama.pembelian_item.barang.nama_barang;
                            single.id_barang = pengambilan_pertama.pembelian_item.barang.id;
                            single.subsi_barang = pengambilan_pertama.pembelian_item.barang.subsi;
                            single.keterangan_aktiva = pengambilan_pertama.aktiva.keterangan_aktiva;
                            single.stokawal = pembelian_items.Where(p => p.pembelian.tanggal.Value.Subtract(from).TotalDays < 0 && p.barang_id == single.id_barang).Sum(p => p.banyak_barang.Value) -
                                pengambilan_all.Where(p => p.pengambilan.tanggal.Value.Subtract(from).TotalDays < 0 && p.pembelian_item.barang_id == single.id_barang).Sum(p => p.banyak_barang.Value) +
                                pengembalian_items.Where(p => p.pengembalian.tanggal.Value.Subtract(from).TotalDays < 0 && p.pengambilan_item.pembelian_item.barang_id == single.id_barang).Sum(p => p.banyak_dikembalikan.Value);
                            single.stokakhir = pembelian_items.Where(p => p.pembelian.tanggal.Value.Subtract(to).TotalDays <= 0 && p.barang_id == single.id_barang).Sum(p => p.banyak_barang.Value) -
                             pengambilan_all.Where(p => p.pengambilan.tanggal.Value.Subtract(to).TotalDays <= 0 && p.pembelian_item.barang_id == single.id_barang).Sum(p => p.banyak_barang.Value) +
                              pengembalian_items.Where(p => p.pengembalian.tanggal.Value.Subtract(to).TotalDays <= 0 && p.pengambilan_item.pembelian_item.barang_id == single.id_barang).Sum(p => p.banyak_dikembalikan.Value);
                            single.saldoawal = pembelian_items.Where(p => p.pembelian.tanggal.Value.Subtract(from).TotalDays < 0 && p.barang_id == single.id_barang).Sum(p => (p.banyak_barang.Value * p.harga_satuan.Value)) -
                                pengambilan_all.Where(p => p.pengambilan.tanggal.Value.Subtract(from).TotalDays < 0 && p.pembelian_item.barang_id == single.id_barang).Sum(p => (p.banyak_barang.Value * p.pembelian_item.harga_satuan.Value)) +
                                pengembalian_items.Where(p => p.pengembalian.tanggal.Value.Subtract(from).TotalDays < 0 && p.pengambilan_item.pembelian_item.barang_id == single.id_barang).Sum(p => (p.banyak_dikembalikan.Value * p.pengambilan_item.pembelian_item.harga_satuan.Value));
                            single.saldoakhir = pembelian_items.Where(p => p.pembelian.tanggal.Value.Subtract(to).TotalDays <= 0 && p.barang_id == single.id_barang).Sum(p => (p.banyak_barang.Value * p.harga_satuan.Value)) -
                              pengambilan_all.Where(p => p.pengambilan.tanggal.Value.Subtract(to).TotalDays <= 0 && p.pembelian_item.barang_id == single.id_barang).Sum(p => (p.banyak_barang.Value * p.pembelian_item.harga_satuan.Value)) +
                               pengembalian_items.Where(p => p.pengembalian.tanggal.Value.Subtract(to).TotalDays <= 0 && p.pengambilan_item.pembelian_item.barang_id == single.id_barang).Sum(p => (p.banyak_dikembalikan.Value * p.pengambilan_item.pembelian_item.harga_satuan.Value));
                            //iterasi pengambilan per ID barang
                            double jumlah_diambil = 0;
                            double harga_pembelian = 0;
                            foreach (var item in pengambilan_per_id)
                            {
                                jumlah_diambil += item.banyak_barang.Value;
                                harga_pembelian += (item.banyak_barang.Value * item.pembelian_item.harga_satuan.Value);
                            }
                            single.jumlah_diambil = jumlah_diambil;
                            single.harga_pembelian = harga_pembelian;
                            result.Add(single);
                        }

                    }
                }
                return result;
            }
        }

        public IEnumerable<LaporanKategoriModel> GetProductDetailsByCategory(DateTime from,
            DateTime to, Guid selectedCategory)
        {
            using (dbContent = new MerapiGolfLogistikEntities())
            {
                var result = new List<LaporanKategoriModel>();
                var barangs = dbContent.mg_barang.ToList();
                if (selectedCategory != Guid.Empty)
                    barangs = barangs.Where(p => p.id_kategori == selectedCategory).ToList();
                var pembelian_items = dbContent.mg_pembelian_item.Where(p => p.pembelian.tanggal.HasValue).ToList();
                //pembelian_items = pembelian_items.Where(p => p.pembelian.tanggal.Value.Subtract(from).TotalDays >= 0 &&
                //p.pembelian.tanggal.Value.Subtract(to).TotalDays <= 0).ToList();
                var pengambilan_items = dbContent.mg_pengambilan_item.Where(p => p.pengambilan.tanggal.HasValue).ToList();
                //pengambilan_items = pengambilan_items.Where(p => p.pengambilan.tanggal.Value.Subtract(from).TotalDays >= 0 &&
                //p.pengambilan.tanggal.Value.Subtract(to).TotalDays <= 0).ToList();
                var pengembalian_items = dbContent.mg_pengembalian_item.Where(p => p.pengembalian.tanggal.HasValue).ToList();
                //pengembalian_items = pengembalian_items.Where(p => p.pengembalian.tanggal.Value.Subtract(from).TotalDays >= 0 &&
                //p.pengembalian.tanggal.Value.Subtract(from).TotalDays <= 0).ToList();

                //group by category
                var barangs_group = barangs.GroupBy(p => p.id_kategori);
                //iterate group
                foreach (var barang_group in barangs_group)
                {
                    foreach (var barang in barang_group)
                    {
                        Guid id_barang = barang.id;
                        LaporanKategoriModel item = new LaporanKategoriModel();
                        item.id_kategori = barang_group.Key.Value;
                        item.nama_kategori = barang.kategori.nama_kategori;
                        item.subsi_kategori = barang.kategori.subsi;
                        item.id_barang = barang.id;
                        item.subsi_barang = barang.subsi;
                        item.nama_barang = barang.nama_barang;
                        //STOCK SECTION
                        //saldo stok
                        var saldostok = pembelian_items.Where(p => p.barang_id == id_barang &&
                        p.pembelian.tanggal.Value.Subtract(from).TotalDays < 0).Sum(p => p.banyak_barang.Value) -
                        pengambilan_items.Where(p => p.pembelian_item.barang_id == id_barang && p.pengambilan.tanggal.Value.Subtract(from).TotalDays < 0).Sum(p => p.banyak_barang.Value) +
                        pengembalian_items.Where(p => p.pengambilan_item.pembelian_item.barang_id == id_barang &&
                        p.pengembalian.tanggal.Value.Subtract(from).TotalDays < 0).Sum(p => p.banyak_dikembalikan.Value);
                        //stok masuk, keluar, kembali
                        var stokmasuk =
                              (pembelian_items.Where(p => p.barang_id == id_barang &&
                        p.pembelian.tanggal.Value.Subtract(to).TotalDays <= 0).ToList().Sum(p => p.banyak_barang.Value)
                        - pembelian_items.Where(p => p.barang_id == id_barang &&
                     p.pembelian.tanggal.Value.Subtract(from).TotalDays < 0).ToList().Sum(p => p.banyak_barang.Value));
                        var stokkeluar = (pengambilan_items.Where(p => p.pembelian_item.barang_id == id_barang &&
                        p.pengambilan.tanggal.Value.Subtract(to).TotalDays <= 0).ToList().Sum(p => p.banyak_barang.Value) -
                        pengambilan_items.Where(p => p.pembelian_item.barang_id == id_barang &&
                        p.pengambilan.tanggal.Value.Subtract(from).TotalDays < 0).ToList().Sum(p => p.banyak_barang.Value));
                        var stokkembali = (pengembalian_items.Where(p => p.pengambilan_item.pembelian_item.barang_id == id_barang &&
                         p.pengembalian.tanggal.Value.Subtract(to).TotalDays <= 0).ToList().Sum(p => p.banyak_dikembalikan.Value) -
                        pengembalian_items.Where(p => p.pengambilan_item.pembelian_item.barang_id == id_barang &&
                         p.pengembalian.tanggal.Value.Subtract(from).TotalDays < 0).ToList().Sum(p => p.banyak_dikembalikan.Value));
                        var sisa = (saldostok + (stokmasuk + stokkembali)) - stokkeluar;

                        //PRICE SECTION
                        var saldo = pembelian_items.Where(p => p.barang_id == id_barang &&
                       p.pembelian.tanggal.Value.Subtract(from).TotalDays < 0).Sum(p => (p.banyak_barang.Value * p.harga_satuan.Value)) -
                       pengambilan_items.Where(p => p.pembelian_item.barang_id == id_barang && p.pengambilan.tanggal.Value.Subtract(from).TotalDays < 0).Sum(p => (p.banyak_barang.Value * p.pembelian_item.harga_satuan.Value)) +
                       pengembalian_items.Where(p => p.pengambilan_item.pembelian_item.barang_id == id_barang &&
                       p.pengembalian.tanggal.Value.Subtract(from).TotalDays < 0).Sum(p => (p.banyak_dikembalikan.Value * p.pengambilan_item.pembelian_item.harga_satuan.Value));
                        var saldomasuk =
                             (pembelian_items.Where(p => p.barang_id == id_barang &&
                       p.pembelian.tanggal.Value.Subtract(to).TotalDays <= 0).ToList().Sum(p => (p.banyak_barang.Value * p.harga_satuan.Value))
                       - pembelian_items.Where(p => p.barang_id == id_barang &&
                    p.pembelian.tanggal.Value.Subtract(from).TotalDays < 0).ToList().Sum(p => (p.banyak_barang.Value * p.harga_satuan.Value)));
                        var saldokeluar = (pengambilan_items.Where(p => p.pembelian_item.barang_id == id_barang &&
                        p.pengambilan.tanggal.Value.Subtract(to).TotalDays <= 0).ToList().Sum(p => (p.banyak_barang.Value * p.pembelian_item.harga_satuan.Value)) -
                        pengambilan_items.Where(p => p.pembelian_item.barang_id == id_barang &&
                        p.pengambilan.tanggal.Value.Subtract(from).TotalDays < 0).ToList().Sum(p => (p.banyak_barang.Value * p.pembelian_item.harga_satuan.Value)));
                        var saldokembali = (pengembalian_items.Where(p => p.pengambilan_item.pembelian_item.barang_id == id_barang &&
                         p.pengembalian.tanggal.Value.Subtract(to).TotalDays <= 0).ToList().Sum(p => (p.banyak_dikembalikan.Value * p.pengambilan_item.pembelian_item.harga_satuan.Value)) -
                        pengembalian_items.Where(p => p.pengambilan_item.pembelian_item.barang_id == id_barang &&
                         p.pengembalian.tanggal.Value.Subtract(from).TotalDays < 0).ToList().Sum(p => (p.banyak_dikembalikan.Value * p.pengambilan_item.pembelian_item.harga_satuan.Value)));
                        //MessageBox.Show(item.nama_barang + ", saldo: " + saldostok.ToString()
                        //    + ", masuk: " + stokmasuk.ToString() + ", keluar: " + stokkeluar.ToString() + ", kembali: " + stokkembali.ToString() + ", sisa: " + sisa.ToString());
                        item.stok = saldostok;
                        item.stokmasuk = stokmasuk;
                        item.stokkeluar = stokkeluar;
                        item.stokkembali = stokkembali;
                        item.saldo = saldo;
                        item.saldomasuk = saldomasuk;
                        item.saldokeluar = saldokeluar;
                        item.saldokembali = saldokembali;
                        result.Add(item);
                    }
                }


                return result;
            }
        }

        public IEnumerable<LaporanPergerakanModel> GetMovementReport(Guid categoryId,
            DateTime from, DateTime to)
        {
            using (dbContent = new MerapiGolfLogistikEntities())
            {
                List<LaporanPergerakanModel> result = new List<LaporanPergerakanModel>();
                var pembelians = dbContent.mg_pembelian.Where(p => p.tanggal.HasValue).ToList();
                pembelians = pembelians.Where(p => p.tanggal.Value.Subtract(from).TotalDays >= 0 &&
                p.tanggal.Value.Subtract(to).TotalDays <= 0).ToList();
                var pengambilans = dbContent.mg_pengambilan.Where(p => p.tanggal.HasValue).ToList();
                pengambilans = pengambilans.Where(p => p.tanggal.Value.Subtract(from).TotalDays >= 0 &&
               p.tanggal.Value.Subtract(to).TotalDays <= 0).ToList();
                var pengembalians = dbContent.mg_pengembalian.Where(p => p.tanggal.HasValue).ToList();
                pengembalians = pengembalians.Where(p => p.tanggal.Value.Subtract(from).TotalDays >= 0 &&
            p.tanggal.Value.Subtract(to).TotalDays <= 0).ToList();
                //all tables
                var pembelian_items = dbContent.mg_pembelian_item.Where(p => p.pembelian.tanggal.HasValue).ToList();
                var pengambilan_items = dbContent.mg_pengambilan_item.Where(p => p.pengambilan.tanggal.HasValue).ToList();
                var pengembalian_items = dbContent.mg_pengembalian_item.Where(p => p.pengembalian.tanggal.HasValue).ToList();
                var barangs = dbContent.mg_barang.ToList();
                if (categoryId != Guid.Empty)
                    barangs = barangs.Where(p => p.id_kategori == categoryId).ToList();

                var barangs_grp = barangs.GroupBy(p => p.id_kategori);
                //iterate on categories
                foreach (var barang_grp in barangs_grp)
                {
                    //iterate on items
                    foreach (var barang in barang_grp)
                    {
                        //select all parent tables
                        var pembelians_parent = pembelians.Where(p => p.pembelian_item.Where(q => q.barang_id == barang.id).Count() > 0).ToList();
                        var pengambilans_parent = pengambilans.Where(p => p.pengambilan_item.Where(q => q.pembelian_item.barang_id == barang.id).Count() > 0).ToList();
                        var pengembalians_parent = pengembalians.Where(p => p.pengembalian_item.Where(q => q.pengambilan_item.pembelian_item.barang_id == barang.id).Count() > 0).ToList();



                        //iterate per pembelian
                        foreach (var pembelian in pembelians_parent)
                        {
                            var item = AddToMovementItem(barang);
                            item.tipe_pergerakan = TipePergerakan.Pembelian;
                            item.tanggal_trx = pembelian.tanggal.Value;

                            var selectCurrent = result.FirstOrDefault(p => p.tipe_pergerakan == TipePergerakan.Pembelian &&
                             p.id_barang == barang.id && p.tanggal_trx == item.tanggal_trx);
                            bool exists = selectCurrent != null;

                            if (exists)
                                item = selectCurrent;

                            double quantity = item.quantity;
                            double totalprice = item.totalprice;
                            if (pembelian.pembelian_item.Count > 0)
                            {
                                var pembs = pembelian.pembelian_item.Where(p => p.barang_id == barang.id).ToList();
                                foreach (var pembelian_item in pembs)
                                {
                                    quantity += pembelian_item.banyak_barang.Value;
                                    totalprice += (pembelian_item.banyak_barang.Value *
                                        pembelian_item.harga_satuan.Value);
                                }
                            }

                            item.quantity = quantity;
                            item.totalprice = totalprice;
                            var pembelian_items_filtered = pembelian_items.Where(p => p.barang_id == barang.id).ToList();
                            var pengambilan_items_filtered = pengambilan_items.Where(p => p.pembelian_item.barang_id == barang.id).ToList();
                            var pengembalian_items_filtered = pengembalian_items.Where(p => p.pengambilan_item.pembelian_item.barang_id == barang.id).ToList();
                            if (!exists)
                            {
                                item.quantity_awal =
                               pembelian_items_filtered.Where(p => p.pembelian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays < 0).Sum(p => p.banyak_barang.Value) -
                               pengambilan_items_filtered.Where(p => p.pengambilan.tanggal.Value.Subtract(item.tanggal_trx).TotalDays < 0).Sum(p => p.banyak_barang.Value) +
                               pengembalian_items_filtered.Where(p => p.pengembalian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays < 0).Sum(p => p.banyak_dikembalikan.Value);
                                item.balance_awal =
                              pembelian_items_filtered.Where(p => p.pembelian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays < 0).Sum(p => (p.banyak_barang.Value * p.harga_satuan.Value)) -
                              pengambilan_items_filtered.Where(p => p.pengambilan.tanggal.Value.Subtract(item.tanggal_trx).TotalDays < 0).Sum(p => (p.banyak_barang.Value * p.pembelian_item.harga_satuan.Value)) +
                              pengembalian_items_filtered.Where(p => p.pengembalian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays < 0).Sum(p => (p.banyak_dikembalikan.Value * p.pengambilan_item.pembelian_item.harga_satuan.Value));
                                item.quantity_balance = pembelian_items_filtered.Where(p => p.pembelian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays <= 0).Sum(p => p.banyak_barang.Value) -
                                    pengambilan_items_filtered.Where(p => p.pengambilan.tanggal.Value.Subtract(item.tanggal_trx).TotalDays < 0).Sum(p => p.banyak_barang.Value) +
                                    pengembalian_items_filtered.Where(p => p.pengembalian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays < 0).Sum(p => p.banyak_dikembalikan.Value);
                                item.balance = pembelian_items_filtered.Where(p => p.pembelian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays <= 0).Sum(p => (p.banyak_barang.Value * p.harga_satuan.Value)) -
                                    pengambilan_items_filtered.Where(p => p.pengambilan.tanggal.Value.Subtract(item.tanggal_trx).TotalDays < 0).Sum(p => (p.banyak_barang.Value * p.pembelian_item.harga_satuan.Value)) +
                                    pengembalian_items_filtered.Where(p => p.pengembalian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays < 0).Sum(p => (p.banyak_dikembalikan.Value * p.pengambilan_item.pembelian_item.harga_satuan.Value));
                                result.Add(item);
                            }
                        }

                        //iterate per pengambilan
                        foreach (var pengambilan in pengambilans_parent)
                        {
                            var item = AddToMovementItem(barang);
                            item.tipe_pergerakan = TipePergerakan.Pengambilan;
                            item.tanggal_trx = pengambilan.tanggal.Value;

                            var selectCurrent = result.FirstOrDefault(p => p.tipe_pergerakan == TipePergerakan.Pengambilan &&
                              p.id_barang == barang.id && p.tanggal_trx == item.tanggal_trx);
                            bool exists = selectCurrent != null;

                            if (exists)
                                item = selectCurrent;

                            double quantity = item.quantity;
                            double totalprice = item.totalprice;
                            if (pengambilan.pengambilan_item.Count > 0)
                            {
                                var pengs = pengambilan.pengambilan_item.Where(p => p.pembelian_item.barang_id == barang.id).ToList();
                                foreach (var pengambilan_item in pengs)
                                {
                                    quantity += pengambilan_item.banyak_barang.Value;
                                    totalprice += (pengambilan_item.banyak_barang.Value *
                                        pengambilan_item.pembelian_item.harga_satuan.Value);
                                }
                            }

                            item.quantity = quantity;
                            item.totalprice = totalprice;
                            var pembelian_items_filtered = pembelian_items.Where(p => p.barang_id == barang.id).ToList();
                            var pengambilan_items_filtered = pengambilan_items.Where(p => p.pembelian_item.barang_id == barang.id).ToList();
                            var pengembalian_items_filtered = pengembalian_items.Where(p => p.pengambilan_item.pembelian_item.barang_id == barang.id).ToList();
                            if (!exists)
                            {
                                item.quantity_awal =
                                   pembelian_items_filtered.Where(p => p.pembelian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays <= 0).Sum(p => p.banyak_barang.Value) -
                               pengambilan_items_filtered.Where(p => p.pengambilan.tanggal.Value.Subtract(item.tanggal_trx).TotalDays < 0).Sum(p => p.banyak_barang.Value) +
                               pengembalian_items_filtered.Where(p => p.pengembalian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays < 0).Sum(p => p.banyak_dikembalikan.Value);
                                item.balance_awal =
                              pembelian_items_filtered.Where(p => p.pembelian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays <= 0).Sum(p => (p.banyak_barang.Value * p.harga_satuan.Value)) -
                              pengambilan_items_filtered.Where(p => p.pengambilan.tanggal.Value.Subtract(item.tanggal_trx).TotalDays < 0).Sum(p => (p.banyak_barang.Value * p.pembelian_item.harga_satuan.Value)) +
                              pengembalian_items_filtered.Where(p => p.pengembalian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays < 0).Sum(p => (p.banyak_dikembalikan.Value * p.pengambilan_item.pembelian_item.harga_satuan.Value));
                                item.quantity_balance = pembelian_items_filtered.Where(p => p.pembelian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays <= 0).Sum(p => p.banyak_barang.Value) -
                                    pengambilan_items_filtered.Where(p => p.pengambilan.tanggal.Value.Subtract(item.tanggal_trx).TotalDays <= 0).Sum(p => p.banyak_barang.Value) +
                                    pengembalian_items_filtered.Where(p => p.pengembalian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays < 0).Sum(p => p.banyak_dikembalikan.Value);
                                item.balance = pembelian_items_filtered.Where(p => p.pembelian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays <= 0).Sum(p => (p.banyak_barang.Value * p.harga_satuan.Value)) -
                                    pengambilan_items_filtered.Where(p => p.pengambilan.tanggal.Value.Subtract(item.tanggal_trx).TotalDays <= 0).Sum(p => (p.banyak_barang.Value * p.pembelian_item.harga_satuan.Value)) +
                                    pengembalian_items_filtered.Where(p => p.pengembalian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays < 0).Sum(p => (p.banyak_dikembalikan.Value * p.pengambilan_item.pembelian_item.harga_satuan.Value));
                                result.Add(item);
                            }
                        }

                        //iterate per pengembalian
                        foreach (var pengembalian in pengembalians_parent)
                        {
                            var item = AddToMovementItem(barang);
                            item.tipe_pergerakan = TipePergerakan.Pengembalian;
                            item.tanggal_trx = pengembalian.tanggal.Value;

                            var selectCurrent = result.FirstOrDefault(p => p.tipe_pergerakan == TipePergerakan.Pengembalian &&
                             p.id_barang == barang.id && p.tanggal_trx == item.tanggal_trx);
                            bool exists = selectCurrent != null;

                            if (exists)
                                item = selectCurrent;

                            double quantity = item.quantity;
                            double totalprice = item.totalprice;
                            if (pengembalian.pengembalian_item.Count > 0)
                            {
                                var pengembs = pengembalian.pengembalian_item.Where(p => p.pengambilan_item.pembelian_item.barang_id == barang.id).ToList();
                                foreach (var pengembalian_item in pengembs)
                                {
                                    quantity += pengembalian_item.banyak_dikembalikan.Value;
                                    totalprice += (pengembalian_item.banyak_dikembalikan.Value *
                                        pengembalian_item.pengambilan_item.pembelian_item.harga_satuan.Value);
                                }
                            }

                            item.quantity = quantity;
                            item.totalprice = totalprice;
                            var pembelian_items_filtered = pembelian_items.Where(p => p.barang_id == barang.id).ToList();
                            var pengambilan_items_filtered = pengambilan_items.Where(p => p.pembelian_item.barang_id == barang.id).ToList();
                            var pengembalian_items_filtered = pengembalian_items.Where(p => p.pengambilan_item.pembelian_item.barang_id == barang.id).ToList();

                            if (!exists)
                            {
                                item.quantity_awal =
                               pembelian_items_filtered.Where(p => p.pembelian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays <= 0).Sum(p => p.banyak_barang.Value) -
                               pengambilan_items_filtered.Where(p => p.pengambilan.tanggal.Value.Subtract(item.tanggal_trx).TotalDays <= 0).Sum(p => p.banyak_barang.Value) +
                               pengembalian_items_filtered.Where(p => p.pengembalian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays < 0).Sum(p => p.banyak_dikembalikan.Value);
                                item.balance_awal =
                              pembelian_items_filtered.Where(p => p.pembelian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays <= 0).Sum(p => (p.banyak_barang.Value * p.harga_satuan.Value)) -
                              pengambilan_items_filtered.Where(p => p.pengambilan.tanggal.Value.Subtract(item.tanggal_trx).TotalDays <= 0).Sum(p => (p.banyak_barang.Value * p.pembelian_item.harga_satuan.Value)) +
                              pengembalian_items_filtered.Where(p => p.pengembalian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays < 0).Sum(p => (p.banyak_dikembalikan.Value * p.pengambilan_item.pembelian_item.harga_satuan.Value));
                                item.quantity_balance = pembelian_items_filtered.Where(p => p.pembelian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays <= 0).Sum(p => p.banyak_barang.Value) -
                                    pengambilan_items_filtered.Where(p => p.pengambilan.tanggal.Value.Subtract(item.tanggal_trx).TotalDays <= 0).Sum(p => p.banyak_barang.Value) +
                                    pengembalian_items_filtered.Where(p => p.pengembalian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays <= 0).Sum(p => p.banyak_dikembalikan.Value);
                                item.balance = pembelian_items_filtered.Where(p => p.pembelian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays <= 0).Sum(p => (p.banyak_barang.Value * p.harga_satuan.Value)) -
                                    pengambilan_items_filtered.Where(p => p.pengambilan.tanggal.Value.Subtract(item.tanggal_trx).TotalDays <= 0).Sum(p => (p.banyak_barang.Value * p.pembelian_item.harga_satuan.Value)) +
                                    pengembalian_items_filtered.Where(p => p.pengembalian.tanggal.Value.Subtract(item.tanggal_trx).TotalDays <= 0).Sum(p => (p.banyak_dikembalikan.Value * p.pengambilan_item.pembelian_item.harga_satuan.Value));
                                result.Add(item);
                            }

                        }
                    }
                }

                return result.OrderBy(p => p.tanggal_trx).OrderBy(p => p.id_barang).ToList();
            }
        }

        private static LaporanPergerakanModel AddToMovementItem(Barang barang)
        {
            LaporanPergerakanModel item = new LaporanPergerakanModel();
            item.id_kategori = barang.id_kategori.Value;
            item.subsi_kategori = barang.kategori.subsi;
            item.nama_kategori = barang.kategori.nama_kategori;
            item.id_barang = barang.id;
            item.subsi_barang = barang.subsi;
            item.nama_barang = barang.nama_barang;
            return item;
        }
    }
}
