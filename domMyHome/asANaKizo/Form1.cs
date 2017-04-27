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
            this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(frmPrijava_KeyDown);
            //this.KeyPress -= new KeyPressEventHandler(frmPrijava_KeyPress);

        }

        private void linklblLozinka_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmZaboravljenaLozinka zaboraviLozinku = new frmZaboravljenaLozinka();
            zaboraviLozinku.Show();
            this.Hide();

        }

        private void frmPrijava_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void frmPrijava_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("down" + e.KeyCode);
        }
    }
}
