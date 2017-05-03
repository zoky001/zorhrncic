using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_4_EvidencijaStudenata
{
    /// <summary>
    /// Klasa za definiranje podataka i funkcionalnosti studenta.
    /// </summary>
    public class Student
    {
        #region Constructors

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

        #endregion
    }
}
