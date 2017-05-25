using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recept
{
    class Artikl
    {
        private int id;
        private string naziv;

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

        public Artikl(DbDataReader dr)
        {
            if (dr != null)
            {
                Id = int.Parse(dr["id"].ToString());
                Naziv = dr["naziv"].ToString();
            }
        }

        public static List<Artikl> DohvatiArtikle(int receptId)
        {
            List<Artikl> lista = new List<Artikl>();
            string sqlUpit = "SELECT * FROM artikl INNER JOIN sastojak ON sastojak.artikl_id = artikl.id INNER JOIN recept ON sastojak.recept_id = recept.id WHERE recept.id = " + receptId;
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Artikl tim = new Artikl(dr);
                lista.Add(tim);
            }
            dr.Close();
            return lista;
        }
    }
}
