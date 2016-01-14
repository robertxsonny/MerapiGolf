using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerapiGolfLogistik.Models
{
    public class PengambilanItemExtended : Barang
    {
        public string nama_aktiva { get; set; }
        public Guid id_aktiva { get; set; }
        public int jumlah { get; set; }
    }
}
