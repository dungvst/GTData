using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using GDataSource.Common;

namespace GDataSource.Controller
{
    class DBController : IDisposable
    {
        IDbConnection dbConnection;
        public IDbConnection openConnection(String dbType)
        {
            if (dbType == CommonConstant.DB_TYPE_POSTGRES)
            {
                //connection = new NpgsqlConnection(connectionString);
            }
            else if (dbType == CommonConstant.DB_TYPE_SQLSERVER)
            {
                //connection = new 
            }
            else if (dbType == CommonConstant.DB_TYPE_MYSQL)
            {
                //connection = new 
            }
            else
            {
                Console.Write("DB Error");
            }

            ConnectionState originalState = dbConnection.State;
            if (originalState != ConnectionState.Open)
            {
                dbConnection.Open();
            }
                
            return dbConnection;
            
        }

        public List<Object> lsTableName()
        {
            return null;
        }

        public void Dispose()
        {
            dbConnection.Close();
        }
    }
}
