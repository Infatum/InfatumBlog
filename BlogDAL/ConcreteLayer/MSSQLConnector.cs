using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.AbstractLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer.ConcreteLayer
{
    public class MSSQLConnector : DBConnector
    {
        private SqlConnection _sqlConnection = null;
        public MSSQLConnector(string connStr): base(connStr)
        {
            _sqlConnection = new SqlConnection();
            _sqlConnection.ConnectionString = connStr;
        }
        public override void CloseConnection()
        {
            _sqlConnection.Dispose();
        }

        public override void OpenConnection()
        {
            _sqlConnection.Open();
        }
    }
}
