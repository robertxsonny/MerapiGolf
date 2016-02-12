using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerapiGolfLogistik.Models
{
    public class LaporanAktivaModel
    {
        public Guid id_aktiva { get; set; }
        public string nama_aktiva { get; set; }
        public string nama_barang { get; set; }
        public Guid id_barang { get; set; }
        public string subsi_barang { get; set; }
        public string keterangan_aktiva { get; set; }
        public double jumlah_diambil { get; set; }
        public double harga_pembelian { get; set; }
        public double harga_per_unit
        {
            get
            {
                return Math.Round(harga_pembelian / jumlah_diambil);
            }
        }
        public double stokawal { get; set; }
        public double stokakhir { get; set; }
        public double saldoawal { get; set; }
        public double saldoakhir { get; set; }
    }
}
