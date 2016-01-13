using MerapiGolfLogistik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerapiGolfLogistik.Classes
{
    public class PengambilanBarang
    {
        private MerapiGolfLogistikEntities dbContent;

        private Pengambilan nota;

        private List<PengambilanItem> items;

        public void AddPengambilan(string nomorNota, DateTime tanggal, string keterangan, Guid userId)
        {
            nota = new Pengambilan();
            nota.id = nomorNota;
            nota.tanggal = tanggal;
            nota.keterangan = keterangan;
            nota.user_id = userId;
            items = new List<PengambilanItem>();
        }

        public void AddItem(Guid barangId, double jumlah, Guid aktivaId)
        {
            using (dbContent = new MerapiGolfLogistikEntities())
            {
                List<StokBarang> barang = dbContent.mg_stok_barang.Where(p => p.id_barang == barangId).OrderBy(p => p.tanggal_masuk).ToList();
                double num = jumlah;
                int i = 0;
                if (items == null)
                    items = new List<PengambilanItem>();
                while (num > 0)
                {
                    PengambilanItem item = new PengambilanItem();
                    item.no_nota = nota.id;
                    item.id_aktiva = aktivaId;
                    item.id_pembelian_barang = barang[i].id;
                    item.banyak_barang = Math.Min(num, (barang[i].stok.HasValue ? barang[i].stok.Value : 0));
                    items.Add(item);
                    i++;
                    num -= (item.banyak_barang.HasValue ? item.banyak_barang.Value : 0);
                }

            }
            
        }

        public void StorePengambilan()
        {
            using (dbContent = new MerapiGolfLogistikEntities())
            {
                dbContent.mg_pengambilan.Add(nota);
                foreach (PengambilanItem item in items)
                {
                    item.no_nota = nota.id;
                    dbContent.mg_pengambilan_item.Add(item);
                }
                dbContent.SaveChanges();
            }
        }

        public NotaPengambilanDetail GetNotaPengambilan()
        {
            using (dbContent = new MerapiGolfLogistikEntities())
            {
                NotaPengambilan notaview = dbContent.mg_nota_pengambilan.Where(n => n.no_nota == nota.id).FirstOrDefault();
                List<PengambilanPerBarang> notadetailview = dbContent.mg_pengambilan_per_barang.Where(t => t.no_nota == nota.id).ToList();
                return new NotaPengambilanDetail(notaview, notadetailview);
            }

        }
    }
}
