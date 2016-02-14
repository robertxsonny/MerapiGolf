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
        Pengambilan
    }

    public class LaporanPergerakanModel
    {
        public Guid id_kategori { get; set; }
        public string subsi_kategori { get; set; }
        public string nama_kategori { get; set; }
        public Guid id_barang { get; set; }
        public string subsi_barang { get; set; }
        public string nama_barang { get; set; }
    }
}
