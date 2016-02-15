using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerapiGolfLogistik.Models
{
    public enum TipePergerakan
    {
        Pembelian,
        Pengambilan,
        Pengembalian
    }

    public class LaporanPergerakanModel
    {
        public Guid id_kategori { get; set; }
        public string subsi_kategori { get; set; }
        public string nama_kategori { get; set; }
        public Guid id_barang { get; set; }
        public string subsi_barang { get; set; }
        public string nama_barang { get; set; }
        public TipePergerakan tipe_pergerakan { get; set; }
        public string tipe_pergerakan_str
        {
            get
            {
                if (this.tipe_pergerakan == TipePergerakan.Pembelian)
                    return "Pembelian";
                else if (this.tipe_pergerakan == TipePergerakan.Pengambilan)
                    return "Pengambilan";
                else return "Pengembalian";
            }
        }
        public DateTime tanggal_trx { get; set; }
        public double quantity { get; set; }
        public double totalprice { get; set; }
        public double unitprice
        {
            get
            {
                return totalprice / quantity;
            }
        }
        public double quantity_awal { get; set; }
        public double quantity_balance { get; set; }
        public double balance { get; set; }
    }
}
