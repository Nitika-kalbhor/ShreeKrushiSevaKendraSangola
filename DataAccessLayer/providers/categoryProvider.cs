using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

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
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_addCategoryDeatials]", parameter);
                return i;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static DataTable getCategoryDetails(int companyID)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@companyId", companyID));
                SqlHandler sqlH = new SqlHandler();
                DataTable dtCategory = new DataTable();
                dtCategory = sqlH.ExecuteAsDataTable("[dbo].[Usp_getCategoryByCompany]",parameter);
                return dtCategory;
            }
            catch(Exception ae)
            {
                throw ae;
            }
        }
        public static int addCompanyDeatials(int categoryId,int companyId, string companyName,int loginId)
        {
            try
            {
                List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                parameter.Add(new KeyValuePair<string, object>("@companyId", companyId));
                parameter.Add(new KeyValuePair<string, object>("@categoryId", categoryId));
                parameter.Add(new KeyValuePair<string, object>("@companyName", companyName));
                parameter.Add(new KeyValuePair<string, object>("@addedBy", 1));
                parameter.Add(new KeyValuePair<string, object>("@addedOn", DateTime.Now));
                SqlHandler sqlH = new SqlHandler();
                int i = sqlH.ExecuteNonQueryI("[dbo].[Usp_addCompanyDeatials]", parameter);
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
        public static DataTable getCategory()
        {
            try
            {

                SqlHandler sqlH = new SqlHandler();
                DataTable dt = sqlH.ExecuteAsDataTable("[dbo].[Usp_getCategory]");
                return dt;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static DataTable getCompany()
        {
            try
            {
               
                
                SqlHandler sqlH = new SqlHandler();
                DataTable dt = sqlH.ExecuteAsDataTable("[dbo].[Usp_getcompany]");
                return dt;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static DataTable getCompanyDetails()
        {
            try
            {

                SqlHandler sqlH = new SqlHandler();
                DataTable dt = sqlH.ExecuteAsDataTable("[dbo].[Usp_getCompanyDetails]");
                return dt;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
     
    }
}
