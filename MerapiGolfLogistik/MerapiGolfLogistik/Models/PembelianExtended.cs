using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerapiGolfLogistik.Models
{
    public class PembelianExtended : Pembelian
    {
        public bool IsFinished { get; set; }
        public string username { get; set; }
    }
}
