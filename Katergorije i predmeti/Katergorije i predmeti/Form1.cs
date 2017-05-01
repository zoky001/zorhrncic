using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Katergorije_i_predmeti
{
    public partial class Form1 : Form
    {

        public Upis upis = new Upis();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (var item in upis.popisKategorija)
            {
                listBoxKategorije.Items.Add(item.Naziv);
            }
           // listBoxKategorije.Items.AddRange(upis.popisKategorija);
        }

        private void butDodaj_Click(object sender, EventArgs e)
        {
            int ects = Int32.Parse(textBoxECTS.Text.ToString());

            string s = listBoxKategorije.SelectedItem.ToString();
            Kategorija k = null;

            foreach (var item in upis.popisKategorija)
            {
                if (item.Naziv == s)
                {
                    k = item;
                }
            }


            Predmeti predmet = new Predmeti (textBoxNaziv.Text.ToString(),ects,k);

            

            upis.popisPredmeta.Add(predmet);

        }

        private void listBoxKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = listBoxKategorije.SelectedItem.ToString();


            listBoxPredmeti.Items.Clear();
            foreach (var item in upis.popisPredmeta)
            {
                if (item.kategorija.Naziv == s)
                {
                      listBoxPredmeti.Items.Add(item.naziv);
                }


              
                
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string predmet = listBoxPredmeti.SelectedItem.ToString();

            Predmeti P = null;
            foreach (var item in upis.popisPredmeta)
            {
                if (predmet == item.naziv)
                {
                    P = item;

                }
            }

            upis.upisaniPredmeta.Add(P);

            foreach (var item in upis.upisaniPredmeta)
            {
                listBoxUpisani.Items.Add(item.naziv);
                   
                




            }



        }
    }
}
