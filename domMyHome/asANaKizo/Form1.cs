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
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();

        }



        private void frmPrijava_Load(object sender, EventArgs e)
        {

        }

        private void linklblLozinka_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmZaboravljenaLozinka zaboraviLozinku = new frmZaboravljenaLozinka();
            zaboraviLozinku.Show();
            this.Hide();

        }
    }
}
