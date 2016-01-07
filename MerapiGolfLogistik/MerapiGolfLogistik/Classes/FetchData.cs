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
                List<Category> categories = new List<Category>();
                if (String.IsNullOrWhiteSpace(query))
                    categories = dbContent.Categories.ToList();
                else
                {
                    string queryLower = query.ToLower();
                    categories = dbContent.Categories.Where(p => p.categoryname.Contains(queryLower)).ToList();
                }
                   
                foreach (var category in categories)
                {
                    MerapiGolfLogistik.Models.CategoryView cat = new Models.CategoryView();
                    cat.categoryid = category.categoryid;
                    cat.categoryname = category.categoryname;
                    cat.stock = category.Items.Count;
                    result.Add(cat);
                }
                return result;
            }
        }
    }
}
