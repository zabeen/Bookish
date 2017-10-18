using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Bookish.DataAccess.Model;

namespace Bookish.DataAccess
{
    public abstract class DbQuery
    {
        public string ConnectionString { get; private set; }

        public DbQuery(string connectionStr)
        {
            ConnectionString = connectionStr;
        }

        protected IDbConnection CreateNewDbConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
