using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerapiGolfLogistik.Models
{
    public class NotaPengambilanDetail : NotaPengambilan
    {
        public List<PengambilanPerBarang> items { get; set; }

        public NotaPengambilanDetail()
        {

        }

        public NotaPengambilanDetail(NotaPengambilan nota, List<PengambilanPerBarang> items)
        {
            this.no_nota = nota.no_nota;
            this.nama_karyawan = nota.nama_karyawan;
            this.tanggal = nota.tanggal;
            this.keterangan = nota.keterangan;
            this.total = nota.total;
            this.items = new List<PengambilanPerBarang>();
            foreach (PengambilanPerBarang item in items)
            {
                if (item.no_nota == nota.no_nota)
                    this.items.Add(item);
            }
        }
    }
}
