using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.models;
using DataAccessLayer.providers;
using System.Data;

namespace DataAccessLayer.controller
{
   public class categoryController
    {
        public static int addCategoryDetails(int categoryId,string categoryName)
        {
            try
            {
                int i = categoryProvider.addCategoryDetails(categoryId, categoryName);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static int DeleteIsActiveCategory(long categoryId)
        {
            try
            {
                int i = categoryProvider.DeleteIsActiveCategory(categoryId);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static int DeleteIsActiveSubCategory(int subCategoryId)
        {
            try
            {
                int i = categoryProvider.DeleteIsActiveSubCategory(subCategoryId);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable getCategoryDetails( )
        {
            try
            {
                DataTable i = categoryProvider.getCategoryDetails();
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable getSubCategoryDetails()
        {
            try
            {
                DataTable i = categoryProvider.getSubCategoryDetails();
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static DataTable getSubCategoryBySearch(int categoryId)
        {
            try
            {
                DataTable ilist = categoryProvider.getSubCategoryBySearch(categoryId);
                return ilist;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static int addSubCategoryDetails(int subCategoryId, int categoryId, string subCategoryName)
        {
            try
            {
                int i = categoryProvider.addSubCategoryDetails(subCategoryId, categoryId, subCategoryName);
                return i;
            }
            catch(Exception ex)
            {
               
                throw ex;
            }
        }
    }
}
