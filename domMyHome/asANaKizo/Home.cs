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
      

        private void Home_Load(object sender, EventArgs e)
        {
            frmPrijava prijava = new frmPrijava();


            prijava.ShowDialog(this);
       
        }

    



        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            frmRegistracija registracija = new frmRegistracija();
            registracija.Show(this);
        }
        
        private void btnDjelatnici_Click(object sender, EventArgs e)
        {frmDjelatnici djelatnici = new frmDjelatnici();

            djelatnici.Show(this);
            
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

    }

      
    }

