using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBudgetWeb.DAL.Base
{
    public interface IDbContext
    {
        SqlConnection Connection { get; }
        SqlTransaction Transaction { get; }

        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void RollBack();
    }
}
