using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerapiGolfLogistik.Models
{
    public class NotaPembelianDetail : NotaPembelian
    {
        public List<TotalPembelian> items { get; set; }

        public NotaPembelianDetail()
        {

        }

        public NotaPembelianDetail(NotaPembelian nota, List<TotalPembelian> items)
        {
            this.no_nota = nota.no_nota;
            this.nama_karyawan = nota.nama_karyawan;
            this.nama_supplier = nota.nama_supplier;
            this.tanggal = nota.tanggal;
            this.keterangan = nota.keterangan;
            this.total = nota.total;
            this.items = new List<TotalPembelian>();
            foreach (TotalPembelian item in items)
            {
                if (item.no_nota == nota.no_nota)
                    this.items.Add(item);
            }
        }
    }
}
