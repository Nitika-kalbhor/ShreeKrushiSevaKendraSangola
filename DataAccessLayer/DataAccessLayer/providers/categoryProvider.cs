using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using DataAccessLayer.models;

namespace DataAccessLayer.providers
{
   public class categoryProvider
    {
        public static int addCategoryDetails(int categoryId,string categoryName)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@categoryId", categoryId));
                parameter.Add(new KeyValuePair<string, object>("@categoryName", categoryName));
                parameter.Add(new KeyValuePair<string, object>("@addedBy", 1));
                parameter.Add(new KeyValuePair<string, object>("@addedOn",DateTime.Now));              
                SqlHandler sqlH = new SqlHandler();
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_addCategoryDetails]", parameter);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static int DeleteIsActiveCategory(long categoryId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@categoryId", categoryId));              
                parameter.Add(new KeyValuePair<string, object>("@addedBy", 1));
                parameter.Add(new KeyValuePair<string, object>("@addedOn", DateTime.Now));               
                SqlHandler sqlH = new SqlHandler();
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_DeleteIsActiveCategory]", parameter);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static int DeleteIsActiveSubCategory(int subCategoryId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@subCategoryId", subCategoryId));
                parameter.Add(new KeyValuePair<string, object>("@addedBy", 1));
                parameter.Add(new KeyValuePair<string, object>("@addedOn", DateTime.Now));
                SqlHandler sqlH = new SqlHandler();
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_DeleteIsActiveSubCategory]", parameter);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static DataTable getCategoryDetails()
        {
            try
            {
            
                SqlHandler sqlH = new SqlHandler();
                DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getCategoryDetails]");
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static DataTable getSubCategoryDetails()
        {
            try
            {

                SqlHandler sqlH = new SqlHandler();
                DataTable i = sqlH.ExecuteAsDataTable("[dbo].[Usp_getSubCategoryDetails]");
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }

        public static DataTable getSubCategoryBySearch(int categoryId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@categoryId", categoryId));
                SqlHandler sqlH = new SqlHandler();
                DataTable listI = sqlH.ExecuteAsDataTable("[dbo].[Usp_getSubCategoryBySearch]", parameter);
                return listI;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static int addSubCategoryDetails(int subCategoryId,int categoryId,string subCategoryName)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@subCategoryId", subCategoryId));
                parameter.Add(new KeyValuePair<string, object>("@categoryId", categoryId));
                parameter.Add(new KeyValuePair<string, object>("@subCategoryName", subCategoryName));
                parameter.Add(new KeyValuePair<string, object>("@addedBy", 1));
                parameter.Add(new KeyValuePair<string, object>("@addedOn", DateTime.Now));
                SqlHandler sqlH = new SqlHandler();
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_addSubCategoryDetails]", parameter);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
    }
}
