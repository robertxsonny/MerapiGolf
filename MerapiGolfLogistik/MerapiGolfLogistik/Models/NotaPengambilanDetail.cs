using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerapiGolfLogistik.Models
{
    public class NotaPengambilanDetail : NotaPengambilan
    {
        public List<TotalPembelian> items { get; set; }
    }
}
