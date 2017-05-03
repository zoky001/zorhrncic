using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Lab_2_4_EvidencijaStudenata
{
    /// <summary>
    /// Klasa za definiranje podataka i funkcionalnosti tima studenata.
    /// </summary>
    public class Tim
    {
        #region Constructors

        //za kreiranje novog tima
        public Tim() {
        }

        //kreira tim sa podacima iz Datareader objekta
        public Tim (DbDataReader dr)
        {
            if (dr != null)
            {       Napomena = dr["Napomena"].ToString();
                OznakaTima = dr["OznakaTima"].ToString();

               
               
                //OznakaTima = dr.GetString(1);
                NazivProjekta = dr["NazivProjekta"].ToString();
                OpisProjekta = dr["OpisProjekta"].ToString();
               
               Id = int.Parse(dr["Id"].ToString());
               // Id = dr.GetInt32(0);
                


            }

        }




        #endregion

        #region Private Fields

        private int id;
        private string oznakaTima;
        private string nazivProjekta;
        private string opisProjekta;
        private string napomena;

        #endregion

        #region Properties

        /// <summary>
        /// Jedinstveni identifikator tima.
        /// </summary>
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (id != value)
                {
                    id = value;
                }
            }
        }

        /// <summary>
        /// Jedinstvena oznaka tima.
        /// </summary>
        public string OznakaTima
        {
            get
            {
                return oznakaTima;
            }
            set
            {
                if (oznakaTima != value)
                {
                    oznakaTima = value;
                }
            }
        }

        /// <summary>
        /// Naziv projekta kojeg je tim odabrao.
        /// </summary>
        public string NazivProjekta
        {
            get
            {
                return nazivProjekta;
            }
            set
            {
                if (nazivProjekta != value)
                {
                    nazivProjekta = value;
                }
            }
        }

        /// <summary>
        /// Detaljan opis projekta kojeg je tim odabrao.
        /// </summary>
        public string OpisProjekta
        {
            get
            {
                return opisProjekta;
            }
            set
            {
                if (opisProjekta != value)
                {
                    opisProjekta = value;
                }
            }
        }

        /// <summary>
        /// Dodatne opcionalne napomene o timu i projektu.
        /// </summary>
        public string Napomena
        {
            get
            {
                return napomena;
            }
            set
            {
                if (napomena != value)
                {
                    napomena = value;
                }
            }
        }

        #endregion

        #region Methods




        public int Spremi()
        {
            string sqlUpit = "";
            if (Id == 0) //insert
            {
                sqlUpit = "INSERT INTO Tim (Id, OznakaTima, NazivProjekta, OpisProjekta, Napomena) VALUES (NULL, '" + OznakaTima + "','" + NazivProjekta + "','" + OpisProjekta + "','" + Napomena + "')";
               
            }

            else
            {
                sqlUpit = "UPDATE Tim SET OznakaTima = '"+OznakaTima+"' ,NazivProjekta = '" + NazivProjekta + "',OpisProjekta = '" + OpisProjekta + "', Napomena = '" + Napomena + "' WHERE Id = " + Id;

            }
            return DB.Instance.IzvrsiUpit(sqlUpit);
        }

        public int Obrisi()
        {
            string sqlDelete = "DELETE FROM Tim WHERE Id =" + Id;
            return DB.Instance.IzvrsiUpit(sqlDelete);

        }

        public static List<Tim> DohvatiTimove()
        {
            List<Tim> lista = new List<Tim>();

            string sqlUpit = "SELECT * FROM Tim";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);

            while (dr.Read())
            {
                Tim tim = new Tim(dr);
                lista.Add(tim);
            }
            dr.Close();
            return lista;



        }

        public override string ToString()
        {
            return OznakaTima;
        }

        #endregion
    }
}
