using MerapiGolfLogistik.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerapiGolfLogistik.Classes
{
    public class PembelianBarang
    {
        private MerapiGolfLogistikEntities dbContent;

        private Pembelian nota;

        private List<PembelianItem> items;

        public void AddPembelian(string nomorNota, DateTime tanggal, string keterangan, Guid userId, Guid supplierId)
        {
            nota = new Pembelian();
            nota.id = nomorNota;
            nota.tanggal = tanggal;
            nota.keterangan = keterangan;
            nota.user_id = userId;
            nota.supplier_id = supplierId;
            items = new List<PembelianItem>();
        }

        public void AddBarang(Guid barangId, double harga, double jumlah)
        {
            PembelianItem item = new PembelianItem();
            item.no_nota = nota.id;
            item.barang_id = barangId;
            item.harga_satuan = harga;
            item.banyak_barang = jumlah;
            if (items == null)
                items = new List<PembelianItem>();
            items.Add(item);
        }

        public void StorePembelian()
        {
            using (dbContent = new MerapiGolfLogistikEntities())
            {
                dbContent.mg_pembelian.Add(nota);
                foreach (PembelianItem item in items)
                {
                    item.no_nota = nota.id;
                    dbContent.mg_pembelian_item.Add(item);
                }
                dbContent.SaveChanges();
            }
        }

        public NotaPembelianDetail GetNotaPembelian()
        {
            using (dbContent = new MerapiGolfLogistikEntities())
            {
                NotaPembelian notaview = dbContent.mg_nota_pembelian.Where(n => n.no_nota == nota.id).FirstOrDefault();
                List<TotalPembelian> notadetailview = dbContent.mg_total_pembelian.Where(t => t.no_nota == nota.id).ToList();
                return new NotaPembelianDetail(notaview, notadetailview);
            }
                
        }

    }
}
