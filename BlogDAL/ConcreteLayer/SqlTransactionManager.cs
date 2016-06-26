using System;
using DataAccessLayer.AbstractLayer;
using System.Data.SqlClient;
namespace DataAccessLayer.ConcreteLayer
{
    internal class SqlTransactionManager : ITransactionManager
    {
        private readonly SqlConnection _connection;
        private SqlTransaction _transaction;

        public SqlTransactionManager(SqlConnection sqlConnection)
        {
            _connection = sqlConnection;
        }

        internal SqlTransaction CurrentTransaction
        {
            get { return _transaction; }
        }

        ~SqlTransactionManager()
        {

        }

        public void Dispose()
        {
            if (_transaction != null)
            {
                _transaction.Dispose();
                _transaction = null;
            }
        }

        public IDisposable Begin()
        {
            if (_transaction != null)
            {
                _transaction.Dispose();
            }
            _transaction = _connection.BeginTransaction();
            return this;
        }

        public void Commit()
        {
            if (_transaction != null) _transaction.Commit();
            _transaction = null;
        }

        public void RollBack()
        {
            if (_transaction != null) _transaction.Rollback();
            _transaction = null;
        }
    }
}
