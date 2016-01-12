using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MerapiGolfLogistik.Models;

namespace MerapiGolfLogistik.Classes
{
    public class FetchData
    {
        private MerapiGolfLogistikEntities dbContent;
        public IEnumerable<MerapiGolfLogistik.Models.CategoryView> GetCategory(string query)
        {
            using(dbContent = new MerapiGolfLogistikEntities())
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
                    cat.stock = Kategori.barang.Count;
                    result.Add(cat);
                    index++;
                }
                return result;
            }
        }

        public IEnumerable<ItemView> GetItems(string query)
        {
            using(dbContent = new MerapiGolfLogistikEntities())
            {
                var res = new List<ItemView>();
                List<Barang> items = new List<Barang>();
                if (String.IsNullOrWhiteSpace(query))
                    items = dbContent.mg_barang.ToList();
                else
                    items = dbContent.mg_barang.Where(p => p.nama_barang.Contains(query.ToLower())).ToList();

                if(items.Count != 0)
                {
                    foreach (var item in items)
                    {
                        ItemView itemview = new ItemView();
                        itemview.id = item.id;
                        itemview.id_kategori = item.id_kategori;
                        itemview.itemcount = item.pembelian_item.Count;
                        if (itemview.itemcount != 0)
                        {
                            if(item.pembelian_item.Count != 0)
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
    }
}
