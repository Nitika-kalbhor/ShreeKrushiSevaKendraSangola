using DataAccessLayer.models;
using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.controller
{
    public class SaleChallanTempController
    {
        public static DataTable getChallenList(DateTime fromDate, DateTime toDate, long financialYearId)
        {
            try
            {
                DataTable dtSaleChallanList = SaleChallanTempProvider.getChallenList(fromDate, toDate, financialYearId);
                return dtSaleChallanList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static long getMaxIdSaleChallanInvoiceId(long financialYearId)
        {
            try
            {
                long saleChallanInvoiceId = SaleChallanTempProvider.getMaxIdSaleChallanInvoiceId(financialYearId);
                return saleChallanInvoiceId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static int deleteRow(long financialYearId, long saleChallenId, long salesChallanItemDetailsId, long StockId, double Quantity)
        {
            try
            {
                int result = SaleChallanTempProvider.deleteRow(financialYearId, saleChallenId, salesChallanItemDetailsId, StockId, Quantity);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int addSalesChallanDetails(SalesDetails saleChallan)
        {
            try
            {
                int result = SaleChallanTempProvider.addSalesChallanDetails(saleChallan);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getSaleChallenDetails(long salesChallanId, long financialYearId)
        {
            try
            {
                DataTable dtSalesChalalanDetails = SaleChallanTempProvider.getSaleChallenDetails(salesChallanId, financialYearId);
                return dtSalesChalalanDetails;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable getChallenList(long customerId, DateTime fromDate, DateTime toDate, long financialYearID)
        {
            try
            {
                DataTable i = SaleChallanTempProvider.getChallenList(customerId, fromDate, toDate, financialYearID);
                return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
