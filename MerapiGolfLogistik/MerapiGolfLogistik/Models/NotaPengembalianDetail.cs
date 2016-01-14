using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerapiGolfLogistik.Models
{
    public class NotaPengembalianDetail : NotaPengambilan
    {
        public List<PengembalianPerBarang> items { get; set; }

        public NotaPengembalianDetail()
        {

        }

        public NotaPengembalianDetail(NotaPengembalian nota, List<PengembalianPerBarang> items)
        {
            this.no_nota = nota.no_nota;
            this.nama_karyawan = nota.nama_karyawan;
            this.tanggal = nota.tanggal;
            this.keterangan = nota.keterangan;
            this.items = new List<PengembalianPerBarang>();
            foreach (PengembalianPerBarang item in items)
            {
                if (item.no_nota == nota.no_nota)
                    this.items.Add(item);
            }
        }


    }
}
