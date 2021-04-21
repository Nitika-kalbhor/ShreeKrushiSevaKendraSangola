using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
       public static DataTable getCategoryDetails(int companyID)
        {
            try
            {
                DataTable i = categoryProvider.getCategoryDetails(companyID);
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static int addCompanyDeatials(int categoryId, int companyId, string companyName, int loginId)
        {
            try
            {
                int i = categoryProvider.addCompanyDeatials(categoryId, companyId, companyName, loginId);
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
        public static DataTable getCategory()
        {
            try
            {
                DataTable i = categoryProvider.getCategory();
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable getCompany()
        {
            try
            {
                DataTable i = categoryProvider.getCompany();
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static DataTable getCompanyDetails()
        {
            try
            {
                DataTable i = categoryProvider.getCompanyDetails();
                return i;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    
    }
}
