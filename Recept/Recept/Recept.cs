using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recept
{
    class Recept
    {
        private int id;
        private string naziv;
        private string opis;

        public int Id
        {
            get
            {
                return id;
            }
            
            private set
            {
                if (id != value)
                {
                    id = value;
                }
            }
        }

        public string Naziv
        {
            get
            {
                return naziv;
            }

            private set
            {
                if (naziv != value)
                {
                    naziv = value;
                }
            }
        }

        public string Opis
        {
            get
            {
                return opis;
            }

            private set
            {
                if (opis != value)
                {
                    opis = value;
                }
            }
        }

        public Recept(DbDataReader dr)
        {
            if (dr != null)
            {
                Id = int.Parse(dr["id"].ToString());
                Naziv = dr["naziv"].ToString();
                Opis = dr["opis"].ToString();
            }
        }

        public static List<Recept> DohvatiRecepte(string kljucnaRijec)
        {
            List<Recept> lista = new List<Recept>();
            string sqlUpit = "SELECT * FROM Recept WHERE naziv LIKE '%" + kljucnaRijec + "%'";

            //string sqlUpit = "SELECT DISTINCT *FROM recept INNER JOIN sastojak ON sastojak.recept_id = recept.id INNER JOIN artikl ON sastojak.artikl_id = artikl.id WHERE artikl.naziv LIKE '%" + kljucnaRijec + "%' OR recept.naziv LIKE '%" + kljucnaRijec + "%' OR recept.opis LIKE '%" + kljucnaRijec + "%'";

            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Recept tim = new Recept(dr);
                lista.Add(tim);
            }
            dr.Close();
            return lista;
        }
    }
}