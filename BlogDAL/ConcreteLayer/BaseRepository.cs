using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.AbstractLayer;
using System.Data.SqlClient;
using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Abstract;

namespace DataAccessLayer.ConcreteLayer
{
    internal abstract class BaseRepository<TKey, TEntity> where TEntity : BaseEntity<TKey>
    {
        private MSSQLConnector _sqlConnector = null;
        private SqlTransactionManager _transactionManager;

        protected BaseRepository(string connectionString, SqlTransactionManager transactionManager)
        {
            _sqlConnector = new MSSQLConnector(connectionString);
            _sqlConnector.OpenConnection();
            _transactionManager = transactionManager;
        }

        private static void FillParameters(IDictionary<string, object> parameters, SqlCommand command)
        {
            if (parameters != null)
                foreach (var parameter in parameters)
                {
                    command.Parameters.AddWithValue(parameter.Key, parameter.Value ?? DBNull.Value);
                }
        }

        protected T ExecuteScalar<T>(string sqlCommand, IDictionary<string, object> parameters = null)
        {
            using (SqlCommand command = new SqlCommand(sqlCommand, _sqlConnector.SqlConnection, _transactionManager.CurrentTransaction))
            {
                FillParameters(parameters, command);
                return (T)command.ExecuteScalar();
            }
        }

    }
}
