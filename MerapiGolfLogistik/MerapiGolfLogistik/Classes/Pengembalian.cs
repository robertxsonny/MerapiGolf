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

        public void AddPengembalian(Guid userId, Guid idPengambilanBarang, DateTime tanggal, double banyak, string keterangan)
        {
            retur = new Pengembalian();
            retur.user_id = userId;
            retur.id_pengambilan_barang = idPengambilanBarang;
            retur.tanggal = tanggal;
            retur.banyak_dikembalikan = banyak;
            retur.keterangan = keterangan;
        }

        public void StorePengembalian()
        {
            using (dbContent = new MerapiGolfLogistikEntities())
            {
                dbContent.mg_pengembalian.Add(retur);
                dbContent.SaveChanges();
            }
        }
    }
}
