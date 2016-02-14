using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerapiGolfLogistik.Models
{
    public class LaporanKategoriModel
    {
        public string nama_kategori { get; set; }
        public Guid id_kategori { get; set; }
        public string subsi_kategori { get; set; }
        public Guid id_barang { get; set; }
        public string subsi_barang { get; set; }
        public string nama_barang { get; set; }
        public double stok { get; set; }
        public double stokmasuk { get; set; }
        public double stokkeluar { get; set; }
        public double stokkembali { get; set; }
        public double sisastok
        {
            get
            {
                return (stok + stokmasuk) - (stokkeluar - stokkembali);
            }
        }
        public double saldo { get; set; }
        public double saldomasuk { get; set; }
        public double saldokeluar { get; set; }
        public double saldokembali { get; set; }
        public double sisasaldo
        {
            get
            {
                return (saldo + saldomasuk) - (saldokeluar - stokkembali);
            }
        }
    }
}
