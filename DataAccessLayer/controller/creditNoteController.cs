using DataAccessLayer.models;
using DataAccessLayer.providers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAccessLayer.controller
{
   public static class creditNoteController
    {
       public static long getMaxIdCreditNoteId(long financialYearID)
       {
           try
           {
               long salesInvoiceId = creditNoteProvider.getMaxIdCreditNoteId(financialYearID);
               return salesInvoiceId;
           }
           catch (Exception ae)
           {
               throw ae;
           }

       }
       public static int addSalescreditNote(SalesReturnDetails creditNote,PusrchaseSaleAccount purchase)
       {
           try
           {
               int result = 0;
               result = creditNoteProvider.addSalescreditNote(creditNote, purchase);
               return result;
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }

       public static DataTable getCreditDebitNote(DateTime fromDate, DateTime toDate, long financialYearId)
       {
           try
           {
               DataTable dtcreditNoteList=creditNoteProvider.getCreditDebitNote(fromDate,toDate,financialYearId);
               return dtcreditNoteList;
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }

       public static DataTable getCreditDebitNoteDetails(long creditNoteId, long financialYearID)
       {
           try
           {
               DataTable dtcreditNoteDetails = creditNoteProvider.getCreditDebitNote(creditNoteId, financialYearID);
               return dtcreditNoteDetails;
           }
           catch(Exception ae)
           {
               throw ae;
           }
       }
    }
}
