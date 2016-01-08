using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerapiGolfLogistik.Models
{
    public class ItemView : MerapiGolfLogistik.Barang
    {
        public int itemcount { get; set; }
        public string lastcreateditemdate { get; set; }
        public string categoryname { get; set; }
    }
}
