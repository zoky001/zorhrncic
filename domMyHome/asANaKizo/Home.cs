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
    public partial class frmHome : Form
    {
        
       

        public frmHome()
        {
            InitializeComponent();

        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            frmPrijava prijava = new frmPrijava();


            prijava.ShowDialog(this);
           this.KeyPreview = true;
           // this.KeyDown += new KeyEventHandler(frmHome_KeyDown);

        }

      

    



        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            frmRegistracija registracija = new frmRegistracija();
            registracija.Show(this);
        }
        
        private void btnDjelatnici_Click(object sender, EventArgs e)
        {frmDjelatnici djelatnici = new frmDjelatnici();

            djelatnici.instance.Show();
            
            /*
            if (djelatnici == null)
            {
                djelatnici = new frmDjelatnici();

                djelatnici.Show();
            }

            else if (djelatnici != null)
                djelatnici.Activate();
                */
            
        }

        private void btnPregledSoba_Click(object sender, EventArgs e)
        {
          
        }

        private void frmHome_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            MessageBox.Show("help button") ;
        }

        private void frmHome_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("keypress");
           
        }

        private void frmHome_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("vrijednost: " + e.KeyCode);
          
            
        }

        private void frmHome_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("mis klik");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

       
    }

      
    }

