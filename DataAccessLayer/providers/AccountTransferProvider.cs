using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataAccessLayer.providers
{
    public class AccountTransferProvider
    {
        #region defination & declaration
        private static string _connectionString = SystemSetting.ConnectionString;
        #endregion
        public static int UpdateAccountTransfer(long accountId, string isCustomerDealer, DataTable data)
        {
            using (var Conn = new SqlConnection(_connectionString))
            {
                SqlHandler sqlH = new SqlHandler();
                SqlTransaction trans = null;
                try
                {
                    Conn.Open();
                    trans = Conn.BeginTransaction();
                    int resullt = 0;
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        List<KeyValuePair<string, object>> parameter = new List<KeyValuePair<string, object>>();
                        parameter.Add(new KeyValuePair<string, object>("@accountId", accountId));
                        parameter.Add(new KeyValuePair<string, object>("@wrongAccountId", data.Rows[i]["accountId"]));
                        parameter.Add(new KeyValuePair<string, object>("@isCustomerDealer", isCustomerDealer));
                        SqlHandler sqlh = new SqlHandler();
                        resullt += sqlh.ExecuteNonQueryTM("[dbo].[Usp_accountTranfer]", parameter, Conn, trans);

                    }
                    trans.Commit();
                    return resullt;
                }
                catch (Exception ex)
                {
                    if (trans != null) trans.Rollback();
                    throw ex;
                }
                finally { Conn.Close(); }
            }
        }
    }
}
