using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data.Common;
using System.Data;

namespace Recept
{
    public class DB
    {
        private DB()
        {
            ConnectionString = @"Data Source= ..\..\baza\Recepti.db";
            Connection = new SQLiteConnection(ConnectionString);
            Connection.Open();
        }

        ~DB()
        {
            Connection.Close();
            Connection = null;
        }

        private static DB instance;
        private string connectionString;
        private SQLiteConnection connection;

        public static DB Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DB();
                }
                return instance;
            }
        }

        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
            private set
            {
                if (connectionString != value)
                {
                    connectionString = value;
                }
            }
        }

        public SQLiteConnection Connection
        {
            get
            {
                return connection;
            }
            private set
            {
                if (connection != value)
                {
                    connection = value;
                }
            }
        }

        public DbDataReader DohvatiDataReader(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteReader();
        }

        public object DohvatiVrijednost(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }

        public int IzvrsiUpit(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery();
        }
    }
}
