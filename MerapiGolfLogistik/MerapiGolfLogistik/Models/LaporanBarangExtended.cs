using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerapiGolfLogistik.Models
{
    public class LaporanBarangExtended : mg_laporan_gudang
    {
        public double stokAwal { get; set; }
        public double hargaSatuan
        {
            get
            {
                return saldoAwal / stokAwal;
            }
        }
        public double saldoAwal { get; set; }
    }
}
