using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DataAccessLayer.providers;

namespace DataAccessLayer.controller
{
    public class AccountTransferController
    {
        public static int UpdateAccountTransfer(long accountId, string isCustomerDealer, DataTable data)
        {           
            try
            {                
                int i = AccountTransferProvider.UpdateAccountTransfer(accountId, isCustomerDealer, data);
                return i;
            }
            catch(Exception ec)
            {throw ec;}
        }
    }
}
