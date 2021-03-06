﻿using System;
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
    public partial class FrmPopisStudenata : Form
    {
        public FrmPopisStudenata()
        {
            InitializeComponent();
        }

        private void FrmPopisStudenata_Load(object sender, EventArgs e)
        {
            PrikaziTimove();
            PrikaziStudente(timBindingSource.Current as Tim);
        }


        private void PrikaziTimove() {
            BindingList<Tim> listaTimova = null;
            using (var db = new EvidencijaStudenataEntities()) {

                listaTimova = new BindingList<Tim>(db.Tim.ToList());



            }
            timBindingSource.DataSource = listaTimova;
        }

        private void PrikaziStudente(Tim tim) {
            List<Student> listaStudenata = null;
            using(var db = new EvidencijaStudenataEntities())
            {
                db.Tim.Attach(tim);
                listaStudenata = new
                List<Student>(tim.Student.ToList<Student>());
                listaStudenata = (from t in listaStudenata
                                  where t.Status == "R".ToString()
                                  &&
                                  t.Ime.Contains("Igor")

                                  select t).ToList<Student>();

                List<int> total = (from t in listaStudenata
                                          select t.Id).ToList<int>();
                // double a = total.Average();
                textBox1.Text = total.Count().ToString();

            }
            studentBindingSource.DataSource = listaStudenata;
        }

        private void dgvTimovi_SelectionChanged(object sender, EventArgs e)
        {
            Tim selektrianiTim = timBindingSource.Current as Tim;
            if (selektrianiTim != null)
            {
                PrikaziStudente(selektrianiTim);
                int sum = 0;
                for (int i = 0; i < dgvStudenti.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dgvStudenti.Rows[i].Cells[0].Value);
                }

                /*int total = dgvStudenti.Rows.Cast<DataGridViewRow>()
                .Min(t => Convert.ToInt32(t.Cells[0].Value));

                textBox1.Text = total.ToString();*/
                using (var db = new EvidencijaStudenataEntities())
                {
                    List<Student> prviTim = (from t in db.Student
                                       where t.Status == "R".ToString()
                 select t).ToList<Student>();

                    /*   BindingList<Student> lista = 
                           new BindingList<Student>(prviTim.Student.ToList<Student>());
       */
                   // dgvStudenti.DataSource = prviTim;
                }
              



            }

        }

        private void btnNoviTim_Click(object sender, EventArgs e)
        {
            FrmNoviTim forma = new FrmNoviTim();
            forma.ShowDialog();
            PrikaziTimove();
        }

        private void btnNoviStudent_Click(object sender, EventArgs e)
        {
            FrmNoviStudent forma = new FrmNoviStudent(timBindingSource.Current as Tim);
            forma.ShowDialog();
            PrikaziStudente(timBindingSource.Current as Tim);
        }

        private void splitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmNoviTim forma = new FrmNoviTim();
            forma.ShowDialog();
            PrikaziTimove();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmNoviStudent forma = new FrmNoviStudent(timBindingSource.Current as Tim);
            forma.ShowDialog();
            PrikaziStudente(timBindingSource.Current as Tim);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tim selektiraniTim = timBindingSource.Current as Tim;
            if (selektiraniTim != null)
            {
                FrmNoviTim forma = new FrmNoviTim(selektiraniTim);
                forma.ShowDialog();
                PrikaziTimove();

            }


        }

        private void brnbrisitim_Click(object sender, EventArgs e)
        {
            Tim selektirnaiTim = timBindingSource.Current as Tim;
            if (selektirnaiTim != null)
            {
                if (MessageBox.Show("DA li ste sigurni?","Upozorenje!",MessageBoxButtons.YesNo)==System.Windows.Forms.DialogResult.Yes)
                {
                    using (var db = new EvidencijaStudenataEntities())
                    {
                        db.Tim.Attach(selektirnaiTim);
                        if (selektirnaiTim.Student.Count == 0)
                        {
                            db.Tim.Remove(selektirnaiTim);
                            db.SaveChanges();


                        }
                        else {
                            MessageBox.Show("Nije moguće!");
                        }


                    }
                    PrikaziTimove();
                }
            }

        }
    }
}
