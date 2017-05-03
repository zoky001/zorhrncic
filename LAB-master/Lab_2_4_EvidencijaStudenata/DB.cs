using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Text;

namespace Lab_2_4_EvidencijaStudenata
{
    public class DB
    {
        private static DB instance; //singleton objekta
        private string connectionString; // putanja itd
        private SQLiteConnection connection; // konekcija prema bazi

        public static DB Instance //singleton instaca klase za rad s bazom
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

            get { return connectionString; }

            private set { connectionString = value; }
        }

        public SQLiteConnection Connection {
            get { return connection; }
            private set { connection = value; }

        }

        private DB() { // konstruktor klase

            ConnectionString = @"Data Source= ..\..\Baza\EvidencijaStudenataPI.db3";


            Connection = new SQLiteConnection(ConnectionString);
            Connection.Open();
                
                }


        ~DB()//destruktor
        {
            Connection.Close();
            Connection = null;

        }
        /*
         * 
         * Dohvaca podatke u obliku dataReadera
         * Vraca rezultat
         * */
        public DbDataReader DohvatiDataReader (string sqlUpit)
        {

            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);

            return command.ExecuteReader();
        }

        public object DohvatiVrijednost (string sqlUpit)
        {//dohvaca skalarnu vrijednost upita

            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }

        public int IzvrsiUpit (string sqlUpit)
        {//izvršava upit i vraća broj redaka koji su promjenjeni
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery();


            

        }





    }
}
