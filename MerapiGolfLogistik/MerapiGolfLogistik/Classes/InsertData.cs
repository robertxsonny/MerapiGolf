using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerapiGolfLogistik.Classes
{
    public class InsertData
    {
        private MerapiGolfLogistikEntities dbContent;
        public Barang InsertItem(Guid catid, string itemname, string pcs, DateTime inputdate)
        {
            using(dbContent = new MerapiGolfLogistikEntities())
            {
                Barang barang = new Barang();
                barang.id_kategori = catid;
                barang.nama_barang = itemname;
                barang.satuan = pcs;
                barang.id = Guid.NewGuid();
                barang.tanggalinput = inputdate;
                dbContent.mg_barang.Add(barang);
                dbContent.SaveChanges();
                return barang;
            }
        }
    }
}
