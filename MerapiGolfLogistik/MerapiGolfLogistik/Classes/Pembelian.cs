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

        public NotaPembelianDetail AddPembelian(Pembelian nota, List<PembelianItem> items)
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
                NotaPembelian notaview = dbContent.mg_nota_pembelian.Where(n => n.id == nota.id).FirstOrDefault();
                List<TotalPembelian> notadetailview = dbContent.mg_total_pembelian.Where(t => t.no_nota == nota.id).ToList();
                return new NotaPembelianDetail(notaview, notadetailview);
            }
        }

    }
}
