using MerapiGolfLogistik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerapiGolfLogistik.Classes
{
    public class PengembalianBarang
    {
        private MerapiGolfLogistikEntities dbContent;

        private Pengembalian retur;

        private List<PengembalianItem> items;

        public void AddPengembalian(Guid userId, DateTime tanggal, string keterangan)
        {
            retur = new Pengembalian();
            retur.user_id = userId;
            retur.tanggal = tanggal;
            retur.keterangan = keterangan;
        }

        public void AddItem(Guid barangId, string nomorNotaPengambilan, double banyakDikembalikan)
        {
            using (dbContent = new MerapiGolfLogistikEntities())
            {
                List<TotalPengambilan> pengambilan = dbContent.mg_total_pengambilan.Where(p => p.no_nota == nomorNotaPengambilan && p.id_barang == barangId)
                    .OrderByDescending(p => p.tanggal_masuk).ToList();
                double num = banyakDikembalikan;
                int i = 0;
                if (items == null)
                    items = new List<PengembalianItem>();
                while (num > 0)
                {
                    PengembalianItem item = new PengembalianItem();
                    item.no_nota = retur.id;
                    item.id_pengambilan_barang = pengambilan[i].id;
                    item.banyak_dikembalikan = Math.Min(num, (pengambilan[i].banyak_barang.HasValue ? pengambilan[i].banyak_barang.Value : 0));
                    items.Add(item);
                    i++;
                    num -= (item.banyak_dikembalikan.HasValue ? item.banyak_dikembalikan.Value : 0);
                }

            }
        }

        public void StorePengembalian()
        {
            using (dbContent = new MerapiGolfLogistikEntities())
            {
                dbContent.mg_pengembalian.Add(retur);
                foreach (PengembalianItem item in items)
                {
                    item.no_nota = retur.id;
                    dbContent.mg_pengembalian_item.Add(item);
                }
                dbContent.SaveChanges();
            }
        }

        public NotaPengembalianDetail GenerateNotaPengembalian(NotaPengembalian nota, List<PengembalianPerBarang> items)
        {
            NotaPengembalian notaview = dbContent.mg_nota_pengembalian.Where(n => n.no_nota == nota.no_nota).FirstOrDefault();
            List<PengembalianPerBarang> notadetailview = dbContent.mg_pengembalian_per_barang.Where(t => t.no_nota == nota.no_nota).ToList();
            return new NotaPengembalianDetail(notaview, notadetailview);
        }
    }
}
