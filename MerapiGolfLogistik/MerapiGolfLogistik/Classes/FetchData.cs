using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerapiGolfLogistik.Classes
{
    public class FetchData
    {
        private MerapiGolfLogistikEntities dbContent;
        public IEnumerable<MerapiGolfLogistik.Models.CategoryView> GetCategory(string query)
        {
            using(dbContent = new MerapiGolfLogistikEntities())
            {
                var result = new List<MerapiGolfLogistik.Models.CategoryView>();
                List<Kategori> categories = new List<Kategori>();
                if (String.IsNullOrWhiteSpace(query))
                    categories = dbContent.Kategori.ToList();
                else
                {
                    string queryLower = query.ToLower();
                    categories = dbContent.Kategori.Where(p => p.nama_kategori.Contains(queryLower)).ToList();
                }
                   
                foreach (var Kategori in categories)
                {
                    MerapiGolfLogistik.Models.CategoryView cat = new Models.CategoryView();
                    cat.id = Kategori.id;
                    cat.nama_kategori = Kategori.nama_kategori;
                    cat.stock = Kategori.barang.Count;
                    result.Add(cat);
                }
                return result;
            }
        }
    }
}
