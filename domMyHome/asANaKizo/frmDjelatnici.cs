using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace domMyHome
{
    public partial class frmDjelatnici : Form
    {
        private static frmDjelatnici _instance;
        public frmDjelatnici()
        {
            InitializeComponent();
        }
        public frmDjelatnici instance
        {
            get
            {

                if (frmDjelatnici._instance == null)
                {

                    frmDjelatnici._instance = new frmDjelatnici();


                }
                else _instance.Activate();

                return frmDjelatnici._instance;

            }

        }

       

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTxtTajnoPitanje_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOdgovor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIzmjeni_Click(object sender, EventArgs e)
        {

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {

        }

        private void dgvKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmDjelatnici_Load(object sender, EventArgs e)
        {

        }

        private void frmDjelatnici_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmDjelatnici._instance = null;
        }
    }
}
