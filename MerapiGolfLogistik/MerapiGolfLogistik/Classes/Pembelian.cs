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

        public List<PembelianItem> items;

        public void AddPembelian(string nomorNota, DateTime tanggal, string keterangan, Guid userId, Guid supplierId, string pembeli)
        {
            nota = new Pembelian();
            nota.id = nomorNota;
            nota.tanggal = tanggal;
            nota.keterangan = keterangan;
            nota.user_id = userId;
            nota.supplier_id = supplierId;
            nota.nama_pembeli = pembeli;
            items = new List<PembelianItem>();
        }

        public void AddBarang(Guid barangId, double harga, double jumlah)
        {
            PembelianItem item = new PembelianItem();
            item.no_nota = nota.id;
            item.barang_id = barangId;
            item.harga_satuan = harga;
            item.banyak_barang = jumlah;
            item.id = Guid.NewGuid();
            if (items == null)
                items = new List<PembelianItem>();
            items.Add(item);
        }

        public async Task StorePembelian()
        {
            using (dbContent = new MerapiGolfLogistikEntities())
            {
                //update
                if(dbContent.mg_pembelian.Where(p => p.id == nota.id).ToList().Count > 0)
                {
                    var current = dbContent.mg_pembelian.Where(p => p.id == nota.id).Single();
                    current.keterangan = nota.keterangan;
                    current.supplier_id = nota.supplier_id;
                    current.user_id = nota.user_id;
                    foreach (PembelianItem item in items)
                    {
                        var pembelianitem = current.pembelian_item.Where(p => p.barang_id == item.barang_id).ToList();
                        if (pembelianitem.Count > 0)
                        {
                            var currentitem = pembelianitem.Single();
                            currentitem.banyak_barang = item.banyak_barang;
                            currentitem.harga_satuan = item.harga_satuan;
                            currentitem.barang_id = item.barang_id;
                        }
                    }
                }
                else //create new
                {
                    dbContent.mg_pembelian.Add(nota);
                    foreach (PembelianItem item in items)
                    {
                        item.no_nota = nota.id;
                        dbContent.mg_pembelian_item.Add(item);
                    }
                }
                await dbContent.SaveChangesAsync();
            }
        }

        public NotaPembelianDetail GetNotaPembelian()
        {
            using (dbContent = new MerapiGolfLogistikEntities())
            {
                NotaPembelian notaview = dbContent.mg_nota_pembelian.Where(n => n.no_nota == nota.id).FirstOrDefault();
                if (notaview != null)
                {
                    List<TotalPembelian> notadetailview = dbContent.mg_total_pembelian.Where(t => t.no_nota == nota.id).ToList();
                    return new NotaPembelianDetail(notaview, notadetailview);
                }
                else
                    return new NotaPembelianDetail();
            }
                
        }

        public string GenerateNoNota(string nonota)
        {
            nonota = nonota.ToLower();
            char alpha = nonota.Substring(0, 1).ToCharArray()[0];
            int num = Convert.ToInt32(nonota.Substring(1, 6));
            if (num == 999999) //next alphabet
            {
                if (alpha == 'z')
                    alpha = 'a';
                else
                    alpha = Convert.ToChar(Convert.ToInt32(alpha) + 1);
                num = 1;
            }
            else
                num++;
            return alpha.ToString().ToUpper() + num.ToString().PadLeft(6, '0');
        }

    }
}
