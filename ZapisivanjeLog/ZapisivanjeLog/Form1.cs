using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZapisivanjeLog
{
    public partial class frmIzrcun : Form
    {
        private int prviBroj = 0;
        private int drugiBroj = 0;
        public System.Threading.Thread dretvaSuma;
        public System.Threading.Thread dretvaUmnozak;


        public frmIzrcun()
        {
            CheckForIllegalCrossThreadCalls = false; // za potrebe dretve
            InitializeComponent();
            //PisiULog("dobar dan!!");
            dretvaSuma = new System.Threading.Thread(new System.Threading.ThreadStart(DretvaSumaWork));
            dretvaUmnozak = new System.Threading.Thread(new System.Threading.ThreadStart(DretvaUmnozakWork));


            MessageBox.Show("Aplikacija je spremna za korištenje");
        }

        public void PisiULog(string tekst)
        {
            lock (log)
            {

                log.Text = tekst + System.Environment.NewLine + log.Text;
            }
        }
        private void ProvjeriUnos() {
            int zamjena = 0;
            prviBroj = int.Parse(txtPrviBroj.Text);
            drugiBroj= int.Parse(txtDrugiBroj.Text);
            if (prviBroj > drugiBroj)
            {
                zamjena = drugiBroj;
                drugiBroj = prviBroj;
                prviBroj = zamjena;

            }

            PisiULog("Prvi broj: " + prviBroj.ToString());
            PisiULog("Drugi broj: " + drugiBroj.ToString());
        }

        public void DretvaSumaWork()
        {

            int suma = 0;
            for (int i = prviBroj; i < drugiBroj; i++)
            {
                suma += i;

                PisiULog("Suma = " + suma.ToString() + " kraj: " + DateTime.Now.ToString());
            }
           
        }

        public void DretvaUmnozakWork()
        {
            int umnozak = 0;
            for (int i = prviBroj; i < drugiBroj; i++)
            {
                umnozak *= i;

                PisiULog("Umnožak: "+ umnozak.ToString() + " kraj: "+DateTime.Now.ToString());
            }


        }

        private void butIzracunaj_Click(object sender, EventArgs e)
        {
            PisiULog("Početak svih izračuna u: " + DateTime.Now.ToString());
            dretvaSuma.Start();
            dretvaUmnozak.Start();


        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            ProvjeriUnos();
        }
    }
}
