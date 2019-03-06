using HomeBudgetWeb.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudgetWeb.DAL.Base
{
    public class DbContext : IDbContext
    {
            #region Private fields

            private const string DefaultConnectionstringNameKey = "HomeBudgetConnectionString";

            #endregion Private fields

            #region Constructors

            public DbContext()
            {
                Connection = new SqlConnection(DefaultConnectionString);
            }

            #endregion Constructors

            #region Properties

            private static string DefaultConnectionString
            {
                get
                {
                    string connectionStringName = DefaultConnectionstringNameKey;
                    if (string.IsNullOrEmpty(connectionStringName))
                    {
                        throw new Exception(string.Format("AppSetting key {0} not exist", DefaultConnectionstringNameKey));
                    }
                    ConnectionStringSettings connectionString = ConfigurationManager.ConnectionStrings[connectionStringName];
                    if (connectionString == null)
                    {
                        throw new Exception(string.Format("ConnectionString with name {0} not found", connectionStringName));
                    }
                    return connectionString.ConnectionString;
                }
            }

            public SqlConnection Connection { get; private set; }

            public SqlTransaction Transaction { get; private set; }

            #endregion Properties

            #region Non-virtual methods

            public void OpenConnection()
            {
                try
                {
                    Connection.Open();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void CloseConnection()
            {
                try
                {
                    Connection.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void BeginTransaction()
            {
                try
                {
                    Transaction = Connection.BeginTransaction();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void Commit()
            {
                try
                {
                    Transaction.Commit();
                    Transaction.Dispose();
                    Connection.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            public void RollBack()
            {
                try
                {
                    Transaction.Rollback();
                    Transaction.Dispose();
                    Connection.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            #endregion Non-virtual methods
        }
    }

