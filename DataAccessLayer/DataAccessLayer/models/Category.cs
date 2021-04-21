using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.models
{
    public class Category: commonModels
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public string Opretion { get; set; }
    }
    public class subCategory:Category
    {
        public int subCategoryId { get; set; }
        public string subCategoryName { get; set; }
    }
}
