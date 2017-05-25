using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Lab_2_4_EvidencijaStudenata
{
    /// <summary>
    /// Klasa za definiranje podataka i funkcionalnosti studenta.
    /// </summary>
    public class Student
    {
        #region Constructors

        public Student() { }
        public Student(DbDataReader dr) {
            if (dr != null)
            {
                Id = int.Parse(dr["Id"].ToString());
                Ime = dr["Ime"].ToString();
                Prezime = dr["Prezime"].ToString();
                Status = char.Parse(dr["Status"].ToString());
                Email = dr["Email"].ToString();
                Napomena = dr["Napomena"].ToString();


                List<Tim> nova = Tim.DohvatiTimove();
                foreach (var item in nova)
                {
                    if (item.Id == int.Parse(dr["TimId"].ToString()))
                    {
                        Tim = item;
                    }
                }

                OdabraniModel = char.Parse(dr["OdabraniModel"].ToString());

            }

        }

        #endregion

        #region Private Fields

        private int id;
        private string ime;
        private string prezime;
        private char status;
        private char odabraniModel;
        private string email;
        private string napomena;
        private Tim tim;

        #endregion

        #region Properties

        /// <summary>
        /// Jedinstveni identifikator studenta.
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
        /// Ime studenta.
        /// </summary>
        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                if (ime != value)
                {
                    ime = value;
                }
            }
        }

        /// <summary>
        /// Prezime studenta.
        /// </summary>
        public string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                if (prezime != value)
                {
                    prezime = value;
                }
            }
        }

        /// <summary>
        /// Status studenta (Izvanredni = I; Redoviti = R).
        /// </summary>
        public char Status
        {
            get
            {
                return status;
            }
            set
            {
                if (status != value)
                {
                    status = value;
                }
            }
        }

        /// <summary>
        /// Odabrani model praćenja (A ili B).
        /// </summary>
        public char OdabraniModel
        {
            get
            {
                return odabraniModel;
            }
            set
            {
                if (odabraniModel != value)
                {
                    odabraniModel = value;
                }
            }
        }

        /// <summary>
        /// Email studenta.
        /// </summary>
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (email != value)
                {
                    email = value;
                }
            }
        }

        /// <summary>
        /// Napomena o studentu.
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

        /// <summary>
        /// Tim kojem student pripada.
        /// </summary>
        public Tim Tim
        {
            get
            {
                return tim;
            }
            set
            {
                if (tim != value)
                {
                    tim = value;
                }
            }
        }

        #endregion

        #region Methods


        public static List<Student> DohvatiStudenteTima( int idTima) {

            List<Student> VRATI = new List<Student>();
            string upit = "SELECT * FROM Student WHERE TimId = '" + idTima.ToString()+"'";
            DbDataReader dr = DB1.Instance.PreuzmiDataReader(upit);

            while (dr.Read())
            {
                Student s = new Student(dr);
                VRATI.Add(s);

            }
            dr.Close();
            return VRATI;


        }


        public static  int Obrisi( int id)
        {
            string sqlDelete = "DELETE FROM Student WHERE Id =" + id;
            return DB.Instance.IzvrsiUpit(sqlDelete);

        }


        public int Spremi() {

            int TimId = tim.Id;

            string upit = "";


            if (id == 0)
            {
                upit = "INSERT INTO Student (Id, Ime, Prezime, Status, Email, Napomena, TimId, OdabraniModel) VALUES ( null, '" + ime + "','" + Prezime + "','" + status + "','" + Email + "','" + Napomena + "','" + TimId+"','"+odabraniModel+"')";
            }
            else
            {




            }

            return DB1.Instance.IzvrsiUpis(upit);


        }

        #endregion
    }
}
