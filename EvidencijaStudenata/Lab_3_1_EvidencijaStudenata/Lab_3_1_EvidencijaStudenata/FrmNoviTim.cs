using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3_1_EvidencijaStudenata
{
    public partial class FrmNoviTim : Form
    {
        /// <summary>
        /// Konstruktor forme koji se poziva kada kreiramo novi tim.
        /// </summary>
        private Tim timZaIzmjenu;
        public FrmNoviTim()
        {
            InitializeComponent();
        }
        public FrmNoviTim(Tim tim)
        {
            InitializeComponent();
            timZaIzmjenu = tim;
        }

        /// <summary>
        /// Rukuje događajem klika na gumb Odustani.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Rukuje događajem učitavanja forme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNoviTim_Load(object sender, EventArgs e)
        {
            txtOznakaTima.Focus();
            if (timZaIzmjenu != null)
            {
                txtId.Text = timZaIzmjenu.Id.ToString();
                txtOznakaTima.Text = timZaIzmjenu.OznakaTima;
                txtNazivProjekta.Text = timZaIzmjenu.NazivProjekta;
                txtOpisProjekta.Text = timZaIzmjenu.OpisProjekta;
                txtNapomena.Text = timZaIzmjenu.Napomena;

            }


        }

        private void btnUredu_Click(object sender, EventArgs e)
        {
            using (var db = new EvidencijaStudenataEntities())
            {if (timZaIzmjenu == null)
                {
                    Tim tim = new Tim
                    {
                        OznakaTima = txtOznakaTima.Text,
                        NazivProjekta = txtNazivProjekta.Text,
                        OpisProjekta = txtOpisProjekta.Text,
                        Napomena = txtNapomena.Text
                    };
                    db.Tim.Add(tim);
                    db.SaveChanges();
                }else
                {
                    db.Tim.Attach(timZaIzmjenu);
                    timZaIzmjenu.OznakaTima = txtOznakaTima.Text;
                    timZaIzmjenu.NazivProjekta = txtNazivProjekta.Text;
                    timZaIzmjenu.OpisProjekta = txtOpisProjekta.Text;
                    timZaIzmjenu.Napomena = txtNapomena.Text;
                    db.SaveChanges();



                }

            }
            Close();
        }
    }
}
