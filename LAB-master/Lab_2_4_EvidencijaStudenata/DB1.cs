using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Text;

namespace Lab_2_4_EvidencijaStudenata
{
    class DB1
    {
        private static DB1 instance;
        private string nazivKonekcije;
        private SQLiteConnection konekcija;

        public static DB1 Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DB1();

                }

                return instance;
            }
        

        }

        public string NazivKonekcije {


            get { return nazivKonekcije; }
            private set
            {

                nazivKonekcije = value;
            }

        }

        public SQLiteConnection Konekcija
        {

            get { return konekcija; }
            private set {
                konekcija = value;
            }
        }


        private DB1()
        {
            NazivKonekcije = @"Data Source= ..\..\Baza\EvidencijaStudenataPI.db3";
            Konekcija = new SQLiteConnection(NazivKonekcije);
            Konekcija.Open();
        }

        ~DB1() {
            Konekcija.Close();
            Konekcija = null;

        }

        public DbDataReader PreuzmiDataReader (string upit)
        {

            SQLiteCommand naredba = new SQLiteCommand(upit, Konekcija);

            return naredba.ExecuteReader();
        }

        public int IzvrsiUpis(string upit)
        {

            SQLiteCommand nareedba = new SQLiteCommand(upit, Konekcija);
            return nareedba.ExecuteNonQuery();
        }

    }
}
