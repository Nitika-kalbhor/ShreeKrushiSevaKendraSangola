using DataAccessLayer.Helper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SqlHandler
    {
        #region defination & declaration
        private string _connectionString = SystemSetting.ConnectionString;
        public SqlHandler(){
            //instance for the handler
        }
        #endregion

        /// <summary>
        /// Execute query.
        /// </summary>
        /// <param name="SQL">SQL</param>
        public int ExecuteQuery(string SQL)
        {
            SqlConnection connection = new SqlConnection(this._connectionString);
            //Create a new command (with no timeout)
            try
            {
                SqlCommand command = new SqlCommand(SQL, connection);
                connection.Open();
                command.CommandTimeout = 0;
                int count = (int)command.ExecuteScalar();
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { connection.Close(); }
        }
        public int ExecuteNonQueryI(string procedureName, List<KeyValuePair<string, object>> ParaMeterCollection)
        {
            SqlConnection SQLConn = new SqlConnection(this._connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = SQLConn;
                cmd.CommandText = procedureName;
                cmd.CommandType = CommandType.StoredProcedure;
                //Loop for Paramets
                for (int i = 0; i < ParaMeterCollection.Count; i++)
                {
                    SqlParameter sqlParaMeter = new SqlParameter();
                    sqlParaMeter.IsNullable = true;
                    sqlParaMeter.ParameterName = ParaMeterCollection[i].Key;
                    sqlParaMeter.Value = ParaMeterCollection[i].Value;
                    cmd.Parameters.Add(sqlParaMeter);
                }
                //End of for loop
                SQLConn.Open();
                int rs = cmd.ExecuteNonQuery();
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                SQLConn.Close();
            }
        }
        public int ExecuteNonQueryM(string procedureName, params SqlParameter[] ParaMeterCollection)
        {
            SqlConnection SQLConn = new SqlConnection(this._connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = SQLConn;
                cmd.CommandText = procedureName;
                cmd.CommandType = CommandType.StoredProcedure;
                //Loop for Paramets
                foreach (SqlParameter p in ParaMeterCollection)
                {
                    if(p!=null)
                    {
                        if((p.Direction==ParameterDirection.InputOutput || 
                            p.Direction == ParameterDirection.Input) && 
                            p.Value== null)
                        {
                            p.Value = DBNull.Value;
                        }
                        cmd.Parameters.Add(p);
                    }
                }
                //End of for loop
                SQLConn.Open();
                int rs = cmd.ExecuteNonQuery();
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                SQLConn.Close();
            }
        }
        /// <summary>
        /// Prepare command for execute.
        /// </summary>
        /// <param name="command">Sql Command.</param>
        /// <param name="connection">connection</param>
        /// <param name="transaction">Transact-SQL transaction</param>
        /// <param name="commandType">Command type</param>
        /// <param name="commandText">Command text.</param>
        public static void PrepareCommand(SqlCommand command, SqlConnection connection, SqlTransaction transaction, CommandType commandType, string commandText)
        {
            //if the provided connection is not open, we will open it
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            //associate the connection with the command
            command.Connection = connection;
            command.Transaction = transaction;
            command.CommandType = commandType;
            command.CommandText = commandText;
            return;
        }
        /// <summary>
        ///  Executes non query
        /// </summary>
        /// <param name="transaction">Transact-SQL transaction</param>
        /// <param name="commandType">Command type</param>
        /// <param name="commandText">Command text.</param>
        /// <param name="ParaMeterCollection">Accept Key Value collection for parameters.</param>
        /// <param name="outParamName">Output parameter.</param>
        /// <returns>ID</returns>
        public int ExecuteNonQuery(SqlTransaction transaction, CommandType commandType, string commandText, List<KeyValuePair<string, object>> ParaMeterCollection, string outParamName)
        {
            //create a command and prepare it for execution
            SqlCommand cmd = new SqlCommand();
            PrepareCommand(cmd, transaction.Connection, transaction, commandType, commandText);

            for (int i = 0; i < ParaMeterCollection.Count; i++)
            {
                SqlParameter sqlParaMeter = new SqlParameter();
                sqlParaMeter.IsNullable = true;
                sqlParaMeter.ParameterName = ParaMeterCollection[i].Key;
                sqlParaMeter.Value = ParaMeterCollection[i].Value;
                cmd.Parameters.Add(sqlParaMeter);
            }
            cmd.Parameters.Add(new SqlParameter(outParamName, SqlDbType.Int));
            cmd.Parameters[outParamName].Direction = ParameterDirection.Output;

            //finally, execute the command.
            cmd.ExecuteNonQuery();
            int id = (int)cmd.Parameters[outParamName].Value;

            // detach the Parameters from the command object, so they can be used again.
            cmd.Parameters.Clear();
            return id;
        }
        /// <summary>
        /// Executes non query.
        /// </summary>
        /// <param name="StroredProcedureName">Store Procedure Name In String.</param>
        /// <param name="ParaMeterCollection">Accept key value collection for parameters.<KeyValuePair<string, object>> </param>
        public void ExecuteNonQuery(string StroredProcedureName, List<KeyValuePair<string, object>> ParaMeterCollection)
        {
            SqlConnection SQLConn = new SqlConnection(this._connectionString);
            try
            {
                SqlCommand SQLCmd = new SqlCommand();
                SQLCmd.Connection = SQLConn;
                SQLCmd.CommandText = StroredProcedureName;
                SQLCmd.CommandType = CommandType.StoredProcedure;
                //Loop for Paramets
                for (int i = 0; i < ParaMeterCollection.Count; i++)
                {
                    SqlParameter sqlParaMeter = new SqlParameter();
                    sqlParaMeter.IsNullable = true;
                    sqlParaMeter.ParameterName = ParaMeterCollection[i].Key;
                    sqlParaMeter.Value = ParaMeterCollection[i].Value;
                    SQLCmd.Parameters.Add(sqlParaMeter);
                }
                //End of for loop

                SQLConn.Open();
                SQLCmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                SQLConn.Close();
            }
        }

        /// <summary>
        /// Executes non query.
        /// </summary>
        /// <param name="StroredProcedureName">Store procedure name.</param>
        /// <param name="ParaMeterCollection">Accept key value collection for parameters. <KeyValuePair<string, string>> </param>
        public void ExecuteNonQuery(string StroredProcedureName, List<KeyValuePair<string, string>> ParaMeterCollection)
        {
            SqlConnection SQLConn = new SqlConnection(this._connectionString);
            try
            {
                SqlCommand SQLCmd = new SqlCommand();
                SQLCmd.Connection = SQLConn;
                SQLCmd.CommandText = StroredProcedureName;
                SQLCmd.CommandType = CommandType.StoredProcedure;
                //Loop for Paramets
                for (int i = 0; i < ParaMeterCollection.Count; i++)
                {
                    SQLCmd.Parameters.Add(new SqlParameter(ParaMeterCollection[i].Key, ParaMeterCollection[i].Value));
                }
                //End of for loop

                SQLConn.Open();
                SQLCmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                SQLConn.Close();
            }
        }
        /// <summary>
        /// Execute non query.
        /// </summary>
        /// <param name="StroredProcedureName">Store procedure name in string.</param>
        /// <param name="ParaMeterCollection">Accept key value collection for parameters.</param>
        /// <param name="OutPutParamerterName">Accept output key value collection for parameters.</param>
        /// <returns>Integer value.</returns>
        public int ExecuteNonQuery(string StroredProcedureName, List<KeyValuePair<string, object>> ParaMeterCollection, string OutPutParamerterName)
        {
            SqlConnection SQLConn = new SqlConnection(this._connectionString);
            try
            {

                SqlCommand SQLCmd = new SqlCommand();
                SQLCmd.Connection = SQLConn;
                SQLCmd.CommandText = StroredProcedureName;
                SQLCmd.CommandType = CommandType.StoredProcedure;
                //Loop for Paramets
                for (int i = 0; i < ParaMeterCollection.Count; i++)
                {
                    SqlParameter sqlParaMeter = new SqlParameter();
                    sqlParaMeter.IsNullable = true;
                    sqlParaMeter.ParameterName = ParaMeterCollection[i].Key;
                    sqlParaMeter.Value = ParaMeterCollection[i].Value;
                    SQLCmd.Parameters.Add(sqlParaMeter);
                }
                //End of for loop
                SQLCmd.Parameters.Add(new SqlParameter(OutPutParamerterName, SqlDbType.Int));
                SQLCmd.Parameters[OutPutParamerterName].Direction = ParameterDirection.Output;

                SQLConn.Open();
                SQLCmd.ExecuteNonQuery();
                int ReturnValue = (int)SQLCmd.Parameters[OutPutParamerterName].Value;
                SQLConn.Close();
                return ReturnValue;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                SQLConn.Close();
            }
        }

        /// <summary>
        /// Executes non query.
        /// </summary>
        /// <param name="StroredProcedureName">Store procedure name.</param>
        public void ExecuteNonQuery(string StroredProcedureName)
        {
            SqlConnection SQLConn = new SqlConnection(this._connectionString);
            try
            {
                SqlCommand SQLCmd = new SqlCommand();
                SQLCmd.Connection = SQLConn;
                SQLCmd.CommandText = StroredProcedureName;
                SQLCmd.CommandType = CommandType.StoredProcedure;
                SQLConn.Open();
                SQLCmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                SQLConn.Close();
            }
        }


        /// <summary>
        /// Execute as object.
        /// </summary>
        /// <typeparam name="T">Given type of object.</typeparam>
        /// <param name="StroredProcedureName">Store procedure name.</param>
        /// <param name="ParaMeterCollection">Accept key value collection for parameters.</param>
        /// <returns></returns>
        public T ExecuteAsObject<T>(string StroredProcedureName, List<KeyValuePair<string, object>> ParaMeterCollection)
        {
            SqlConnection SQLConn = new SqlConnection(this._connectionString);
            try
            {

                SqlDataReader SQLReader;
                SqlCommand SQLCmd = new SqlCommand();
                SQLCmd.Connection = SQLConn;
                SQLCmd.CommandText = StroredProcedureName;
                SQLCmd.CommandType = CommandType.StoredProcedure;
                //Loop for Parameters
                for (int i = 0; i < ParaMeterCollection.Count; i++)
                {
                    SqlParameter sqlParaMeter = new SqlParameter();
                    sqlParaMeter.IsNullable = true;
                    sqlParaMeter.ParameterName = ParaMeterCollection[i].Key;
                    sqlParaMeter.Value = ParaMeterCollection[i].Value;
                    SQLCmd.Parameters.Add(sqlParaMeter);
                }
                //End of for loop
                SQLConn.Open();
                SQLReader = SQLCmd.ExecuteReader(CommandBehavior.CloseConnection);
                ArrayList arrColl = DataSourceHelper.FillCollection(SQLReader, typeof(T));
                SQLConn.Close();
                if (SQLReader != null)
                {
                    SQLReader.Close();
                }
                if (arrColl != null && arrColl.Count > 0)
                {
                    return (T)arrColl[0];
                }
                else
                {
                    return default(T);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                SQLConn.Close();
            }
        }

        /// <summary>
        /// Execute As Object
        /// </summary>
        /// <typeparam name="T">Given type of object.</typeparam>
        /// <param name="StroredProcedureName">Store procedure name.</param>
        /// <param name="ParaMeterCollection">Accept key value collection for parameters.</param>
        /// <returns>Type of the object implementing.</returns>
        public T ExecuteAsObject<T>(string StroredProcedureName, List<KeyValuePair<string, string>> ParaMeterCollection)
        {
            SqlConnection SQLConn = new SqlConnection(this._connectionString);
            try
            {

                SqlDataReader SQLReader;
                SqlCommand SQLCmd = new SqlCommand();
                SQLCmd.Connection = SQLConn;
                SQLCmd.CommandText = StroredProcedureName;
                SQLCmd.CommandType = CommandType.StoredProcedure;
                //Loop for Paramets
                for (int i = 0; i < ParaMeterCollection.Count; i++)
                {
                    SQLCmd.Parameters.Add(new SqlParameter(ParaMeterCollection[i].Key, ParaMeterCollection[i].Value));
                }
                //End of for loop
                SQLConn.Open();
                SQLReader = SQLCmd.ExecuteReader();
                ArrayList arrColl = DataSourceHelper.FillCollection(SQLReader, typeof(T));
                SQLConn.Close();
                if (SQLReader != null)
                {
                    SQLReader.Close();
                }
                if (arrColl != null && arrColl.Count > 0)
                {
                    return (T)arrColl[0];
                }
                else
                {
                    return default(T);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                SQLConn.Close();
            }
        }

        /// <summary>
        /// Execute As Object
        /// </summary>
        /// <typeparam name="T">Given type of object.</typeparam>
        /// <param name="StroredProcedureName">Accept Key Value Collection For Parameters</param>
        /// <returns> Type of the object implementing</returns>
        public T ExecuteAsObject<T>(string StroredProcedureName)
        {
            SqlConnection SQLConn = new SqlConnection(this._connectionString);
            try
            {

                SqlDataReader SQLReader;
                SqlCommand SQLCmd = new SqlCommand();
                SQLCmd.Connection = SQLConn;
                SQLCmd.CommandText = StroredProcedureName;
                SQLCmd.CommandType = CommandType.StoredProcedure;

                SQLConn.Open();
                SQLReader = SQLCmd.ExecuteReader();
                ArrayList arrColl = DataSourceHelper.FillCollection(SQLReader, typeof(T));
                SQLConn.Close();
                if (SQLReader != null)
                {
                    SQLReader.Close();
                }
                if (arrColl != null && arrColl.Count > 0)
                {
                    return (T)arrColl[0];
                }
                else
                {
                    return default(T);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                SQLConn.Close();
            }
        }


        /// <summary>
        /// Execute As list
        /// </summary>
        /// <typeparam name="T">Given type of object.</typeparam>
        /// <param name="StroredProcedureName">Store procedure name.</param>
        /// <param name="ParaMeterCollection"></param>
        /// <returns>Type of list of object implementing.</returns>
        public List<T> ExecuteAsList<T>(string StroredProcedureName, List<KeyValuePair<string, object>> ParaMeterCollection)
        {
            SqlConnection SQLConn = new SqlConnection(this._connectionString);
            try
            {

                SqlDataReader SQLReader;
                SqlCommand SQLCmd = new SqlCommand();
                SQLCmd.Connection = SQLConn;
                SQLCmd.CommandText = StroredProcedureName;
                SQLCmd.CommandType = CommandType.StoredProcedure;
                //Loop for Paramets
                for (int i = 0; i < ParaMeterCollection.Count; i++)
                {
                    SqlParameter sqlParaMeter = new SqlParameter();
                    sqlParaMeter.IsNullable = true;
                    sqlParaMeter.ParameterName = ParaMeterCollection[i].Key;
                    sqlParaMeter.Value = ParaMeterCollection[i].Value;
                    SQLCmd.Parameters.Add(sqlParaMeter);

                }
                //End of for loop
                SQLConn.Open();
                SQLReader = SQLCmd.ExecuteReader(CommandBehavior.CloseConnection); //datareader automatically closes the SQL connection
                List<T> mList = new List<T>();
                mList = DataSourceHelper.FillCollection<T>(SQLReader);
                if (SQLReader != null)
                {
                    SQLReader.Close();
                }
                SQLConn.Close();
                return mList;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                SQLConn.Close();
            }
        }

        /// <summary>
        /// Execute as list.
        /// </summary>
        /// <typeparam name="T">Given type of object</typeparam>
        /// <param name="StroredProcedureName">Store procedure name.</param>
        /// <param name="ParaMeterCollection">Accept Key Value collection for parameters.</param>
        /// <returns>Type of list of object implementing.</returns>
        public List<T> ExecuteAsList<T>(string StroredProcedureName, List<KeyValuePair<string, string>> ParaMeterCollection)
        {
            SqlConnection SQLConn = new SqlConnection(this._connectionString);
            try
            {
                SqlDataReader SQLReader;
                SqlCommand SQLCmd = new SqlCommand();
                SQLCmd.Connection = SQLConn;
                SQLCmd.CommandText = StroredProcedureName;
                SQLCmd.CommandType = CommandType.StoredProcedure;
                //Loop for Paramets
                for (int i = 0; i < ParaMeterCollection.Count; i++)
                {
                    SqlParameter sqlParaMeter = new SqlParameter();
                    sqlParaMeter.IsNullable = true;
                    sqlParaMeter.ParameterName = ParaMeterCollection[i].Key;
                    sqlParaMeter.Value = ParaMeterCollection[i].Value;
                    SQLCmd.Parameters.Add(sqlParaMeter);
                }
                //End of for loop
                SQLConn.Open();
                SQLReader = SQLCmd.ExecuteReader(CommandBehavior.CloseConnection); //datareader automatically closes the SQL connection
                List<T> mList = new List<T>();
                mList = DataSourceHelper.FillCollection<T>(SQLReader);
                if (SQLReader != null)
                {
                    SQLReader.Close();
                }
                SQLConn.Close();
                return mList;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                SQLConn.Close();
            }
        }

        /// <summary>
        /// Execute As List.
        /// </summary>
        /// <typeparam name="T">Given type of object.</typeparam>
        /// <param name="StroredProcedureName">Storedprocedure name.</param>
        /// <returns>Type of list of object implementing.</returns>
        public List<T> ExecuteAsList<T>(string StroredProcedureName)
        {
            SqlConnection SQLConn = new SqlConnection(this._connectionString);
            try
            {
                SqlDataReader SQLReader;
                SqlCommand SQLCmd = new SqlCommand();
                SQLCmd.Connection = SQLConn;
                SQLCmd.CommandText = StroredProcedureName;
                SQLCmd.CommandType = CommandType.StoredProcedure;

                SQLConn.Open();
                SQLReader = SQLCmd.ExecuteReader(CommandBehavior.CloseConnection); //datareader automatically closes the SQL connection
                List<T> mList = new List<T>();
                mList = DataSourceHelper.FillCollection<T>(SQLReader);
                if (SQLReader != null)
                {
                    SQLReader.Close();
                }
                SQLConn.Close();
                return mList;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                SQLConn.Close();
            }
        }


        /// <summary>
        /// Execute as DataSet.
        /// </summary>
        /// <param name="StroredProcedureName">Store procedure name.</param>
        /// <param name="ParaMeterCollection">Accept key value collection for parameters.</param>
        /// <returns>Object of DataSet.</returns>
        public DataSet ExecuteAsDataSet(string StroredProcedureName, List<KeyValuePair<string, object>> ParaMeterCollection)
        {
            SqlConnection SQLConn = new SqlConnection(this._connectionString);
            try
            {
                SqlCommand SQLCmd = new SqlCommand();
                SqlDataAdapter SQLAdapter = new SqlDataAdapter();
                DataSet SQLds = new DataSet();
                SQLCmd.Connection = SQLConn;
                SQLCmd.CommandText = StroredProcedureName;
                SQLCmd.CommandType = CommandType.StoredProcedure;

                //Loop for Paramets
                for (int i = 0; i < ParaMeterCollection.Count; i++)
                {
                    SqlParameter sqlParaMeter = new SqlParameter();
                    sqlParaMeter.IsNullable = true;
                    sqlParaMeter.ParameterName = ParaMeterCollection[i].Key;
                    sqlParaMeter.Value = ParaMeterCollection[i].Value;
                    SQLCmd.Parameters.Add(sqlParaMeter);
                }
                //End of for loop

                SQLAdapter.SelectCommand = SQLCmd;
                SQLConn.Open();
                SQLAdapter.Fill(SQLds);
                SQLConn.Close();
                return SQLds;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                SQLConn.Close();
            }
        }

        /// <summary>
        /// Execute as DataSet.
        /// </summary>
        /// <param name="StroredProcedureName">Store procedure name.</param>
        /// <param name="ParaMeterCollection">Accept key value collection for parameters.</param>
        /// <returns>Object of DataSet.</returns>
        public DataSet ExecuteAsDataSet(string StroredProcedureName, List<KeyValuePair<string, string>> ParaMeterCollection)
        {
            SqlConnection SQLConn = new SqlConnection(this._connectionString);
            try
            {

                SqlCommand SQLCmd = new SqlCommand();
                SqlDataAdapter SQLAdapter = new SqlDataAdapter();
                DataSet SQLds = new DataSet();
                SQLCmd.Connection = SQLConn;
                SQLCmd.CommandText = StroredProcedureName;
                SQLCmd.CommandType = CommandType.StoredProcedure;

                //Loop for Paramets
                for (int i = 0; i < ParaMeterCollection.Count; i++)
                {
                    SQLCmd.Parameters.Add(new SqlParameter(ParaMeterCollection[i].Key, ParaMeterCollection[i].Value));
                }
                //End of for loop

                SQLAdapter.SelectCommand = SQLCmd;
                SQLConn.Open();
                SQLAdapter.Fill(SQLds);
                SQLConn.Close();
                return SQLds;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                SQLConn.Close();
            }
        }

        public DataTable ExecuteAsDataTable(string StroredProcedureName, List<KeyValuePair<string, object>> ParaMeterCollection)
        {
            SqlConnection SQLConn = new SqlConnection(this._connectionString);
            try
            {

                SqlCommand SQLCmd = new SqlCommand();
                SqlDataAdapter SQLAdapter = new SqlDataAdapter();
                DataTable SQLds = new DataTable();
                SQLCmd.Connection = SQLConn;
                SQLCmd.CommandText = StroredProcedureName;
                SQLCmd.CommandType = CommandType.StoredProcedure;

                //Loop for Paramets
                for (int i = 0; i < ParaMeterCollection.Count; i++)
                {
                    SQLCmd.Parameters.Add(new SqlParameter(ParaMeterCollection[i].Key, ParaMeterCollection[i].Value));
                }
                //End of for loop

                SQLAdapter.SelectCommand = SQLCmd;
                SQLConn.Open();
                SQLAdapter.Fill(SQLds);
                SQLConn.Close();
                return SQLds;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                SQLConn.Close();
            }
        }

        public DataTable ExecuteAsDataTable(string StroredProcedureName)
        {
            SqlConnection SQLConn = new SqlConnection(this._connectionString);
            try
            {

                SqlCommand SQLCmd = new SqlCommand();
                SqlDataAdapter SQLAdapter = new SqlDataAdapter();
                DataTable SQLds = new DataTable();
                SQLCmd.Connection = SQLConn;
                SQLCmd.CommandText = StroredProcedureName;
                SQLCmd.CommandType = CommandType.StoredProcedure;
                //End of for loop

                SQLAdapter.SelectCommand = SQLCmd;
                SQLConn.Open();
                SQLAdapter.Fill(SQLds);
                SQLConn.Close();
                return SQLds;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                SQLConn.Close();
            }
        }

    }
}
