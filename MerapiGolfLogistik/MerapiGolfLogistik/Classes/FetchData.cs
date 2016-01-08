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
                    categories = dbContent.mg_kategori.ToList();
                else
                {
                    string queryLower = query.ToLower();
                    categories = dbContent.mg_kategori.Where(p => p.nama_kategori.Contains(queryLower)).ToList();
                }
                int index = 1;
                categories = categories.OrderBy(p => p.inputdate).ToList();
                foreach (var Kategori in categories)
                {
                    MerapiGolfLogistik.Models.CategoryView cat = new Models.CategoryView();
                    cat.id = Kategori.id;
                    cat.index = index.ToString().PadLeft(7, '0');
                    cat.nama_kategori = Kategori.nama_kategori;
                    cat.stock = Kategori.barang.Count;
                    result.Add(cat);
                    index++;
                }
                return result;
            }
        }
    }
}
