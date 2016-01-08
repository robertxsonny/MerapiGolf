using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerapiGolfLogistik.Models
{
    public class CategoryView : MerapiGolfLogistik.Kategori
    {
        public int stock { get; set; }
        public string index { get; set; }
    }
}
