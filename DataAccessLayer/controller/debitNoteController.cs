using DataAccessLayer.models;
using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.controller
{
   public static class debitNoteController
    {
        public static long getMaxIdDebitNoteId(long financialYearID)
        {
            try
            {
                long salesInvoiceId = DebitNoteProvider.getMaxIdDebitNoteId(financialYearID);
                return salesInvoiceId;
            }
            catch (Exception ae)
            {
                throw ae;
            }

        }
        public static int addDebitNote(SalesReturnDetails DebitNote, PusrchaseSaleAccount purchase)
        {
            try
            {
                int result = 0;
                result = DebitNoteProvider.addDebitNote(DebitNote, purchase);
                return result;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }

        public static DataTable getCreditDebitNote(DateTime fromDate, DateTime toDate, long financialYearId)
        {
            try
            {
                DataTable dtcreditNoteList = DebitNoteProvider.getCreditDebitNote(fromDate, toDate, financialYearId);
                return dtcreditNoteList;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }

        public static DataTable getCreditDebitNoteDetails(long creditNoteId, long financialYearID)
        {
            try
            {
                DataTable dtcreditNoteDetails = DebitNoteProvider.getCreditDebitNote(creditNoteId, financialYearID);
                return dtcreditNoteDetails;
            }
            catch (Exception ae)
            {
                throw ae;
            }
        }
    }
}
