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
    public partial class FrmNoviStudent : Form
    {
        /// <summary>
        /// Konstruktor forme koji se poziva kada kreiramo novog studenta.
        /// </summary>
        /// 
        private Tim selektiraniTim;

        public FrmNoviStudent(Tim tim)
        {
            InitializeComponent();
            selektiraniTim = tim;
        }

        /// <summary>
        /// Rukuje događajem klika na gumb odustani.
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
        private void FrmNoviStudent_Load(object sender, EventArgs e)
        {
            txtIme.Focus();
        }

        private void btnUredu_Click(object sender, EventArgs e)
        {
            using (var db = new EvidencijaStudenataEntities())
            {
                db.Tim.Attach(selektiraniTim);
                Student student = new Student {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    Status = txtStatus.Text,
                    OdabraniModel = txtOdabraniModel.Text,
                    Napomena = txtNapomena.Text,
                    Email = txtEmail.Text,
                    Tim = selektiraniTim
                };
                db.Student.Add(student);
                db.SaveChanges();
            }
            Close();
        }
    }
}
