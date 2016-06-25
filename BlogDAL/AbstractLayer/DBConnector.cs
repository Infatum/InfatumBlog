﻿namespace DataAccessLayer.AbstractLayer
{
    public abstract class DBConnector
    {
        public static string ConnectionString { get; private set; }
        public abstract void OpenConnection();
        public abstract void CloseConnection();

        public DBConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
