using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAccessLayer.models
{
    public class Category : commonModels
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public string Opretion { get; set; }
    }
    public class subCategory : Category
    {
        public int subCategoryId { get; set; }
        public string subCategoryName { get; set; }
    }

    public class Company: Category
    {
        public int companyId { get; set; }
        public string companyName { get; set; }
    }
}
